using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace boardgame
{
    public partial class Template : Form
    {
        public bool AdminStatus = false;
        private Panel topPanel;
        PictureBox back;
        public Template()
        {
            InitializeComponent();
            InitializeTopPanel();
        }
        private void InitializeTopPanel()
        {
            AdminStatus = true;

            topPanel = new Panel();
            topPanel.Dock = DockStyle.Top;
            topPanel.Height = 43;
            topPanel.BackColor = Color.FromArgb(207, 184, 255);

            Label label = new Label();
            label.Text = "Unmatched League";
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font("MV Boli", 12F, FontStyle.Bold | FontStyle.Underline);
            topPanel.Controls.Add(label);

            PictureBox closeButton = new PictureBox();
            closeButton.Image = Properties.Resources.CloseIcon;
            closeButton.Location = new Point(topPanel.Width - closeButton.Width - 96, topPanel.Height - closeButton.Height + 8);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(40, 40);
            closeButton.SizeMode = PictureBoxSizeMode.Zoom;
            closeButton.Cursor = Cursors.Hand;
            closeButton.TabStop = false;
            closeButton.Click += (sender, e) =>
            {
                var result = MessageBox.Show("Biztosan ki szeretne lépni az alkalmazásból?", "Kilépés megerősítése", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Close();
                    Application.Exit();
                }
                else if (result == DialogResult.Cancel)
                {

                }
            };
            topPanel.Controls.Add(closeButton);
            closeButton.BringToFront();

            PictureBox minimize = new PictureBox();
            minimize.Image = Properties.Resources.minimize;
            minimize.Location = new Point(topPanel.Width - minimize.Width - 50, topPanel.Height - minimize.Height + 8);
            minimize.Name = "minimize";
            minimize.Size = new Size(42, 42);
            minimize.SizeMode = PictureBoxSizeMode.Zoom;
            minimize.Cursor = Cursors.Hand;
            minimize.TabStop = false;
            minimize.Click += (sender, e) => WindowState = FormWindowState.Minimized;
            topPanel.Controls.Add(minimize);
            minimize.BringToFront();

            back = new PictureBox();
            back.Image = Properties.Resources.back;
            back.Location = new Point(topPanel.Width - minimize.Width - 55, topPanel.Height - minimize.Height );
            back.Name = "minimize";
            back.Size = new Size(42, 42);
            back.SizeMode = PictureBoxSizeMode.Zoom;
            back.Cursor = Cursors.Hand;
            back.TabStop = false;
            back.Visible = false;
            back.Click += back_Click;
            topPanel.Controls.Add(back);
            back.BringToFront();

            // Hozzáadjuk a panelt a Form-hoz
            this.Controls.Add(topPanel);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Unmatched is a board game from Restoration Games and Mondo Games where players control various iconic characters in combat against each other. Each character has their own deck with a unique fighting style.");
        }

        private void Template_Activated(object sender, EventArgs e)
        {
            if (this is Mycharacters || this is Informations || this is Start)
            {
                if (back != null) back.Visible = true;
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            Menuform form2 = new Menuform();
            if (AdminStatus)
            {
                form2.ShowAdminButton();
            }
            form2.Show();
        }
    }
}
