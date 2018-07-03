namespace ATMWinForm
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
            this.showBalanceLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showInitialBalanceText = new System.Windows.Forms.TextBox();
            this.withdrawalTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showBalanceLabel
            // 
            this.showBalanceLabel.AccessibleName = "BalanceText";
            this.showBalanceLabel.AutoSize = true;
            this.showBalanceLabel.Location = new System.Drawing.Point(199, 371);
            this.showBalanceLabel.Name = "showBalanceLabel";
            this.showBalanceLabel.Size = new System.Drawing.Size(67, 20);
            this.showBalanceLabel.TabIndex = 0;
            this.showBalanceLabel.Text = "Balance";
            this.showBalanceLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.AccessibleName = "getBalanceButton";
            this.button1.Location = new System.Drawing.Point(21, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Get Balance";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Withdrawal amount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Current Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // showInitialBalanceText
            // 
            this.showInitialBalanceText.Location = new System.Drawing.Point(201, 26);
            this.showInitialBalanceText.Name = "showInitialBalanceText";
            this.showInitialBalanceText.ReadOnly = true;
            this.showInitialBalanceText.Size = new System.Drawing.Size(113, 26);
            this.showInitialBalanceText.TabIndex = 6;
            // 
            // withdrawalTextBox
            // 
            this.withdrawalTextBox.Location = new System.Drawing.Point(203, 101);
            this.withdrawalTextBox.Name = "withdrawalTextBox";
            this.withdrawalTextBox.Size = new System.Drawing.Size(114, 26);
            this.withdrawalTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Deposit amount:";
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(204, 147);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(112, 26);
            this.depositTextBox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.depositTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.withdrawalTextBox);
            this.Controls.Add(this.showInitialBalanceText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showBalanceLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showBalanceLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox showInitialBalanceText;
        private System.Windows.Forms.TextBox withdrawalTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox depositTextBox;
    }
}

