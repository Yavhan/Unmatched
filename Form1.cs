using System;
using System.IO;
using System.Windows.Forms;

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
                MessageBox.Show("Sikeres bejelentkezés!");
                // Ide írhatod a sikeres bejelentkezés utáni tevékenységeket
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!");
            }
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
                    if (parts.Length == 2)
                    {
                        string storedUsername = parts[0];
                        string storedPassword = parts[1];

                        if (username == storedUsername && password == storedPassword)
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
    }
}
