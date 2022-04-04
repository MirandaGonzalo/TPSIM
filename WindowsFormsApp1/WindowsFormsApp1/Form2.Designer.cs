
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataInforme = new System.Windows.Forms.DataGridView();
            this.CbIntervalos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.graficoHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HipotesisTxt = new System.Windows.Forms.Label();
            this.graficoFrecEsperada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hipotesisNulaTxt = new System.Windows.Forms.Label();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoFrecEsperada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione la cantidad de intervalos:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 21);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataInforme
            // 
            this.dataInforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInforme.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desde,
            this.Hasta,
            this.MarcaClase,
            this.FrecuenciaObservada,
            this.Column7,
            this.Column8,
            this.FrecuenciaEsperada,
            this.Column5,
            this.Column6});
            this.dataInforme.Location = new System.Drawing.Point(60, 94);
            this.dataInforme.Name = "dataInforme";
            this.dataInforme.RowHeadersWidth = 51;
            this.dataInforme.Size = new System.Drawing.Size(1110, 176);
            this.dataInforme.TabIndex = 8;
            // 
            // CbIntervalos
            // 
            this.CbIntervalos.FormattingEnabled = true;
            this.CbIntervalos.Items.AddRange(new object[] {
            "Opciones",
            "5 intervalos",
            "8 intervalos",
            "10 intervalos",
            "12 intervalos"});
            this.CbIntervalos.Location = new System.Drawing.Point(155, 67);
            this.CbIntervalos.Name = "CbIntervalos";
            this.CbIntervalos.Size = new System.Drawing.Size(121, 21);
            this.CbIntervalos.TabIndex = 17;
            this.CbIntervalos.Text = "Opciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "INTERVALOS:";
            // 
            // graficoHistograma
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoHistograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoHistograma.Legends.Add(legend1);
            this.graficoHistograma.Location = new System.Drawing.Point(60, 276);
            this.graficoHistograma.Name = "graficoHistograma";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Intervalos";
            this.graficoHistograma.Series.Add(series1);
            this.graficoHistograma.Size = new System.Drawing.Size(667, 304);
            this.graficoHistograma.TabIndex = 21;
            this.graficoHistograma.Text = "chart1";
            // 
            // HipotesisTxt
            // 
            this.HipotesisTxt.AutoSize = true;
            this.HipotesisTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HipotesisTxt.Location = new System.Drawing.Point(59, 667);
            this.HipotesisTxt.Name = "HipotesisTxt";
            this.HipotesisTxt.Size = new System.Drawing.Size(0, 24);
            this.HipotesisTxt.TabIndex = 22;
            this.HipotesisTxt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // graficoFrecEsperada
            // 
            chartArea2.Name = "ChartArea1";
            this.graficoFrecEsperada.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoFrecEsperada.Legends.Add(legend2);
            this.graficoFrecEsperada.Location = new System.Drawing.Point(740, 276);
            this.graficoFrecEsperada.Name = "graficoFrecEsperada";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graficoFrecEsperada.Series.Add(series2);
            this.graficoFrecEsperada.Size = new System.Drawing.Size(430, 304);
            this.graficoFrecEsperada.TabIndex = 23;
            this.graficoFrecEsperada.Text = "chart1";
            // 
            // hipotesisNulaTxt
            // 
            this.hipotesisNulaTxt.AutoSize = true;
            this.hipotesisNulaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hipotesisNulaTxt.Location = new System.Drawing.Point(56, 620);
            this.hipotesisNulaTxt.Name = "hipotesisNulaTxt";
            this.hipotesisNulaTxt.Size = new System.Drawing.Size(0, 24);
            this.hipotesisNulaTxt.TabIndex = 24;
            this.hipotesisNulaTxt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Desde
            // 
            this.Desde.HeaderText = "Desde";
            this.Desde.MinimumWidth = 6;
            this.Desde.Name = "Desde";
            this.Desde.Width = 125;
            // 
            // Hasta
            // 
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.MinimumWidth = 6;
            this.Hasta.Name = "Hasta";
            this.Hasta.Width = 125;
            // 
            // MarcaClase
            // 
            this.MarcaClase.HeaderText = "Marca de clase";
            this.MarcaClase.MinimumWidth = 6;
            this.MarcaClase.Name = "MarcaClase";
            this.MarcaClase.Width = 125;
            // 
            // FrecuenciaObservada
            // 
            this.FrecuenciaObservada.HeaderText = "Frecuencia observada";
            this.FrecuenciaObservada.MinimumWidth = 6;
            this.FrecuenciaObservada.Name = "FrecuenciaObservada";
            this.FrecuenciaObservada.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Frec relativa";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Frec relativa Acumulado";
            this.Column8.Name = "Column8";
            // 
            // FrecuenciaEsperada
            // 
            this.FrecuenciaEsperada.HeaderText = "Frecuencia esperada";
            this.FrecuenciaEsperada.MinimumWidth = 6;
            this.FrecuenciaEsperada.Name = "FrecuenciaEsperada";
            this.FrecuenciaEsperada.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "C()";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "C() Acumulado";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 749);
            this.Controls.Add(this.hipotesisNulaTxt);
            this.Controls.Add(this.graficoFrecEsperada);
            this.Controls.Add(this.HipotesisTxt);
            this.Controls.Add(this.graficoHistograma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbIntervalos);
            this.Controls.Add(this.dataInforme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFORME Y PRUEBA CHI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataInforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoFrecEsperada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataInforme;
        private System.Windows.Forms.ComboBox CbIntervalos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistograma;
        private System.Windows.Forms.Label HipotesisTxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoFrecEsperada;
        private System.Windows.Forms.Label hipotesisNulaTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaEsperada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}