namespace booking
{
    partial class Giohang
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(1188, 66);
            button1.Name = "button1";
            button1.Size = new Size(116, 47);
            button1.TabIndex = 24;
            button1.Text = "Đặt bàn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Giohang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1448, 630);
            Controls.Add(button1);
            Name = "Giohang";
            Text = "Giohang";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
    }
}