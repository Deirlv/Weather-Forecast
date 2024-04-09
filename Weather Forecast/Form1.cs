using LiveCharts;
using LiveCharts.Wpf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace Weather_Forecast
{
    public partial class Form1 : Form
    {
        List<DateTime> time;
        List<double> temp;
        List<int> humidity;
        public Form1()
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            InitializeComponent();

            double[] list1 = { 1,2};
            double[] list2 = { 1, 2};

            chartTemperature.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Title = "Temperature",
                    Values = new ChartValues<double>(list1)
                },
            };

            chartHumidity.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries
                {
                    Title = "Humidity",
                    Values = new ChartValues<double>(list2),
                    PointGeometry = null
                }
            };

            chartTemperature.AxisX.Add(new Axis
            {
                Title = "Time",
                Labels = new List<string> { "1", "2",  "3", "4", "5"}
            });

            chartHumidity.AxisY.Add(new Axis
            {
                Title = "Humidity",
                LabelFormatter = val => $"{val} C"
            });
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(textBoxLatitude.Text.Length == 0 || textBoxLongitude.Text.Length == 0)
            {
                MessageBox.Show("You must fill all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            time = new List<DateTime>();
            temp = new List<double>();
            humidity = new List<int>();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage responseMessage = await client.GetAsync($@"https://api.openweathermap.org/data/2.5/onecall?lat={textBoxLatitude.Text}&lon={textBoxLongitude.Text}&exclude=current,minutely,daily,alerts&appid=ef5ebfda74903c4b21316165b1c7b5de&units=metric&lang=ua");
                string body = await responseMessage.Content.ReadAsStringAsync();

                Root data = JsonConvert.DeserializeObject<Root>(body);

                data.hourly.Select(d => new { Time = new DateTime(1970, 1, 1).AddSeconds(d.dt), Temp = d.temp, humidity = d.humidity });

                foreach (var item in data.hourly)
                {
                    humidity.Add(item.humidity);
                }
                    
                foreach (var item in data.hourly)
                {
                    temp.Add(item.temp);
                }

                foreach (var item in data.hourly)
                {
                    time.Add(new DateTime(1970, 1, 1).AddSeconds(item.dt));
                }

                List<string> shortDateString = time.ConvertAll(p => p.ToLongDateString() + p.ToShortDateString());

                chartTemperature.Series = new LiveCharts.SeriesCollection
                {
                    new LineSeries
                    {
                        Title="Temperature",
                        Values=new ChartValues<double>(temp)
                    }
                };
                chartTemperature.AxisX.Clear();
                chartTemperature.AxisX.Add(new Axis
                {
                    Title = "Time",
                    Labels = shortDateString
                });
                chartTemperature.AxisY.Clear();
                chartTemperature.AxisY.Add(new Axis
                {
                    Title = "Temperature",
                    LabelFormatter = val => $"{val} C"
                });

                            
                chartHumidity.Series = new LiveCharts.SeriesCollection
                {
                    new LineSeries
                    {
                        Title="Humidity",
                        Values=new ChartValues<int>(humidity),
                        PointGeometry=null
                    }
                };
                chartHumidity.AxisX.Clear();
                chartHumidity.AxisX.Add(new Axis
                {
                    Title = "Time",
                    Labels = shortDateString
                });
                chartHumidity.AxisY.Clear();
                chartHumidity.AxisY.Add(new Axis
                {
                    Title = "Humidity",
                    LabelFormatter = val => $"{val}%"
                });
            }
        }
    }
}
