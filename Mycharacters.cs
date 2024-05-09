using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boardgame
{
    public partial class Mycharacters : Template
    {
        public Mycharacters()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void ShowAdminButtons()
        {
            Button edit = new Button();
            edit.BackColor = Color.FromArgb(50, 12, 59);
            edit.BackgroundImageLayout = ImageLayout.None;
            edit.Cursor = Cursors.Hand;
            edit.FlatStyle = FlatStyle.Popup;
            edit.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edit.ForeColor = Color.White;
            edit.Location = new Point(887, 455);
            edit.Name = "edit";
            edit.Size = new Size(202, 105);
            edit.TabIndex = 8;
            edit.Text = "EDIT";
            edit.UseVisualStyleBackColor = false;
            edit.Click += edit_Click;
            this.Controls.Add(edit);

            Button delete = new Button();
            delete.BackColor = Color.FromArgb(50, 12, 59);
            delete.BackgroundImageLayout = ImageLayout.None;
            delete.Cursor = Cursors.Hand;
            delete.FlatStyle = FlatStyle.Popup;
            delete.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete.ForeColor = Color.White;
            delete.Location = new Point(887, 566);
            delete.Name = "delete";
            delete.Size = new Size(288, 105);
            delete.TabIndex = 12;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            this.Controls.Add(delete);

            Button add = new Button();
            add.BackColor = Color.FromArgb(50, 12, 59);
            add.BackgroundImageLayout = ImageLayout.None;
            add.Cursor = Cursors.Hand;
            add.FlatStyle = FlatStyle.Popup;
            add.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            add.ForeColor = Color.White;
            add.Location = new Point(887, 677);
            add.Name = "add";
            add.Size = new Size(352, 90);
            add.TabIndex = 13;
            add.Text = "Add New";
            add.UseVisualStyleBackColor = false;
            add.Click += add_Click;
            this.Controls.Add(add);

            Button save = new Button();
            save.BackColor = Color.FromArgb(50, 12, 59);
            save.BackgroundImageLayout = ImageLayout.None;
            save.Cursor = Cursors.Hand;
            save.FlatStyle = FlatStyle.Popup;
            save.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save.ForeColor = Color.White;
            save.Location = new Point(887, 788);
            save.Name = "save";
            save.Size = new Size(205, 90);
            save.TabIndex = 14;
            save.Text = "Save";
            save.UseVisualStyleBackColor = false;
            save.Click += save_Click;
            this.Controls.Add(save);
        }
        private void edit_Click(object sender, EventArgs e)
        {

        }
        private void delete_Click(object sender, EventArgs e)
        {

        }
        private void add_Click(object sender, EventArgs e)
        {

        }
        private void save_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
