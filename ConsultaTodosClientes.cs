namespace AppBancoDeDados
{
    public partial class ConsultaTodosClientes : Form
    {
        public ConsultaTodosClientes()
        {
            InitializeComponent();
        }

        // Botão que exibe as tabelas
        private void button1_Click(object sender, EventArgs e)
        {
            // Exibe em um dataGridView
            dataGridView1.DataSource = Consulta.ConsultaTodos();
        }
    }
}
