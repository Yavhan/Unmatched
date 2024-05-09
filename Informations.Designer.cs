namespace boardgame
{
    partial class Informations
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
            components = new System.ComponentModel.Container();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            Options = new ContextMenuStrip(components);
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            Options.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 38);
            toolStripMenuItem1.Text = "Log out ";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(177, 38);
            toolStripMenuItem2.Text = "Back";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // Options
            // 
            Options.ImageScalingSize = new Size(20, 20);
            Options.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            Options.Name = "Options";
            Options.Size = new Size(178, 80);
            Options.Opening += Options_Opening;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Turquoise;
            label2.Font = new Font("Showcard Gothic", 22.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(970, 220);
            label2.Name = "label2";
            label2.Size = new Size(656, 74);
            label2.TabIndex = 3;
            label2.Text = "Choose a character";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(7, 97, 77);
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe Print", 16.125F, FontStyle.Italic, GraphicsUnit.Point, 238);
            label3.ForeColor = Color.FromArgb(253, 247, 219);
            label3.Location = new Point(19, 385);
            label3.Name = "label3";
            label3.Size = new Size(463, 375);
            label3.TabIndex = 4;
            label3.Text = "Ezen a felületen az \r\nadott karaktert \r\nkiválasztva hasznos \r\nés új információkat \r\ntudhatsz meg róluk.";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaptionText;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.Window;
            richTextBox1.Location = new Point(970, 534);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(438, 93);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(0, 64, 64);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.ForeColor = Color.LawnGreen;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Láthatatlan ember", "Medúza", "Arthúr király", "Jekyl és Hide", "Szimbád", "Alice", "Sherlock Holmes", "Drakula" });
            comboBox1.Location = new Point(970, 297);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(746, 68);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Informations
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.medusa;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1920, 1080);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Informations";
            Text = "Informations";
            Load += Informations_Load;
            MouseClick += Informations_MouseClick;
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(richTextBox1, 0);
            Controls.SetChildIndex(comboBox1, 0);
            Options.ResumeLayout(false);
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip Options;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}