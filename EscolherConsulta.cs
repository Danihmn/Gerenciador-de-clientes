namespace AppBancoDeDados
{
    /// <summary>
    /// Formulário de consultas de dados
    /// </summary>
    public partial class EscolherConsulta : Form
    {
        public EscolherConsulta()
        {
            InitializeComponent();
        }

        // Botão de consulta por id
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text;
                var consulta = Consulta.ConsultaPorId(id); // Executa o método de consulta por id
                string resultadoId = consulta.Rows[0].ItemArray[0].ToString();
                string resultadoNome = consulta.Rows[0].ItemArray[1].ToString();
                string resultadoEmail = consulta.Rows[0].ItemArray[2].ToString();
                string resultadoTelefone = consulta.Rows[0].ItemArray[3].ToString();
                string resultadoFinal = $"Id: {resultadoId}\nNome: {resultadoNome}\nE-mail: {resultadoEmail}\nTelefone: {resultadoTelefone}";

                if (consulta != null)
                {
                    // Exibe a linha do DataTable
                    MessageBox.Show(resultadoFinal, "Cliente encontrado");
                }
                else
                {
                    MessageBox.Show("Erro ao encontrar o cliente com os dados fornecidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a consulta. " + ex.Message);
                throw;
            }
        }

        // Botão de consulta por nome
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = textBox2.Text.ToUpper().Trim();
                var consulta = Consulta.ConsultaPorNome(nome); // Executa o método de consulta por nome
                string resultadoId = consulta.Rows[0].ItemArray[0].ToString();
                string resultadoNome = consulta.Rows[0].ItemArray[1].ToString();
                string resultadoEmail = consulta.Rows[0].ItemArray[2].ToString();
                string resultadoTelefone = consulta.Rows[0].ItemArray[3].ToString();
                string resultadoFinal = $"Id: {resultadoId}\nNome: {resultadoNome}\nE-mail: {resultadoEmail}\nTelefone: {resultadoTelefone}";

                if (consulta != null)
                {
                    // Exibe a linha do DataTable
                    MessageBox.Show(resultadoFinal, "Cliente encontrado");
                }
                else
                {
                    MessageBox.Show("Erro ao encontrar o cliente com os dados fornecidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao realizar a consulta. " + ex.Message);
                throw;
            }
        }

        // Botão de abrir a janela para consultar todos os clientes
        private void button3_Click(object sender, EventArgs e)
        {
            ConsultaTodosClientes janela = new ConsultaTodosClientes();
            janela.ShowDialog();
        }
    }
}
