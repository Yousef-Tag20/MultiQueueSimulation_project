namespace MultiQueueSimulation
{
    partial class ServerResults
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
            if (disposing && (components != null)) {
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
            this.ResultsGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultsGraph
            // 
            chartArea2.Name = "Busy";
            this.ResultsGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ResultsGraph.Legends.Add(legend2);
            this.ResultsGraph.Location = new System.Drawing.Point(66, 64);
            this.ResultsGraph.Margin = new System.Windows.Forms.Padding(4);
            this.ResultsGraph.Name = "ResultsGraph";
            this.ResultsGraph.Size = new System.Drawing.Size(1224, 471);
            this.ResultsGraph.TabIndex = 2;
            this.ResultsGraph.Text = "chart1";
            this.ResultsGraph.Click += new System.EventHandler(this.ResultsGraph_Click);
            // 
            // ServerResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 598);
            this.Controls.Add(this.ResultsGraph);
            this.Name = "ServerResults";
            this.Text = "ServerResults";
            this.Load += new System.EventHandler(this.ServerResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ResultsGraph;
    }
}