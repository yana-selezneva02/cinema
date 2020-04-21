using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    
    public partial class Form1 : Form
    {
        private RegionData path;
        public Form1()
        {
            InitializeComponent();

           /* this.button3.Size = new System.Drawing.Size(50, 50);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 50, 50);
            button3.Region = rgn;
            button3.Click += new EventHandler(button3_Click);*/
            var myPath = new System.Drawing.Drawing2D.GraphicsPath();
            myPath.AddEllipse(0, 0, 20, 20);
            Region myRegion = new Region(myPath);
            button3.Region = myRegion;
           

        }

     

        public System.Drawing.Region rgn { get; set; }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            Form form = new Form2();
            form.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new Form6();
            form.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Form7();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form8();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form9();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form10();
            form.Show();
            this.Hide();
        }

       
        }

      
        
        }

        

    
    



            
