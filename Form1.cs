namespace AppBancoDeDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Bot�o de inserir dados
        private void button1_Click(object sender, EventArgs e)
        {
            InserirDados janela = new InserirDados();
            janela.ShowDialog(); // Exibe a janela
        }

        // Bot�o de abrir menu de consulta
        private void button2_Click(object sender, EventArgs e)
        {
            EscolherConsulta janela = new EscolherConsulta();
            janela.ShowDialog(); // Exibe a janela
        }

        // Bot�o de abrir o menu de exclus�o
        private void button3_Click(object sender, EventArgs e)
        {
            RemoverDados janela = new RemoverDados();
            janela.ShowDialog(); // Exibe a janela
        }
    }
}
