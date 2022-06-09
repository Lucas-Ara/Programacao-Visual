using MySql.Data.MySqlClient;

namespace Uni_Locadora.Dao
{
    public class Conexao
    {
        const string server = "localhost";
        const string user = "root";
        const string pass = null;
        const string database = "unilocadora_4manha";
        //se a porta do seu MySQl não é a 3306, você precisa declará-la tambem.
        
        //const string port = "3308"; exemplo
        

        public static MySqlConnection GetConnection()
        {
            try
            {
                string connString = $"server={server};uid={user};pwd={pass};database={database}";
                MySqlConnection conn = new MySqlConnection(connString);
                return conn;
            }
            catch
            {
                return null;
            }
        }
    }
}