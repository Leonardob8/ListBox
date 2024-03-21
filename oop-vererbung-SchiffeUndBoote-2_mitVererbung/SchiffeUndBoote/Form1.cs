using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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


        static bool NurBuchstaben(string text)
        {
            // Regex-Pattern, das nur Buchstaben zulässt
            string pattern = "^[a-zA-Z]+$";

            // Überprüfen, ob der übergebene Text dem Pattern entspricht
            return Regex.IsMatch(text, pattern);
        }

        static bool NurZahlen(string text)
        {
            // Regex-Pattern, das nur Buchstaben zulässt
            string pattern = "^[0-9]+$";

            // Überprüfen, ob der übergebene Text dem Pattern entspricht
            return Regex.IsMatch(text, pattern);
        }

    //-----
        private bool EnthältSonderzeichen(string text)
        {
            // Regex-Pattern, das nur Buchstaben und Zahlen zulässt
            string pattern = "^[a-zA-Z0-9]+$";
            // Überprüfen, ob der Text nicht dem Pattern entspricht (also Sonderzeichen enthält)
            return !Regex.IsMatch(text, pattern);
        }

        // Funktion zum Entfernen von Sonderzeichen aus dem Text
        private string EntferneSonderzeichen(string text)
        {
            // Regex-Pattern, das Sonderzeichen findet
            string pattern = "[^a-zA-Z0-9]";
            // Entfernen von Sonderzeichen aus dem Text und Rückgabe des bereinigten Texts
            return Regex.Replace(text, pattern, "");
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

        private void tbxVorname_TextChanged(object sender, EventArgs e)
        {
            if (!NurBuchstaben(tbxVorname.Text))
            {
                // Falls der Text nicht nur Buchstaben enthält, entferne die letzten eingegebenen Zeichen
                tbxVorname.Text = Regex.Replace(tbxVorname.Text, "[^a-zA-Z]", "");
                
               
            }
        }
        private void tbxNachname_TextChanged(object sender, EventArgs e)
        {
            if (!NurBuchstaben(tbxNachname.Text))
            {
                // Falls der Text nicht nur Buchstaben enthält, entferne die letzten eingegebenen Zeichen
                tbxNachname.Text = Regex.Replace(tbxNachname.Text, "[^a-zA-Z]", "");
                
            }
        }

        private void tbxStrasse_TextChanged(object sender, EventArgs e)
        {
            if (!NurBuchstaben(tbxStrasse.Text))
            {
                // Falls der Text nicht nur Buchstaben enthält, entferne die letzten eingegebenen Zeichen
                tbxStrasse.Text = Regex.Replace(tbxStrasse.Text, "[^a-zA-Z]", "");
             
            }
        }

        private void tbxHausnummer_TextChanged(object sender, EventArgs e)
        {
            if (EnthältSonderzeichen(tbxHausnummer.Text))
            {
                // Falls der Text Sonderzeichen enthält, entferne die letzten eingegebenen Zeichen
                tbxHausnummer.Text = EntferneSonderzeichen(tbxHausnummer.Text);
              
            }
        }

        private void tbxPlz_TextChanged(object sender, EventArgs e)
        {
            if (!NurZahlen(tbxPlz.Text))
            {
                // Falls der Text nicht nur Zahlen enthält, entferne die letzten eingegebenen Zeichen
                tbxPlz.Text = Regex.Replace(tbxPlz.Text, "[^0-9]", "");
               
            }
        }

        private void tbxOrt_TextChanged(object sender, EventArgs e)
        {
            if (!NurBuchstaben(tbxOrt.Text))
            {
                // Falls der Text nicht nur Buchstaben enthält, entferne die letzten eingegebenen Zeichen
                tbxOrt.Text = Regex.Replace(tbxOrt.Text, "[^a-zA-Z]", "");
               
            }
        }
    }
}
