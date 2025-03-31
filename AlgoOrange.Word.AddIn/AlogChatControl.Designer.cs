using System.Drawing;

namespace AlgoOrange.Word.AddIn
{
    partial class AlogChatControl
    {
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox picturebox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private RoundedButton button4;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private RoundedButton button5;
        private RoundedButton button6;
        private RoundedButton button7;
        private RoundedButton button8;
        private RoundedButton button9;
        private RoundedButton button10;
        private System.Windows.Forms.Label label9;
        private RoundedButton button11;
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox2;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlogChatControl));
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button11 = new AlgoOrange.Word.AddIn.RoundedButton();
            this.button10 = new AlgoOrange.Word.AddIn.RoundedButton();
            this.button9 = new AlgoOrange.Word.AddIn.RoundedButton();
            this.button8 = new AlgoOrange.Word.AddIn.RoundedButton();
            this.button7 = new AlgoOrange.Word.AddIn.RoundedButton();
            this.button6 = new AlgoOrange.Word.AddIn.RoundedButton();
            this.button5 = new AlgoOrange.Word.AddIn.RoundedButton();
            this.button4 = new AlgoOrange.Word.AddIn.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox3
            // 
            this.richTextBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox3.Location = new System.Drawing.Point(3, 363);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(432, 217);
            this.richTextBox3.TabIndex = 1;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 593);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 61);
            this.textBox1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.ImageLocation = " C: \\Users\\Manoj\\OneDrive\\Desktop\\AlgoOrange.Word.AddIn\\AlgoOrange.Word.AddIn\\ico" +
    "n.png";
            this.pictureBox2.Location = new System.Drawing.Point(25, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(88, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 21);
            this.label8.TabIndex = 4;
            this.label8.Text = "AlgoOrange AI";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(21, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "AI Responce";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.SkyBlue;
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Location = new System.Drawing.Point(247, 313);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(154, 37);
            this.button11.TabIndex = 12;
            this.button11.Text = "Copy Responce";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.SkyBlue;
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Location = new System.Drawing.Point(247, 240);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(154, 37);
            this.button10.TabIndex = 10;
            this.button10.Text = "Quick Action";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.SkyBlue;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Location = new System.Drawing.Point(44, 240);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 37);
            this.button9.TabIndex = 9;
            this.button9.Text = "Export to PDF";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SkyBlue;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(247, 166);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 37);
            this.button8.TabIndex = 8;
            this.button8.Text = "Summarize Word";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SkyBlue;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Location = new System.Drawing.Point(44, 166);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 37);
            this.button7.TabIndex = 7;
            this.button7.Text = "Analyze Doc";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.SkyBlue;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(247, 94);
            this.button6.Margin = new System.Windows.Forms.Padding(5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 37);
            this.button6.TabIndex = 6;
            this.button6.Text = "Our Add-in";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SkyBlue;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(44, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 37);
            this.button5.TabIndex = 5;
            this.button5.Text = "What is AlgoOrange";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SkyBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(3, 667);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(432, 43);
            this.button4.TabIndex = 0;
            this.button4.Text = "Ask Algo AI";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // AlogChatControl
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.button4);
            this.Name = "AlogChatControl";
            this.Size = new System.Drawing.Size(438, 727);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
   
    }
}
