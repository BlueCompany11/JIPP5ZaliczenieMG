using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JIPP5ZaliczenieMG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btDodajPojecie_Click(object sender, EventArgs e)
        {
            var form = new EdycjaPojecia();
            form.ShowDialog();
            AktualizacjaPojec();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AktualizacjaPojec();
            AktualizacjaFiszek();
        }

        void AktualizacjaFiszek()
        {
            Model2 db = new Model2();
            var lista = db.PodgladFiszeks.ToList();
            var bindingList = new BindingList<PodgladFiszek>(lista);
            var source = new BindingSource(bindingList, null);
            dataGridViewFiszki.DataSource = source;
        }

        private void AktualizacjaPojec()
        {
            Model1 db = new Model1();
            var lista = db.Pojecias.ToList();
            var bindingList = new BindingList<Pojecia>(lista);
            var source = new BindingSource(bindingList, null);
            dataGridViewPojecia.DataSource = source;
        }

        private void btUsunPojecie_Click(object sender, EventArgs e)
        {
            if (dataGridViewPojecia.SelectedRows.Count != 0)
            {
                Model1 db = new Model1();
                DataGridViewRow row = dataGridViewPojecia.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value);
                Pojecia nowePojecie = db.Pojecias.Find(id);
                db.Pojecias.Remove(nowePojecie);
                db.SaveChanges();
                AktualizacjaPojec();
            }
        }

        private void btEdytujPojecie_Click(object sender, EventArgs e)
        {
            if (dataGridViewPojecia.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewPojecia.SelectedRows[0];
                Model1 db = new Model1();
                int id = Convert.ToInt32(row.Cells[0].Value);
                //Pojecia nowePojecie = db.Pojecias.Find(id);
                var form = new EdycjaPojecia(id);
                form.ShowDialog();
                AktualizacjaPojec();
            }
        }

        private void btDodajFiszke_Click(object sender, EventArgs e)
        {
            if (dataGridViewPojecia.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewPojecia.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value);
                var form = EdycjaFiszek.DodajFiszke(id);
                form.ShowDialog();
                AktualizacjaFiszek();
            }
        }

        private void btUsunFiszke_Click(object sender, EventArgs e)
        {
            if (dataGridViewFiszki.SelectedRows.Count != 0)
            {
                Model1 db = new Model1();
                DataGridViewRow row = dataGridViewFiszki.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[0].Value);
                Fiszki fiszka = db.Fiszkis.Find(id);
                db.Fiszkis.Remove(fiszka);
                db.SaveChanges();
                AktualizacjaFiszek();
            }
        }

        private void btEdytujFiszke_Click(object sender, EventArgs e)
        {
            if (dataGridViewFiszki.SelectedRows.Count != 0)
            {
                DataGridViewRow row = dataGridViewFiszki.SelectedRows[0];
                int id = Convert.ToInt32(row.Cells[1].Value);
                var form = EdycjaFiszek.EdytujFiszke(id);
                form.ShowDialog();
                AktualizacjaFiszek();
            }
        }

        private void btNauka_Click(object sender, EventArgs e)
        {
            var form = new Nauka();
            form.ShowDialog();
        }
    }
}
