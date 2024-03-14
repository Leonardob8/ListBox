using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchiffeUndBoote
{
    public partial class Form1 : Form
    {
        //liste erstellen 
        List<Besitzer> Besitzers = new List<Besitzer>();


        public Form1()
        {
            InitializeComponent();
            //lbxbesitzer.DataSource = besitzers;
        }




        private void btnneubesitzer_Click(object sender, EventArgs e)
        {
            //Einfügen von werten 
            Besitzers.Add(new Besitzer(tbxVorname.Text, tbxNachname.Text, tbxStrasse.Text, tbxHausnummer.Text, tbxPlz.Text, tbxOrt.Text));

            lbxBesitzer.Items.Clear();

            for (int x = 0; x < Besitzers.Count; x++)
            {
                lbxBesitzer.Items.Add(Besitzers[x].Nachname + ", " + Besitzers[x].Vorname);
            }

            tbxVorname.Clear();
            tbxNachname.Clear();
            tbxStrasse.Clear();
            tbxHausnummer.Clear();
            tbxPlz.Clear();
            tbxOrt.Clear();

        }

        private void btnBearbeitenBesitzer_Click(object sender, EventArgs e)
        {

            //Werte in der ListBox bearbeiten/verändern

            int auswahl = lbxBesitzer.SelectedIndex;

            Besitzers[auswahl].Vorname = tbxVorname.Text;
            Besitzers[auswahl].Nachname = tbxNachname.Text;
            Besitzers[auswahl].Strasse = tbxStrasse.Text;
            Besitzers[auswahl].Hausnummer = tbxHausnummer.Text;
            Besitzers[auswahl].Plz = tbxPlz.Text;
            Besitzers[auswahl].Ort = tbxOrt.Text;


            lbxBesitzer.Items.Clear();

            for (int x = 0; x < Besitzers.Count; x++)
            {
                lbxBesitzer.Items.Add(Besitzers[x].Nachname + ", " + Besitzers[x].Vorname);
            }

            tbxVorname.Clear();
            tbxNachname.Clear();
            tbxStrasse.Clear();
            tbxHausnummer.Clear();
            tbxPlz.Clear();
            tbxOrt.Clear();

        }

        private void lbxbesitzer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Ausgabe von Werten
            // Index aus ListBox abfragen
            int auswahl = lbxBesitzer.SelectedIndex;

            tbxVorname.Text = Besitzers[auswahl].Vorname;
            tbxNachname.Text = Besitzers[auswahl].Nachname;
            tbxStrasse.Text = Besitzers[auswahl].Strasse;
            tbxHausnummer.Text = Besitzers[auswahl].Hausnummer;
            tbxPlz.Text = Besitzers[auswahl].Plz;
            tbxOrt.Text = Besitzers[auswahl].Ort;
                

        }

        private void mubesitzer(object sender, EventArgs e)
        {
            Form Form1 = new Form1();
            Form1.Show();
            this.Close();  

        }
    }
}
