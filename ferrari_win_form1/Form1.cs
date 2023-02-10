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
        //dichiarazione
        public string[] array;
        public int lunghezza;

        //funzioni degli eventi
        public Form1()
        {
            InitializeComponent();
            array = new string[100];

        }
        private void Form1_Load(object sender, EventArgs e)
        {

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

        }
        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button10_Click(object sender, EventArgs e)
        {

        }

        //funzioni di servizio
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
        static void BubbleSort(int lun, string[] arr)
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
        }                         //bubblesort
    }
}