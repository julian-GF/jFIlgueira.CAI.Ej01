namespace jFIlgueira.CAI.Ej01
{
    public partial class FormularioPersona : Form
    {
        FormularioPersonasModel model;
        public FormularioPersona()
        {
            InitializeComponent();
        }

        private void FormularioPersona_Load(object sender, EventArgs e)
        {
            model = new FormularioPersonasModel();
            
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            model.DocumentoIngresado = this.DocuementoTxt.Text;
            model.NombreIngresado = this.NombreTxt.Text;
            model.ApellidoIngresado = this.ApellidoTxt.Text;
            model.FechaNacimiento = this.FechaNacimientoTxt.Text;

            string mensaje =model.validar();
            MessageBox.Show(mensaje);

        }
    }
}