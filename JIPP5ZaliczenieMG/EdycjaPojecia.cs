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
    public partial class EdycjaPojecia : Form
    {
        Pojecia pojecie;
        public EdycjaPojecia()
        {
            InitializeComponent();
            btDodaj.Text = "Dodaj";
            btDodaj.Click += BtDodaj_Click;
        }

        public EdycjaPojecia(int idPojecia)
        {
            InitializeComponent();
            btDodaj.Text = "Uaktualnij";
            btDodaj.Click += BtEdytuj_Click;
            Model1 db = new Model1();
            pojecie = db.Pojecias.Find(idPojecia);
            tbNazwa.Text = pojecie.nazwa;
            tbTag.Text = pojecie.tag;
        }

        private void BtDodaj_Click(object sender, EventArgs e)
        {
            string nazwa = this.tbNazwa.Text;
            string tag = this.tbTag.Text;
            Model1 db = new Model1();
            pojecie = new Pojecia { nazwa = nazwa, tag = tag };
            db.Pojecias.Add(pojecie);
            db.SaveChanges();
            this.Close();
        }

        private void BtEdytuj_Click(object sender, EventArgs e)
        {
            string nazwa = this.tbNazwa.Text;
            string tag = this.tbTag.Text;
            Model1 db = new Model1();
            pojecie.nazwa = tbNazwa.Text;
            pojecie.tag = tbTag.Text;
            db.Entry(pojecie).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            this.Close();
        }
        

    }
}
