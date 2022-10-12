
namespace TEST_01
{
    partial class LandingPage
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
            this.btnDesignationLP = new System.Windows.Forms.Button();
            this.btnViewEmployeeLP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDesignationLP
            // 
            this.btnDesignationLP.Location = new System.Drawing.Point(202, 83);
            this.btnDesignationLP.Name = "btnDesignationLP";
            this.btnDesignationLP.Size = new System.Drawing.Size(167, 51);
            this.btnDesignationLP.TabIndex = 0;
            this.btnDesignationLP.Text = "Designation";
            this.btnDesignationLP.UseVisualStyleBackColor = true;
            this.btnDesignationLP.Click += new System.EventHandler(this.btnDesignationLP_Click);
            // 
            // btnViewEmployeeLP
            // 
            this.btnViewEmployeeLP.Location = new System.Drawing.Point(390, 83);
            this.btnViewEmployeeLP.Name = "btnViewEmployeeLP";
            this.btnViewEmployeeLP.Size = new System.Drawing.Size(167, 51);
            this.btnViewEmployeeLP.TabIndex = 1;
            this.btnViewEmployeeLP.Text = "View/Add Employee";
            this.btnViewEmployeeLP.UseVisualStyleBackColor = true;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewEmployeeLP);
            this.Controls.Add(this.btnDesignationLP);
            this.Name = "LandingPage";
            this.Text = "Landing Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDesignationLP;
        private System.Windows.Forms.Button btnViewEmployeeLP;
    }
}

