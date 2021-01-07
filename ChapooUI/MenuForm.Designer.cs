namespace ChapooUI
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.btnLunch = new System.Windows.Forms.Button();
            this.btnDiner = new System.Windows.Forms.Button();
            this.btnDrank = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pnlLunch = new System.Windows.Forms.Panel();
            this.pnlMenuListView = new System.Windows.Forms.Panel();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listviewMenuItems = new System.Windows.Forms.ListView();
            this.Gerecht = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTerugNaarMenu = new System.Windows.Forms.Button();
            this.lblMenuText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLunchNagerecht = new System.Windows.Forms.Button();
            this.btnLunchHoofdgerecht = new System.Windows.Forms.Button();
            this.lblLunchMenu = new System.Windows.Forms.Label();
            this.btnLunchVoorgerecht = new System.Windows.Forms.Button();
            this.btnTerugNaarTafel = new System.Windows.Forms.Button();
            this.btnMenuBekijkBestelling = new System.Windows.Forms.Button();
            this.pnlDiner = new System.Windows.Forms.Panel();
            this.btnDinerTerug = new System.Windows.Forms.Button();
            this.btnDinerHoofd = new System.Windows.Forms.Button();
            this.btnDinerTussen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDinerVoor = new System.Windows.Forms.Button();
            this.btnDinerNa = new System.Windows.Forms.Button();
            this.pnlDranken = new System.Windows.Forms.Panel();
            this.btnGedistilleerd = new System.Windows.Forms.Button();
            this.btnDrankTerug = new System.Windows.Forms.Button();
            this.btnWijnen = new System.Windows.Forms.Button();
            this.btnBieren = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFrisdrank = new System.Windows.Forms.Button();
            this.btnKoffieThee = new System.Windows.Forms.Button();
            this.btnMenuListBekijkOrder = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lblAantal = new System.Windows.Forms.Label();
            this.pnlLunch.SuspendLayout();
            this.pnlMenuListView.SuspendLayout();
            this.pnlDiner.SuspendLayout();
            this.pnlDranken.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLunch
            // 
            this.btnLunch.BackColor = System.Drawing.Color.LightCyan;
            this.btnLunch.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunch.Location = new System.Drawing.Point(12, 95);
            this.btnLunch.Name = "btnLunch";
            this.btnLunch.Size = new System.Drawing.Size(335, 113);
            this.btnLunch.TabIndex = 0;
            this.btnLunch.Text = "Lunch";
            this.btnLunch.UseVisualStyleBackColor = false;
            this.btnLunch.Click += new System.EventHandler(this.BtnLunch_Click);
            // 
            // btnDiner
            // 
            this.btnDiner.BackColor = System.Drawing.Color.LightCyan;
            this.btnDiner.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiner.Location = new System.Drawing.Point(12, 225);
            this.btnDiner.Name = "btnDiner";
            this.btnDiner.Size = new System.Drawing.Size(335, 113);
            this.btnDiner.TabIndex = 1;
            this.btnDiner.Text = "Diner";
            this.btnDiner.UseVisualStyleBackColor = false;
            this.btnDiner.Click += new System.EventHandler(this.BtnDiner_Click);
            // 
            // btnDrank
            // 
            this.btnDrank.BackColor = System.Drawing.Color.LightCyan;
            this.btnDrank.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrank.Location = new System.Drawing.Point(12, 356);
            this.btnDrank.Name = "btnDrank";
            this.btnDrank.Size = new System.Drawing.Size(335, 113);
            this.btnDrank.TabIndex = 2;
            this.btnDrank.Text = "Dranken";
            this.btnDrank.UseVisualStyleBackColor = false;
            this.btnDrank.Click += new System.EventHandler(this.BtnDrank_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(12, 26);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(124, 50);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "Menu:";
            // 
            // pnlLunch
            // 
            this.pnlLunch.Controls.Add(this.button1);
            this.pnlLunch.Controls.Add(this.btnLunchNagerecht);
            this.pnlLunch.Controls.Add(this.btnLunchHoofdgerecht);
            this.pnlLunch.Controls.Add(this.lblLunchMenu);
            this.pnlLunch.Controls.Add(this.btnLunchVoorgerecht);
            this.pnlLunch.Location = new System.Drawing.Point(1, 1);
            this.pnlLunch.Name = "pnlLunch";
            this.pnlLunch.Size = new System.Drawing.Size(355, 780);
            this.pnlLunch.TabIndex = 4;
            this.pnlLunch.Visible = false;
            // 
            // pnlMenuListView
            // 
            this.pnlMenuListView.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenuListView.Controls.Add(this.lblAantal);
            this.pnlMenuListView.Controls.Add(this.btnMin);
            this.pnlMenuListView.Controls.Add(this.btnPlus);
            this.pnlMenuListView.Controls.Add(this.btnMenuListBekijkOrder);
            this.pnlMenuListView.Controls.Add(this.btnVoegToe);
            this.pnlMenuListView.Controls.Add(this.label3);
            this.pnlMenuListView.Controls.Add(this.listviewMenuItems);
            this.pnlMenuListView.Controls.Add(this.btnTerugNaarMenu);
            this.pnlMenuListView.Controls.Add(this.lblMenuText);
            this.pnlMenuListView.Location = new System.Drawing.Point(1, 1);
            this.pnlMenuListView.Name = "pnlMenuListView";
            this.pnlMenuListView.Size = new System.Drawing.Size(355, 780);
            this.pnlMenuListView.TabIndex = 8;
            this.pnlMenuListView.Visible = false;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.BackColor = System.Drawing.Color.LawnGreen;
            this.btnVoegToe.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoegToe.Location = new System.Drawing.Point(182, 529);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(164, 39);
            this.btnVoegToe.TabIndex = 15;
            this.btnVoegToe.Text = "Voeg toe aan bestelling";
            this.btnVoegToe.UseVisualStyleBackColor = false;
            this.btnVoegToe.Click += new System.EventHandler(this.BtnVoegToeLunchVoor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 506);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aantal:";
            // 
            // listviewMenuItems
            // 
            this.listviewMenuItems.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listviewMenuItems.AutoArrange = false;
            this.listviewMenuItems.BackColor = System.Drawing.Color.LightCyan;
            this.listviewMenuItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Gerecht,
            this.columnHeader1,
            this.columnHeader2});
            this.listviewMenuItems.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewMenuItems.GridLines = true;
            this.listviewMenuItems.HideSelection = false;
            this.listviewMenuItems.Location = new System.Drawing.Point(11, 119);
            this.listviewMenuItems.Name = "listviewMenuItems";
            this.listviewMenuItems.Size = new System.Drawing.Size(335, 375);
            this.listviewMenuItems.TabIndex = 8;
            this.listviewMenuItems.UseCompatibleStateImageBehavior = false;
            this.listviewMenuItems.View = System.Windows.Forms.View.Details;
            // 
            // Gerecht
            // 
            this.Gerecht.Text = "ID";
            this.Gerecht.Width = 34;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gerecht";
            this.columnHeader1.Width = 199;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Voorraad";
            this.columnHeader2.Width = 97;
            // 
            // btnTerugNaarMenu
            // 
            this.btnTerugNaarMenu.BackColor = System.Drawing.Color.Gold;
            this.btnTerugNaarMenu.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerugNaarMenu.Location = new System.Drawing.Point(11, 685);
            this.btnTerugNaarMenu.Name = "btnTerugNaarMenu";
            this.btnTerugNaarMenu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTerugNaarMenu.Size = new System.Drawing.Size(138, 76);
            this.btnTerugNaarMenu.TabIndex = 7;
            this.btnTerugNaarMenu.Text = "Terug naar menu";
            this.btnTerugNaarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerugNaarMenu.UseVisualStyleBackColor = false;
            this.btnTerugNaarMenu.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lblMenuText
            // 
            this.lblMenuText.AutoSize = true;
            this.lblMenuText.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuText.Location = new System.Drawing.Point(11, 26);
            this.lblMenuText.Name = "lblMenuText";
            this.lblMenuText.Size = new System.Drawing.Size(38, 50);
            this.lblMenuText.TabIndex = 4;
            this.lblMenuText.Text = "..";
            this.lblMenuText.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 685);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(138, 76);
            this.button1.TabIndex = 7;
            this.button1.Text = "Terug naar menu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnLunchNagerecht
            // 
            this.btnLunchNagerecht.BackColor = System.Drawing.Color.LightCyan;
            this.btnLunchNagerecht.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchNagerecht.Location = new System.Drawing.Point(11, 356);
            this.btnLunchNagerecht.Name = "btnLunchNagerecht";
            this.btnLunchNagerecht.Size = new System.Drawing.Size(335, 113);
            this.btnLunchNagerecht.TabIndex = 6;
            this.btnLunchNagerecht.Text = "Nagerechten";
            this.btnLunchNagerecht.UseVisualStyleBackColor = false;
            this.btnLunchNagerecht.Click += new System.EventHandler(this.BtnLunchNagerecht_Click);
            // 
            // btnLunchHoofdgerecht
            // 
            this.btnLunchHoofdgerecht.BackColor = System.Drawing.Color.LightCyan;
            this.btnLunchHoofdgerecht.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchHoofdgerecht.Location = new System.Drawing.Point(11, 225);
            this.btnLunchHoofdgerecht.Name = "btnLunchHoofdgerecht";
            this.btnLunchHoofdgerecht.Size = new System.Drawing.Size(335, 113);
            this.btnLunchHoofdgerecht.TabIndex = 5;
            this.btnLunchHoofdgerecht.Text = "Hoofdgerechten";
            this.btnLunchHoofdgerecht.UseVisualStyleBackColor = false;
            this.btnLunchHoofdgerecht.Click += new System.EventHandler(this.BtnLunchHoofdgerecht_Click);
            // 
            // lblLunchMenu
            // 
            this.lblLunchMenu.AutoSize = true;
            this.lblLunchMenu.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLunchMenu.Location = new System.Drawing.Point(11, 26);
            this.lblLunchMenu.Name = "lblLunchMenu";
            this.lblLunchMenu.Size = new System.Drawing.Size(231, 50);
            this.lblLunchMenu.TabIndex = 4;
            this.lblLunchMenu.Text = "Lunch Menu:";
            // 
            // btnLunchVoorgerecht
            // 
            this.btnLunchVoorgerecht.BackColor = System.Drawing.Color.LightCyan;
            this.btnLunchVoorgerecht.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLunchVoorgerecht.Location = new System.Drawing.Point(11, 95);
            this.btnLunchVoorgerecht.Name = "btnLunchVoorgerecht";
            this.btnLunchVoorgerecht.Size = new System.Drawing.Size(335, 113);
            this.btnLunchVoorgerecht.TabIndex = 1;
            this.btnLunchVoorgerecht.Text = "Voorgerechten";
            this.btnLunchVoorgerecht.UseVisualStyleBackColor = false;
            this.btnLunchVoorgerecht.Click += new System.EventHandler(this.BtnLunchVoorgerecht_Click);
            // 
            // btnTerugNaarTafel
            // 
            this.btnTerugNaarTafel.BackColor = System.Drawing.Color.Gold;
            this.btnTerugNaarTafel.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerugNaarTafel.Location = new System.Drawing.Point(12, 685);
            this.btnTerugNaarTafel.Name = "btnTerugNaarTafel";
            this.btnTerugNaarTafel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTerugNaarTafel.Size = new System.Drawing.Size(138, 76);
            this.btnTerugNaarTafel.TabIndex = 8;
            this.btnTerugNaarTafel.Text = "Terug naar tafel";
            this.btnTerugNaarTafel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTerugNaarTafel.UseVisualStyleBackColor = false;
            this.btnTerugNaarTafel.Click += new System.EventHandler(this.BtnTerugNaarTafel_Click);
            // 
            // btnMenuBekijkBestelling
            // 
            this.btnMenuBekijkBestelling.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMenuBekijkBestelling.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBekijkBestelling.Location = new System.Drawing.Point(209, 685);
            this.btnMenuBekijkBestelling.Name = "btnMenuBekijkBestelling";
            this.btnMenuBekijkBestelling.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnMenuBekijkBestelling.Size = new System.Drawing.Size(138, 76);
            this.btnMenuBekijkBestelling.TabIndex = 9;
            this.btnMenuBekijkBestelling.Text = "Bekijk bestelling";
            this.btnMenuBekijkBestelling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBekijkBestelling.UseVisualStyleBackColor = false;
            this.btnMenuBekijkBestelling.Click += new System.EventHandler(this.BtnMenuBekijkBestelling_Click);
            // 
            // pnlDiner
            // 
            this.pnlDiner.Controls.Add(this.btnDinerNa);
            this.pnlDiner.Controls.Add(this.btnDinerTerug);
            this.pnlDiner.Controls.Add(this.btnDinerHoofd);
            this.pnlDiner.Controls.Add(this.btnDinerTussen);
            this.pnlDiner.Controls.Add(this.label6);
            this.pnlDiner.Controls.Add(this.btnDinerVoor);
            this.pnlDiner.Location = new System.Drawing.Point(1, 1);
            this.pnlDiner.Name = "pnlDiner";
            this.pnlDiner.Size = new System.Drawing.Size(355, 780);
            this.pnlDiner.TabIndex = 9;
            this.pnlDiner.Visible = false;
            // 
            // btnDinerTerug
            // 
            this.btnDinerTerug.BackColor = System.Drawing.Color.Gold;
            this.btnDinerTerug.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinerTerug.Location = new System.Drawing.Point(11, 685);
            this.btnDinerTerug.Name = "btnDinerTerug";
            this.btnDinerTerug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDinerTerug.Size = new System.Drawing.Size(138, 76);
            this.btnDinerTerug.TabIndex = 7;
            this.btnDinerTerug.Text = "Terug naar menu";
            this.btnDinerTerug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDinerTerug.UseVisualStyleBackColor = false;
            this.btnDinerTerug.Click += new System.EventHandler(this.BtnDinerTerug_Click);
            // 
            // btnDinerHoofd
            // 
            this.btnDinerHoofd.BackColor = System.Drawing.Color.LightCyan;
            this.btnDinerHoofd.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinerHoofd.Location = new System.Drawing.Point(11, 356);
            this.btnDinerHoofd.Name = "btnDinerHoofd";
            this.btnDinerHoofd.Size = new System.Drawing.Size(335, 113);
            this.btnDinerHoofd.TabIndex = 6;
            this.btnDinerHoofd.Text = "Hoofdgerechten";
            this.btnDinerHoofd.UseVisualStyleBackColor = false;
            this.btnDinerHoofd.Click += new System.EventHandler(this.BtnDinerHoofd_Click);
            // 
            // btnDinerTussen
            // 
            this.btnDinerTussen.BackColor = System.Drawing.Color.LightCyan;
            this.btnDinerTussen.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinerTussen.Location = new System.Drawing.Point(11, 225);
            this.btnDinerTussen.Name = "btnDinerTussen";
            this.btnDinerTussen.Size = new System.Drawing.Size(335, 113);
            this.btnDinerTussen.TabIndex = 5;
            this.btnDinerTussen.Text = "Tussengerechten";
            this.btnDinerTussen.UseVisualStyleBackColor = false;
            this.btnDinerTussen.Click += new System.EventHandler(this.BtnDinerTussen_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "Diner Menu:";
            // 
            // btnDinerVoor
            // 
            this.btnDinerVoor.BackColor = System.Drawing.Color.LightCyan;
            this.btnDinerVoor.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinerVoor.Location = new System.Drawing.Point(11, 95);
            this.btnDinerVoor.Name = "btnDinerVoor";
            this.btnDinerVoor.Size = new System.Drawing.Size(335, 113);
            this.btnDinerVoor.TabIndex = 1;
            this.btnDinerVoor.Text = "Voorgerechten";
            this.btnDinerVoor.UseVisualStyleBackColor = false;
            this.btnDinerVoor.Click += new System.EventHandler(this.BtnDinerVoor_Click);
            // 
            // btnDinerNa
            // 
            this.btnDinerNa.BackColor = System.Drawing.Color.LightCyan;
            this.btnDinerNa.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinerNa.Location = new System.Drawing.Point(11, 490);
            this.btnDinerNa.Name = "btnDinerNa";
            this.btnDinerNa.Size = new System.Drawing.Size(335, 113);
            this.btnDinerNa.TabIndex = 9;
            this.btnDinerNa.Text = "Nagerechten";
            this.btnDinerNa.UseVisualStyleBackColor = false;
            this.btnDinerNa.Click += new System.EventHandler(this.BtnDinerNa_Click);
            // 
            // pnlDranken
            // 
            this.pnlDranken.Controls.Add(this.btnKoffieThee);
            this.pnlDranken.Controls.Add(this.btnGedistilleerd);
            this.pnlDranken.Controls.Add(this.btnDrankTerug);
            this.pnlDranken.Controls.Add(this.btnWijnen);
            this.pnlDranken.Controls.Add(this.btnBieren);
            this.pnlDranken.Controls.Add(this.label7);
            this.pnlDranken.Controls.Add(this.btnFrisdrank);
            this.pnlDranken.Location = new System.Drawing.Point(1, 1);
            this.pnlDranken.Name = "pnlDranken";
            this.pnlDranken.Size = new System.Drawing.Size(355, 780);
            this.pnlDranken.TabIndex = 10;
            this.pnlDranken.Visible = false;
            // 
            // btnGedistilleerd
            // 
            this.btnGedistilleerd.BackColor = System.Drawing.Color.LightCyan;
            this.btnGedistilleerd.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGedistilleerd.Location = new System.Drawing.Point(11, 443);
            this.btnGedistilleerd.Name = "btnGedistilleerd";
            this.btnGedistilleerd.Size = new System.Drawing.Size(335, 113);
            this.btnGedistilleerd.TabIndex = 9;
            this.btnGedistilleerd.Text = "Gedistilleerd";
            this.btnGedistilleerd.UseVisualStyleBackColor = false;
            this.btnGedistilleerd.Click += new System.EventHandler(this.BtnGedistilleerd_Click);
            // 
            // btnDrankTerug
            // 
            this.btnDrankTerug.BackColor = System.Drawing.Color.Gold;
            this.btnDrankTerug.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrankTerug.Location = new System.Drawing.Point(11, 685);
            this.btnDrankTerug.Name = "btnDrankTerug";
            this.btnDrankTerug.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDrankTerug.Size = new System.Drawing.Size(138, 76);
            this.btnDrankTerug.TabIndex = 7;
            this.btnDrankTerug.Text = "Terug naar menu";
            this.btnDrankTerug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrankTerug.UseVisualStyleBackColor = false;
            this.btnDrankTerug.Click += new System.EventHandler(this.BtnDrankTerug_Click);
            // 
            // btnWijnen
            // 
            this.btnWijnen.BackColor = System.Drawing.Color.LightCyan;
            this.btnWijnen.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijnen.Location = new System.Drawing.Point(11, 324);
            this.btnWijnen.Name = "btnWijnen";
            this.btnWijnen.Size = new System.Drawing.Size(335, 113);
            this.btnWijnen.TabIndex = 6;
            this.btnWijnen.Text = "Wijnen";
            this.btnWijnen.UseVisualStyleBackColor = false;
            this.btnWijnen.Click += new System.EventHandler(this.BtnWijnen_Click);
            // 
            // btnBieren
            // 
            this.btnBieren.BackColor = System.Drawing.Color.LightCyan;
            this.btnBieren.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBieren.Location = new System.Drawing.Point(11, 205);
            this.btnBieren.Name = "btnBieren";
            this.btnBieren.Size = new System.Drawing.Size(335, 113);
            this.btnBieren.TabIndex = 5;
            this.btnBieren.Text = "Bieren";
            this.btnBieren.UseVisualStyleBackColor = false;
            this.btnBieren.Click += new System.EventHandler(this.BtnBieren_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 50);
            this.label7.TabIndex = 4;
            this.label7.Text = "Dranken Menu:";
            // 
            // btnFrisdrank
            // 
            this.btnFrisdrank.BackColor = System.Drawing.Color.LightCyan;
            this.btnFrisdrank.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrisdrank.Location = new System.Drawing.Point(11, 82);
            this.btnFrisdrank.Name = "btnFrisdrank";
            this.btnFrisdrank.Size = new System.Drawing.Size(335, 113);
            this.btnFrisdrank.TabIndex = 1;
            this.btnFrisdrank.Text = "Frisdrank";
            this.btnFrisdrank.UseVisualStyleBackColor = false;
            this.btnFrisdrank.Click += new System.EventHandler(this.BtnFrisdrank_Click);
            // 
            // btnKoffieThee
            // 
            this.btnKoffieThee.BackColor = System.Drawing.Color.LightCyan;
            this.btnKoffieThee.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKoffieThee.Location = new System.Drawing.Point(11, 562);
            this.btnKoffieThee.Name = "btnKoffieThee";
            this.btnKoffieThee.Size = new System.Drawing.Size(335, 113);
            this.btnKoffieThee.TabIndex = 10;
            this.btnKoffieThee.Text = "Koffie/Thee";
            this.btnKoffieThee.UseVisualStyleBackColor = false;
            this.btnKoffieThee.Click += new System.EventHandler(this.BtnKoffieThee_Click);
            // 
            // btnMenuListBekijkOrder
            // 
            this.btnMenuListBekijkOrder.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMenuListBekijkOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuListBekijkOrder.Location = new System.Drawing.Point(208, 686);
            this.btnMenuListBekijkOrder.Name = "btnMenuListBekijkOrder";
            this.btnMenuListBekijkOrder.Size = new System.Drawing.Size(138, 75);
            this.btnMenuListBekijkOrder.TabIndex = 17;
            this.btnMenuListBekijkOrder.Text = "Bekijk bestelling";
            this.btnMenuListBekijkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuListBekijkOrder.UseVisualStyleBackColor = false;
            this.btnMenuListBekijkOrder.Click += new System.EventHandler(this.BtnMenuListBekijkOrder_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.LawnGreen;
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(111, 529);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(38, 39);
            this.btnPlus.TabIndex = 18;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Red;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(11, 529);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(38, 39);
            this.btnMin.TabIndex = 19;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // lblAantal
            // 
            this.lblAantal.AutoSize = true;
            this.lblAantal.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAantal.Location = new System.Drawing.Point(68, 531);
            this.lblAantal.Name = "lblAantal";
            this.lblAantal.Size = new System.Drawing.Size(25, 30);
            this.lblAantal.TabIndex = 20;
            this.lblAantal.Text = "0";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 773);
            this.Controls.Add(this.pnlMenuListView);
            this.Controls.Add(this.pnlDranken);
            this.Controls.Add(this.pnlDiner);
            this.Controls.Add(this.pnlLunch);
            this.Controls.Add(this.btnMenuBekijkBestelling);
            this.Controls.Add(this.btnTerugNaarTafel);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.btnDrank);
            this.Controls.Add(this.btnDiner);
            this.Controls.Add(this.btnLunch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MenuForm";
            this.Text = "ChapooApp";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.pnlLunch.ResumeLayout(false);
            this.pnlLunch.PerformLayout();
            this.pnlMenuListView.ResumeLayout(false);
            this.pnlMenuListView.PerformLayout();
            this.pnlDiner.ResumeLayout(false);
            this.pnlDiner.PerformLayout();
            this.pnlDranken.ResumeLayout(false);
            this.pnlDranken.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLunch;
        private System.Windows.Forms.Button btnDiner;
        private System.Windows.Forms.Button btnDrank;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Panel pnlLunch;
        private System.Windows.Forms.Button btnLunchNagerecht;
        private System.Windows.Forms.Button btnLunchHoofdgerecht;
        private System.Windows.Forms.Label lblLunchMenu;
        private System.Windows.Forms.Button btnLunchVoorgerecht;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlMenuListView;
        private System.Windows.Forms.Button btnTerugNaarMenu;
        private System.Windows.Forms.Label lblMenuText;
        private System.Windows.Forms.ListView listviewMenuItems;
        private System.Windows.Forms.ColumnHeader Gerecht;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnTerugNaarTafel;
        private System.Windows.Forms.Button btnMenuBekijkBestelling;
        private System.Windows.Forms.Panel pnlDiner;
        private System.Windows.Forms.Button btnDinerNa;
        private System.Windows.Forms.Button btnDinerTerug;
        private System.Windows.Forms.Button btnDinerHoofd;
        private System.Windows.Forms.Button btnDinerTussen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDinerVoor;
        public System.Windows.Forms.Panel pnlDranken;
        private System.Windows.Forms.Button btnKoffieThee;
        private System.Windows.Forms.Button btnGedistilleerd;
        private System.Windows.Forms.Button btnDrankTerug;
        private System.Windows.Forms.Button btnWijnen;
        private System.Windows.Forms.Button btnBieren;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFrisdrank;
        private System.Windows.Forms.Button btnMenuListBekijkOrder;
        private System.Windows.Forms.Label lblAantal;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnPlus;
    }
}

