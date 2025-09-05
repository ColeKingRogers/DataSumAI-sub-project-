namespace DataSumAI_sub_project_
{
    partial class MainUI
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
            textBox2 = new TextBox();
            bntQuestion = new Button();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(426, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(226, 23);
            textBox2.TabIndex = 3;
            // 
            // bntQuestion
            // 
            bntQuestion.Location = new Point(345, 6);
            bntQuestion.Name = "bntQuestion";
            bntQuestion.Size = new Size(75, 23);
            bntQuestion.TabIndex = 4;
            bntQuestion.Text = "Question";
            bntQuestion.UseVisualStyleBackColor = true;
            bntQuestion.Click += button2_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(12, 41);
            webView21.Name = "webView21";
            webView21.Size = new Size(563, 601);
            webView21.TabIndex = 6;
            webView21.ZoomFactor = 1D;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 15);
            label1.TabIndex = 7;
            label1.Text = "Go to the Website that has the information for your question";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(581, 41);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(522, 601);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1115, 654);
            Controls.Add(richTextBox1);
            Controls.Add(label1);
            Controls.Add(webView21);
            Controls.Add(bntQuestion);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Button bntQuestion;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label1;
        private RichTextBox richTextBox1;
    }
}
