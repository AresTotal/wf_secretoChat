namespace wf_secretoChatClient
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
            Logs = new ListBox();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // Logs
            // 
            Logs.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Logs.FormattingEnabled = true;
            Logs.ItemHeight = 18;
            Logs.Location = new Point(12, 43);
            Logs.Name = "Logs";
            Logs.Size = new Size(281, 328);
            Logs.TabIndex = 11;
            // 
            // button2
            // 
            button2.Font = new Font("Consolas", 12F);
            button2.Location = new Point(12, 415);
            button2.Name = "button2";
            button2.Size = new Size(281, 31);
            button2.TabIndex = 10;
            button2.Text = "Отправить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(12, 12);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "IP получателя";
            textBox2.Size = new Size(281, 25);
            textBox2.TabIndex = 9;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(12, 386);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите сообщение";
            textBox1.Size = new Size(281, 23);
            textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(305, 458);
            Controls.Add(textBox1);
            Controls.Add(Logs);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "SecretoChatClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Logs;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
