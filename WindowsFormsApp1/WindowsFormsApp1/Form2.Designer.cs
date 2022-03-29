
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
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaClase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaObservada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FrecuenciaEsperada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataChi = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbIntervalos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.graficoHistograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.HipotesisTxt = new System.Windows.Forms.Label();
            this.graficoFrecEsperada = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hipotesisNulaTxt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataChi)).BeginInit();
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
            this.FrecuenciaEsperada,
            this.Column5,
            this.Column6});
            this.dataInforme.Location = new System.Drawing.Point(60, 110);
            this.dataInforme.Name = "dataInforme";
            this.dataInforme.Size = new System.Drawing.Size(741, 176);
            this.dataInforme.TabIndex = 8;
            // 
            // Desde
            // 
            this.Desde.HeaderText = "Desde";
            this.Desde.Name = "Desde";
            // 
            // Hasta
            // 
            this.Hasta.HeaderText = "Hasta";
            this.Hasta.Name = "Hasta";
            // 
            // MarcaClase
            // 
            this.MarcaClase.HeaderText = "Marca de clase";
            this.MarcaClase.Name = "MarcaClase";
            // 
            // FrecuenciaObservada
            // 
            this.FrecuenciaObservada.HeaderText = "Frecuencia observada";
            this.FrecuenciaObservada.Name = "FrecuenciaObservada";
            // 
            // FrecuenciaEsperada
            // 
            this.FrecuenciaEsperada.HeaderText = "Frecuencia esperada";
            this.FrecuenciaEsperada.Name = "FrecuenciaEsperada";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "C()";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "C() Acumulado";
            this.Column6.Name = "Column6";
            // 
            // dataChi
            // 
            this.dataChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.C,
            this.xd});
            this.dataChi.Location = new System.Drawing.Point(60, 307);
            this.dataChi.Name = "dataChi";
            this.dataChi.Size = new System.Drawing.Size(644, 178);
            this.dataChi.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Desde";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hasta";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Frecuencia Observada";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Frecuencia esperada";
            this.Column4.Name = "Column4";
            // 
            // C
            // 
            this.C.HeaderText = "C";
            this.C.Name = "C";
            // 
            // xd
            // 
            this.xd.HeaderText = "C(acumulado)";
            this.xd.Name = "xd";
            // 
            // CbIntervalos
            // 
            this.CbIntervalos.FormattingEnabled = true;
            this.CbIntervalos.Items.AddRange(new object[] {
            "Opciones",
            "5 intervalos",
            "10 intervalos",
            "20 intervalos",
            "25 intervalos"});
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "HIPOTESIS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 535);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "GRAFICO";
            // 
            // graficoHistograma
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoHistograma.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoHistograma.Legends.Add(legend1);
            this.graficoHistograma.Location = new System.Drawing.Point(43, 292);
            this.graficoHistograma.Name = "graficoHistograma";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Intervalos";
            this.graficoHistograma.Series.Add(series1);
            this.graficoHistograma.Size = new System.Drawing.Size(687, 304);
            this.graficoHistograma.TabIndex = 21;
            this.graficoHistograma.Text = "chart1";
            this.graficoHistograma.Click += new System.EventHandler(this.graficoHistograma_Click);
            // 
            // HipotesisTxt
            // 
            this.HipotesisTxt.AutoSize = true;
            this.HipotesisTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HipotesisTxt.Location = new System.Drawing.Point(59, 667);
            this.HipotesisTxt.Name = "HipotesisTxt";
            this.HipotesisTxt.Size = new System.Drawing.Size(66, 24);
            this.HipotesisTxt.TabIndex = 22;
            this.HipotesisTxt.Text = "label4";
            this.HipotesisTxt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // graficoFrecEsperada
            // 
            chartArea2.Name = "ChartArea1";
            this.graficoFrecEsperada.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.graficoFrecEsperada.Legends.Add(legend2);
            this.graficoFrecEsperada.Location = new System.Drawing.Point(736, 292);
            this.graficoFrecEsperada.Name = "graficoFrecEsperada";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graficoFrecEsperada.Series.Add(series2);
            this.graficoFrecEsperada.Size = new System.Drawing.Size(463, 304);
            this.graficoFrecEsperada.TabIndex = 23;
            this.graficoFrecEsperada.Text = "chart1";
            // 
            // hipotesisNulaTxt
            // 
            this.hipotesisNulaTxt.AutoSize = true;
            this.hipotesisNulaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hipotesisNulaTxt.Location = new System.Drawing.Point(56, 620);
            this.hipotesisNulaTxt.Name = "hipotesisNulaTxt";
            this.hipotesisNulaTxt.Size = new System.Drawing.Size(66, 24);
            this.hipotesisNulaTxt.TabIndex = 24;
            this.hipotesisNulaTxt.Text = "label4";
            this.hipotesisNulaTxt.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 749);
            this.Controls.Add(this.hipotesisNulaTxt);
            this.Controls.Add(this.graficoFrecEsperada);
            this.Controls.Add(this.HipotesisTxt);
            this.Controls.Add(this.graficoHistograma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbIntervalos);
            this.Controls.Add(this.dataChi);
            this.Controls.Add(this.dataInforme);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFORME Y PRUEBA CHI";
            ((System.ComponentModel.ISupportInitialize)(this.dataInforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoHistograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoFrecEsperada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataInforme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaClase;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaObservada;
        private System.Windows.Forms.DataGridViewTextBoxColumn FrecuenciaEsperada;
        private System.Windows.Forms.DataGridView dataChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn C;
        private System.Windows.Forms.DataGridViewTextBoxColumn xd;
        private System.Windows.Forms.ComboBox CbIntervalos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoHistograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label HipotesisTxt;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoFrecEsperada;
        private System.Windows.Forms.Label hipotesisNulaTxt;
    }
}