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
                MessageBox.Show("Sikeres bejelentkez�s!");
                // Ide �rhatod a sikeres bejelentkez�s ut�ni tev�kenys�geket
            }
            else
            {
                MessageBox.Show("Hib�s felhaszn�l�n�v vagy jelsz�!");
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
                MessageBox.Show("Hiba t�rt�nt a f�jl olvas�sa k�zben: " + ex.Message);
            }

            return false;
        }
    }
}
