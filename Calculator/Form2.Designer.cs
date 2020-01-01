namespace Calculator
{
    partial class Graph_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph_Generator));
            this.btnData = new System.Windows.Forms.Button();
            this.chrtGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtXAxis = new System.Windows.Forms.TextBox();
            this.txtYAxis = new System.Windows.Forms.TextBox();
            this.btnXAxis = new System.Windows.Forms.Button();
            this.btnYAxis = new System.Windows.Forms.Button();
            this.lblOutputX = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblOutputY = new System.Windows.Forms.Label();
            this.btnGraph = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chrtGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(26, 274);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(104, 38);
            this.btnData.TabIndex = 0;
            this.btnData.Text = "Submit";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.Data_Submit);
            // 
            // chrtGraph
            // 
            this.chrtGraph.BackColor = System.Drawing.Color.Gray;
            this.chrtGraph.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.TileFlipXY;
            this.chrtGraph.BorderlineColor = System.Drawing.SystemColors.ActiveCaptionText;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chrtGraph.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Black;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chrtGraph.Legends.Add(legend1);
            this.chrtGraph.Location = new System.Drawing.Point(470, 221);
            this.chrtGraph.Name = "chrtGraph";
            series1.BackImageTransparentColor = System.Drawing.Color.Black;
            series1.BackSecondaryColor = System.Drawing.Color.Black;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Lime;
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.Name = "X";
            series1.XValueMember = "arrayX";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueMembers = "arrayY";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chrtGraph.Series.Add(series1);
            this.chrtGraph.Size = new System.Drawing.Size(499, 392);
            this.chrtGraph.TabIndex = 1;
            this.chrtGraph.Text = "chart1";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(26, 246);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(104, 22);
            this.txtData.TabIndex = 2;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplay.BackColor = System.Drawing.Color.Black;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Mongolian Baiti", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.Color.Lime;
            this.txtDisplay.Location = new System.Drawing.Point(14, 31);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(994, 67);
            this.txtDisplay.TabIndex = 22;
            this.txtDisplay.Text = "Graphic Display Application";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(37, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Data Points: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(53, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "X-Axis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(53, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Y-Axis";
            // 
            // txtXAxis
            // 
            this.txtXAxis.Location = new System.Drawing.Point(26, 377);
            this.txtXAxis.Name = "txtXAxis";
            this.txtXAxis.Size = new System.Drawing.Size(100, 22);
            this.txtXAxis.TabIndex = 26;
            // 
            // txtYAxis
            // 
            this.txtYAxis.Location = new System.Drawing.Point(26, 507);
            this.txtYAxis.Name = "txtYAxis";
            this.txtYAxis.Size = new System.Drawing.Size(100, 22);
            this.txtYAxis.TabIndex = 27;
            // 
            // btnXAxis
            // 
            this.btnXAxis.Location = new System.Drawing.Point(26, 405);
            this.btnXAxis.Name = "btnXAxis";
            this.btnXAxis.Size = new System.Drawing.Size(100, 38);
            this.btnXAxis.TabIndex = 28;
            this.btnXAxis.Text = "Add to X";
            this.btnXAxis.UseVisualStyleBackColor = true;
            this.btnXAxis.Click += new System.EventHandler(this.btnXAxis_Click);
            // 
            // btnYAxis
            // 
            this.btnYAxis.Location = new System.Drawing.Point(26, 535);
            this.btnYAxis.Name = "btnYAxis";
            this.btnYAxis.Size = new System.Drawing.Size(100, 38);
            this.btnYAxis.TabIndex = 29;
            this.btnYAxis.Text = "Add to Y";
            this.btnYAxis.UseVisualStyleBackColor = true;
            this.btnYAxis.Click += new System.EventHandler(this.btnYAxis_Click);
            // 
            // lblOutputX
            // 
            this.lblOutputX.AutoSize = true;
            this.lblOutputX.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputX.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputX.ForeColor = System.Drawing.Color.Lime;
            this.lblOutputX.Location = new System.Drawing.Point(215, 395);
            this.lblOutputX.Name = "lblOutputX";
            this.lblOutputX.Size = new System.Drawing.Size(0, 25);
            this.lblOutputX.TabIndex = 31;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.Lime;
            this.lblOutput.Location = new System.Drawing.Point(215, 258);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 25);
            this.lblOutput.TabIndex = 32;
            // 
            // lblOutputY
            // 
            this.lblOutputY.AutoSize = true;
            this.lblOutputY.BackColor = System.Drawing.Color.Transparent;
            this.lblOutputY.Font = new System.Drawing.Font("Mongolian Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputY.ForeColor = System.Drawing.Color.Lime;
            this.lblOutputY.Location = new System.Drawing.Point(215, 525);
            this.lblOutputY.Name = "lblOutputY";
            this.lblOutputY.Size = new System.Drawing.Size(0, 25);
            this.lblOutputY.TabIndex = 33;
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(662, 177);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(122, 38);
            this.btnGraph.TabIndex = 34;
            this.btnGraph.Text = "Create Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.btnGraph_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(662, 619);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 38);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Clear Graph";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(220, 619);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(122, 38);
            this.btnClearData.TabIndex = 36;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // Graph_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1020, 770);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGraph);
            this.Controls.Add(this.lblOutputY);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblOutputX);
            this.Controls.Add(this.btnYAxis);
            this.Controls.Add(this.btnXAxis);
            this.Controls.Add(this.txtYAxis);
            this.Controls.Add(this.txtXAxis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.chrtGraph);
            this.Controls.Add(this.btnData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Graph_Generator";
            this.Text = "Graphic Display Application";
            ((System.ComponentModel.ISupportInitialize)(this.chrtGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtGraph;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtXAxis;
        private System.Windows.Forms.TextBox txtYAxis;
        private System.Windows.Forms.Button btnXAxis;
        private System.Windows.Forms.Button btnYAxis;
        private System.Windows.Forms.Label lblOutputX;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblOutputY;
        private System.Windows.Forms.Button btnGraph;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClearData;
    }
}