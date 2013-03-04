namespace BurgerCity
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBurgerCount = new System.Windows.Forms.TextBox();
            this.chkExtraCount = new System.Windows.Forms.CheckBox();
            this.txtExtraCount = new System.Windows.Forms.TextBox();
            this.lblExtraCount = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBurgerCost = new System.Windows.Forms.Label();
            this.lblExtrasCost = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "# of Burgers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBurgerCount
            // 
            this.txtBurgerCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBurgerCount.Location = new System.Drawing.Point(252, 94);
            this.txtBurgerCount.Name = "txtBurgerCount";
            this.txtBurgerCount.Size = new System.Drawing.Size(100, 29);
            this.txtBurgerCount.TabIndex = 0;
            this.txtBurgerCount.Text = "5";
            this.txtBurgerCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBurgerCount.TextChanged += new System.EventHandler(this.txtBurgerCount_TextChanged);
            // 
            // chkExtraCount
            // 
            this.chkExtraCount.AutoSize = true;
            this.chkExtraCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCount.Location = new System.Drawing.Point(252, 146);
            this.chkExtraCount.Name = "chkExtraCount";
            this.chkExtraCount.Size = new System.Drawing.Size(81, 28);
            this.chkExtraCount.TabIndex = 3;
            this.chkExtraCount.Text = "Extras";
            this.chkExtraCount.UseVisualStyleBackColor = true;
            this.chkExtraCount.CheckedChanged += new System.EventHandler(this.chkExtraCount_CheckedChanged);
            // 
            // txtExtraCount
            // 
            this.txtExtraCount.Enabled = false;
            this.txtExtraCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraCount.Location = new System.Drawing.Point(252, 185);
            this.txtExtraCount.Name = "txtExtraCount";
            this.txtExtraCount.Size = new System.Drawing.Size(100, 29);
            this.txtExtraCount.TabIndex = 1;
            this.txtExtraCount.Text = "3";
            this.txtExtraCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExtraCount.TextChanged += new System.EventHandler(this.txtExtraCount_TextChanged);
            // 
            // lblExtraCount
            // 
            this.lblExtraCount.AutoSize = true;
            this.lblExtraCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraCount.Location = new System.Drawing.Point(139, 185);
            this.lblExtraCount.Name = "lblExtraCount";
            this.lblExtraCount.Size = new System.Drawing.Size(97, 24);
            this.lblExtraCount.TabIndex = 5;
            this.lblExtraCount.Text = "# of Extras";
            this.lblExtraCount.Click += new System.EventHandler(this.lblExtraCount_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(77, 263);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 50);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(255, 263);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(433, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(255, 227);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 24);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "<lblTotal>";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // lblBurgerCost
            // 
            this.lblBurgerCost.AutoSize = true;
            this.lblBurgerCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurgerCost.Location = new System.Drawing.Point(140, 1);
            this.lblBurgerCost.Name = "lblBurgerCost";
            this.lblBurgerCost.Size = new System.Drawing.Size(145, 24);
            this.lblBurgerCost.TabIndex = 9;
            this.lblBurgerCost.Text = "<lblBurgerCost>";
            // 
            // lblExtrasCost
            // 
            this.lblExtrasCost.AutoSize = true;
            this.lblExtrasCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrasCost.Location = new System.Drawing.Point(141, 35);
            this.lblExtrasCost.Name = "lblExtrasCost";
            this.lblExtrasCost.Size = new System.Drawing.Size(140, 24);
            this.lblExtrasCost.TabIndex = 10;
            this.lblExtrasCost.Text = "<lblExtrasCost>";
            this.lblExtrasCost.Click += new System.EventHandler(this.lblExtrasCost_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(176, 63);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(51, 13);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "<lblError>";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(573, 362);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblExtrasCost);
            this.Controls.Add(this.lblBurgerCost);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblExtraCount);
            this.Controls.Add(this.txtExtraCount);
            this.Controls.Add(this.chkExtraCount);
            this.Controls.Add(this.txtBurgerCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Burger City";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBurgerCount;
        private System.Windows.Forms.CheckBox chkExtraCount;
        private System.Windows.Forms.TextBox txtExtraCount;
        private System.Windows.Forms.Label lblExtraCount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBurgerCost;
        private System.Windows.Forms.Label lblExtrasCost;
        private System.Windows.Forms.Label lblError;
    }
}

