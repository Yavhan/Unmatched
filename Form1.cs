using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace boardgame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textuser.Text;
            string password = textpass.Text;

            if (CheckCredentials(username, password))
            {

                this.Hide();
                Menuform form2 = new Menuform();

                if (IsAdmin(username))
                {
                    form2.ShowAdminButton();

                }
                form2.Show();

            }
            else
            {
                MessageBox.Show("WRONG username or/and password!");
            }
        }
        private static bool IsAdmin(string username)
        {
            string filePath = @"C:\tmp\passwords.csv";

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3) // Ha három rész van: felhasználónév, jelszó, szerepkör
                    {
                        string storedUsername = parts[0];
                        string role = parts[2];

                        if (username == storedUsername && role == "admin")
                        {
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a fájl olvasása közben: " + ex.Message);
            }

            return false;
        }
        

        private bool CheckCredentials(string username, string password)
        {
            string filePath = @"C:\tmp\passwords.csv";

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        string storedUsername = parts[0];
                        string storedPassword = parts[1];
                        string role = parts[2];

                        if (username == storedUsername && password == storedPassword)
                        {
                            if (role == "admin")
                            {
                                return true;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a fájl olvasása közben: " + ex.Message);
            }
            return false;
        }

        private void textpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
