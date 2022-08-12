namespace Login
{
    partial class Form1
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
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_paswd = new System.Windows.Forms.Label();
            this.tbx_paswd = new System.Windows.Forms.TextBox();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(218, 90);
            this.tbx_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(231, 24);
            this.tbx_name.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(106, 94);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 17);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(151, 227);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(84, 33);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_paswd
            // 
            this.lbl_paswd.AutoSize = true;
            this.lbl_paswd.Location = new System.Drawing.Point(106, 151);
            this.lbl_paswd.Name = "lbl_paswd";
            this.lbl_paswd.Size = new System.Drawing.Size(68, 17);
            this.lbl_paswd.TabIndex = 3;
            this.lbl_paswd.Text = "Password";
            // 
            // tbx_paswd
            // 
            this.tbx_paswd.Location = new System.Drawing.Point(218, 144);
            this.tbx_paswd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_paswd.Name = "tbx_paswd";
            this.tbx_paswd.Size = new System.Drawing.Size(231, 24);
            this.tbx_paswd.TabIndex = 4;
            // 
            // btn_cancle
            // 
            this.btn_cancle.Location = new System.Drawing.Point(318, 227);
            this.btn_cancle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(84, 33);
            this.btn_cancle.TabIndex = 5;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = true;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 352);
            this.Controls.Add(this.btn_cancle);
            this.Controls.Add(this.tbx_paswd);
            this.Controls.Add(this.lbl_paswd);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.tbx_name);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_login;
        public System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label lbl_paswd;
        private System.Windows.Forms.TextBox tbx_paswd;
        private System.Windows.Forms.Button btn_cancle;
    }
}

