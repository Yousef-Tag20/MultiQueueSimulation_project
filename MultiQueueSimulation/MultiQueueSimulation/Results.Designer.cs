namespace MultiQueueSimulation
{
    partial class Results
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
            this.Output = new System.Windows.Forms.DataGridView();
            this.CustomerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RndArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeBetween = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RndService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeInQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Simulate = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.AllowUserToAddRows = false;
            this.Output.AllowUserToDeleteRows = false;
            this.Output.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Output.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerNo,
            this.RndArrival,
            this.TimeBetween,
            this.ArrivalTime,
            this.RndService,
            this.ServerID,
            this.ServiceBegin,
            this.ServiceTime,
            this.ServiceEnd,
            this.TimeInQueue});
            this.Output.Location = new System.Drawing.Point(0, -1);
            this.Output.Margin = new System.Windows.Forms.Padding(4);
            this.Output.Name = "Output";
            this.Output.ReadOnly = true;
            this.Output.Size = new System.Drawing.Size(1396, 588);
            this.Output.TabIndex = 0;
            this.Output.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Output_CellContentClick);
            // 
            // CustomerNo
            // 
            this.CustomerNo.Frozen = true;
            this.CustomerNo.HeaderText = "CustomerNo";
            this.CustomerNo.Name = "CustomerNo";
            this.CustomerNo.ReadOnly = true;
            // 
            // RndArrival
            // 
            this.RndArrival.Frozen = true;
            this.RndArrival.HeaderText = "RndArrival";
            this.RndArrival.Name = "RndArrival";
            this.RndArrival.ReadOnly = true;
            // 
            // TimeBetween
            // 
            this.TimeBetween.Frozen = true;
            this.TimeBetween.HeaderText = "TimeBetween";
            this.TimeBetween.Name = "TimeBetween";
            this.TimeBetween.ReadOnly = true;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.Frozen = true;
            this.ArrivalTime.HeaderText = "ArrivalTime";
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.ReadOnly = true;
            // 
            // RndService
            // 
            this.RndService.Frozen = true;
            this.RndService.HeaderText = "RndService";
            this.RndService.Name = "RndService";
            this.RndService.ReadOnly = true;
            // 
            // ServerID
            // 
            this.ServerID.Frozen = true;
            this.ServerID.HeaderText = "ServerID";
            this.ServerID.Name = "ServerID";
            this.ServerID.ReadOnly = true;
            // 
            // ServiceBegin
            // 
            this.ServiceBegin.Frozen = true;
            this.ServiceBegin.HeaderText = "ServiceBegin";
            this.ServiceBegin.Name = "ServiceBegin";
            this.ServiceBegin.ReadOnly = true;
            // 
            // ServiceTime
            // 
            this.ServiceTime.Frozen = true;
            this.ServiceTime.HeaderText = "ServiceTime";
            this.ServiceTime.Name = "ServiceTime";
            this.ServiceTime.ReadOnly = true;
            // 
            // ServiceEnd
            // 
            this.ServiceEnd.Frozen = true;
            this.ServiceEnd.HeaderText = "ServiceEnd";
            this.ServiceEnd.Name = "ServiceEnd";
            this.ServiceEnd.ReadOnly = true;
            // 
            // TimeInQueue
            // 
            this.TimeInQueue.HeaderText = "TimeInQueue";
            this.TimeInQueue.Name = "TimeInQueue";
            this.TimeInQueue.ReadOnly = true;
            // 
            // Simulate
            // 
            this.Simulate.Location = new System.Drawing.Point(180, 629);
            this.Simulate.Margin = new System.Windows.Forms.Padding(4);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(235, 66);
            this.Simulate.TabIndex = 7;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1199, 690);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 22;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(957, 690);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 23);
            this.button5.TabIndex = 21;
            this.button5.Text = "WaitingProbability";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(957, 646);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = " MaxQueueLength";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(957, 604);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "AverageWaitingTime";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1199, 647);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1199, 604);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 743);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Simulate);
            this.Controls.Add(this.Output);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Output;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RndArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBetween;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn RndService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeInQueue;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}