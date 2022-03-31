
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
            this.TxtA = new System.Windows.Forms.TextBox();
            this.TxtM = new System.Windows.Forms.TextBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(223, 127);
            this.TxtA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(132, 22);
            this.TxtA.TabIndex = 1;
            // 
            // TxtM
            // 
            this.TxtM.Location = new System.Drawing.Point(223, 181);
            this.TxtM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtM.Name = "TxtM";
            this.TxtM.Size = new System.Drawing.Size(132, 22);
            this.TxtM.TabIndex = 2;
            // 
            // TxtSemilla
            // 
            this.TxtSemilla.Location = new System.Drawing.Point(223, 69);
            this.TxtSemilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtSemilla.Name = "TxtSemilla";
            this.TxtSemilla.Size = new System.Drawing.Size(132, 22);
            this.TxtSemilla.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese X0:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese M:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 234);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ingrese c:";
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(223, 236);
            this.TxtC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(132, 22);
            this.TxtC.TabIndex = 11;
            // 
            // DgvTablaIteraciones
            // 
            this.DgvTablaIteraciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTablaIteraciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iteracion,
            this.Column1,
            this.Column2});
            this.DgvTablaIteraciones.Location = new System.Drawing.Point(473, 69);
            this.DgvTablaIteraciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DgvTablaIteraciones.Name = "DgvTablaIteraciones";
            this.DgvTablaIteraciones.RowHeadersWidth = 51;
            this.DgvTablaIteraciones.Size = new System.Drawing.Size(519, 383);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(391, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "k";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(391, 185);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "g";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "semilla";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 468);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 60);
            this.button1.TabIndex = 18;
            this.button1.Text = "Generar otro pseudoaletorio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RbCongruencialMIxto
            // 
            this.RbCongruencialMIxto.AutoSize = true;
            this.RbCongruencialMIxto.Checked = true;
            this.RbCongruencialMIxto.Location = new System.Drawing.Point(88, 375);
            this.RbCongruencialMIxto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbCongruencialMIxto.Name = "RbCongruencialMIxto";
            this.RbCongruencialMIxto.Size = new System.Drawing.Size(240, 20);
            this.RbCongruencialMIxto.TabIndex = 21;
            this.RbCongruencialMIxto.TabStop = true;
            this.RbCongruencialMIxto.Text = "METODO CONGRUENCIAL MIXTO";
            this.RbCongruencialMIxto.UseVisualStyleBackColor = true;
            this.RbCongruencialMIxto.CheckedChanged += new System.EventHandler(this.RbCongruencialMIxto_CheckedChanged);
            // 
            // RbCongruencialMulti
            // 
            this.RbCongruencialMulti.AutoSize = true;
            this.RbCongruencialMulti.Location = new System.Drawing.Point(92, 423);
            this.RbCongruencialMulti.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbCongruencialMulti.Name = "RbCongruencialMulti";
            this.RbCongruencialMulti.Size = new System.Drawing.Size(307, 20);
            this.RbCongruencialMulti.TabIndex = 22;
            this.RbCongruencialMulti.Text = "METODO CONGRUENCIAL MULTIPLICATIVO";
            this.RbCongruencialMulti.UseVisualStyleBackColor = true;
            this.RbCongruencialMulti.CheckedChanged += new System.EventHandler(this.RbCongruencialMulti_CheckedChanged);
            // 
            // RbLenguajeC
            // 
            this.RbLenguajeC.AutoSize = true;
            this.RbLenguajeC.Location = new System.Drawing.Point(96, 471);
            this.RbLenguajeC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RbLenguajeC.Name = "RbLenguajeC";
            this.RbLenguajeC.Size = new System.Drawing.Size(118, 20);
            this.RbLenguajeC.TabIndex = 23;
            this.RbLenguajeC.Text = "LENGUAJE C#";
            this.RbLenguajeC.UseVisualStyleBackColor = true;
            this.RbLenguajeC.CheckedChanged += new System.EventHandler(this.RbLenguajeC_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(67, 500);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(311, 65);
            this.button4.TabIndex = 24;
            this.button4.Text = "GENERAR SIMULACION";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BotonSimular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ingrese N:";
            // 
            // txtN
            // 
            this.txtN.Enabled = false;
            this.txtN.Location = new System.Drawing.Point(223, 281);
            this.txtN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(132, 22);
            this.txtN.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbGeneracionPorTeclado);
            this.groupBox1.Location = new System.Drawing.Point(67, 314);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(360, 54);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // CbGeneracionPorTeclado
            // 
            this.CbGeneracionPorTeclado.AutoSize = true;
            this.CbGeneracionPorTeclado.Location = new System.Drawing.Point(25, 23);
            this.CbGeneracionPorTeclado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CbGeneracionPorTeclado.Name = "CbGeneracionPorTeclado";
            this.CbGeneracionPorTeclado.Size = new System.Drawing.Size(184, 20);
            this.CbGeneracionPorTeclado.TabIndex = 29;
            this.CbGeneracionPorTeclado.Text = "GENERE POR TECLADO";
            this.CbGeneracionPorTeclado.UseVisualStyleBackColor = true;
            this.CbGeneracionPorTeclado.CheckedChanged += new System.EventHandler(this.CbGeneracionPorTeclado_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(685, 468);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 64);
            this.button2.TabIndex = 29;
            this.button2.Text = "INFORME";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(856, 471);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(136, 64);
            this.btnLimpiar.TabIndex = 30;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1036, 602);
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
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DgvTablaIteraciones);
            this.Controls.Add(this.TxtC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSemilla);
            this.Controls.Add(this.TxtM);
            this.Controls.Add(this.TxtA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox TxtA;
        private System.Windows.Forms.TextBox TxtM;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
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

