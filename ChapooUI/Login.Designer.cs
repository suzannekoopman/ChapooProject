namespace ChapooUI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gebruikersnaam_lbl = new System.Windows.Forms.Label();
            this.wachtwoord_lbl = new System.Windows.Forms.Label();
            this.txtbox_Gebruikersnaam = new System.Windows.Forms.TextBox();
            this.txtbox_Wachtwoord = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_wachtwoordVergeten = new System.Windows.Forms.Button();
            this.chapooLogo_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chapooLogo_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // gebruikersnaam_lbl
            // 
            this.gebruikersnaam_lbl.AutoSize = true;
            this.gebruikersnaam_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikersnaam_lbl.Location = new System.Drawing.Point(37, 217);
            this.gebruikersnaam_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gebruikersnaam_lbl.Name = "gebruikersnaam_lbl";
            this.gebruikersnaam_lbl.Size = new System.Drawing.Size(200, 32);
            this.gebruikersnaam_lbl.TabIndex = 0;
            this.gebruikersnaam_lbl.Text = "Gebruikersnaam:";
            // 
            // wachtwoord_lbl
            // 
            this.wachtwoord_lbl.AutoSize = true;
            this.wachtwoord_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wachtwoord_lbl.Location = new System.Drawing.Point(38, 358);
            this.wachtwoord_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wachtwoord_lbl.Name = "wachtwoord_lbl";
            this.wachtwoord_lbl.Size = new System.Drawing.Size(159, 32);
            this.wachtwoord_lbl.TabIndex = 1;
            this.wachtwoord_lbl.Text = "Wachtwoord:";
            // 
            // txtbox_Gebruikersnaam
            // 
            this.txtbox_Gebruikersnaam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Gebruikersnaam.Location = new System.Drawing.Point(44, 261);
            this.txtbox_Gebruikersnaam.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_Gebruikersnaam.Name = "txtbox_Gebruikersnaam";
            this.txtbox_Gebruikersnaam.Size = new System.Drawing.Size(261, 39);
            this.txtbox_Gebruikersnaam.TabIndex = 2;
            // 
            // txtbox_Wachtwoord
            // 
            this.txtbox_Wachtwoord.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Wachtwoord.Location = new System.Drawing.Point(42, 413);
            this.txtbox_Wachtwoord.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_Wachtwoord.Name = "txtbox_Wachtwoord";
            this.txtbox_Wachtwoord.Size = new System.Drawing.Size(261, 39);
            this.txtbox_Wachtwoord.TabIndex = 3;
            this.txtbox_Wachtwoord.TextChanged += new System.EventHandler(this.Txtbox_Wachtwoord_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.LawnGreen;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(189, 567);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(116, 58);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_wachtwoordVergeten
            // 
            this.btn_wachtwoordVergeten.BackColor = System.Drawing.Color.Gold;
            this.btn_wachtwoordVergeten.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_wachtwoordVergeten.Location = new System.Drawing.Point(44, 567);
            this.btn_wachtwoordVergeten.Margin = new System.Windows.Forms.Padding(2);
            this.btn_wachtwoordVergeten.Name = "btn_wachtwoordVergeten";
            this.btn_wachtwoordVergeten.Size = new System.Drawing.Size(117, 58);
            this.btn_wachtwoordVergeten.TabIndex = 5;
            this.btn_wachtwoordVergeten.Text = "Wachtwoord vergeten?";
            this.btn_wachtwoordVergeten.UseVisualStyleBackColor = false;
            this.btn_wachtwoordVergeten.Click += new System.EventHandler(this.btn_wachtwoordVergeten_Click);
            // 
            // chapooLogo_pic
            // 
            this.chapooLogo_pic.Image = ((System.Drawing.Image)(resources.GetObject("chapooLogo_pic.Image")));
            this.chapooLogo_pic.Location = new System.Drawing.Point(58, -1);
            this.chapooLogo_pic.Margin = new System.Windows.Forms.Padding(2);
            this.chapooLogo_pic.Name = "chapooLogo_pic";
            this.chapooLogo_pic.Size = new System.Drawing.Size(301, 186);
            this.chapooLogo_pic.TabIndex = 6;
            this.chapooLogo_pic.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 773);
            this.ControlBox = false;
            this.Controls.Add(this.chapooLogo_pic);
            this.Controls.Add(this.btn_wachtwoordVergeten);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txtbox_Wachtwoord);
            this.Controls.Add(this.txtbox_Gebruikersnaam);
            this.Controls.Add(this.wachtwoord_lbl);
            this.Controls.Add(this.gebruikersnaam_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.chapooLogo_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gebruikersnaam_lbl;
        private System.Windows.Forms.Label wachtwoord_lbl;
        private System.Windows.Forms.TextBox txtbox_Gebruikersnaam;
        private System.Windows.Forms.TextBox txtbox_Wachtwoord;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_wachtwoordVergeten;
        private System.Windows.Forms.PictureBox chapooLogo_pic;
    }
}