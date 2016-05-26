namespace lab10
{
    partial class ChangesForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cHumidity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cTemperature)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHumidity)).BeginInit();
            this.SuspendLayout();
            // 
            // cTemperature
            // 
            chartArea1.Name = "ChartArea1";
            this.cTemperature.ChartAreas.Add(chartArea1);
            this.cTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.cTemperature.Legends.Add(legend1);
            this.cTemperature.Location = new System.Drawing.Point(3, 3);
            this.cTemperature.Name = "cTemperature";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cTemperature.Series.Add(series1);
            this.cTemperature.Size = new System.Drawing.Size(677, 149);
            this.cTemperature.TabIndex = 0;
            this.cTemperature.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.cTemperature, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cHumidity, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cPressure, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 466);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cPressure
            // 
            chartArea3.Name = "ChartArea1";
            this.cPressure.ChartAreas.Add(chartArea3);
            this.cPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.cPressure.Legends.Add(legend3);
            this.cPressure.Location = new System.Drawing.Point(3, 158);
            this.cPressure.Name = "cPressure";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.cPressure.Series.Add(series3);
            this.cPressure.Size = new System.Drawing.Size(677, 149);
            this.cPressure.TabIndex = 4;
            this.cPressure.Text = "chart1";
            // 
            // cHumidity
            // 
            chartArea2.Name = "ChartArea1";
            this.cHumidity.ChartAreas.Add(chartArea2);
            this.cHumidity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.cHumidity.Legends.Add(legend2);
            this.cHumidity.Location = new System.Drawing.Point(3, 313);
            this.cHumidity.Name = "cHumidity";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.cHumidity.Series.Add(series2);
            this.cHumidity.Size = new System.Drawing.Size(677, 150);
            this.cHumidity.TabIndex = 5;
            this.cHumidity.Text = "chart1";
            // 
            // ChangesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 466);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ChangesForm";
            this.Text = "График изменений";
            ((System.ComponentModel.ISupportInitialize)(this.cTemperature)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cHumidity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cTemperature;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart cHumidity;
        private System.Windows.Forms.DataVisualization.Charting.Chart cPressure;
    }
}