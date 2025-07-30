using System.Data.SQLite;

namespace AppBancoDeDados
{
    public class InsercoesTests
    {
        private SQLiteConnection _conexao; // Será a conexão temporária

        /// <summary>
        /// Método responsável por estabelecer a conexão com o banco temporário.
        /// Cria o comando de criar uma nova tabela de clientes
        /// </summary>
        [TestInitialize]
        public void Setup()
        {
            // Passa como conexão um banco em memória
            _conexao = new SQLiteConnection("Data Source=:memory:;Version=3;New=True;");
            _conexao.Open();

            // Cria nova tabela
            var comando = _conexao.CreateCommand();
            comando.CommandText = @"
                CREATE TABLE clientes(
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    nome TEXT,
                    email TEXT,
                    telefone TEXT
                );
            ";
            comando.ExecuteNonQuery();

            // Substitui a conexão com o banco físico com uma conexão com o banco temporário
            Conexao.ObterConexaoParaTestes(_conexao);
        }

        /// <summary>
        /// Método responsável por testar as inserções feitas no banco
        /// </summary>
        [TestMethod]
        public void InserirDados_DeveInserirDadosNoBanco()
        {
            // Act
            Insercao.InserirDados("Daniel", "daniel.bezerra.mult@outlook.com", "19993054611");

            // Assert
            var comando = _conexao.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM clientes WHERE nome = @nome;"; // Query que conta as linhas na consulta
            comando.Parameters.AddWithValue("@nome", "Daniel");

            // Converte em um long a quantidade de linhas
            long count = (long)comando.ExecuteScalar();

            // Se for o mesmo valor do long, então passou no teste
            Assert.AreEqual(1, count);
        }

        /// <summary>
        /// Método responsável por fechar a conexão temporária, descartando a inserção de teste
        /// </summary>
        [TestCleanup]
        public void LimparTeste()
        {
            _conexao.Close(); // Fecha a conexão
        }
    }
}
