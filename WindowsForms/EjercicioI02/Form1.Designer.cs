namespace EjercicioI02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpb_DetallesUsuario = new System.Windows.Forms.GroupBox();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.nmc_Edad = new System.Windows.Forms.NumericUpDown();
            this.txb_Direccion = new System.Windows.Forms.TextBox();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.gpb_Genero = new System.Windows.Forms.GroupBox();
            this.rdb_NoBinario = new System.Windows.Forms.RadioButton();
            this.rdb_Femenino = new System.Windows.Forms.RadioButton();
            this.rdb_Masculino = new System.Windows.Forms.RadioButton();
            this.gpb_Cursos = new System.Windows.Forms.GroupBox();
            this.chb_JavaScript = new System.Windows.Forms.CheckBox();
            this.chb_CPlusPlus = new System.Windows.Forms.CheckBox();
            this.chb_CSharp = new System.Windows.Forms.CheckBox();
            this.lsb_Pais = new System.Windows.Forms.ListBox();
            this.lbl_Pais = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.gpb_DetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Edad)).BeginInit();
            this.gpb_Genero.SuspendLayout();
            this.gpb_Cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_DetallesUsuario
            // 
            this.gpb_DetallesUsuario.Controls.Add(this.lbl_Edad);
            this.gpb_DetallesUsuario.Controls.Add(this.lbl_Direccion);
            this.gpb_DetallesUsuario.Controls.Add(this.lbl_Nombre);
            this.gpb_DetallesUsuario.Controls.Add(this.nmc_Edad);
            this.gpb_DetallesUsuario.Controls.Add(this.txb_Direccion);
            this.gpb_DetallesUsuario.Controls.Add(this.txb_Nombre);
            this.gpb_DetallesUsuario.Location = new System.Drawing.Point(53, 45);
            this.gpb_DetallesUsuario.Name = "gpb_DetallesUsuario";
            this.gpb_DetallesUsuario.Size = new System.Drawing.Size(253, 160);
            this.gpb_DetallesUsuario.TabIndex = 0;
            this.gpb_DetallesUsuario.TabStop = false;
            this.gpb_DetallesUsuario.Text = "Detalles del usuario";
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(28, 131);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_Edad.TabIndex = 5;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(28, 82);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_Direccion.TabIndex = 4;
            this.lbl_Direccion.Text = "Dirección";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(28, 46);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 3;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // nmc_Edad
            // 
            this.nmc_Edad.Location = new System.Drawing.Point(132, 131);
            this.nmc_Edad.Name = "nmc_Edad";
            this.nmc_Edad.Size = new System.Drawing.Size(100, 23);
            this.nmc_Edad.TabIndex = 2;
            // 
            // txb_Direccion
            // 
            this.txb_Direccion.Location = new System.Drawing.Point(132, 79);
            this.txb_Direccion.Name = "txb_Direccion";
            this.txb_Direccion.Size = new System.Drawing.Size(100, 23);
            this.txb_Direccion.TabIndex = 1;
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(132, 41);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_Nombre.TabIndex = 0;
            // 
            // gpb_Genero
            // 
            this.gpb_Genero.Controls.Add(this.rdb_NoBinario);
            this.gpb_Genero.Controls.Add(this.rdb_Femenino);
            this.gpb_Genero.Controls.Add(this.rdb_Masculino);
            this.gpb_Genero.Location = new System.Drawing.Point(389, 47);
            this.gpb_Genero.Name = "gpb_Genero";
            this.gpb_Genero.Size = new System.Drawing.Size(141, 119);
            this.gpb_Genero.TabIndex = 1;
            this.gpb_Genero.TabStop = false;
            this.gpb_Genero.Text = "Género";
            // 
            // rdb_NoBinario
            // 
            this.rdb_NoBinario.AutoSize = true;
            this.rdb_NoBinario.Location = new System.Drawing.Point(23, 72);
            this.rdb_NoBinario.Name = "rdb_NoBinario";
            this.rdb_NoBinario.Size = new System.Drawing.Size(81, 19);
            this.rdb_NoBinario.TabIndex = 2;
            this.rdb_NoBinario.TabStop = true;
            this.rdb_NoBinario.Text = "No binario";
            this.rdb_NoBinario.UseVisualStyleBackColor = true;
            // 
            // rdb_Femenino
            // 
            this.rdb_Femenino.AutoSize = true;
            this.rdb_Femenino.Location = new System.Drawing.Point(23, 47);
            this.rdb_Femenino.Name = "rdb_Femenino";
            this.rdb_Femenino.Size = new System.Drawing.Size(78, 19);
            this.rdb_Femenino.TabIndex = 1;
            this.rdb_Femenino.TabStop = true;
            this.rdb_Femenino.Text = "Femenino";
            this.rdb_Femenino.UseVisualStyleBackColor = true;
            // 
            // rdb_Masculino
            // 
            this.rdb_Masculino.AutoSize = true;
            this.rdb_Masculino.Location = new System.Drawing.Point(23, 22);
            this.rdb_Masculino.Name = "rdb_Masculino";
            this.rdb_Masculino.Size = new System.Drawing.Size(80, 19);
            this.rdb_Masculino.TabIndex = 0;
            this.rdb_Masculino.TabStop = true;
            this.rdb_Masculino.Text = "Masculino";
            this.rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // gpb_Cursos
            // 
            this.gpb_Cursos.Controls.Add(this.chb_JavaScript);
            this.gpb_Cursos.Controls.Add(this.chb_CPlusPlus);
            this.gpb_Cursos.Controls.Add(this.chb_CSharp);
            this.gpb_Cursos.Location = new System.Drawing.Point(389, 176);
            this.gpb_Cursos.Name = "gpb_Cursos";
            this.gpb_Cursos.Size = new System.Drawing.Size(141, 117);
            this.gpb_Cursos.TabIndex = 2;
            this.gpb_Cursos.TabStop = false;
            this.gpb_Cursos.Text = "Cursos";
            // 
            // chb_JavaScript
            // 
            this.chb_JavaScript.AutoSize = true;
            this.chb_JavaScript.Location = new System.Drawing.Point(20, 72);
            this.chb_JavaScript.Name = "chb_JavaScript";
            this.chb_JavaScript.Size = new System.Drawing.Size(78, 19);
            this.chb_JavaScript.TabIndex = 2;
            this.chb_JavaScript.Text = "JavaScript";
            this.chb_JavaScript.UseVisualStyleBackColor = true;
            // 
            // chb_CPlusPlus
            // 
            this.chb_CPlusPlus.AutoSize = true;
            this.chb_CPlusPlus.Location = new System.Drawing.Point(20, 47);
            this.chb_CPlusPlus.Name = "chb_CPlusPlus";
            this.chb_CPlusPlus.Size = new System.Drawing.Size(50, 19);
            this.chb_CPlusPlus.TabIndex = 1;
            this.chb_CPlusPlus.Text = "C++";
            this.chb_CPlusPlus.UseVisualStyleBackColor = true;
            // 
            // chb_CSharp
            // 
            this.chb_CSharp.AutoSize = true;
            this.chb_CSharp.Location = new System.Drawing.Point(20, 22);
            this.chb_CSharp.Name = "chb_CSharp";
            this.chb_CSharp.Size = new System.Drawing.Size(41, 19);
            this.chb_CSharp.TabIndex = 0;
            this.chb_CSharp.Text = "C#";
            this.chb_CSharp.UseVisualStyleBackColor = true;
            // 
            // lsb_Pais
            // 
            this.lsb_Pais.FormattingEnabled = true;
            this.lsb_Pais.ItemHeight = 15;
            this.lsb_Pais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lsb_Pais.Location = new System.Drawing.Point(63, 259);
            this.lsb_Pais.Name = "lsb_Pais";
            this.lsb_Pais.Size = new System.Drawing.Size(190, 79);
            this.lsb_Pais.TabIndex = 3;
            // 
            // lbl_Pais
            // 
            this.lbl_Pais.AutoSize = true;
            this.lbl_Pais.Location = new System.Drawing.Point(64, 238);
            this.lbl_Pais.Name = "lbl_Pais";
            this.lbl_Pais.Size = new System.Drawing.Size(28, 15);
            this.lbl_Pais.TabIndex = 4;
            this.lbl_Pais.Text = "País";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(389, 328);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(117, 30);
            this.btn_Ingresar.TabIndex = 5;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 385);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lbl_Pais);
            this.Controls.Add(this.lsb_Pais);
            this.Controls.Add(this.gpb_Cursos);
            this.Controls.Add(this.gpb_Genero);
            this.Controls.Add(this.gpb_DetallesUsuario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpb_DetallesUsuario.ResumeLayout(false);
            this.gpb_DetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmc_Edad)).EndInit();
            this.gpb_Genero.ResumeLayout(false);
            this.gpb_Genero.PerformLayout();
            this.gpb_Cursos.ResumeLayout(false);
            this.gpb_Cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gpb_DetallesUsuario;
        private TextBox txb_Nombre;
        private NumericUpDown nmc_Edad;
        private TextBox txb_Direccion;
        private Label lbl_Edad;
        private Label lbl_Direccion;
        private Label lbl_Nombre;
        private GroupBox gpb_Genero;
        private RadioButton rdb_NoBinario;
        private RadioButton rdb_Femenino;
        private RadioButton rdb_Masculino;
        private GroupBox gpb_Cursos;
        private CheckBox chb_JavaScript;
        private CheckBox chb_CPlusPlus;
        private CheckBox chb_CSharp;
        private ListBox lsb_Pais;
        private Label lbl_Pais;
        private Button btn_Ingresar;
    }
}