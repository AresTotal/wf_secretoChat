namespace wf_secretoChat
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
            textBox2 = new TextBox();
            button2 = new Button();
            Logs = new ListBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(12, 12);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Ваш IP";
            textBox2.Size = new Size(281, 25);
            textBox2.TabIndex = 1;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Font = new Font("Consolas", 12F);
            button2.Location = new Point(12, 415);
            button2.Name = "button2";
            button2.Size = new Size(281, 31);
            button2.TabIndex = 7;
            button2.Text = "Синхронизация";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Logs
            // 
            Logs.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Logs.FormattingEnabled = true;
            Logs.ItemHeight = 18;
            Logs.Location = new Point(12, 43);
            Logs.Name = "Logs";
            Logs.Size = new Size(281, 364);
            Logs.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(305, 458);
            Controls.Add(Logs);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Name = "Form1";
            Text = "SecretoChatServer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Button button2;
        private ListBox Logs;
    }
}
