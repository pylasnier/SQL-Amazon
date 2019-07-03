using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SQL_Amazon
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            var program = new AmazonProgram();
            program.Run();
        }
    }

    class AmazonProgram
    {
        public bool Running { get; private set; }

        private Nile _nile;
        private Login _login;
        private Dashboard _dashboard;

        private string _username;

        public AmazonProgram()
        {
            _nile = new Nile("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Amazon.accdb");
        }

        public void Run()
        {
            Running = true;

            StartLogin();
        }

        private void StartLogin()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _login = new Login(_nile);
            _login.Show();
            _login.Activate();
            _login.Success += Login_Success;
            _login.FormClosed += Close;
            Application.Run(_login);
        }

        private void Login_Success(object sender, LoginSuccessEventArgs e)
        {
            _login.FormClosed -= Close;
            _login.Hide();
            _username = e.Username;

            _dashboard = new Dashboard(_nile, _username);
            _dashboard.Show();
            _dashboard.Activate();
            _dashboard.FormClosed += Close;
        }

        private void Close(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    public class Nile
    {
        private OleDbConnection _connection;

        public Nile(string connectionString)
        {
            _connection = new OleDbConnection(connectionString);
        }

        public bool VerifyUser(string username, string password)
        {
            var command = new OleDbCommand("SELECT * FROM Users WHERE Username = @username AND PasswordHash = @passwordHash", _connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@passwordHash", Hash(password));

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            var reader = command.ExecuteReader();
            var result = reader.HasRows;
            _connection.Close();

            return result;
        }

        public bool RegisterUser(string username, string password)
        {
            bool result = true;

            var command = new OleDbCommand("INSERT INTO Users VALUES (@username, @passwordHash)", _connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@passwordHash", Hash(password));

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            try
            {
                var reader = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                result = false;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        private string Hash(string input)
        {
            var sha256 = new SHA256Managed();
            sha256.ComputeHash(Encoding.ASCII.GetBytes(input));
            return Encoding.ASCII.GetString(sha256.Hash);
        }
    }
}
