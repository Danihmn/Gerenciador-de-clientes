using System.Data.SQLite;

namespace AppBancoDeDados
{
    #region Sessao de conexao
    /// <summary>
    /// Classe responsável por estabelecer conexão com o banco
    /// </summary>
    internal class Conexao
    {
        #region Obtem a conexao com o banco
        /// <summary>
        /// Método responsável por estabelecer conexão com o banco
        /// </summary>
        /// <returns>Retorna a conexão aberta</returns>
        public static SQLiteConnection ObterConexao()
        {
            SQLiteConnection conexao = new SQLiteConnection(@"Data Source = C:\\Users\\danie\\Dev.NET\\Estudos\\AppBancoDeDados\\database.db");
            conexao.Open(); // Abre a conexão

            return conexao;
        }
        #endregion
    }
    #endregion
}
