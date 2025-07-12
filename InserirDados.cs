namespace AppBancoDeDados
{
    /// <summary>
    /// Formulário de inserção de dados
    /// </summary>
    public partial class InserirDados : Form
    {
        public InserirDados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Armazena os valores dos campos
                string nome = textBox1.Text.ToUpper().Trim();
                string email = textBox2.Text.ToLower().Trim();
                string telefone = textBox3.Text.ToUpper().Trim();

                // Métodos de verificação de existência
                bool existeEmail = Verificacao.VerificarPorEmail(email);
                bool existeTelefone = Verificacao.VerificarPorTelefone(telefone);

                if (nome != "" && email != "" && telefone != "")
                {
                    if (!existeEmail)
                    {
                        if (!existeTelefone)
                        {
                            Insercao.InserirDados(nome, email, telefone); // Chama o método de inserir os dados
                            MessageBox.Show("Dados inseridos com sucesso");
                        }
                        else
                        {
                            MessageBox.Show("Já existe um cliente com esse telefone");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Já existe um cliente com esse e-mail");
                    }
                }
                else
                {
                    MessageBox.Show("Insira os dados para prosseguir");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir os dados: {ex.Message}");
                throw;
            }
        }
    }
}