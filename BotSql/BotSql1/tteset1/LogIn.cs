namespace tteset1
{
    using System.Data.SqlClient;
    public partial class LogIn : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC\Documents\Infos.mdf;Integrated Security=True;Connect Timeout=30";
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            hp.Show();
            
            string name = textBox1.Text;
            string password = textBox2.Text;

            SqlConnection conn = new SqlConnection(connectionString);
            {
                string query = "INSERT INTO Users (UserName,Password) VALUES (@UserName,@Password)";
                SqlCommand cmd = new SqlCommand(query, conn);
                {
                    cmd.Parameters.AddWithValue("@UserName", name);
                    cmd.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Данните са записани успешно!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Грешка " + ex.Message);

                    }

                }
            }
        }
    }
}
