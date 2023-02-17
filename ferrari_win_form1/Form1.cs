using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ferrari_win_form1
{
    public partial class Form1 : Form
    {
        #region dichiarazione
        public string[] array;
        public int lunghezza;
        int pos;
        #endregion
        #region funzioni degli eventi
        public Form1()
        {
            InitializeComponent();
            array = new string[100];
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Aggiunge la stringa inserita in input in coda all'array");
            toolTip2.SetToolTip(button3, "Cancella la stringa inserita in input per 1 occorrenza");
            toolTip3.SetToolTip(button5, "Ordina l'array in ordine alfabetico con il metodo Bubblesort");
            toolTip4.SetToolTip(button4, "Ricerca la stringa inserita in input e ne restituisce la posizione");
            toolTip5.SetToolTip(button9, "Restituisce il numero di ripetizioni dei nomi");
            toolTip6.SetToolTip(button8, "permette di modificare il nome trovato nella posizione inserito, inmmettendo il nuovo nome in input");
            toolTip8.SetToolTip(button6, "Restituisce il nome più lungo/più corto");
            toolTip9.SetToolTip(button10, "Cancella la stringa inserita in input per tutte le occorrenze");
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Aggiunta(ref lunghezza, array, textBox1.Text);
            for (int i = 0; i < lunghezza; i++)
            {
                listView1.Items.Add(array[i]);
            }
            textBox1.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Cancella(ref lunghezza, array, textBox1.Text);
            for (int i = 0; i < lunghezza; i++)
            {
                listView1.Items.Add(array[i]);
            }
            textBox1.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            BubbleSort(lunghezza, array);
            for (int i = 0; i < lunghezza; i++)
            {
                listView1.Items.Add(array[i]);
            }
            textBox1.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int outp = RicercaSequenziale(lunghezza, textBox1.Text, array);
            if (outp < 0)
            {
                MessageBox.Show("Nome non trovato");
            }
            else
            {
                MessageBox.Show($"Il nome {textBox1.Text} si trova in posizione {outp}");
            }
            textBox1.Text = "";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (lunghezza > 0)
            {
                string vis = VisualizzaRipetuti(lunghezza, array);
                if (vis != "")
                {
                    MessageBox.Show(vis);
                }
                else
                {
                    MessageBox.Show("Nessuna Ripetizione");
                }
            }
            else
            {
                MessageBox.Show("Array Vuoto");
            }
            textBox1.Text = "";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (lunghezza > 0)
            {
                pos = int.Parse(textBox2.Text);
                if (pos >= 0 && pos <= lunghezza)
                {
                    ModificaNome(array, textBox1.Text, pos);
                    listView1.Items.Clear();
                    for (int i = 0; i < lunghezza; i++)
                    {
                        listView1.Items.Add(array[i]);
                    }
                }
                else
                {
                    MessageBox.Show("Errore nell'input/posizione");
                }
            }
            else
            {
                MessageBox.Show("Array Vuoto");
            }
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (lunghezza > 0)
            {
                MessageBox.Show(LungoCorto(array, lunghezza));
            }
            else 
            {
                MessageBox.Show("Array Vuoto");
            }
            textBox1.Text = "";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            CancellaUguali(ref lunghezza, array, textBox1.Text);
            for (int i = 0; i < lunghezza; i++)
            {
                listView1.Items.Add(array[i]);
            }
            textBox1.Text = "";
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip4_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip5_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip6_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip8_Popup(object sender, PopupEventArgs e)
        {

        }
        private void toolTip9_Popup(object sender, PopupEventArgs e)
        {

        }
        #endregion
        #region funzioni di servizio
        void Aggiunta(ref int lunghezza, string[] arr, string agg)
        {
            arr[lunghezza] = agg;
            lunghezza++;
        }            //aggiunta
        void Cancella(ref int lunghezza, string[] arr, string can)
        {
            for (int i = 0; i < lunghezza; i++)
            {
                if (arr[i] == can)
                {
                    for (; i < lunghezza - 1; i++)
                    {
                        arr[i] = arr[i + 1];
                    }
                    lunghezza--;
                    break;
                }
            }
        }            //cancella
        void BubbleSort(int lun, string[] arr)
        {
            int x, y;
            string temp;
            for (x = 0; x < lun - 1; x++)
            {
                for (y = 0; y < lun - 1; y++)
                {
                    int comp = string.Compare(arr[y], arr[y + 1]);
                    if (comp == 1)
                    {
                        temp = arr[y];
                        arr[y] = arr[y + 1];
                        arr[y + 1] = temp;
                    }
                }
            }
        }                                //bubblesort
        int RicercaSequenziale(int lun, string ric, string[] arr)
        {
            int pos = 0;
            for (int i = 0; i < lun; i++)
            {
                if (arr[i] == ric)
                {
                    pos = i;
                    break;
                }
                else
                {
                    pos = -1;
                }
            }
            return pos;
        }            //ricerca
        string VisualizzaRipetuti(int lun, string[] arr)
        {
            int[] occorrenze = new int[lun];
            string[] uni = new string[lun];
            string outp = "";
            for (int i = 0; i < lun; i++)
            {
                uni[i] = arr[i];
            }
            int x, y;
            string temp;
            for (x = 0; x < lun - 1; x++)
            {
                for (y = 0; y < lun - 1; y++)
                {
                    int comp = string.Compare(uni[y], uni[y + 1]);
                    if (comp == 1)
                    {
                        temp = uni[y];
                        uni[y] = uni[y + 1];
                        uni[y + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < lun; i++)
            {
                if (uni[i] != "")
                {
                    occorrenze[i] = 1;
                    for (int j = i + 1; j < lun; j++)
                    {
                        if (uni[i] == uni[j])
                        {
                            uni[j] = "";
                            occorrenze[i]++;
                        }
                    }
                    if (occorrenze[i] > 1)
                    {
                        outp += ($"{uni[i]}: {occorrenze[i]}");
                    }
                }
            }
            return outp;
        }                       //visualizza ripetuti
        void ModificaNome(string[] arr, string nuovo, int posizione)
        {
            arr[posizione] = nuovo;
        }          //modifica nome
        string LungoCorto(string[] arr, int lun)
        {
            string lungo = arr[0], corto = arr[0];
            string outp = "";
            for (int i = 1; i < lun; i++)
            {

                if (arr[i].Length > lungo.Length)
                {
                    lungo = arr[i];
                }
                if (arr[i].Length < corto.Length)
                {
                    corto = arr[i];
                }
            }
            outp += ($"il nome più lungo è: {lungo}\nil nome più corto è: {corto}");
            return outp;
        }                               //ricerca nome più lungo/corto
        void CancellaUguali(ref int lunghezza, string[] arr, string can)
        {
            for (int i = 0; i < lunghezza; i++)
            {
                if (arr[i] == can)
                {
                    for (int j = i; j < lunghezza - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }
                    arr[lunghezza] = null;
                    i--;
                    lunghezza--;
                }
            }
        }       //cancella nomi uguali
        #endregion

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}