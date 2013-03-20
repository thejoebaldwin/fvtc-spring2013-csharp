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
            this.rbStrawberry = new System.Windows.Forms.RadioButton();
            this.pbxCone = new System.Windows.Forms.PictureBox();
            this.pbxFlavor = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbChocolate2 = new System.Windows.Forms.RadioButton();
            this.rbVanilla2 = new System.Windows.Forms.RadioButton();
            this.rbStrawberry2 = new System.Windows.Forms.RadioButton();
            this.pbxFlavor2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlavor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlavor2)).BeginInit();
            this.SuspendLayout();
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChocolate.Location = new System.Drawing.Point(23, 31);
            this.rbChocolate.Margin = new System.Windows.Forms.Padding(6);
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
            this.rbVanilla.Location = new System.Drawing.Point(23, 75);
            this.rbVanilla.Margin = new System.Windows.Forms.Padding(6);
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
            this.lblFlavor.Location = new System.Drawing.Point(98, 277);
            this.lblFlavor.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFlavor.Name = "lblFlavor";
            this.lblFlavor.Size = new System.Drawing.Size(103, 24);
            this.lblFlavor.TabIndex = 2;
            this.lblFlavor.Text = "<lblFlavor>";
            // 
            // rbStrawberry
            // 
            this.rbStrawberry.AutoSize = true;
            this.rbStrawberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStrawberry.Location = new System.Drawing.Point(23, 123);
            this.rbStrawberry.Margin = new System.Windows.Forms.Padding(6);
            this.rbStrawberry.Name = "rbStrawberry";
            this.rbStrawberry.Size = new System.Drawing.Size(117, 28);
            this.rbStrawberry.TabIndex = 4;
            this.rbStrawberry.TabStop = true;
            this.rbStrawberry.Text = "Strawberry";
            this.rbStrawberry.UseVisualStyleBackColor = true;
            this.rbStrawberry.CheckedChanged += new System.EventHandler(this.rbStrawberry_CheckedChanged);
            // 
            // pbxCone
            // 
            this.pbxCone.Image = global::IceCreamShoppe.Properties.Resources.cone;
            this.pbxCone.Location = new System.Drawing.Point(475, 280);
            this.pbxCone.Name = "pbxCone";
            this.pbxCone.Size = new System.Drawing.Size(100, 204);
            this.pbxCone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCone.TabIndex = 5;
            this.pbxCone.TabStop = false;
            // 
            // pbxFlavor
            // 
            this.pbxFlavor.BackColor = System.Drawing.Color.Transparent;
            this.pbxFlavor.Image = global::IceCreamShoppe.Properties.Resources.chocolate;
            this.pbxFlavor.Location = new System.Drawing.Point(450, 145);
            this.pbxFlavor.Name = "pbxFlavor";
            this.pbxFlavor.Size = new System.Drawing.Size(150, 150);
            this.pbxFlavor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFlavor.TabIndex = 6;
            this.pbxFlavor.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbChocolate);
            this.groupBox1.Controls.Add(this.rbVanilla);
            this.groupBox1.Controls.Add(this.rbStrawberry);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(13, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scoop #1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbChocolate2);
            this.groupBox2.Controls.Add(this.rbVanilla2);
            this.groupBox2.Controls.Add(this.rbStrawberry2);
            this.groupBox2.Location = new System.Drawing.Point(241, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 150);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scoop #2";
            // 
            // rbChocolate2
            // 
            this.rbChocolate2.AutoSize = true;
            this.rbChocolate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChocolate2.Location = new System.Drawing.Point(23, 31);
            this.rbChocolate2.Margin = new System.Windows.Forms.Padding(6);
            this.rbChocolate2.Name = "rbChocolate2";
            this.rbChocolate2.Size = new System.Drawing.Size(113, 28);
            this.rbChocolate2.TabIndex = 0;
            this.rbChocolate2.TabStop = true;
            this.rbChocolate2.Text = "Chocolate";
            this.rbChocolate2.UseVisualStyleBackColor = true;
            this.rbChocolate2.CheckedChanged += new System.EventHandler(this.rbChocolate2_CheckedChanged);
            // 
            // rbVanilla2
            // 
            this.rbVanilla2.AutoSize = true;
            this.rbVanilla2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVanilla2.Location = new System.Drawing.Point(23, 75);
            this.rbVanilla2.Margin = new System.Windows.Forms.Padding(6);
            this.rbVanilla2.Name = "rbVanilla2";
            this.rbVanilla2.Size = new System.Drawing.Size(84, 28);
            this.rbVanilla2.TabIndex = 1;
            this.rbVanilla2.TabStop = true;
            this.rbVanilla2.Text = "Vanilla";
            this.rbVanilla2.UseVisualStyleBackColor = true;
            this.rbVanilla2.CheckedChanged += new System.EventHandler(this.rbVanilla2_CheckedChanged);
            // 
            // rbStrawberry2
            // 
            this.rbStrawberry2.AutoSize = true;
            this.rbStrawberry2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStrawberry2.Location = new System.Drawing.Point(23, 123);
            this.rbStrawberry2.Margin = new System.Windows.Forms.Padding(6);
            this.rbStrawberry2.Name = "rbStrawberry2";
            this.rbStrawberry2.Size = new System.Drawing.Size(117, 28);
            this.rbStrawberry2.TabIndex = 4;
            this.rbStrawberry2.TabStop = true;
            this.rbStrawberry2.Text = "Strawberry";
            this.rbStrawberry2.UseVisualStyleBackColor = true;
            this.rbStrawberry2.CheckedChanged += new System.EventHandler(this.rbStrawberry2_CheckedChanged);
            // 
            // pbxFlavor2
            // 
            this.pbxFlavor2.BackColor = System.Drawing.Color.Transparent;
            this.pbxFlavor2.Image = global::IceCreamShoppe.Properties.Resources.chocolate;
            this.pbxFlavor2.Location = new System.Drawing.Point(449, -4);
            this.pbxFlavor2.Name = "pbxFlavor2";
            this.pbxFlavor2.Size = new System.Drawing.Size(150, 150);
            this.pbxFlavor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFlavor2.TabIndex = 14;
            this.pbxFlavor2.TabStop = false;
            this.pbxFlavor2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 484);
            this.Controls.Add(this.lblFlavor);
            this.Controls.Add(this.pbxFlavor2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbxCone);
            this.Controls.Add(this.pbxFlavor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlavor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFlavor2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.RadioButton rbVanilla;
        private System.Windows.Forms.Label lblFlavor;
        private System.Windows.Forms.RadioButton rbStrawberry;
        private System.Windows.Forms.PictureBox pbxCone;
        private System.Windows.Forms.PictureBox pbxFlavor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbChocolate2;
        private System.Windows.Forms.RadioButton rbVanilla2;
        private System.Windows.Forms.RadioButton rbStrawberry2;
        private System.Windows.Forms.PictureBox pbxFlavor2;

    }
}

