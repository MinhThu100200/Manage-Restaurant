
namespace ManageRes
{
    partial class BestSellerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridViewBestSeller = new System.Windows.Forms.DataGridView();
            this.chartBestSeller = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBestSeller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBestSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBestSeller
            // 
            this.dataGridViewBestSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBestSeller.Location = new System.Drawing.Point(12, 110);
            this.dataGridViewBestSeller.Name = "dataGridViewBestSeller";
            this.dataGridViewBestSeller.RowHeadersWidth = 51;
            this.dataGridViewBestSeller.RowTemplate.Height = 24;
            this.dataGridViewBestSeller.Size = new System.Drawing.Size(525, 419);
            this.dataGridViewBestSeller.TabIndex = 0;
            // 
            // chartBestSeller
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBestSeller.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartBestSeller.Legends.Add(legend2);
            this.chartBestSeller.Location = new System.Drawing.Point(543, 110);
            this.chartBestSeller.Name = "chartBestSeller";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartBestSeller.Series.Add(series2);
            this.chartBestSeller.Size = new System.Drawing.Size(503, 419);
            this.chartBestSeller.TabIndex = 1;
            this.chartBestSeller.Text = "chartBestSeller";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(440, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Best Seller";
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(12, 76);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(170, 28);
            this.comboBoxTime.TabIndex = 15;
            this.comboBoxTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxTime_SelectedIndexChanged);
            // 
            // BestSellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1058, 541);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartBestSeller);
            this.Controls.Add(this.dataGridViewBestSeller);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BestSellerForm";
            this.Text = "BestSellerForm";
            this.Load += new System.EventHandler(this.BestSellerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBestSeller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBestSeller)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBestSeller;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBestSeller;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxTime;
    }
}