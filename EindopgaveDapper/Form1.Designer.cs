
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
            this.lblAddDocent = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.tbxVoornaam = new System.Windows.Forms.TextBox();
            this.tbxFamilienaam = new System.Windows.Forms.TextBox();
            this.lblFamilienaam = new System.Windows.Forms.Label();
            this.tbxWedde = new System.Windows.Forms.TextBox();
            this.lblWedde = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDetailDocent = new System.Windows.Forms.Label();
            this.lblDetailWedde = new System.Windows.Forms.Label();
            this.lblDetailFamilienaam = new System.Windows.Forms.Label();
            this.lblDetailVoornaam = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbxDocenten = new System.Windows.Forms.ListBox();
            this.tbxDetailWedde = new System.Windows.Forms.TextBox();
            this.tbxDetailFamilienaam = new System.Windows.Forms.TextBox();
            this.tbxDetailVoornaam = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCampus
            // 
            this.cmbCampus.FormattingEnabled = true;
            this.cmbCampus.Location = new System.Drawing.Point(12, 110);
            this.cmbCampus.Name = "cmbCampus";
            this.cmbCampus.Size = new System.Drawing.Size(452, 21);
            this.cmbCampus.TabIndex = 0;
            this.cmbCampus.SelectedIndexChanged += new System.EventHandler(this.cmbCampus_SelectedIndexChanged);
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampus.Location = new System.Drawing.Point(7, 82);
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
            this.label1.Location = new System.Drawing.Point(7, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecteer een docent:";
            // 
            // lblAddDocent
            // 
            this.lblAddDocent.AutoSize = true;
            this.lblAddDocent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddDocent.Location = new System.Drawing.Point(7, 347);
            this.lblAddDocent.Name = "lblAddDocent";
            this.lblAddDocent.Size = new System.Drawing.Size(203, 25);
            this.lblAddDocent.TabIndex = 5;
            this.lblAddDocent.Text = "Docent toevoegen";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoornaam.Location = new System.Drawing.Point(12, 398);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(87, 20);
            this.lblVoornaam.TabIndex = 6;
            this.lblVoornaam.Text = "Voornaam:";
            // 
            // tbxVoornaam
            // 
            this.tbxVoornaam.Location = new System.Drawing.Point(247, 397);
            this.tbxVoornaam.Name = "tbxVoornaam";
            this.tbxVoornaam.Size = new System.Drawing.Size(217, 20);
            this.tbxVoornaam.TabIndex = 7;
            // 
            // tbxFamilienaam
            // 
            this.tbxFamilienaam.Location = new System.Drawing.Point(247, 444);
            this.tbxFamilienaam.Name = "tbxFamilienaam";
            this.tbxFamilienaam.Size = new System.Drawing.Size(217, 20);
            this.tbxFamilienaam.TabIndex = 9;
            // 
            // lblFamilienaam
            // 
            this.lblFamilienaam.AutoSize = true;
            this.lblFamilienaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFamilienaam.Location = new System.Drawing.Point(12, 445);
            this.lblFamilienaam.Name = "lblFamilienaam";
            this.lblFamilienaam.Size = new System.Drawing.Size(103, 20);
            this.lblFamilienaam.TabIndex = 8;
            this.lblFamilienaam.Text = "Familienaam:";
            // 
            // tbxWedde
            // 
            this.tbxWedde.Location = new System.Drawing.Point(247, 487);
            this.tbxWedde.Name = "tbxWedde";
            this.tbxWedde.Size = new System.Drawing.Size(217, 20);
            this.tbxWedde.TabIndex = 11;
            // 
            // lblWedde
            // 
            this.lblWedde.AutoSize = true;
            this.lblWedde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedde.Location = new System.Drawing.Point(12, 488);
            this.lblWedde.Name = "lblWedde";
            this.lblWedde.Size = new System.Drawing.Size(64, 20);
            this.lblWedde.TabIndex = 10;
            this.lblWedde.Text = "Wedde:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(247, 535);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(217, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Toevoegen";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDetailDocent
            // 
            this.lblDetailDocent.AutoSize = true;
            this.lblDetailDocent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailDocent.Location = new System.Drawing.Point(504, 82);
            this.lblDetailDocent.Name = "lblDetailDocent";
            this.lblDetailDocent.Size = new System.Drawing.Size(216, 25);
            this.lblDetailDocent.TabIndex = 14;
            this.lblDetailDocent.Text = "Details een docent:";
            // 
            // lblDetailWedde
            // 
            this.lblDetailWedde.AutoSize = true;
            this.lblDetailWedde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailWedde.Location = new System.Drawing.Point(505, 232);
            this.lblDetailWedde.Name = "lblDetailWedde";
            this.lblDetailWedde.Size = new System.Drawing.Size(64, 20);
            this.lblDetailWedde.TabIndex = 17;
            this.lblDetailWedde.Text = "Wedde:";
            // 
            // lblDetailFamilienaam
            // 
            this.lblDetailFamilienaam.AutoSize = true;
            this.lblDetailFamilienaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailFamilienaam.Location = new System.Drawing.Point(505, 189);
            this.lblDetailFamilienaam.Name = "lblDetailFamilienaam";
            this.lblDetailFamilienaam.Size = new System.Drawing.Size(103, 20);
            this.lblDetailFamilienaam.TabIndex = 16;
            this.lblDetailFamilienaam.Text = "Familienaam:";
            // 
            // lblDetailVoornaam
            // 
            this.lblDetailVoornaam.AutoSize = true;
            this.lblDetailVoornaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetailVoornaam.Location = new System.Drawing.Point(505, 142);
            this.lblDetailVoornaam.Name = "lblDetailVoornaam";
            this.lblDetailVoornaam.Size = new System.Drawing.Size(87, 20);
            this.lblDetailVoornaam.TabIndex = 15;
            this.lblDetailVoornaam.Text = "Voornaam:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(509, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(360, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Verwijderen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbxDocenten
            // 
            this.lbxDocenten.FormattingEnabled = true;
            this.lbxDocenten.Location = new System.Drawing.Point(12, 180);
            this.lbxDocenten.Name = "lbxDocenten";
            this.lbxDocenten.Size = new System.Drawing.Size(452, 147);
            this.lbxDocenten.TabIndex = 4;
            this.lbxDocenten.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbxDocenten_MouseDoubleClick);
            // 
            // tbxDetailWedde
            // 
            this.tbxDetailWedde.Location = new System.Drawing.Point(614, 234);
            this.tbxDetailWedde.Name = "tbxDetailWedde";
            this.tbxDetailWedde.Size = new System.Drawing.Size(217, 20);
            this.tbxDetailWedde.TabIndex = 21;
            // 
            // tbxDetailFamilienaam
            // 
            this.tbxDetailFamilienaam.Location = new System.Drawing.Point(614, 191);
            this.tbxDetailFamilienaam.Name = "tbxDetailFamilienaam";
            this.tbxDetailFamilienaam.Size = new System.Drawing.Size(217, 20);
            this.tbxDetailFamilienaam.TabIndex = 20;
            // 
            // tbxDetailVoornaam
            // 
            this.tbxDetailVoornaam.Location = new System.Drawing.Point(614, 144);
            this.tbxDetailVoornaam.Name = "tbxDetailVoornaam";
            this.tbxDetailVoornaam.Size = new System.Drawing.Size(217, 20);
            this.tbxDetailVoornaam.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(509, 304);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(360, 23);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Updaten";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 578);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbxDetailWedde);
            this.Controls.Add(this.tbxDetailFamilienaam);
            this.Controls.Add(this.tbxDetailVoornaam);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblDetailWedde);
            this.Controls.Add(this.lblDetailFamilienaam);
            this.Controls.Add(this.lblDetailVoornaam);
            this.Controls.Add(this.lblDetailDocent);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbxWedde);
            this.Controls.Add(this.lblWedde);
            this.Controls.Add(this.tbxFamilienaam);
            this.Controls.Add(this.lblFamilienaam);
            this.Controls.Add(this.tbxVoornaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.lblAddDocent);
            this.Controls.Add(this.lbxDocenten);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblCampus);
            this.Controls.Add(this.cmbCampus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCampus;
        private System.Windows.Forms.Label lblCampus;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAddDocent;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.TextBox tbxVoornaam;
        private System.Windows.Forms.TextBox tbxFamilienaam;
        private System.Windows.Forms.Label lblFamilienaam;
        private System.Windows.Forms.TextBox tbxWedde;
        private System.Windows.Forms.Label lblWedde;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDetailDocent;
        private System.Windows.Forms.Label lblDetailWedde;
        private System.Windows.Forms.Label lblDetailFamilienaam;
        private System.Windows.Forms.Label lblDetailVoornaam;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ListBox lbxDocenten;
        private System.Windows.Forms.TextBox tbxDetailWedde;
        private System.Windows.Forms.TextBox tbxDetailFamilienaam;
        private System.Windows.Forms.TextBox tbxDetailVoornaam;
        private System.Windows.Forms.Button btnUpdate;
    }
}

