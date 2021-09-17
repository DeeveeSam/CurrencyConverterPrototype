
namespace Project_Converter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radbtnAdmin = new System.Windows.Forms.RadioButton();
            this.radbtnUser = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(686, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME! YOU ARE A/AN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radbtnUser);
            this.groupBox1.Controls.Add(this.radbtnAdmin);
            this.groupBox1.Location = new System.Drawing.Point(194, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radbtnAdmin
            // 
            this.radbtnAdmin.AutoSize = true;
            this.radbtnAdmin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnAdmin.Location = new System.Drawing.Point(18, 59);
            this.radbtnAdmin.Name = "radbtnAdmin";
            this.radbtnAdmin.Size = new System.Drawing.Size(95, 31);
            this.radbtnAdmin.TabIndex = 0;
            this.radbtnAdmin.TabStop = true;
            this.radbtnAdmin.Text = "Admin";
            this.radbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // radbtnUser
            // 
            this.radbtnUser.AutoSize = true;
            this.radbtnUser.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnUser.Location = new System.Drawing.Point(260, 59);
            this.radbtnUser.Name = "radbtnUser";
            this.radbtnUser.Size = new System.Drawing.Size(74, 31);
            this.radbtnUser.TabIndex = 1;
            this.radbtnUser.TabStop = true;
            this.radbtnUser.Text = "User";
            this.radbtnUser.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(601, 342);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 84);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radbtnUser;
        private System.Windows.Forms.RadioButton radbtnAdmin;
        private System.Windows.Forms.Button btnNext;
    }
}

