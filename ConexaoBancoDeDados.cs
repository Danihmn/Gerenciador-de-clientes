using System.Data.SQLite;

namespace AppBancoDeDados
{
    #region Sessao de conexao
    /// <summary>
    /// Classe responsável por estabelecer conexão com o banco
    /// </summary>
    internal class Conexao
    {
        // Conexão para testes
        private static SQLiteConnection _conexaoTeste;

        #region Obtem a conexao com o banco temporario
        /// <summary>
        /// Método responsável por atribuir à variável de conexão uma conexão temporária
        /// em memória, para os testes não interferirem no banco de dados físico do projeto
        /// </summary>
        /// <param name="conexao">Conexão temporária a ser passada</param>
        public static void ObterConexaoParaTestes(SQLiteConnection conexao)
        {
            _conexaoTeste = conexao; // A variável de conexão recebe a conexão temporária de memória para teste
        }
        #endregion

        #region Obtem a conexao com o banco fisico
        /// <summary>
        /// Método responsável por estabelecer conexão com o banco físico
        /// </summary>
        /// <returns>Retorna a conexão aberta</returns>
        public static SQLiteConnection ObterConexao()
        {
            // Verifica se a conexão de testes está sendo usada, ou seja, se estão havendo testes
            if (_conexaoTeste != null)
                return _conexaoTeste; // Retorna a conexão de testes

            // Caso não estiverem havendo testes, estabelece conexão normal com o banco de dados físico
            SQLiteConnection conexao = new SQLiteConnection(@"Data Source = C:\\Users\\danie\\Dev.NET\\Estudos\\AppBancoDeDados\\database.db");
            conexao.Open(); // Abre a conexão

            return conexao;
        }
        #endregion
    }
    #endregion
}
