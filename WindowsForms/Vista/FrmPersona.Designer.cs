namespace Vista
{
    partial class FrmPersona
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
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.txb_Legajo = new System.Windows.Forms.TextBox();
            this.lbl_ErrorNombre = new System.Windows.Forms.Label();
            this.lbl_ErrorLegajo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(187, 312);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirmar.TabIndex = 0;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(532, 312);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 1;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(321, 88);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.PlaceholderText = "Ingrese Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(100, 23);
            this.txb_Nombre.TabIndex = 2;
            // 
            // txb_Legajo
            // 
            this.txb_Legajo.Location = new System.Drawing.Point(321, 159);
            this.txb_Legajo.Name = "txb_Legajo";
            this.txb_Legajo.PlaceholderText = "Ingrese Legajo";
            this.txb_Legajo.Size = new System.Drawing.Size(100, 23);
            this.txb_Legajo.TabIndex = 3;
            // 
            // lbl_ErrorNombre
            // 
            this.lbl_ErrorNombre.AutoSize = true;
            this.lbl_ErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorNombre.Location = new System.Drawing.Point(321, 70);
            this.lbl_ErrorNombre.Name = "lbl_ErrorNombre";
            this.lbl_ErrorNombre.Size = new System.Drawing.Size(132, 15);
            this.lbl_ErrorNombre.TabIndex = 4;
            this.lbl_ErrorNombre.Text = "No se aceptan números";
            this.lbl_ErrorNombre.Visible = false;
            // 
            // lbl_ErrorLegajo
            // 
            this.lbl_ErrorLegajo.AutoSize = true;
            this.lbl_ErrorLegajo.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorLegajo.Location = new System.Drawing.Point(321, 141);
            this.lbl_ErrorLegajo.Name = "lbl_ErrorLegajo";
            this.lbl_ErrorLegajo.Size = new System.Drawing.Size(113, 15);
            this.lbl_ErrorLegajo.TabIndex = 5;
            this.lbl_ErrorLegajo.Text = "No se aceptan letras";
            this.lbl_ErrorLegajo.Visible = false;
            // 
            // FrmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ErrorLegajo);
            this.Controls.Add(this.lbl_ErrorNombre);
            this.Controls.Add(this.txb_Legajo);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Confirmar);
            this.Name = "FrmPersona";
            this.Text = "FrmPersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Confirmar;
        private Button btn_Cancelar;
        private TextBox txb_Nombre;
        private TextBox txb_Legajo;
        private Label lbl_ErrorNombre;
        private Label lbl_ErrorLegajo;
    }
}