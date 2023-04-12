using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmPersona : Form
    {
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if(!(Validadora.ValidarTexto(txb_Nombre.Text)))
            {
                lbl_ErrorNombre.Visible = true;
            }
            if(!(Validadora.ValidarTexto(txb_Legajo.Text)))
            {
                lbl_ErrorLegajo.Visible = true;
            }
        }
    }
}
