namespace ChapooUI
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.listviewOrderItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotaalprijs = new System.Windows.Forms.Label();
            this.btnBevestigOrder = new System.Windows.Forms.Button();
            this.btnOrderFormTerug = new System.Windows.Forms.Button();
            this.txtOpmerking = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlPopUp = new System.Windows.Forms.Panel();
            this.lblOpmerking = new System.Windows.Forms.Label();
            this.listViewPopUp = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBevestigOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlWijzigOrder = new System.Windows.Forms.Panel();
            this.lblWijzigAantal = new System.Windows.Forms.Label();
            this.btnWijzigAantal = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnWijzigPlus = new System.Windows.Forms.Button();
            this.btnBevestigWijziging = new System.Windows.Forms.Button();
            this.btnVerwijderItem = new System.Windows.Forms.Button();
            this.listViewWijzigOrder = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAangemaaktDoor = new System.Windows.Forms.Label();
            this.pnlPopUp.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlWijzigOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // listviewOrderItems
            // 
            this.listviewOrderItems.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listviewOrderItems.AutoArrange = false;
            this.listviewOrderItems.BackColor = System.Drawing.Color.LightCyan;
            this.listviewOrderItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listviewOrderItems.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewOrderItems.GridLines = true;
            this.listviewOrderItems.HideSelection = false;
            this.listviewOrderItems.Location = new System.Drawing.Point(12, 104);
            this.listviewOrderItems.Name = "listviewOrderItems";
            this.listviewOrderItems.Size = new System.Drawing.Size(335, 277);
            this.listviewOrderItems.TabIndex = 9;
            this.listviewOrderItems.UseCompatibleStateImageBehavior = false;
            this.listviewOrderItems.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gerecht";
            this.columnHeader1.Width = 182;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aantal";
            this.columnHeader2.Width = 73;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prijs";
            this.columnHeader3.Width = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bestelling met ordernummer:";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderId.Location = new System.Drawing.Point(282, 42);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(22, 25);
            this.lblOrderId.TabIndex = 11;
            this.lblOrderId.Text = "..";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Totaalprijs:";
            // 
            // lblTotaalprijs
            // 
            this.lblTotaalprijs.AutoSize = true;
            this.lblTotaalprijs.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotaalprijs.Location = new System.Drawing.Point(282, 388);
            this.lblTotaalprijs.Name = "lblTotaalprijs";
            this.lblTotaalprijs.Size = new System.Drawing.Size(22, 25);
            this.lblTotaalprijs.TabIndex = 13;
            this.lblTotaalprijs.Text = "..";
            this.lblTotaalprijs.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnBevestigOrder
            // 
            this.btnBevestigOrder.BackColor = System.Drawing.Color.LawnGreen;
            this.btnBevestigOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBevestigOrder.Location = new System.Drawing.Point(209, 686);
            this.btnBevestigOrder.Name = "btnBevestigOrder";
            this.btnBevestigOrder.Size = new System.Drawing.Size(138, 75);
            this.btnBevestigOrder.TabIndex = 18;
            this.btnBevestigOrder.Text = "Bevestig bestelling";
            this.btnBevestigOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBevestigOrder.UseVisualStyleBackColor = false;
            this.btnBevestigOrder.Click += new System.EventHandler(this.BtnBevestigOrder_Click);
            // 
            // btnOrderFormTerug
            // 
            this.btnOrderFormTerug.BackColor = System.Drawing.Color.Gold;
            this.btnOrderFormTerug.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderFormTerug.Location = new System.Drawing.Point(12, 686);
            this.btnOrderFormTerug.Name = "btnOrderFormTerug";
            this.btnOrderFormTerug.Size = new System.Drawing.Size(138, 75);
            this.btnOrderFormTerug.TabIndex = 19;
            this.btnOrderFormTerug.Text = "Wijzig bestelling";
            this.btnOrderFormTerug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderFormTerug.UseVisualStyleBackColor = false;
            this.btnOrderFormTerug.Click += new System.EventHandler(this.BtnOrderFormTerug_Click);
            // 
            // txtOpmerking
            // 
            this.txtOpmerking.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOpmerking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOpmerking.Location = new System.Drawing.Point(12, 469);
            this.txtOpmerking.Name = "txtOpmerking";
            this.txtOpmerking.Size = new System.Drawing.Size(335, 192);
            this.txtOpmerking.TabIndex = 21;
            this.txtOpmerking.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Opmerking:";
            // 
            // pnlPopUp
            // 
            this.pnlPopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPopUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPopUp.Controls.Add(this.lblAangemaaktDoor);
            this.pnlPopUp.Controls.Add(this.lblOpmerking);
            this.pnlPopUp.Controls.Add(this.listViewPopUp);
            this.pnlPopUp.Controls.Add(this.btnBevestigOK);
            this.pnlPopUp.Controls.Add(this.panel2);
            this.pnlPopUp.Location = new System.Drawing.Point(12, 167);
            this.pnlPopUp.Name = "pnlPopUp";
            this.pnlPopUp.Size = new System.Drawing.Size(335, 398);
            this.pnlPopUp.TabIndex = 23;
            this.pnlPopUp.Visible = false;
            // 
            // lblOpmerking
            // 
            this.lblOpmerking.AutoSize = true;
            this.lblOpmerking.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpmerking.Location = new System.Drawing.Point(14, 281);
            this.lblOpmerking.Name = "lblOpmerking";
            this.lblOpmerking.Size = new System.Drawing.Size(164, 17);
            this.lblOpmerking.TabIndex = 11;
            this.lblOpmerking.Text = "Geen opmerking geplaatst";
            // 
            // listViewPopUp
            // 
            this.listViewPopUp.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewPopUp.AutoArrange = false;
            this.listViewPopUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listViewPopUp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewPopUp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPopUp.GridLines = true;
            this.listViewPopUp.HideSelection = false;
            this.listViewPopUp.Location = new System.Drawing.Point(17, 121);
            this.listViewPopUp.Name = "listViewPopUp";
            this.listViewPopUp.Size = new System.Drawing.Size(300, 134);
            this.listViewPopUp.TabIndex = 10;
            this.listViewPopUp.UseCompatibleStateImageBehavior = false;
            this.listViewPopUp.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gerecht";
            this.columnHeader4.Width = 235;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Aantal";
            // 
            // btnBevestigOK
            // 
            this.btnBevestigOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBevestigOK.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBevestigOK.Location = new System.Drawing.Point(188, 317);
            this.btnBevestigOK.Name = "btnBevestigOK";
            this.btnBevestigOK.Size = new System.Drawing.Size(129, 65);
            this.btnBevestigOK.TabIndex = 1;
            this.btnBevestigOK.Text = "OK";
            this.btnBevestigOK.UseVisualStyleBackColor = false;
            this.btnBevestigOK.Click += new System.EventHandler(this.BtnBevestigOK_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(17, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 80);
            this.panel2.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bestelling bevestigd!";
            // 
            // pnlWijzigOrder
            // 
            this.pnlWijzigOrder.Controls.Add(this.lblWijzigAantal);
            this.pnlWijzigOrder.Controls.Add(this.btnWijzigAantal);
            this.pnlWijzigOrder.Controls.Add(this.btnMin);
            this.pnlWijzigOrder.Controls.Add(this.btnWijzigPlus);
            this.pnlWijzigOrder.Controls.Add(this.btnBevestigWijziging);
            this.pnlWijzigOrder.Controls.Add(this.btnVerwijderItem);
            this.pnlWijzigOrder.Controls.Add(this.listViewWijzigOrder);
            this.pnlWijzigOrder.Location = new System.Drawing.Point(2, 0);
            this.pnlWijzigOrder.Name = "pnlWijzigOrder";
            this.pnlWijzigOrder.Size = new System.Drawing.Size(355, 775);
            this.pnlWijzigOrder.TabIndex = 24;
            this.pnlWijzigOrder.Visible = false;
            // 
            // lblWijzigAantal
            // 
            this.lblWijzigAantal.AutoSize = true;
            this.lblWijzigAantal.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWijzigAantal.Location = new System.Drawing.Point(268, 481);
            this.lblWijzigAantal.Name = "lblWijzigAantal";
            this.lblWijzigAantal.Size = new System.Drawing.Size(22, 25);
            this.lblWijzigAantal.TabIndex = 24;
            this.lblWijzigAantal.Text = "0";
            // 
            // btnWijzigAantal
            // 
            this.btnWijzigAantal.BackColor = System.Drawing.Color.Gold;
            this.btnWijzigAantal.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzigAantal.Location = new System.Drawing.Point(11, 478);
            this.btnWijzigAantal.Name = "btnWijzigAantal";
            this.btnWijzigAantal.Size = new System.Drawing.Size(138, 30);
            this.btnWijzigAantal.TabIndex = 23;
            this.btnWijzigAantal.Text = "Wijzig aantal";
            this.btnWijzigAantal.UseVisualStyleBackColor = false;
            this.btnWijzigAantal.Click += new System.EventHandler(this.BtnWijzigAantal_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Red;
            this.btnMin.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(207, 479);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(29, 30);
            this.btnMin.TabIndex = 22;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnWijzigPlus
            // 
            this.btnWijzigPlus.BackColor = System.Drawing.Color.LawnGreen;
            this.btnWijzigPlus.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWijzigPlus.Location = new System.Drawing.Point(316, 478);
            this.btnWijzigPlus.Name = "btnWijzigPlus";
            this.btnWijzigPlus.Size = new System.Drawing.Size(29, 30);
            this.btnWijzigPlus.TabIndex = 21;
            this.btnWijzigPlus.Text = "+";
            this.btnWijzigPlus.UseVisualStyleBackColor = false;
            this.btnWijzigPlus.Click += new System.EventHandler(this.BtnWijzigPlus_Click);
            // 
            // btnBevestigWijziging
            // 
            this.btnBevestigWijziging.BackColor = System.Drawing.Color.LawnGreen;
            this.btnBevestigWijziging.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBevestigWijziging.Location = new System.Drawing.Point(207, 686);
            this.btnBevestigWijziging.Name = "btnBevestigWijziging";
            this.btnBevestigWijziging.Size = new System.Drawing.Size(138, 75);
            this.btnBevestigWijziging.TabIndex = 20;
            this.btnBevestigWijziging.Text = "Bevestig wijziging";
            this.btnBevestigWijziging.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBevestigWijziging.UseVisualStyleBackColor = false;
            this.btnBevestigWijziging.Click += new System.EventHandler(this.BtnBevestigWijziging_Click);
            // 
            // btnVerwijderItem
            // 
            this.btnVerwijderItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnVerwijderItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerwijderItem.Location = new System.Drawing.Point(10, 515);
            this.btnVerwijderItem.Name = "btnVerwijderItem";
            this.btnVerwijderItem.Size = new System.Drawing.Size(138, 30);
            this.btnVerwijderItem.TabIndex = 11;
            this.btnVerwijderItem.Text = "Verwijder item";
            this.btnVerwijderItem.UseVisualStyleBackColor = false;
            this.btnVerwijderItem.Click += new System.EventHandler(this.BtnVerwijderItem_Click);
            // 
            // listViewWijzigOrder
            // 
            this.listViewWijzigOrder.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewWijzigOrder.AutoArrange = false;
            this.listViewWijzigOrder.BackColor = System.Drawing.Color.LightCyan;
            this.listViewWijzigOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewWijzigOrder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewWijzigOrder.GridLines = true;
            this.listViewWijzigOrder.HideSelection = false;
            this.listViewWijzigOrder.Location = new System.Drawing.Point(11, 70);
            this.listViewWijzigOrder.Name = "listViewWijzigOrder";
            this.listViewWijzigOrder.Size = new System.Drawing.Size(335, 383);
            this.listViewWijzigOrder.TabIndex = 10;
            this.listViewWijzigOrder.UseCompatibleStateImageBehavior = false;
            this.listViewWijzigOrder.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ItemID";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Gerecht";
            this.columnHeader7.Width = 173;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Aantal";
            this.columnHeader8.Width = 75;
            // 
            // lblAangemaaktDoor
            // 
            this.lblAangemaaktDoor.AutoSize = true;
            this.lblAangemaaktDoor.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAangemaaktDoor.Location = new System.Drawing.Point(14, 369);
            this.lblAangemaaktDoor.Name = "lblAangemaaktDoor";
            this.lblAangemaaktDoor.Size = new System.Drawing.Size(13, 13);
            this.lblAangemaaktDoor.TabIndex = 12;
            this.lblAangemaaktDoor.Text = "..";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 773);
            this.Controls.Add(this.pnlWijzigOrder);
            this.Controls.Add(this.pnlPopUp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOpmerking);
            this.Controls.Add(this.btnOrderFormTerug);
            this.Controls.Add(this.btnBevestigOrder);
            this.Controls.Add(this.lblTotaalprijs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrderId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listviewOrderItems);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.pnlPopUp.ResumeLayout(false);
            this.pnlPopUp.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlWijzigOrder.ResumeLayout(false);
            this.pnlWijzigOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listviewOrderItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotaalprijs;
        private System.Windows.Forms.Button btnBevestigOrder;
        private System.Windows.Forms.Button btnOrderFormTerug;
        private System.Windows.Forms.RichTextBox txtOpmerking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlPopUp;
        private System.Windows.Forms.Label lblOpmerking;
        private System.Windows.Forms.ListView listViewPopUp;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnBevestigOK;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlWijzigOrder;
        private System.Windows.Forms.Button btnVerwijderItem;
        private System.Windows.Forms.ListView listViewWijzigOrder;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnBevestigWijziging;
        private System.Windows.Forms.Button btnWijzigPlus;
        private System.Windows.Forms.Label lblWijzigAantal;
        private System.Windows.Forms.Button btnWijzigAantal;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label lblAangemaaktDoor;
    }
}