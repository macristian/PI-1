using MySqlConnector;

namespace Scisense.Models
{
    public abstract class Repository
    {
        //protected const string _strConexao = "Database = Scisense; Data Source = localhost; User Id = root; Password = ";
        protected const string _strConexao = "Database = Scisense; Data Source = localhost; User Id = root; Password = ";
        protected MySqlConnection conexao = new MySqlConnection(_strConexao);
    }
}