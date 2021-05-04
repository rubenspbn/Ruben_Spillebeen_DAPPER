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

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            IService<Docent> service = GemeenschapFactory.GetDocentService();
            string voornaam = tbxVoornaam.Text;
            string familienaam = tbxFamilienaam.Text;
            decimal wedde = decimal.Parse(tbxWedde.Text);
            int campusNr = ((Campus)cmbCampus.SelectedItem).CampusNr;
            Docent docent = GemeenschapFactory.GetDocent(voornaam, familienaam, wedde, campusNr);
            await service.InsertAsync(docent);
            LoadDocenten();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCampussen();
            LoadDocenten();
        }

        private async void LoadCampussen()
        {
            IService<Campus> service = GemeenschapFactory.GetCampusService();
            cmbCampus.DisplayMember = "Naam";
            cmbCampus.ValueMember = "CampusNr";
            cmbCampus.DataSource = null;
            cmbCampus.DataSource = await service.GetAllAsync();
        }

        private async void LoadDocenten()
        {
            IService<Docent> service = GemeenschapFactory.GetDocentService();
            lbxDocenten.DataSource = null;
            lbxDocenten.DataSource = (await service.GetAllAsync()).Where(x => x.CampusNr == (int)cmbCampus.SelectedValue).ToList();
        }

        private void cmbCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblAddDocent.Text = $"Docent toevoegen aan campus {cmbCampus.Text}";
            LoadDocenten();
        }

        private async void lbxDocenten_SelectedIndexChanged(object sender, EventArgs e)
        {
            IService<Docent> service = GemeenschapFactory.GetDocentService();
            Docent docent = await service.GetAsync(((Docent)lbxDocenten.SelectedItem).DocentNr);
            lblDetailVoornaam.Text = docent.Voornaam;
            lblDetailFamilienaam.Text = docent.Familienaam;
            lblDetailWedde.Text = docent.Wedde.ToString();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            IService<Docent> service = GemeenschapFactory.GetDocentService();
            int nr = (await service.GetAsync(((Docent)lbxDocenten.SelectedItem).DocentNr)).DocentNr;
            await service.DeleteRowAsync(nr);
        }
    }
}
