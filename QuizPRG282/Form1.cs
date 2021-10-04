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

namespace QuizPRG282
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// message 1 
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\nehal\source\repos\QuizPRG282\QuizPRG282\bin\Debug\PRG282Quiz.txt";

            StreamReader sr = new StreamReader(path);
            string data = sr.ReadToEnd();
            richTextBox1.Text = data;
            sr.Close(); 


            //using (StreamReader sr = File.OpenText(path))
            //{
            //    string s = "";
            //    while ((s = sr.ReadLine()) != null)
            //    {
            //        richTextBox1.Text = s; 

            //    }
            //}
            
            
            
        }
    }
}
