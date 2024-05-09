namespace boardgame
{
    partial class Mycharacters
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
            listBox1 = new ListBox();
            button2 = new Button();
            label1 = new Label();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 12, 59);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(887, 137);
            button1.Name = "button1";
            button1.Size = new Size(229, 90);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(60, 20, 70);
            listBox1.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.ForeColor = Color.White;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 53;
            listBox1.Location = new Point(257, 137);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(597, 799);
            listBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(50, 12, 59);
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(887, 233);
            button2.Name = "button2";
            button2.Size = new Size(352, 105);
            button2.TabIndex = 7;
            button2.Text = "REMOVE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 12, 59);
            label1.BackgroundImageLayout = ImageLayout.None;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(257, 67);
            label1.Name = "label1";
            label1.Size = new Size(458, 67);
            label1.TabIndex = 8;
            label1.Text = "My Characters";
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.FromArgb(60, 20, 70);
            listBox2.Font = new Font("Showcard Gothic", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.ForeColor = Color.White;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 53;
            listBox2.Location = new Point(1289, 137);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(583, 799);
            listBox2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(50, 12, 59);
            label2.BackgroundImageLayout = ImageLayout.None;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Showcard Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(1289, 67);
            label2.Name = "label2";
            label2.Size = new Size(468, 67);
            label2.TabIndex = 10;
            label2.Text = "All Characters";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(50, 12, 59);
            label3.BackgroundImageLayout = ImageLayout.None;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(887, 52);
            label3.Name = "label3";
            label3.Size = new Size(167, 40);
            label3.TabIndex = 15;
            label3.Text = "SELECTED";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(860, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(423, 39);
            textBox1.TabIndex = 16;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(50, 12, 59);
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Showcard Gothic", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(887, 344);
            button3.Name = "button3";
            button3.Size = new Size(352, 105);
            button3.TabIndex = 17;
            button3.Text = "DETAILS";
            button3.UseVisualStyleBackColor = false;
            // 
            // Mycharacters
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.vector;
            ClientSize = new Size(1920, 1080);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Mycharacters";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mycharacters";
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(listBox1, 0);
            Controls.SetChildIndex(button2, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(listBox2, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(button3, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Label label1;
        private ListBox listBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Button button3;
    }
}