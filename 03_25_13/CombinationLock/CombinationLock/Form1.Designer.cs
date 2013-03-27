namespace CombinationLock
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
            this.cbPin1 = new System.Windows.Forms.ComboBox();
            this.cbPin2 = new System.Windows.Forms.ComboBox();
            this.cbPin3 = new System.Windows.Forms.ComboBox();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbPin1
            // 
            this.cbPin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPin1.FormattingEnabled = true;
            this.cbPin1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbPin1.Location = new System.Drawing.Point(34, 69);
            this.cbPin1.Name = "cbPin1";
            this.cbPin1.Size = new System.Drawing.Size(50, 32);
            this.cbPin1.TabIndex = 0;
            this.cbPin1.Text = "0";
            this.cbPin1.SelectedIndexChanged += new System.EventHandler(this.cbPin1_SelectedIndexChanged);
            // 
            // cbPin2
            // 
            this.cbPin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPin2.FormattingEnabled = true;
            this.cbPin2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbPin2.Location = new System.Drawing.Point(119, 69);
            this.cbPin2.Name = "cbPin2";
            this.cbPin2.Size = new System.Drawing.Size(50, 32);
            this.cbPin2.TabIndex = 1;
            this.cbPin2.Text = "0";
            this.cbPin2.SelectedIndexChanged += new System.EventHandler(this.cbPin2_SelectedIndexChanged);
            // 
            // cbPin3
            // 
            this.cbPin3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPin3.FormattingEnabled = true;
            this.cbPin3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbPin3.Location = new System.Drawing.Point(204, 69);
            this.cbPin3.Name = "cbPin3";
            this.cbPin3.Size = new System.Drawing.Size(50, 32);
            this.cbPin3.TabIndex = 2;
            this.cbPin3.Text = "0";
            this.cbPin3.SelectedIndexChanged += new System.EventHandler(this.cbPin3_SelectedIndexChanged);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Enabled = false;
            this.btnUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.Location = new System.Drawing.Point(108, 150);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(100, 50);
            this.btnUnlock.TabIndex = 3;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.cbPin3);
            this.Controls.Add(this.cbPin2);
            this.Controls.Add(this.cbPin1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPin1;
        private System.Windows.Forms.ComboBox cbPin2;
        private System.Windows.Forms.ComboBox cbPin3;
        private System.Windows.Forms.Button btnUnlock;
    }
}

