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
    public partial class Nauka : Form
    {
        int i;
        int iloscFiszek;
        List<Fiszki> fiszkis;
        public Nauka()
        {
            InitializeComponent();
            this.labelOdpowiedz.Visible = false;
            i = 0;
            ZaladujWszystkieFiszki();
        }
        private void ZaladujFiszke(int idFiszki)
        {

        }
        private void ZaladujWszystkieFiszki()
        {
            Model1 db = new Model1();
            fiszkis = db.Fiszkis.ToList();
            iloscFiszek = fiszkis.Count;
        }

        private void btPokazOdpowiedz_Click(object sender, EventArgs e)
        {
            this.labelOdpowiedz.Visible = true;
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            if (i >= iloscFiszek)
            {
                this.labelOdpowiedz.Text = "Zakończono naukę!";
            }
            else
            {
                this.labelOdpowiedz.Visible = false;
                this.labelQuestion.Text = fiszkis[i].Notki1.tekst;
                this.labelOdpowiedz.Text = fiszkis[i].Notki.tekst;
                //Model1 db = new Model1();
                //var daneFiszki = db.DaneFiszkis.Where(x => x.idFiszki == fiszkis[i].id).ToList();
                //daneFiszki[0].dataOstatniegoPowtorzenia = DateTime.Now;
                //db.Entry(daneFiszki[0]).State = System.Data.Entity.EntityState.Modified;
                //db.Entry(fiszkis[i]).State = System.Data.Entity.EntityState.Modified;
            }
            i++;
        }
    }
}
