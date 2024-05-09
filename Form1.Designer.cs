using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace boardgame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textuser = new TextBox();
            textpass = new TextBox();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textuser
            // 
            textuser.AccessibleName = "textuser";
            textuser.BackColor = Color.FromArgb(0, 60, 130);
            textuser.BorderStyle = BorderStyle.None;
            textuser.Cursor = Cursors.IBeam;
            textuser.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textuser.ForeColor = Color.FromArgb(100, 225, 255);
            textuser.ImeMode = ImeMode.NoControl;
            textuser.Location = new Point(368, 280);
            textuser.Margin = new Padding(0);
            textuser.MaxLength = 20;
            textuser.Name = "textuser";
            textuser.PlaceholderText = "textuser";
            textuser.Size = new Size(330, 62);
            textuser.TabIndex = 0;
            // 
            // textpass
            // 
            textpass.AccessibleName = "textpass";
            textpass.BackColor = Color.FromArgb(0, 60, 130);
            textpass.BorderStyle = BorderStyle.None;
            textpass.Cursor = Cursors.IBeam;
            textpass.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textpass.ForeColor = Color.FromArgb(100, 225, 255);
            textpass.Location = new Point(368, 387);
            textpass.Margin = new Padding(0);
            textpass.Name = "textpass";
            textpass.PasswordChar = '*';
            textpass.PlaceholderText = "password";
            textpass.RightToLeft = RightToLeft.No;
            textpass.Size = new Size(330, 62);
            textpass.TabIndex = 1;
            textpass.Tag = "";
            textpass.TextChanged += textpass_TextChanged;
            // 
            // button1
            // 
            button1.AccessibleName = "button1";
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(100, 225, 255);
            button1.Location = new Point(273, 717);
            button1.Name = "button1";
            button1.Size = new Size(425, 70);
            button1.TabIndex = 3;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.username;
            pictureBox2.Location = new Point(273, 260);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(82, 82);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.password;
            pictureBox3.Location = new Point(273, 367);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(82, 82);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // button2
            // 
            button2.AccessibleName = "button1";
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Stencil", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(273, 793);
            button2.Name = "button2";
            button2.Size = new Size(425, 70);
            button2.TabIndex = 12;
            button2.Text = "EXIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1024, 1024);
            Controls.Add(button2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(textpass);
            Controls.Add(textuser);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(1024, 1024);
            MinimizeBox = false;
            MinimumSize = new Size(1024, 1024);
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textuser;
        private TextBox textpass;
        private Button button1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button2;
    }
}
