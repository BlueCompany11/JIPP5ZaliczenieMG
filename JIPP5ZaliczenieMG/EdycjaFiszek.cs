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
    public partial class EdycjaFiszek : Form
    {
        Notki pytanie;
        Notki odpowiedz;
        Zrodlo pytanieZrodlo;
        Zrodlo odpowiedzZrodlo;
        int idPojecia;
        int idFiszki;
        bool dodanie;
        public static EdycjaFiszek DodajFiszke(int idPojecia)
        {
            return new EdycjaFiszek(idPojecia, true);
        }
        public static EdycjaFiszek EdytujFiszke(int IdFiszki)
        {
            return new EdycjaFiszek(IdFiszki, false);
        }
        private EdycjaFiszek()
        {
            InitializeComponent();
        }
        private EdycjaFiszek(int id, bool dodaj)
        {
            InitializeComponent();
            if (dodaj == true)
            {
                dodanie = true;
                this.idPojecia = id;
            }
            else
            {
                dodanie = false;
                this.idFiszki = id;
                Model1 model1 = new Model1();
                Fiszki fiszka = model1.Fiszkis.Find(idFiszki);
                pytanie = model1.Notkis.Find(fiszka.pytanie);
                odpowiedz = model1.Notkis.Find(fiszka.odpowiedz);
                pytanieZrodlo = model1.Zrodloes.Find(pytanie.idZrodla);
                odpowiedzZrodlo = model1.Zrodloes.Find(odpowiedz.idZrodla);
                tbPytanie.Text = pytanie.tekst;
                tbOdpowiedz.Text = odpowiedz.tekst;
                tbPytanieZrodlo.Text = pytanieZrodlo.szczegoly;
                tbOdpowiedzZrodlo.Text = odpowiedzZrodlo.szczegoly;
            }
        }
        
        private void btPolecenie_Click(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            if (dodanie)
            {
                pytanieZrodlo = new Zrodlo { szczegoly = tbPytanieZrodlo.Text, typ = 1 };
                odpowiedzZrodlo = new Zrodlo { szczegoly = tbOdpowiedzZrodlo.Text, typ = 1 };
                pytanie = new Notki { tekst = tbPytanie.Text, Zrodlo = pytanieZrodlo };
                odpowiedz = new Notki { tekst = tbOdpowiedz.Text, Zrodlo = odpowiedzZrodlo };
                Fiszki fiszka = new Fiszki { idPojecie = idPojecia, Notki = odpowiedz, Notki1 = pytanie };
                model1.Fiszkis.Add(fiszka);
            }
            else
            {
                Fiszki fiszka = model1.Fiszkis.Find(idFiszki);
                pytanieZrodlo = new Zrodlo { szczegoly = tbPytanieZrodlo.Text, typ = 1 };
                odpowiedzZrodlo = new Zrodlo { szczegoly = tbOdpowiedzZrodlo.Text, typ = 1 };
                pytanie = new Notki { tekst = tbPytanie.Text, Zrodlo = pytanieZrodlo };
                odpowiedz = new Notki { tekst = tbOdpowiedz.Text, Zrodlo = odpowiedzZrodlo };
                fiszka.Notki.Zrodlo = odpowiedzZrodlo;
                fiszka.Notki = odpowiedz;
                fiszka.Notki1.Zrodlo = pytanieZrodlo;
                fiszka.Notki1 = odpowiedz;
                model1.Entry(fiszka).State = System.Data.Entity.EntityState.Modified;
            }
            model1.SaveChanges();
            this.Close();
        }

        private void btDodajPytanie_Click(object sender, EventArgs e)
        {
            //var FD = new System.Windows.Forms.OpenFileDialog();
            //if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string fileToOpen = FD.FileName;

            //    System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);

            //    //OR

            //    System.IO.StreamReader reader = new System.IO.StreamReader(fileToOpen);
            //}
        }

        private void btDodajOdpowiedz_Click(object sender, EventArgs e)
        {

        }
    }
}
