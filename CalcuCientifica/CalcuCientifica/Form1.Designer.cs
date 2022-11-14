
namespace CalcuCientifica
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnPot = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btnDer = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLog = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn2d = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(46, 66);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(190, 22);
            this.tb1.TabIndex = 0;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(320, 66);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(190, 22);
            this.tb2.TabIndex = 1;
            // 
            // tbRes
            // 
            this.tbRes.Location = new System.Drawing.Point(590, 66);
            this.tbRes.Name = "tbRes";
            this.tbRes.ReadOnly = true;
            this.tbRes.Size = new System.Drawing.Size(153, 22);
            this.tbRes.TabIndex = 2;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(46, 134);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(139, 23);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(46, 185);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(139, 23);
            this.btnResta.TabIndex = 4;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(46, 232);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(139, 23);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(46, 289);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(139, 23);
            this.btnDiv.TabIndex = 6;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnSin
            // 
            this.btnSin.Location = new System.Drawing.Point(209, 134);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(145, 23);
            this.btnSin.TabIndex = 7;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = true;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnCos
            // 
            this.btnCos.Location = new System.Drawing.Point(209, 185);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(145, 23);
            this.btnCos.TabIndex = 8;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = true;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTan
            // 
            this.btnTan.Location = new System.Drawing.Point(209, 232);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(145, 23);
            this.btnTan.TabIndex = 9;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = true;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnPot
            // 
            this.btnPot.Location = new System.Drawing.Point(209, 289);
            this.btnPot.Name = "btnPot";
            this.btnPot.Size = new System.Drawing.Size(145, 23);
            this.btnPot.TabIndex = 10;
            this.btnPot.Text = "^";
            this.btnPot.UseVisualStyleBackColor = true;
            this.btnPot.Click += new System.EventHandler(this.btnPot_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Location = new System.Drawing.Point(391, 185);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(145, 23);
            this.btnRaiz.TabIndex = 11;
            this.btnRaiz.Text = "raíz";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.btnRaiz_Click);
            // 
            // btnDer
            // 
            this.btnDer.Location = new System.Drawing.Point(391, 232);
            this.btnDer.Name = "btnDer";
            this.btnDer.Size = new System.Drawing.Size(145, 23);
            this.btnDer.TabIndex = 12;
            this.btnDer.Text = "d/dx";
            this.btnDer.UseVisualStyleBackColor = true;
            this.btnDer.Click += new System.EventHandler(this.btnDer_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(391, 289);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(145, 23);
            this.btnInt.TabIndex = 13;
            this.btnInt.Text = "Integral def.";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(590, 290);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(137, 22);
            this.tb3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "limite inferior:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(391, 134);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(145, 23);
            this.btnLog.TabIndex = 16;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(786, 32);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            // 
            // btn2d
            // 
            this.btn2d.Location = new System.Drawing.Point(46, 360);
            this.btn2d.Name = "btn2d";
            this.btn2d.Size = new System.Drawing.Size(139, 23);
            this.btn2d.TabIndex = 18;
            this.btn2d.Text = "2dPlot";
            this.btn2d.UseVisualStyleBackColor = true;
            this.btn2d.Click += new System.EventHandler(this.btn2d_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 411);
            this.Controls.Add(this.btn2d);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnDer);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPot);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnPot;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btnDer;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn2d;
    }
}

