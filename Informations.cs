using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace boardgame
{
    public partial class Informations : Template
    {
        public Informations()
        {
            InitializeComponent();
        }
        private void Informations_Load(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
        private void Informations_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                richTextBox1.Visible = false;
            }
            if (e.Button == MouseButtons.Right)
            {
                Options.Show(this, e.Location);
            }
        }
        private void Options_Opening(object sender, CancelEventArgs e)
        {
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ide kell a visszajelentkezés a főoldalra
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCharacter = comboBox1.SelectedItem.ToString();
            string filePath = @"C:\temp\menukezeles probalkozas\kurvaanyad\Karakterek.csv";
            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split(';');
                        string characterName = parts[0];
                        string characterInfo = parts[1];
                        string characterAllies = parts[2];
                        if (characterName == selectedCharacter)
                        {
                            string displayText = "karakterinfo: " + characterInfo + "\nsegédek: " + characterAllies;
                            richTextBox1.Text = displayText;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("A karakter információk fájl nem található!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
        }
    }
}