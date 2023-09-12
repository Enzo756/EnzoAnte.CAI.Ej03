namespace EnzoAnte.CAI.Ej03
{
    public partial class FormPrincipal : Form
    {
        Ejercicio03Model modelo;
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            modelo = new Ejercicio03Model();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            modelo.Pa�sIngresado = (string)this.cmbPa�s.SelectedItem;
            modelo.ProvinciaIngresada = (string)this.cmbProvincia.SelectedItem;
            modelo.LocalidadIngresada = (string)this.cmbLocalidad.SelectedItem;
            modelo.CalleIngresada = this.txtCalle.Text;
            modelo.N�meroIngresado = this.txtN�mero.Text;
            modelo.PisoIngresado = this.txtPiso.Text;
            modelo.DepartamentoIngresado = this.txtDepartamento.Text;

            string mensaje = modelo.Validar();
            MessageBox.Show(mensaje);

        }
    }
}