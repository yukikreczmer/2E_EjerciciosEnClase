using Biblioteca;

namespace Vista
{
    public partial class Form1 : Form
    {
        Persona persona1;
        List<Persona> listaPersonas;
        public Form1()
        {
            listaPersonas = new List<Persona>();
            InitializeComponent();
        }

        private void btn_CargarPersona_Click(object sender, EventArgs e)
        {
            FrmPersona frmPersona = new FrmPersona ();
            if(frmPersona.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}