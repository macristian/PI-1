using System.Collections.Generic;
using MySqlConnector;

namespace Scisense.Models
{
    public class AdministradorRepository : Repository
    {
        public Administrador QueryLogin(Administrador adm)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string sql = "SELECT * FROM administrator WHERE UserName = @Login AND UserPass = @Password";
            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            comandoQuery.Parameters.AddWithValue("@Login", adm.Login);
            comandoQuery.Parameters.AddWithValue("@Password", adm.Password);
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            Administrador Adm = null;
            if (reader.Read())
            {
                Adm = new Administrador();
                Adm.IdAdm = reader.GetInt32("idAdm");
                if (!reader.IsDBNull(reader.GetOrdinal("UserFullName")))
                    Adm.Name = reader.GetString("UserFullName");
                if (!reader.IsDBNull(reader.GetOrdinal("UserName")))
                    Adm.Login = reader.GetString("UserName");
                if (!reader.IsDBNull(reader.GetOrdinal("UserPass")))
                    Adm.Password = reader.GetString("UserPass");
            }
            conexao.Close();
            return Adm;
        }
    }
}