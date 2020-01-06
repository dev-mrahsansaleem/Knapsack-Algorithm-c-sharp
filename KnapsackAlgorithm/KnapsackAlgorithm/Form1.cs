using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnapsackAlgorithm
{
    public partial class Form1 : Form
    {
        int maxWeight = 0;//max capacity of bag that can carry 
        GFG mygfg = new GFG();
        List<cItem> selected = new List<cItem>();
        List<cItem> itemStore = new List<cItem>();
        public Form1()
        {
            InitializeComponent();
        }
        int[] arrayOfWeight(List<cItem> mylist)
        {
            List<int> myWt = new List<int>();
            foreach (cItem x in mylist)
            {
                myWt.Add(x.Weight);
            }
            return myWt.ToArray();
        }
        int[] arrayOfWorth(List<cItem> mylist)
        {
            List<int> myWt = new List<int>();
            foreach (cItem x in mylist)
            {
                myWt.Add(x.Worth);
            }
            return myWt.ToArray();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cItem item = new cItem();
            item.Name = textBox1.Text;
            item.Weight = Convert.ToInt32(textBox3.Text);
            try
            {
                item.Worth= Convert.ToInt32(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("invalid input in worth box");
            }

            itemStore.Add(item);
            maxWeight = Convert.ToInt32(textBox4.Text);
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = itemStore;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maxWeight = Convert.ToInt32(textBox4.Text);
            dataGridView2.DataSource = "";
            dataGridView2.DataSource = mygfg.printknapSack(itemStore, maxWeight, arrayOfWeight(itemStore), arrayOfWorth(itemStore), itemStore.Count);
            //knapsack(50, mybag.ItemStore);
        }
    }
}
