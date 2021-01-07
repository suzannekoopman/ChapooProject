namespace ChapooUI
{
    partial class ForgotPasswordScreen
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
            this.wwvergeten_lbl = new System.Windows.Forms.Label();
            this.gebruikersnaam_lbl = new System.Windows.Forms.Label();
            this.tb_GebruiksN = new System.Windows.Forms.TextBox();
            this.vraag_lbl = new System.Windows.Forms.Label();
            this.antwoord_lbl = new System.Windows.Forms.Label();
            this.tb_Answer = new System.Windows.Forms.TextBox();
            this.maakWW_lbl = new System.Windows.Forms.Label();
            this.nieuwWW_lbl = new System.Windows.Forms.Label();
            this.tb_NewPassword = new System.Windows.Forms.TextBox();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_enter2 = new System.Windows.Forms.Button();
            this.btn_enter3 = new System.Windows.Forms.Button();
            this.lbl_antwoordVraag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wwvergeten_lbl
            // 
            this.wwvergeten_lbl.AutoSize = true;
            this.wwvergeten_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wwvergeten_lbl.Location = new System.Drawing.Point(291, 69);
            this.wwvergeten_lbl.Name = "wwvergeten_lbl";
            this.wwvergeten_lbl.Size = new System.Drawing.Size(206, 28);
            this.wwvergeten_lbl.TabIndex = 0;
            this.wwvergeten_lbl.Text = "Wachtwoord vergeten";
            this.wwvergeten_lbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // gebruikersnaam_lbl
            // 
            this.gebruikersnaam_lbl.AutoSize = true;
            this.gebruikersnaam_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gebruikersnaam_lbl.Location = new System.Drawing.Point(56, 127);
            this.gebruikersnaam_lbl.Name = "gebruikersnaam_lbl";
            this.gebruikersnaam_lbl.Size = new System.Drawing.Size(138, 23);
            this.gebruikersnaam_lbl.TabIndex = 1;
            this.gebruikersnaam_lbl.Text = "Gebruikersnaam:";
            // 
            // tb_GebruiksN
            // 
            this.tb_GebruiksN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GebruiksN.Location = new System.Drawing.Point(253, 124);
            this.tb_GebruiksN.Name = "tb_GebruiksN";
            this.tb_GebruiksN.Size = new System.Drawing.Size(308, 30);
            this.tb_GebruiksN.TabIndex = 2;
            // 
            // vraag_lbl
            // 
            this.vraag_lbl.AutoSize = true;
            this.vraag_lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vraag_lbl.Location = new System.Drawing.Point(111, 181);
            this.vraag_lbl.Name = "vraag_lbl";
            this.vraag_lbl.Size = new System.Drawing.Size(50, 20);
            this.vraag_lbl.TabIndex = 3;
            this.vraag_lbl.Text = "Vraag:";
            // 
            // antwoord_lbl
            // 
            this.antwoord_lbl.AutoSize = true;
            this.antwoord_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.antwoord_lbl.Location = new System.Drawing.Point(56, 228);
            this.antwoord_lbl.Name = "antwoord_lbl";
            this.antwoord_lbl.Size = new System.Drawing.Size(161, 23);
            this.antwoord_lbl.TabIndex = 4;
            this.antwoord_lbl.Text = "Antwoord op vraag:";
            // 
            // tb_Answer
            // 
            this.tb_Answer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Answer.Location = new System.Drawing.Point(253, 225);
            this.tb_Answer.Name = "tb_Answer";
            this.tb_Answer.Size = new System.Drawing.Size(308, 30);
            this.tb_Answer.TabIndex = 5;
            // 
            // maakWW_lbl
            // 
            this.maakWW_lbl.AutoSize = true;
            this.maakWW_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maakWW_lbl.Location = new System.Drawing.Point(248, 305);
            this.maakWW_lbl.Name = "maakWW_lbl";
            this.maakWW_lbl.Size = new System.Drawing.Size(301, 28);
            this.maakWW_lbl.TabIndex = 6;
            this.maakWW_lbl.Text = "Maak een nieuw wachtwoord aan";
            // 
            // nieuwWW_lbl
            // 
            this.nieuwWW_lbl.AutoSize = true;
            this.nieuwWW_lbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nieuwWW_lbl.Location = new System.Drawing.Point(57, 376);
            this.nieuwWW_lbl.Name = "nieuwWW_lbl";
            this.nieuwWW_lbl.Size = new System.Drawing.Size(169, 23);
            this.nieuwWW_lbl.TabIndex = 7;
            this.nieuwWW_lbl.Text = "Nieuwe wachtwoord:";
            // 
            // tb_NewPassword
            // 
            this.tb_NewPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NewPassword.Location = new System.Drawing.Point(253, 373);
            this.tb_NewPassword.Name = "tb_NewPassword";
            this.tb_NewPassword.Size = new System.Drawing.Size(308, 30);
            this.tb_NewPassword.TabIndex = 8;
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter.Location = new System.Drawing.Point(655, 124);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(118, 30);
            this.btn_enter.TabIndex = 9;
            this.btn_enter.Text = "Enter";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_enter2
            // 
            this.btn_enter2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter2.Location = new System.Drawing.Point(655, 225);
            this.btn_enter2.Name = "btn_enter2";
            this.btn_enter2.Size = new System.Drawing.Size(118, 30);
            this.btn_enter2.TabIndex = 10;
            this.btn_enter2.Text = "Enter";
            this.btn_enter2.UseVisualStyleBackColor = true;
            this.btn_enter2.Click += new System.EventHandler(this.btn_enter2_Click);
            // 
            // btn_enter3
            // 
            this.btn_enter3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enter3.Location = new System.Drawing.Point(655, 373);
            this.btn_enter3.Name = "btn_enter3";
            this.btn_enter3.Size = new System.Drawing.Size(118, 30);
            this.btn_enter3.TabIndex = 11;
            this.btn_enter3.Text = "Enter";
            this.btn_enter3.UseVisualStyleBackColor = true;
            this.btn_enter3.Click += new System.EventHandler(this.btn_enter3_Click);
            // 
            // lbl_antwoordVraag
            // 
            this.lbl_antwoordVraag.AutoSize = true;
            this.lbl_antwoordVraag.Location = new System.Drawing.Point(253, 183);
            this.lbl_antwoordVraag.Name = "lbl_antwoordVraag";
            this.lbl_antwoordVraag.Size = new System.Drawing.Size(0, 17);
            this.lbl_antwoordVraag.TabIndex = 12;
            // 
            // ForgotPasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 476);
            this.Controls.Add(this.lbl_antwoordVraag);
            this.Controls.Add(this.btn_enter3);
            this.Controls.Add(this.btn_enter2);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.tb_NewPassword);
            this.Controls.Add(this.nieuwWW_lbl);
            this.Controls.Add(this.maakWW_lbl);
            this.Controls.Add(this.tb_Answer);
            this.Controls.Add(this.antwoord_lbl);
            this.Controls.Add(this.vraag_lbl);
            this.Controls.Add(this.tb_GebruiksN);
            this.Controls.Add(this.gebruikersnaam_lbl);
            this.Controls.Add(this.wwvergeten_lbl);
            this.Name = "ForgotPasswordScreen";
            this.Text = "ForgotPasswordScreen";
            this.Load += new System.EventHandler(this.ForgotPasswordScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wwvergeten_lbl;
        private System.Windows.Forms.Label gebruikersnaam_lbl;
        private System.Windows.Forms.TextBox tb_GebruiksN;
        private System.Windows.Forms.Label vraag_lbl;
        private System.Windows.Forms.Label antwoord_lbl;
        private System.Windows.Forms.TextBox tb_Answer;
        private System.Windows.Forms.Label maakWW_lbl;
        private System.Windows.Forms.Label nieuwWW_lbl;
        private System.Windows.Forms.TextBox tb_NewPassword;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_enter2;
        private System.Windows.Forms.Button btn_enter3;
        private System.Windows.Forms.Label lbl_antwoordVraag;
    }
}