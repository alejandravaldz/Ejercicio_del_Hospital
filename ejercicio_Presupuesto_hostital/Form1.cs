namespace ejercicio_Presupuesto_hostital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Distribuir_Click(object sender, EventArgs e)
        {
            Double presupuesto, administracion, cirugia, emergencia, imagenes, suministros, laboratorio;

            presupuesto = Double.Parse(txt_Presupuesto.Text);

            emergencia = (presupuesto * 30) / 100;
            cirugia = (presupuesto * 15) / 100;
            suministros = (presupuesto * 25) / 100;
            administracion = (presupuesto * 18) / 100;
            laboratorio = (presupuesto * 5) / 100;
            imagenes = (presupuesto * 7) / 100;

            txt_Administración.Text = administracion.ToString();
            txt_Cirugía.Text = cirugia.ToString();
            txt_Emergencia.Text = emergencia.ToString();
            txt_Imagenes_Diagnosticadas.Text = imagenes.ToString();
            txt_Laboratorio.Text = laboratorio.ToString();
            txt_Suministro.Text = suministros.ToString();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Presupuesto.Clear();
            txt_Administración.Clear();
            txt_Cirugía.Clear();
            txt_Emergencia.Clear();
            txt_Imagenes_Diagnosticadas.Clear();
            txt_Laboratorio.Clear();
            txt_Suministro.Clear();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}