﻿namespace Vista
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
            this.btn_CargarPersona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CargarPersona
            // 
            this.btn_CargarPersona.Location = new System.Drawing.Point(114, 231);
            this.btn_CargarPersona.Name = "btn_CargarPersona";
            this.btn_CargarPersona.Size = new System.Drawing.Size(116, 39);
            this.btn_CargarPersona.TabIndex = 0;
            this.btn_CargarPersona.Text = "Cargar Persona";
            this.btn_CargarPersona.UseVisualStyleBackColor = true;
            this.btn_CargarPersona.Click += new System.EventHandler(this.btn_CargarPersona_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_CargarPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_CargarPersona;
    }
}