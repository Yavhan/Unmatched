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
            label1 = new Label();
            SuspendLayout();
            // 
            // textuser
            // 
            textuser.Cursor = Cursors.IBeam;
            textuser.Location = new Point(73, 42);
            textuser.Name = "textuser";
            textuser.Size = new Size(200, 39);
            textuser.TabIndex = 0;
            // 
            // textpass
            // 
            textpass.Cursor = Cursors.IBeam;
            textpass.Location = new Point(73, 96);
            textpass.Name = "textpass";
            textpass.Size = new Size(200, 39);
            textpass.TabIndex = 1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(73, 164);
            button1.Name = "button1";
            button1.Size = new Size(200, 46);
            button1.TabIndex = 2;
            button1.Text = "log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 75);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 3;
            label1.Text = "pass";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textpass);
            Controls.Add(textuser);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textuser;
        private TextBox textpass;
        private Button button1;
        private Label label1;
    }
}
