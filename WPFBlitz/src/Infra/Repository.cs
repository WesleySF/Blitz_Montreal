using System.Data;
using System.Data.SqlClient;
using WPFBlitz.Properties;

namespace WPFBlitz.src.Infra
{
    public class Repository
    {
        public DataTable SiteAddress()
        {
            const string commandtext = "SELECT * FROM autobot.Site WHERE SiteId = @siteid";

            var connectionString = Settings.Default.Setting;

            using(var adapter = new SqlDataAdapter(commandtext, connectionString))
            {
                adapter.SelectCommand.Parameters.Add("@siteid", SqlDbType.Int).Value = 12;

                var table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }

        public DataTable Client()
        {
            const string command = "SELECT * FROM dbo.ClienteRoboUsuarios WHERE SiteId = @siteid";

            var connectionString = Settings.Default.Setting;

            using (var adapter = new SqlDataAdapter(command, connectionString))
            {
                adapter.SelectCommand.Parameters.Add("@siteid", SqlDbType.Int).Value = 12;

                var table = new DataTable();

                adapter.Fill(table);

                return table;
            }
        }
    }
}
