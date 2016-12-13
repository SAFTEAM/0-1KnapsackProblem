using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//FARUK ALBAYRAK SAMET TOPAKKAYA ANIL GÜRBÜZ 
namespace _0_1KnapsackProblem
{
    public partial class Form1 : Form
    {
        ArrayList v_list = new ArrayList();
        ArrayList w_list = new ArrayList();
        int a = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void printSelectedItems(bool[,] keep, int sackCapacity, int[] values, int[] weights)
        {
            int K = sackCapacity;
            int n = values.Length;
            int wsel = 0;
            int vsel = 0;           
            for (int i = n - 1; i >= 0; i--)
            {
                if (keep[i, K] == true)
                {
                    lvSelectedItems.Items.Add("V=" + values[i]);
                    lvSelectedItems.Items.Add("W=" + weights[i]);
                    wsel += weights[i];
                    vsel += values[i];
                    K = K - weights[i];
                }
            }
            lblMaxValue.Text = "Max Value:" + vsel;
            lblMaxWeight.Text = "Max Weight:" + wsel;
        }
        public bool[,] knapsack(int[] values, int[] weights, int sackCapacity)
        {
            int nItems = values.Length;
            int[,] dpTable = new int[nItems + 1, sackCapacity + 1];
            bool[,] keep = new bool[nItems, sackCapacity + 1];

            for (int i = 1; i <= nItems; i++)
            {
                for (int w = 1; w <= sackCapacity; w++)
                {
                    if (weights[i - 1] > w)
                    {
                        dpTable[i, w] = dpTable[i - 1, w];
                    }
                    else
                    {
                        int pYes = values[i - 1] + dpTable[i - 1, w - weights[i - 1]];
                        int pNo = dpTable[i - 1, w];
                        if (pYes > pNo)
                        {
                            keep[i - 1, w] = true;
                            dpTable[i, w] = pYes;
                        }
                        else
                        {
                            dpTable[i, w] = pNo;
                        }
                    }
                }
            }
            lvTable.Width = (sackCapacity + 1) * (44);
            for (int a = 0; a <= nItems; a++)
            {
                for (int b = 0; b <= sackCapacity; b++)
                {
                    lvTable.Items.Add(Convert.ToString((dpTable[a, b])));
                }
            }
            return keep;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txbWeight.Text != "" | txbVariable.Text != "" | txbValue.Text != "")
            {
                lvInserted.Items.Add(txbVariable.Text);
                lvInserted.Items[a].SubItems.Add(txbValue.Text);
                lvInserted.Items[a].SubItems.Add(txbWeight.Text);
                w_list.Add(Convert.ToInt32(txbWeight.Text));
                v_list.Add(Convert.ToInt32(txbValue.Text));
                a++;
                txbValue.Clear();
                txbVariable.Clear();
                txbWeight.Clear();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            resetle();
            if (txbCapacity.Text != "")
            {
               
                int[] values = new int[v_list.Count];
                int[] weights = new int[w_list.Count];
                for (int i = 0; i < v_list.Count; i++)
                {
                    values[i] = Convert.ToInt32(v_list[i]);
                    weights[i] = Convert.ToInt32(w_list[i]);
                }
                int sackCapacity = Convert.ToInt32(txbCapacity.Text);
                bool[,] keep = knapsack(values, weights, sackCapacity);
                printSelectedItems(keep, sackCapacity, values, weights);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            lvInserted.Items.Clear();
            txbValue.Clear();
            txbVariable.Clear();
            txbWeight.Clear();
            lvTable.Clear();
            txbCapacity.Clear();
            lvSelectedItems.Clear();
            lblMaxValue.Text = "";
            lblMaxWeight.Text = "";
            a = 0;
        }
        public void resetle()
        {
            
            txbValue.Clear();
            txbVariable.Clear();
            txbWeight.Clear();
            lvTable.Clear();
            lvSelectedItems.Clear();
            lblMaxValue.Text = "";
            lblMaxWeight.Text = "";
            a = 0;
        }
    }
}
