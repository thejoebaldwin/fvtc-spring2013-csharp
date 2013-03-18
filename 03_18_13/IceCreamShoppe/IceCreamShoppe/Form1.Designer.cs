namespace IceCreamShoppe
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
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.rbVanilla = new System.Windows.Forms.RadioButton();
            this.lblFlavor = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbStrawberry = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChocolate.Location = new System.Drawing.Point(40, 86);
            this.rbChocolate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbChocolate.Name = "rbChocolate";
            this.rbChocolate.Size = new System.Drawing.Size(113, 28);
            this.rbChocolate.TabIndex = 0;
            this.rbChocolate.TabStop = true;
            this.rbChocolate.Text = "Chocolate";
            this.rbChocolate.UseVisualStyleBackColor = true;
            this.rbChocolate.CheckedChanged += new System.EventHandler(this.rbChocolate_CheckedChanged);
            // 
            // rbVanilla
            // 
            this.rbVanilla.AutoSize = true;
            this.rbVanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVanilla.Location = new System.Drawing.Point(40, 150);
            this.rbVanilla.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbVanilla.Name = "rbVanilla";
            this.rbVanilla.Size = new System.Drawing.Size(84, 28);
            this.rbVanilla.TabIndex = 1;
            this.rbVanilla.TabStop = true;
            this.rbVanilla.Text = "Vanilla";
            this.rbVanilla.UseVisualStyleBackColor = true;
            this.rbVanilla.CheckedChanged += new System.EventHandler(this.rbVanilla_CheckedChanged);
            // 
            // lblFlavor
            // 
            this.lblFlavor.AutoSize = true;
            this.lblFlavor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlavor.Location = new System.Drawing.Point(77, 277);
            this.lblFlavor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFlavor.Name = "lblFlavor";
            this.lblFlavor.Size = new System.Drawing.Size(103, 24);
            this.lblFlavor.TabIndex = 2;
            this.lblFlavor.Text = "<lblFlavor>";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(193, 329);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 40);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbStrawberry
            // 
            this.rbStrawberry.AutoSize = true;
            this.rbStrawberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStrawberry.Location = new System.Drawing.Point(40, 207);
            this.rbStrawberry.Margin = new System.Windows.Forms.Padding(6);
            this.rbStrawberry.Name = "rbStrawberry";
            this.rbStrawberry.Size = new System.Drawing.Size(117, 28);
            this.rbStrawberry.TabIndex = 4;
            this.rbStrawberry.TabStop = true;
            this.rbStrawberry.Text = "Strawberry";
            this.rbStrawberry.UseVisualStyleBackColor = true;
            this.rbStrawberry.CheckedChanged += new System.EventHandler(this.rbStrawberry_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 484);
            this.Controls.Add(this.rbStrawberry);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFlavor);
            this.Controls.Add(this.rbVanilla);
            this.Controls.Add(this.rbChocolate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.RadioButton rbVanilla;
        private System.Windows.Forms.Label lblFlavor;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbStrawberry;

    }
}

