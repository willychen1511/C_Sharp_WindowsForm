using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bubble_Sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[] data = new int[4];
            data[0] = Convert.ToInt32(txtInput1.Text);
            data[1] = Convert.ToInt32(txtInput2.Text);
            data[2] = Convert.ToInt32(txtInput3.Text);
            data[3] = Convert.ToInt32(txtInput4.Text);
            bubleSortLowToHigh(data);
            txtInput1.Text = data[0].ToString();
            txtInput2.Text = data[1].ToString();
            txtInput3.Text = data[2].ToString();
            txtInput4.Text = data[3].ToString();
        }
        public void bubleSortLowToHigh(int[] data)
        {
            int i, j, len, temp;
            len = data.GetUpperBound(0);
            for (i = len; i >= 0; i--)
            {
                for (j = 0; j <= (len - 1); j++)
                {
                    if (data[j + 1] < data[j])
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int[] data = new int[4];
            data[0] = Convert.ToInt32(txtInput1.Text);
            data[1] = Convert.ToInt32(txtInput2.Text);
            data[2] = Convert.ToInt32(txtInput3.Text);
            data[3] = Convert.ToInt32(txtInput4.Text);
            bubleSortHighToLow(data);
            txtInput1.Text = data[0].ToString();
            txtInput2.Text = data[1].ToString();
            txtInput3.Text = data[2].ToString();
            txtInput4.Text = data[3].ToString();
        }
        public void bubleSortHighToLow(int[] data)
        {
            int i, j, len, temp;
            len = data.GetUpperBound(0);
            for (i = len; i >= 0; i--)
            {
                for (j = 0; j <= (len - 1); j++)
                {
                    if (data[j + 1] > data[j])
                    {
                        temp = data[j + 1];
                        data[j + 1] = data[j];
                        data[j] = temp;
                    }
                }
            }
        }        
        private void button3_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(txtInput.Text);
            int[] data = new int[number];
            lbOutput2.Text = "已排序亂數: ";
            bubleSortRandom(data);
            for (int i = 0; i < number; i++)
            {
                lbOutput2.Text += data[i] + " ";                
            }
        }
        public void bubleSortRandom(int[] data)
        {
            int i, j, k, temp,len;
            len = data.GetUpperBound(0);
            lbOutput1.Text = "未排序亂數: ";
            Random random = new Random();
            for(i=0; i < len+1; i++)
            {
                data[i] = random.Next(1, 1000);
                lbOutput1.Text += data[i] + " ";
            }
            for( j=len; j >=0; j--)
            {
                for (k = 0; k <= (len - 1); k++)
                {
                    if (data[k + 1] < data[k])
                    {
                        temp = data[k + 1];
                        data[k + 1] = data[k];
                        data[k] = temp;
                    }
                }
            }                        
        }
    }
}
