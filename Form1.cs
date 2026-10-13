namespace EjerOperaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperaciones.Items.Add("Suma");
            this.cmbOperaciones.Items.Add("Resta");
            this.cmbOperaciones.Items.Add("Multiplicación");
            this.cmbOperaciones.Items.Add("División");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            if (this.cmbOperaciones.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una operación");
                return;
            }

            string op = this.cmbOperaciones.SelectedItem.ToString();
            
            if (string.IsNullOrEmpty(this.txtnum1.Text) || string.IsNullOrEmpty(this.txtnum2.Text))
            {
                MessageBox.Show("Ingrese los números");
                return;
            }
            if (!int.TryParse(this.txtnum1.Text, out int txtnum1) || !int.TryParse(this.txtnum2.Text, out int txtnum2))
            {
                MessageBox.Show("Ingrese números válidos");
                return;
            }
            switch (op)
            {
                case "Suma":
                    resultado = int.Parse(this.txtnum1.Text) + int.Parse(this.txtnum2.Text);
                    this.txtResultado.Text = resultado.ToString();
                    break;
                case "Resta":
                    resultado = int.Parse(this.txtnum1.Text) - int.Parse(this.txtnum2.Text);
                    this.txtResultado.Text = resultado.ToString();
                    break;
                case "Multiplicación":
                    resultado = int.Parse(this.txtnum1.Text) * int.Parse(this.txtnum2.Text);
                    this.txtResultado.Text = resultado.ToString();
                    break;
                case "División":
                    if ((int.Parse(this.txtnum1.Text)==0) || (int.Parse(this.txtnum2.Text)==0))
                    {
                        MessageBox.Show("No se puede dividir por cero");
                        return;
                    }
                    resultado = int.Parse(this.txtnum1.Text) / int.Parse(this.txtnum2.Text);
                    this.txtResultado.Text = resultado.ToString();
                    break;

                default:
                    break;
            }
            this.txtResultado.Text = resultado.ToString();
        }
    }
}
