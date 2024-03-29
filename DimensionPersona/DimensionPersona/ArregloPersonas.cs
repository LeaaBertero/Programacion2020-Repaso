using System.Security.Cryptography;

namespace DimensionPersona
{
    public partial class ArregloPersonas : Form
    {
        //public DimensionPersona.Persona[] Personas { get; set; }

        //se instancia y se inicializa nuevamente el objeto persona (Front End)
        public Persona per = new Persona();

        //Clase ListaPersonas ---> inicializada 
        public ListaPersonas Lista { get; set; } = new ListaPersonas();


        public ArregloPersonas()
        {
            InitializeComponent();
        }

        //M�todo boton cargar
        private void btcargar_Click(object sender, EventArgs e)
        {
            //Persona persona = new Persona();
            //persona.Nombre = txnombre.Text;
            //persona.A�oNacimiento = Convert.ToInt32(txa�o.Text);
            //Lista.Redimensionar();
            //Lista.Personas[Lista.Personas.Length - 1] = persona;

            if (per.Id == 0) 
            {
                per.Nombre = txnombre.Text;
                per.A�oNacimiento = Convert.ToInt32(txa�o.Text);
            }

            lblista.Visible = true;
            if (!Lista.AddPersona(per))
            {
                txa�o.Focus();
                txa�o.SelectAll();
                //lblista.Text = "Persona no valida";
                MessageBox.Show("Persona no valida");
            }
            else
            {
                btmostrar_Click(null, null);
                txa�o.Text = "";
                txnombre.Text = "";
                txnombre.Focus();
                //lblista.Text = "Carga correcta";
                //MessageBox.Show("Carga correcta");
            }

            per = new Persona();

        }

        //M�todo boton mostrar
        private void btmostrar_Click(object sender, EventArgs e)
        {
            //lblista.Text = "Lista:\\r\\n\\";
            //foreach (Persona item in Lista.Personas)
            //{
            //    lblista.Text = "Lista de personas cargadas" 
            //        + "\r\n" 
            //        + "\r\n" 
            //        + "Nombre:" + " " 
            //        + item.Nombre + "\r\n" 
            //        + "A�o:" + " " + item.A�oNacimiento.ToString();
            //}
            lblista.Text = Lista.ToString();
        }

        //private void Redimensionar()
        //{
        //    if (Personas == null)
        //    {
        //        Personas = new Persona[0];
        //    }
        //    else
        //    {
        //        Persona[] arregloAuxiliar = new Persona[Personas.Length + 1];

        //        for (int incremneto = 0; incremneto < Personas.Length; incremneto++)
        //        {
        //            arregloAuxiliar[incremneto] = Personas[incremneto];
        //        }

        //        Personas = arregloAuxiliar;
        //    }
        //}

        private void btOperaciones_Click(object sender, EventArgs e)
        {
            Form calcu = new Calcu();
            calcu.Show();
        }

        private void btcerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btFiltrar_Click(object sender, EventArgs e)
        {
            lblista.Text = Lista.ToStringFiltrado(2000);
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            per = Lista.BuscarPersonas(Convert.ToInt32(txCodigo.Text));

            //Lista.deletePersona(per);

            if (per.Id > 0)
            {
                txnombre.Text = per.Nombre;
                txa�o.Text = per.A�oNacimiento.ToString();

                txnombre.Focus();
            }
            else
            {
                txCodigo.Text = "C�digo inexistente";
                txCodigo.Focus();
                txCodigo.SelectAll();
            }

        }

        private void btBorrar_Click(object sender, EventArgs e)
        {

        }

      
    }
}
