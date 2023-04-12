using Biblioteca;

namespace EjercicioI02
{
    public partial class Form1 : Form
    {
        Ingresante ingresante;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if(Validadora.ValidarTexto(txb_Nombre.Text))
            {
                if(!string.IsNullOrEmpty(txb_Direccion.Text))
                {
                    if(ValidarRadioButtonSeleccionado(gpb_Genero))
                    {
                        if(lsb_Pais.SelectedItems.Count > 0)
                        {
                            // falta validar edad, cursos
                        }
                        //error pais no seleccionado
                    }
                    //error genero no seleccionado                    
                }
                //error direccion vacia
            }
            //error nombre
        }
        private bool ValidarRadioButtonSeleccionado(GroupBox gpb)
        {
            foreach (RadioButton rbtn in gpb_Genero.Controls)
            {                
                if(rbtn.Checked == true)
                {
                    return true;
                }
            }
            return false;
        }        
        private bool ValidarItemListBoxSeleccionado(ListBox list)
        {
            foreach (object item in list)
            {
                if(item.)
                {
                    return true;
                }
            }
            return false;
        }
    }
}