namespace Weather_Forecast
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSend = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTemperature = new System.Windows.Forms.TabPage();
            this.tabPageHumidity = new System.Windows.Forms.TabPage();
            this.chartTemperature = new LiveCharts.WinForms.CartesianChart();
            this.chartHumidity = new LiveCharts.WinForms.CartesianChart();
            this.textBoxLatitude = new System.Windows.Forms.TextBox();
            this.textBoxLongitude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageTemperature.SuspendLayout();
            this.tabPageHumidity.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(479, 12);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(107, 20);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Find Forecast";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTemperature);
            this.tabControlMain.Controls.Add(this.tabPageHumidity);
            this.tabControlMain.Location = new System.Drawing.Point(12, 38);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(728, 439);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageTemperature
            // 
            this.tabPageTemperature.Controls.Add(this.chartTemperature);
            this.tabPageTemperature.Location = new System.Drawing.Point(4, 22);
            this.tabPageTemperature.Name = "tabPageTemperature";
            this.tabPageTemperature.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemperature.Size = new System.Drawing.Size(720, 413);
            this.tabPageTemperature.TabIndex = 0;
            this.tabPageTemperature.Text = "Temperature";
            this.tabPageTemperature.UseVisualStyleBackColor = true;
            // 
            // tabPageHumidity
            // 
            this.tabPageHumidity.Controls.Add(this.chartHumidity);
            this.tabPageHumidity.Location = new System.Drawing.Point(4, 22);
            this.tabPageHumidity.Name = "tabPageHumidity";
            this.tabPageHumidity.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHumidity.Size = new System.Drawing.Size(720, 413);
            this.tabPageHumidity.TabIndex = 1;
            this.tabPageHumidity.Text = "Humidity";
            this.tabPageHumidity.UseVisualStyleBackColor = true;
            // 
            // chartTemperature
            // 
            this.chartTemperature.Location = new System.Drawing.Point(8, 6);
            this.chartTemperature.Name = "chartTemperature";
            this.chartTemperature.Size = new System.Drawing.Size(706, 399);
            this.chartTemperature.TabIndex = 1;
            this.chartTemperature.Text = "cartesianChart1";
            // 
            // chartHumidity
            // 
            this.chartHumidity.Location = new System.Drawing.Point(8, 6);
            this.chartHumidity.Name = "chartHumidity";
            this.chartHumidity.Size = new System.Drawing.Size(706, 399);
            this.chartHumidity.TabIndex = 2;
            this.chartHumidity.Text = "cartesianChart1";
            // 
            // textBoxLatitude
            // 
            this.textBoxLatitude.Location = new System.Drawing.Point(67, 12);
            this.textBoxLatitude.Name = "textBoxLatitude";
            this.textBoxLatitude.Size = new System.Drawing.Size(147, 20);
            this.textBoxLatitude.TabIndex = 3;
            // 
            // textBoxLongitude
            // 
            this.textBoxLongitude.Location = new System.Drawing.Point(293, 12);
            this.textBoxLongitude.Name = "textBoxLongitude";
            this.textBoxLongitude.Size = new System.Drawing.Size(156, 20);
            this.textBoxLongitude.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Latitude:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Longitude:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 489);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLongitude);
            this.Controls.Add(this.textBoxLatitude);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonSend);
            this.Name = "Form1";
            this.Text = "Weather Forecast";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTemperature.ResumeLayout(false);
            this.tabPageHumidity.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTemperature;
        private LiveCharts.WinForms.CartesianChart chartTemperature;
        private System.Windows.Forms.TabPage tabPageHumidity;
        private LiveCharts.WinForms.CartesianChart chartHumidity;
        private System.Windows.Forms.TextBox textBoxLatitude;
        private System.Windows.Forms.TextBox textBoxLongitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

