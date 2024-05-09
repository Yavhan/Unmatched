using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace boardgame
{
    public partial class Menuform : Template
    {
        public Menuform()
        {
            InitializeComponent();
        }

        public void ShowAdminButton()
        {
            Button adminButton = new Button();
            adminButton.BackColor = Color.FromArgb(50, 12, 59);
            adminButton.BackgroundImageLayout = ImageLayout.None;
            adminButton.Cursor = Cursors.Hand;
            adminButton.FlatStyle = FlatStyle.Popup;
            adminButton.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminButton.ForeColor = Color.White;
            adminButton.Location = new Point(785, 1060);
            adminButton.Name = "ADMINpanel";
            adminButton.Size = new Size(905, 127);
            adminButton.TabIndex = 8;
            adminButton.Text = "adminButton";
            adminButton.UseVisualStyleBackColor = false;
            adminButton.Click += adminButton_Click;
            this.Controls.Add(adminButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }


        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mycharacters mycharacters = new Mycharacters();
            mycharacters.ShowAdminButtons();
            mycharacters.Show();
        }

        private void charinfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Informations informations = new Informations();
            informations.Show();
        }   

        private void mycharbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mycharacters mycharacters = new Mycharacters();
            mycharacters.Show();
        }
    }
}
