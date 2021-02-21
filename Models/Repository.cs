using MySqlConnector;

namespace Scisense.Models
{
    public abstract class Repository
    {
        protected const string _strConexao = "Database = Scisense; Data Source = localhost; User Id = root; Password = ";
        
        //protected const string _strConexao = "Server=MYSQL5043.site4now.net;Database=db_a6fb52_sci;Uid=a6fb52_sci;Pwd=Sc!Sense142536";
        protected MySqlConnection conexao = new MySqlConnection(_strConexao);
    }
}