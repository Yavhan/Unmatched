namespace boardgame
{
    partial class Menuform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button3 = new Button();
            charinfo = new Button();
            mycharbutton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 12, 59);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1143, 528);
            button1.Name = "button1";
            button1.Size = new Size(547, 127);
            button1.TabIndex = 2;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(50, 12, 59);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1334, 927);
            button3.Name = "button3";
            button3.Size = new Size(356, 127);
            button3.TabIndex = 4;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // charinfo
            // 
            charinfo.BackColor = Color.FromArgb(50, 12, 59);
            charinfo.BackgroundImageLayout = ImageLayout.None;
            charinfo.Cursor = Cursors.Hand;
            charinfo.FlatStyle = FlatStyle.Popup;
            charinfo.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            charinfo.ForeColor = Color.White;
            charinfo.Location = new Point(785, 661);
            charinfo.Name = "charinfo";
            charinfo.Size = new Size(905, 127);
            charinfo.TabIndex = 6;
            charinfo.Text = "Characters info";
            charinfo.UseVisualStyleBackColor = false;
            charinfo.Click += charinfo_Click;
            // 
            // mycharbutton
            // 
            mycharbutton.BackColor = Color.FromArgb(50, 12, 59);
            mycharbutton.BackgroundImageLayout = ImageLayout.None;
            mycharbutton.Cursor = Cursors.Hand;
            mycharbutton.FlatStyle = FlatStyle.Popup;
            mycharbutton.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mycharbutton.ForeColor = Color.White;
            mycharbutton.Location = new Point(836, 794);
            mycharbutton.Name = "mycharbutton";
            mycharbutton.Size = new Size(854, 127);
            mycharbutton.TabIndex = 7;
            mycharbutton.Text = "Mycharacters";
            mycharbutton.UseVisualStyleBackColor = false;
            mycharbutton.Click += mycharbutton_Click;
            // 
            // Menuform
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkRed;
            BackgroundImage = Properties.Resources.form2background;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1770, 1326);
            Controls.Add(mycharbutton);
            Controls.Add(charinfo);
            Controls.Add(button3);
            Controls.Add(button1);
            StartPosition = FormStartPosition.CenterScreen;
            Name = "Menuform";
            Text = "Form2";
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(button3, 0);
            Controls.SetChildIndex(charinfo, 0);
            Controls.SetChildIndex(mycharbutton, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button3;
        private Button charinfo;
        private Button mycharbutton;
    }
}