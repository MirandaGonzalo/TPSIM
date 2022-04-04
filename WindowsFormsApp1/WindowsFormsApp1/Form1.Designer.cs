
namespace WindowsFormsApp1
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
            this.TxtK = new System.Windows.Forms.TextBox();
            this.TxtG = new System.Windows.Forms.TextBox();
            this.TxtSemilla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.DgvTablaIteraciones = new System.Windows.Forms.DataGridView();
            this.Iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.RbCongruencialMIxto = new System.Windows.Forms.RadioButton();
            this.RbCongruencialMulti = new System.Windows.Forms.RadioButton();
            this.RbLenguajeC = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbGeneracionPorTeclado = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaIteraciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtK
            // 
            this.TxtK.Location = new System.Drawing.Point(167, 103);
            this.TxtK.Name = "TxtK";
            this.TxtK.Size = new System.Drawing.Size(100, 20);
            this.TxtK.TabIndex = 1;
            // 
            // TxtG
            // 
            this.TxtG.Location = new System.Drawing.Point(167, 147);
            this.TxtG.Name = "TxtG";
            this.TxtG.Size = new System.Drawing.Size(100, 20);
            this.TxtG.TabIndex = 2;
            // 
            // TxtSemilla
            // 
            this.TxtSemilla.Location = new System.Drawing.Point(167, 56);
            this.TxtSemilla.Name = "TxtSemilla";
            this.TxtSemilla.Size = new System.Drawing.Size(100, 20);
            this.TxtSemilla.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese X0:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese G:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese K:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese c:";
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(167, 192);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(100, 20);
            this.TxtC.TabIndex = 11;
            // 
            // DgvTablaIteraciones
            // 
            this.DgvTablaIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaIteraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Column1,
            this.Column2});
            this.DgvTablaIteraciones.Location = new System.Drawing.Point(355, 56);
            this.DgvTablaIteraciones.Name = "DgvTablaIteraciones";
            this.DgvTablaIteraciones.RowHeadersWidth = 51;
            this.DgvTablaIteraciones.Size = new System.Drawing.Size(389, 311);
            this.DgvTablaIteraciones.TabIndex = 14;
            // 
            // Iteracion
            // 
            this.Iteracion.HeaderText = "Iteracion";
            this.Iteracion.MinimumWidth = 6;
            this.Iteracion.Name = "Iteracion";
            this.Iteracion.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Valor X";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "RANDOM";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "semilla";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Generar otro pseudoaletorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RbCongruencialMIxto
            // 
            this.RbCongruencialMIxto.AutoSize = true;
            this.RbCongruencialMIxto.Checked = true;
            this.RbCongruencialMIxto.Location = new System.Drawing.Point(66, 305);
            this.RbCongruencialMIxto.Name = "RbCongruencialMIxto";
            this.RbCongruencialMIxto.Size = new System.Drawing.Size(197, 17);
            this.RbCongruencialMIxto.TabIndex = 21;
            this.RbCongruencialMIxto.TabStop = true;
            this.RbCongruencialMIxto.Text = "METODO CONGRUENCIAL MIXTO";
            this.RbCongruencialMIxto.UseVisualStyleBackColor = true;
            this.RbCongruencialMIxto.CheckedChanged += new System.EventHandler(this.RbCongruencialMIxto_CheckedChanged);
            // 
            // RbCongruencialMulti
            // 
            this.RbCongruencialMulti.AutoSize = true;
            this.RbCongruencialMulti.Location = new System.Drawing.Point(69, 344);
            this.RbCongruencialMulti.Name = "RbCongruencialMulti";
            this.RbCongruencialMulti.Size = new System.Drawing.Size(251, 17);
            this.RbCongruencialMulti.TabIndex = 22;
            this.RbCongruencialMulti.Text = "METODO CONGRUENCIAL MULTIPLICATIVO";
            this.RbCongruencialMulti.UseVisualStyleBackColor = true;
            this.RbCongruencialMulti.CheckedChanged += new System.EventHandler(this.RbCongruencialMulti_CheckedChanged);
            // 
            // RbLenguajeC
            // 
            this.RbLenguajeC.AutoSize = true;
            this.RbLenguajeC.Location = new System.Drawing.Point(72, 383);
            this.RbLenguajeC.Name = "RbLenguajeC";
            this.RbLenguajeC.Size = new System.Drawing.Size(98, 17);
            this.RbLenguajeC.TabIndex = 23;
            this.RbLenguajeC.Text = "LENGUAJE C#";
            this.RbLenguajeC.UseVisualStyleBackColor = true;
            this.RbLenguajeC.CheckedChanged += new System.EventHandler(this.RbLenguajeC_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(50, 406);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 53);
            this.button4.TabIndex = 24;
            this.button4.Text = "GENERAR SIMULACION";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BotonSimular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ingrese N:";
            // 
            // txtN
            // 
            this.txtN.Enabled = false;
            this.txtN.Location = new System.Drawing.Point(167, 228);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 20);
            this.txtN.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbGeneracionPorTeclado);
            this.groupBox1.Location = new System.Drawing.Point(50, 255);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 44);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // CbGeneracionPorTeclado
            // 
            this.CbGeneracionPorTeclado.AutoSize = true;
            this.CbGeneracionPorTeclado.Location = new System.Drawing.Point(19, 19);
            this.CbGeneracionPorTeclado.Name = "CbGeneracionPorTeclado";
            this.CbGeneracionPorTeclado.Size = new System.Drawing.Size(150, 17);
            this.CbGeneracionPorTeclado.TabIndex = 29;
            this.CbGeneracionPorTeclado.Text = "GENERE POR TECLADO";
            this.CbGeneracionPorTeclado.UseVisualStyleBackColor = true;
            this.CbGeneracionPorTeclado.CheckedChanged += new System.EventHandler(this.CbGeneracionPorTeclado_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(514, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 52);
            this.button2.TabIndex = 29;
            this.button2.Text = "INFORME";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(642, 383);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(102, 52);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(777, 489);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RbLenguajeC);
            this.Controls.Add(this.RbCongruencialMulti);
            this.Controls.Add(this.RbCongruencialMIxto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DgvTablaIteraciones);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSemilla);
            this.Controls.Add(this.TxtG);
            this.Controls.Add(this.TxtK);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GENERADOR DE NUMERO PSEUDOALEATORIOS";
            ((System.ComponentModel.ISupportInitialize)(this.DgvTablaIteraciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtK;
        private System.Windows.Forms.TextBox TxtG;
        private System.Windows.Forms.TextBox TxtSemilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtC;
        private System.Windows.Forms.DataGridView DgvTablaIteraciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RbCongruencialMIxto;
        private System.Windows.Forms.RadioButton RbCongruencialMulti;
        private System.Windows.Forms.RadioButton RbLenguajeC;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox CbGeneracionPorTeclado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

