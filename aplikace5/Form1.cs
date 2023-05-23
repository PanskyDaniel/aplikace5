using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikace5
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private List<string> selectedFilePaths;
        private DateTime posledniDatumKontroly;
        private const int defaultInterval = 60;
        private bool inicializace = false;

        public Form1()
        {
            inicializace = true;
            InitializeComponent();
            inicializace = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            posledniDatumKontroly = DateTime.MinValue;

            timer = new Timer();
            timer.Tick += Timer_Tick;

            IntervalTextBox.Text = defaultInterval.ToString();
            NastavInterval_Click(null, null);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Kontrola_Click(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Soubory logu |*.log;*.txt";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePaths = openFileDialog.FileNames.ToList();
                    string[] fileNames = openFileDialog.SafeFileNames;
                    NazevSouboru.Text = string.Join(", ", fileNames);

                    NactiSoubory(selectedFilePaths);
                }
                else
                {
                    selectedFilePaths = new List<string>();
                    NazevSouboru.Text = string.Empty;
                }
            }
        }

        private void NactiSoubory(List<string> soubory)
        {
            foreach (string soubor in soubory)
            {
                string cesta = Path.GetDirectoryName(soubor);
                string nazev = Path.GetFileName(soubor);

                long filelength = new FileInfo(soubor).Length;
                double fileLengthMB = (double)filelength / (1024 * 1024);
                string velikost = fileLengthMB.ToString("0.###");

                DateTime filemodify = File.GetLastWriteTime(soubor);
                string posledniZmena = filemodify.ToString("dd.MM.yyyy HH:mm:ss");

                int rowCount = GetLineCount(soubor);
                string pocetRadku = rowCount.ToString();

                Seznam.Rows.Add(cesta, nazev, velikost, posledniZmena, pocetRadku, "", "", false); // Přidáme sloupec pro checkbox

            }
        }

        private int GetLineCount(string filePath)
        {
            int count = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    count++;
                }
            }

            return count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] filters = new[] { "*.log", "*.txt" };
            selectedFilePaths = new List<string>();

            using (FolderBrowserDialog folderDig = new FolderBrowserDialog())
            {
                folderDig.SelectedPath = "C:\\";

                if (folderDig.ShowDialog() == DialogResult.OK)
                {
                    foreach (string filter in filters)
                    {
                        var tmp = Directory.GetFiles(folderDig.SelectedPath, filter);
                        selectedFilePaths.AddRange(Directory.GetFiles(folderDig.SelectedPath, filter).ToList());
                    }

                    NactiSoubory(selectedFilePaths);
                }
            }
        }

        private void Kontrola_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Seznam.Rows)
            {
                int pocetRadku = 0;
                int maxRadku = 0;
                double fileLengthMB = 0;
                double maxFileSizeMB = 0;

                string cesta = (string)row.Cells["Cesta"].Value;
                string nazev = (string)row.Cells["Nazev"].Value;
                string strPocetRadku = (string)row.Cells["PocetRadku"].Value;
                string strMaxPocetRadku = (string)row.Cells["MaxPocetRadku"].Value;
                string strVelikost = (string)row.Cells["Velikost"].Value;
                string strMaxVelikost = (string)row.Cells["MaxVelikost"].Value;
                bool shouldCheck = (bool)row.Cells["ZmenaTest"].Value; // Získáme hodnotu checkboxu pro daný řádek

                DateTime filemodify = File.GetLastWriteTime(Path.Combine(cesta, nazev));
                if (filemodify > posledniDatumKontroly || shouldCheck)
                {

                    if (double.TryParse(strVelikost, out fileLengthMB) && double.TryParse(strMaxVelikost, out maxFileSizeMB))
                    {
                        if (fileLengthMB > maxFileSizeMB)
                        {
                            Log.Text += string.Format("Soubor {0} má větší velikost...", nazev) + Environment.NewLine;
                        }
                    }

                    if (int.TryParse(strPocetRadku, out pocetRadku) && int.TryParse(strMaxPocetRadku, out maxRadku))
                    {
                        if (pocetRadku > maxRadku)
                        {
                            Log.Text += string.Format("Soubor {0} má více řádků...", nazev) + Environment.NewLine;
                        }
                    }

                }

                row.Cells["PocetRadku"].Value = GetLineCount(Path.Combine(cesta, nazev)).ToString();

                long filelength = new FileInfo(Path.Combine(cesta, nazev)).Length;
                fileLengthMB = (double)filelength / (1024 * 1024);
                row.Cells["Velikost"].Value = fileLengthMB.ToString("0.###");

                row.Cells["PosledniZmena"].Value = filemodify.ToString("dd.MM.yyyy HH:mm:ss");
                row.Cells[ZmenaTest.Index].Value = false;
            }

            posledniDatumKontroly = DateTime.Now;
            PosDatKont.Text = posledniDatumKontroly.ToString("dd.MM.yyyy.HH:mm:ss");
        }

        private void NastavInterval_Click(object sender, EventArgs e)
        {
            int interval = 0;
            if (int.TryParse(IntervalTextBox.Text, out interval))
            {
                if (interval == 0)
                {
                    MessageBox.Show("Interval nesmí být 0 nula!");
                    return;
                }

                timer.Stop();
                timer.Interval = interval * 1000;
                timer.Start();
            }
        }

        private void Log_TextChanged(object sender, EventArgs e)
        {
            Log.SelectionStart = Log.TextLength;
            Log.ScrollToCaret();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Seznam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Seznam_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (inicializace)
                return;

            if (e.ColumnIndex == MaxPocetRadku.Index || e.ColumnIndex == MaxVelikost.Index)
            {
                Seznam.Rows[e.RowIndex].Cells[ZmenaTest.Index].Value = true;
            }
        }
    }
}
