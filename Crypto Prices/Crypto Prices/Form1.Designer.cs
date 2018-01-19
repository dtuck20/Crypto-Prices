namespace Crypto_Prices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblBTC = new System.Windows.Forms.Label();
            this.lblBCH = new System.Windows.Forms.Label();
            this.lblETH = new System.Windows.Forms.Label();
            this.lblZEC = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblBTG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBTC
            // 
            this.lblBTC.AutoSize = true;
            this.lblBTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBTC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBTC.Location = new System.Drawing.Point(24, 54);
            this.lblBTC.Name = "lblBTC";
            this.lblBTC.Size = new System.Drawing.Size(45, 13);
            this.lblBTC.TabIndex = 0;
            this.lblBTC.Text = "Bitcoin: ";
            // 
            // lblBCH
            // 
            this.lblBCH.AutoSize = true;
            this.lblBCH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBCH.Location = new System.Drawing.Point(24, 87);
            this.lblBCH.Name = "lblBCH";
            this.lblBCH.Size = new System.Drawing.Size(72, 13);
            this.lblBCH.TabIndex = 1;
            this.lblBCH.Text = "Bitcoin Cash: ";
            // 
            // lblETH
            // 
            this.lblETH.AutoSize = true;
            this.lblETH.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblETH.Location = new System.Drawing.Point(24, 125);
            this.lblETH.Name = "lblETH";
            this.lblETH.Size = new System.Drawing.Size(38, 13);
            this.lblETH.TabIndex = 2;
            this.lblETH.Text = "Ether: ";
            // 
            // lblZEC
            // 
            this.lblZEC.AutoSize = true;
            this.lblZEC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblZEC.Location = new System.Drawing.Point(24, 159);
            this.lblZEC.Name = "lblZEC";
            this.lblZEC.Size = new System.Drawing.Size(47, 13);
            this.lblZEC.TabIndex = 3;
            this.lblZEC.Text = "Z Cash: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblBTG
            // 
            this.lblBTG.AutoSize = true;
            this.lblBTG.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBTG.Location = new System.Drawing.Point(24, 188);
            this.lblBTG.Name = "lblBTG";
            this.lblBTG.Size = new System.Drawing.Size(67, 13);
            this.lblBTG.TabIndex = 5;
            this.lblBTG.Text = "Bitcoin Gold:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(427, 224);
            this.Controls.Add(this.lblBTG);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblZEC);
            this.Controls.Add(this.lblETH);
            this.Controls.Add(this.lblBCH);
            this.Controls.Add(this.lblBTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Current Crypto Prices";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBTC;
        private System.Windows.Forms.Label lblBCH;
        private System.Windows.Forms.Label lblETH;
        private System.Windows.Forms.Label lblZEC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblBTG;
    }
}

