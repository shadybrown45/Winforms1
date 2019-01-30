namespace Winformsapp_1
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(294, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "MY FIRST WINFORM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(393, 157);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(209, 20);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.Click += new System.EventHandler(this.label2_Click);
            this.tb_Name.TextChanged += new System.EventHandler(this.label1_Click);
            // 
            // tb_Button
            // 
            this.tb_Button.Location = new System.Drawing.Point(518, 211);
            this.tb_Button.Name = "tb_Button";
            this.tb_Button.Size = new System.Drawing.Size(84, 30);
            this.tb_Button.TabIndex = 3;
            this.tb_Button.Text = "Get Started";
            this.tb_Button.UseVisualStyleBackColor = true;
            this.tb_Button.Click += new System.EventHandler(this.tb_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(918, 504);
            this.Controls.Add(this.tb_Button);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "My First Winform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button tb_Button;
    }
}

