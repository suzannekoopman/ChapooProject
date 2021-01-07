namespace ChapooUI
{
    partial class BarForm
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
            this.bar_lbl = new System.Windows.Forms.Label();
            this.btnTerugNaarMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bar_lbl
            // 
            this.bar_lbl.AutoSize = true;
            this.bar_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_lbl.Location = new System.Drawing.Point(202, 271);
            this.bar_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bar_lbl.Name = "bar_lbl";
            this.bar_lbl.Size = new System.Drawing.Size(369, 37);
            this.bar_lbl.TabIndex = 0;
            this.bar_lbl.Text = "Welkom bij het baroverzicht.";
            // 
            // btnTerugNaarMenu
            // 
            this.btnTerugNaarMenu.BackColor = System.Drawing.Color.Red;
            this.btnTerugNaarMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerugNaarMenu.Location = new System.Drawing.Point(12, 498);
            this.btnTerugNaarMenu.Name = "btnTerugNaarMenu";
            this.btnTerugNaarMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTerugNaarMenu.Size = new System.Drawing.Size(138, 76);
            this.btnTerugNaarMenu.TabIndex = 21;
            this.btnTerugNaarMenu.Text = "Log uit";
            this.btnTerugNaarMenu.UseVisualStyleBackColor = false;
            this.btnTerugNaarMenu.Click += new System.EventHandler(this.BtnTerugNaarMenu_Click);
            // 
            // BarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 586);
            this.Controls.Add(this.btnTerugNaarMenu);
            this.Controls.Add(this.bar_lbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BarForm";
            this.Text = "BarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bar_lbl;
        private System.Windows.Forms.Button btnTerugNaarMenu;
    }
}