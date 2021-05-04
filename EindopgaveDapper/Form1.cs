using Gemeenschap.Interfaces;
using Gemeenschap.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EindopgaveDapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            IService service = GemeenschapFactory.GetService();
            string voornaam = tbxVoornaam.Text;
            string familienaam = tbxFamilienaam.Text;
            decimal wedde = decimal.Parse(tbxWedde.Text);
            int campusNr = ((Campus)cmbCampus.SelectedItem).CampusNr;
            Docent docent = GemeenschapFactory.GetDocent(voornaam, familienaam, wedde, campusNr);
            service.InsertDocent(docent);
            LoadDocenten();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCampussen();
        }

        private void LoadCampussen()
        {
            IService service = GemeenschapFactory.GetService();
            cmbCampus.DisplayMember = "Naam";
            cmbCampus.ValueMember = "CampusNr";
            cmbCampus.DataSource = null;
            cmbCampus.DataSource = service.GetAllCampus();
        }

        private void LoadDocenten()
        {
            IService service = GemeenschapFactory.GetService();
            lbxDocenten.DataSource = null;
            lbxDocenten.DataSource = (service.GetAllDocent()).Where(x => x.CampusNr == (int)cmbCampus.SelectedValue).ToList();
        }

        private void cmbCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAddDocent.Text = $"Docent toevoegen aan campus {cmbCampus.Text}";
            LoadDocenten();
        }

        private void lbxDocenten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxDocenten.SelectedIndex >-1)
            {
                Docent docent = (Docent)lbxDocenten.SelectedItem;
                lblDetailVoornaam.Text = docent.Voornaam;
                lblDetailFamilienaam.Text = docent.Familienaam;
                lblDetailWedde.Text = docent.Wedde.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            IService service = GemeenschapFactory.GetService();
            service.DeleteDocentRow(((Docent)lbxDocenten.SelectedItem).DocentNr);
            LoadDocenten();
        }
    }
}
