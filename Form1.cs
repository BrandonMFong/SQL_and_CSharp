using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.IO;

namespace Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class DBConnect
        {
            private MySqlConnection connection;
            private string server;
            private string database;
            private string uid;
            private string password;

            //Constructor
            public DBConnect()
            {
                Initialize();
            }

            //Initialize values
            private void Initialize()
            {
                server = "127.0.0.1";
                database = "compe_361_proj_4";
                uid = "root";
                password = "";
                string connectionString;
                connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

                connection = new MySqlConnection(connectionString);
            }

            //open connection to database
            private bool OpenConnection()
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;

                        case 1042:
                            MessageBox.Show("Unable to connect to any of the specified MySQL hosts.");
                            break;

                    }
                    return false;
                }
            }

            //Close connection
            private bool CloseConnection()
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }

            }

            //Insert statement
            public void Insert(int Acctnum, string lastname, string firstname, double currentbalance)
            {
                string query = "INSERT INTO whatever (Account_Number, LastName, FirstName, CurrentBalance) VALUES(" + Acctnum + ", '" + lastname + "', '" + firstname + "',  "+ currentbalance +")";


                //open connection
                if (this.OpenConnection() == true)
                {
                    //create command and assign the query and connection from the constructor
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //Execute command
                    cmd.ExecuteNonQuery();

                    //close connection
                    this.CloseConnection();
                }

            }

            //Update statement
            public void Update(int Account_Number, string First_Name, string Last_Name)
            {
                String query = "";
                if (string.IsNullOrEmpty(First_Name))
                {
                     query = "UPDATE whatever SET LastName= '"+ Last_Name +"' WHERE Account_Number = " + Account_Number;
                }
                else if(string.IsNullOrEmpty(Last_Name))
                {
                     query = "UPDATE whatever SET FirstName= '" + First_Name + "' WHERE Account_Number = " + Account_Number;
                }
                else
                {
                     query = "UPDATE whatever SET FirstName= '" + First_Name + "', LastName= '" + Last_Name + "' WHERE Account_Number = " + Account_Number;
                }
                //Open connection
                if (this.OpenConnection() == true)
                {
                    //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException woops)
                    {
                        MessageBox.Show(woops.Message);
                    }

                    //close connection
                    this.CloseConnection();
                }

            }

            //Delete statement
            public void Delete(int acctnum)
            {
                string query = "DELETE FROM whatever WHERE Account_Number = " + acctnum;

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                    this.CloseConnection();
                }

            }

            //Select statement for current balance
            public String Select_CurrentBalance(int Account_Number)
            {
                string query = "SELECT CurrentBalance FROM whatever where Account_Number = " + Account_Number;

                //Create a list to store the result
                String info = "Didn't get anything";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        info = Convert.ToString(dataReader["CurrentBalance"]);
                    }


                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return info;
                }
                else
                {
                    return info;
                }

            }
             //Select statement for account name
            public String Select_Account_Name(int Account_Number)
            {
                string query = "SELECT * FROM whatever where Account_Number = " + Account_Number;

                //Create a list to store the result
                String info = "User does not exist.";

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        info = Convert.ToString(dataReader["FirstName"]) + ' ' + Convert.ToString(dataReader["LastName"]);
                    }


                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return info;
                }
                else
                {
                    return info;
                }

            }

            //Count statement
            public int Count()
            {
                string query = "SELECT Count(*) FROM tableinfo";
                int Count = -1;

                //Open Connection
                if (this.OpenConnection() == true)
                {
                    //Create Mysql Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //ExecuteScalar will return one value
                    Count = int.Parse(cmd.ExecuteScalar() + "");

                    //close Connection
                    this.CloseConnection();

                    return Count;
                }
                else
                {
                    return Count;
                }

            }

            //Backup
            public void Backup()
            {
                try
                {
                    DateTime Time = DateTime.Now;
                    int year = Time.Year;
                    int month = Time.Month;
                    int day = Time.Day;
                    int hour = Time.Hour;
                    int minute = Time.Minute;
                    int second = Time.Second;
                    int millisecond = Time.Millisecond;

                    //Save file to C:\ with the current date as a filename
                    string path;
                    path = "C:\\MySqlBackup" + year + "-" + month + "-" + day +
                "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                    StreamWriter file = new StreamWriter(path);


                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = "mysqldump";
                    psi.RedirectStandardInput = false;
                    psi.RedirectStandardOutput = true;
                    psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                        uid, password, server, database);
                    psi.UseShellExecute = false;

                    Process process = Process.Start(psi);

                    string output;
                    output = process.StandardOutput.ReadToEnd();
                    file.WriteLine(output);
                    process.WaitForExit();
                    file.Close();
                    process.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error , unable to backup!");
                }

            }

            //Restore
            public void Restore()
            {
                try
                {
                    //Read file from C:\
                    string path;
                    path = "C:\\MySqlBackup.sql";
                    StreamReader file = new StreamReader(path);
                    string input = file.ReadToEnd();
                    file.Close();

                    ProcessStartInfo psi = new ProcessStartInfo();
                    psi.FileName = "mysql";
                    psi.RedirectStandardInput = true;
                    psi.RedirectStandardOutput = false;
                    psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                        uid, password, server, database);
                    psi.UseShellExecute = false;


                    Process process = Process.Start(psi);
                    process.StandardInput.WriteLine(input);
                    process.StandardInput.Close();
                    process.WaitForExit();
                    process.Close();
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error , unable to Restore!");
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect Connect = new DBConnect();

            try
            {
                Account_mem_name.Text = Convert.ToString(Connect.Select_Account_Name(Convert.ToInt32(Account_Number_SELECT.Text)));
                Mem_Balance.Text = "$" + Convert.ToString(Connect.Select_CurrentBalance(Convert.ToInt32(Account_Number_SELECT.Text)));
            }
            catch (FormatException)
            {
                MessageBox.Show("Nothing is in the text box homie");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            DBConnect Connect = new DBConnect();

            try
            {
                Connect.Update(Convert.ToInt32(Account_Number_UPDATE.Text), New_First_Name.Text, New_Last_Name.Text);
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DBConnect Connect = new DBConnect();

            try
            {
                Connect.Insert(Convert.ToInt32(newacccountnum.Text),  newmemlastname.Text, newmemfirstname.Text, Convert.ToDouble(newmembalance.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBConnect Connect = new DBConnect();

            try
            {
                Connect.Delete(Convert.ToInt32(Account_to_delete.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
