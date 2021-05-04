
namespace EindopgaveDapper
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
            this.cmbCampus = new System.Windows.Forms.ComboBox();
            this.lblCampus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbxDocenten = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbCampus
            // 
            this.cmbCampus.FormattingEnabled = true;
            this.cmbCampus.Location = new System.Drawing.Point(12, 110);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(452, 21);
            this.cmbCampus.TabIndex = 0;
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampus.Location = new System.Drawing.Point(12, 82);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(253, 25);
            this.lblCampus.TabIndex = 1;
            this.lblCampus.Text = "Selecteer een campus:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(393, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Campussen en docenten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecteer een docent:";
            // 
            // lbxDocenten
            // 
            this.lbxDocenten.FormattingEnabled = true;
            this.lbxDocenten.Location = new System.Drawing.Point(12, 180);
            this.lbxDocenten.Name = "lbxDocenten";
            this.lbxDocenten.Size = new System.Drawing.Size(452, 147);
            this.lbxDocenten.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 540);
            this.Controls.Add(this.lbxDocenten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCampus);
            this.Controls.Add(this.cmbCampus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCampus;
        private System.Windows.Forms.Label lblCampus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbxDocenten;
    }
}

