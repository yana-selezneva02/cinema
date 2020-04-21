using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           if (textBox2.Text == "abcd@mail.ru" && textBox1.Text == "12345678")
           {

               Form form = new Form5();
               form.Show();
               this.Hide();
           }
            
           else
            MessageBox.Show("Электронная почта или пароль введены неверно");



            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
        }


      