namespace Test_liên_kết_SQL_server
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
            btnMoKetNoi = new Button();
            btnDongKetNoi = new Button();
            SuspendLayout();
            // 
            // btnMoKetNoi
            // 
            btnMoKetNoi.Location = new Point(100, 96);
            btnMoKetNoi.Name = "btnMoKetNoi";
            btnMoKetNoi.Size = new Size(134, 57);
            btnMoKetNoi.TabIndex = 0;
            btnMoKetNoi.Text = "Mở Kết Nối";
            btnMoKetNoi.UseVisualStyleBackColor = true;
            btnMoKetNoi.Click += btnMoKetNoi_Click;
            // 
            // btnDongKetNoi
            // 
            btnDongKetNoi.Location = new Point(309, 96);
            btnDongKetNoi.Name = "btnDongKetNoi";
            btnDongKetNoi.Size = new Size(137, 57);
            btnDongKetNoi.TabIndex = 1;
            btnDongKetNoi.Text = "Đóng Kết Nối";
            btnDongKetNoi.UseVisualStyleBackColor = true;
            btnDongKetNoi.Click += btnDongKetNoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 260);
            Controls.Add(btnDongKetNoi);
            Controls.Add(btnMoKetNoi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMoKetNoi;
        private Button btnDongKetNoi;
    }
}