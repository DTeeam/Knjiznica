
namespace knjiznica_timtom
{
    partial class Stat_form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.rent_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.section_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.rent_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.section_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // rent_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.rent_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.rent_chart.Legends.Add(legend1);
            this.rent_chart.Location = new System.Drawing.Point(28, 56);
            this.rent_chart.Name = "rent_chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Izposoje v tem času";
            this.rent_chart.Series.Add(series1);
            this.rent_chart.Size = new System.Drawing.Size(713, 299);
            this.rent_chart.TabIndex = 0;
            this.rent_chart.Text = "chart1";
            // 
            // section_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.section_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.section_chart.Legends.Add(legend2);
            this.section_chart.Location = new System.Drawing.Point(28, 396);
            this.section_chart.Name = "section_chart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "UDK";
            this.section_chart.Series.Add(series2);
            this.section_chart.Size = new System.Drawing.Size(713, 424);
            this.section_chart.TabIndex = 1;
            this.section_chart.Text = "chart1";
            // 
            // Stat_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 832);
            this.Controls.Add(this.section_chart);
            this.Controls.Add(this.rent_chart);
            this.Name = "Stat_form";
            this.Text = "Statistika";
            this.Load += new System.EventHandler(this.Stat_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rent_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.section_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart rent_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart section_chart;
    }
}