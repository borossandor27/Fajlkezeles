using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Betoltes_Mentes
{
    public partial class Form1 : Form
    {
        string filter = "Minden fájl (*.*)|*.*|Szövegfájl (*.txt)|*.txt|struktúrált szövegfájl (*.xml)|*.xml"; 

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     A létrejött objektumok futásidejű kezdeti beállításai
        /// </summary>
        /// <param name="sender">A létrejött Form példányunk</param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker_Szuletesi_Datum.MaxDate = DateTime.Today.AddYears(-18);  //-- Legalább 18 évesnek kell lennie
            dateTimePicker_Szuletesi_Datum.MinDate = DateTime.Today.AddYears(-150); //-- Maximum 150 éves lehet
            dateTimePicker_Szuletesi_Datum.Value = DateTime.Today.AddYears(-35);    //-- A megjelenítéskor kb. átlagnak jó
            this.AcceptButton = button_Hobbit_hozzaad;  //-- ENTER leütésre hobbit hozzáad a listához
        }

        /// <summary>
        ///     Csak betű, whitespace (szóköz, tabulátor,...) és pont a "dr." miatt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Csak_betuket_enged(object sender, EventArgs e)
        {
            textBox_nev.Text = string.Concat(textBox_nev.Text.Where(c => char.IsLetter(c) || char.IsWhiteSpace(c) || c.Equals('.')));
            textBox_nev.SelectionStart = textBox_nev.Text.Length + 1;
        }

        private void button_Hobbit_hozzaad_Click(object sender, EventArgs e)
        {
            string uj = textBox_Ujhobbi.Text.Trim();
            if (uj.Length<1)
            {
                return;
            }
            if (ListBox.NoMatches == listBox_Hobbik.FindStringExact(uj))
            {
                listBox_Hobbik.Items.Add(uj);   //-- Hozzáadjuk a listához
                textBox_Ujhobbi.Text = "";      //-- Kiürítjük a beviteli mezőt
                textBox_Ujhobbi.Focus();        //-- A mezőt tesszük aktívvá
                textBox_Ujhobbi.Select(0, 1);   //-- A kurzort pozicionáljuk
            }
        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
            //-- adatok ellenőrzése ----------------------------------------------------
            string nev = textBox_nev.Text.Trim();
            if (nev.Length<=6)
            {
                MessageBox.Show("A név legalább hat betűs kell legyen!");
                textBox_nev.Focus();
                textBox_nev.Select(textBox_nev.Text.Length, 1);
                return;
            }
            DateTime szulido = dateTimePicker_Szuletesi_Datum.Value;
            bool neme;
            if (!radioButton_ferfi.Checked && !radioButton_no.Checked)
            {
                MessageBox.Show("Nem adta meg a nemét!");
                return;
            }
            else
            {
                neme = radioButton_ferfi.Checked;
            }
            bool feliratkozik = checkBox_feliratkozom.Checked;
            Szemely szemely = new Szemely(nev, neme, szulido, feliratkozik, listBox_Hobbik.Items.OfType<string>().ToArray());
            //-- ellenőrzött adatok fájlba írása ---------------------------------------
            saveFileDialog1.Filter = filter;
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            saveFileDialog1.FileName = "szemely.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.WriteLine(szemely.toTXT());
                }
                textBox_nev.Text = "";
                listBox_Hobbik.Items.Clear();
                checkBox_feliratkozom.Checked = false;
            }
        }

        private void button_Betoltes_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = filter;
            openFileDialog1.FilterIndex = 2;    //-- a filterben a másodikat teszi alapértelmezetté
            openFileDialog1.FileName = "szemely.txt";   //-- alapértelmezett fájlnév
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Szemely szemely = new Szemely();
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        if (!szemely.fromTXT(sr.ReadLine()))
                        {
                            MessageBox.Show("Sérült adatok!", "Beolvasási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Form_Update(szemely);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Form_Update(Szemely szemely)
        {
            textBox_nev.Text = szemely.Nev;
            dateTimePicker_Szuletesi_Datum.Value = szemely.Szulido;
            if (szemely.Nem)
            {
                radioButton_ferfi.Checked = true;
                radioButton_no.Checked = false;
            }
            else
            {
                radioButton_ferfi.Checked = false;
                radioButton_no.Checked = true;
            }
            checkBox_feliratkozom.Checked = szemely.Feliratkozik;
            foreach (string item in szemely.Hobbik)
            {
                listBox_Hobbik.Items.Add(item);
            }
        }
    }
}
