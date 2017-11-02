using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace chartexample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
           /* int counter = 0;
            string text1 = System.IO.File.ReadAllText(@"C:\Users\承翰\Desktop\1.C# chart HomeWork\_sin100.txt");
            string text2 = System.IO.File.ReadAllText(@"C:\Users\承翰\Desktop\1.C# chart HomeWork\_cos100.txt");
            string text3 = System.IO.File.ReadAllText(@"C:\Users\承翰\Desktop\1.C# chart HomeWork\_sc100.txt");*/

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream mystream;
            int count = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select a File / Files";
            openFileDialog1.Multiselect = true;
            
            
            
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                foreach(string f in openFileDialog1.FileNames)
                { 
                StreamReader R = new StreamReader(f);
                //string filename = openFileDialog1.SafeFileName;
                //textBox1.Text = filename;
                try
                {
                    //if((mystream = openFileDialog1.OpenFile())!=null)
                    //{
                        
                        int counter = 0;
                        string line = R.ReadLine();
                        string[] split = new string[2];
                        string[,] alldata = new string[10000, 2];
                        while ((line = R.ReadLine()) != null)
                        {
                            split = line.Split(' ');
                            alldata[counter, 0] = split[0];
                            alldata[counter, 1] = split[1];
                            counter++;
                        }
                        for (int i=0;i<counter;i++)
                        {
                            if(count==0)
                             chart1.Series[count].Points.AddXY(alldata[i,0],alldata[i,1]);
                            else if(count==1)
                             chart1.Series[count].Points.AddXY(alldata[i,0], alldata[i,1]);
                            else if(count==2)
                             chart1.Series[count].Points.AddXY(alldata[i, 0], alldata[i, 1]);
                        }
                    //}
                }
                     catch
                     {
                        MessageBox.Show("Error: Could not read file from disk.  Original error: ");
                     }
                    count++;              //to different series;
            }


            
               
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
