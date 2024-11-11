namespace banking_system.forms
{
    partial class TransactionsForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.transactionsGridView = new System.Windows.Forms.DataGridView();
            this.depositLabel = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.FlatAppearance.BorderSize = 1230;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backButton.Location = new System.Drawing.Point(415, 553);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(219, 51);
            this.backButton.TabIndex = 23;
            this.backButton.Text = "Back";
            this.backButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.HandleBackButtonClick);
            // 
            // transactionsGridView
            // 
            this.transactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGridView.Location = new System.Drawing.Point(85, 112);
            this.transactionsGridView.Name = "transactionsGridView";
            this.transactionsGridView.RowHeadersWidth = 62;
            this.transactionsGridView.RowTemplate.Height = 28;
            this.transactionsGridView.Size = new System.Drawing.Size(874, 397);
            this.transactionsGridView.TabIndex = 24;
            // 
            // depositLabel
            // 
            this.depositLabel.AutoSize = true;
            this.depositLabel.Font = new System.Drawing.Font("Ubuntu", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depositLabel.Location = new System.Drawing.Point(296, 25);
            this.depositLabel.Name = "depositLabel";
            this.depositLabel.Size = new System.Drawing.Size(441, 66);
            this.depositLabel.TabIndex = 25;
            this.depositLabel.Text = "TRANSACTIONS";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1050, 33);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click_1);
            // 
            // TransactionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 644);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.depositLabel);
            this.Controls.Add(this.transactionsGridView);
            this.Controls.Add(this.backButton);
            this.Name = "TransactionsForm";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.TransactionsFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView transactionsGridView;
        private System.Windows.Forms.Label depositLabel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    }
}