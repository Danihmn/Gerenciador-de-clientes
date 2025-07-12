namespace AppBancoDeDados
{
    public partial class RemoverDados : Form
    {
        public RemoverDados()
        {
            InitializeComponent();
        }

        // Botão de remover clientes
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                object id = textBox1.Text; // Passa o texto para a variável id
                bool existeDado = Verificacao.VerificarPorId(id); // Método de verificação de existência por id

                if (id != "")
                {
                    if (existeDado)
                    {
                        Remocao.RemoverDados(id); // Executa a exclusão
                        MessageBox.Show("Cliente removido com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Não existe um cliente com esse id.");
                    }
                }
                else
                {
                    MessageBox.Show("Um id deve ser inserido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o cliente. " + ex.Message);
                return;
            }
        }
    }
}
