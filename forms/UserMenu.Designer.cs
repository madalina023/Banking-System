namespace banking_system.forms
{
    partial class UserMenu
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
            this.userMenuLabel = new System.Windows.Forms.Label();
            this.addCardButton = new System.Windows.Forms.Button();
            this.depositButton = new System.Windows.Forms.Button();
            this.showCardsButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userMenuLabel
            // 
            this.userMenuLabel.AutoSize = true;
            this.userMenuLabel.Font = new System.Drawing.Font("Ubuntu", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userMenuLabel.Location = new System.Drawing.Point(532, 55);
            this.userMenuLabel.Name = "userMenuLabel";
            this.userMenuLabel.Size = new System.Drawing.Size(339, 66);
            this.userMenuLabel.TabIndex = 8;
            this.userMenuLabel.Text = "USER MENU";
            // 
            // addCardButton
            // 
            this.addCardButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addCardButton.FlatAppearance.BorderSize = 1230;
            this.addCardButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCardButton.Location = new System.Drawing.Point(583, 200);
            this.addCardButton.Name = "addCardButton";
            this.addCardButton.Size = new System.Drawing.Size(232, 71);
            this.addCardButton.TabIndex = 19;
            this.addCardButton.Text = "Add Card";
            this.addCardButton.UseVisualStyleBackColor = true;
            this.addCardButton.Click += new System.EventHandler(this.HandleAddCardButtonClick);
            // 
            // depositButton
            // 
            this.depositButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.depositButton.FlatAppearance.BorderSize = 1230;
            this.depositButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.depositButton.Location = new System.Drawing.Point(583, 317);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(232, 71);
            this.depositButton.TabIndex = 20;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.HandleDepositClickButton);
            // 
            // showCardsButton
            // 
            this.showCardsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.showCardsButton.FlatAppearance.BorderSize = 1230;
            this.showCardsButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showCardsButton.Location = new System.Drawing.Point(583, 680);
            this.showCardsButton.Name = "showCardsButton";
            this.showCardsButton.Size = new System.Drawing.Size(232, 71);
            this.showCardsButton.TabIndex = 21;
            this.showCardsButton.Text = "Cards";
            this.showCardsButton.UseVisualStyleBackColor = true;
            this.showCardsButton.Click += new System.EventHandler(this.HandleShowCardsButtonClick);
            // 
            // logOutButton
            // 
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logOutButton.FlatAppearance.BorderSize = 1230;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logOutButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logOutButton.Location = new System.Drawing.Point(609, 819);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(187, 51);
            this.logOutButton.TabIndex = 22;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.HandleLogOutButtonClick);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 1230;
            this.button1.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(583, 560);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 71);
            this.button1.TabIndex = 23;
            this.button1.Text = "Transactions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.HandleShowTransactionsButtonClick);
            // 
            // withdrawButton
            // 
            this.withdrawButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.withdrawButton.FlatAppearance.BorderSize = 1230;
            this.withdrawButton.Font = new System.Drawing.Font("SF Pro Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.withdrawButton.Location = new System.Drawing.Point(583, 435);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(232, 71);
            this.withdrawButton.TabIndex = 24;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.HandleWithdrawClickButton);
            // 
            // UserMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 903);
            this.Controls.Add(this.withdrawButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.showCardsButton);
            this.Controls.Add(this.depositButton);
            this.Controls.Add(this.addCardButton);
            this.Controls.Add(this.userMenuLabel);
            this.Name = "UserMenu";
            this.Text = "UserMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userMenuLabel;
        private System.Windows.Forms.Button addCardButton;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.Button showCardsButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button withdrawButton;
    }
}