using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fayl_meneceri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "All files *.* | *.*";
            sv.ShowDialog();

            if (sv.FileName.Length == 0)
            {
                MessageBox.Show("Sənəd seçilməyib", "Dayan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Text = sv.FileName;
                listBox1.Items.Add(sv.SafeFileName); 
            }
        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "All files *.* | *.*";
            sv.ShowDialog();

            if (sv.FileName.Length == 0)
            {
                MessageBox.Show("Sənəd seçilməyib", "Dayan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Text = sv.FileName;
                richTextBox1.Text = File.ReadAllText(sv.FileName);
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "All files *.* | *.*";
            sv.ShowDialog();

            if (sv.FileName.Length == 0)
            {
                MessageBox.Show("Sənəd seçilməyib", "Dayan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Text = sv.FileName;
                File.WriteAllText(sv.FileName, richTextBox1.Text);
                MessageBox.Show("Fayl yadda saxlanıldı", "Məlumat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Sənəd seçilməyib", "Dayan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult d = MessageBox.Show("Fayl silinsinmi?", "Sual", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (d == DialogResult.Yes)
                {
                    
                    File.Delete(textBox1.Text);

                    listBox1.Items.Remove(listBox1.SelectedItem);

                    
                    richTextBox1.Clear();
                    textBox1.Text = "";
                }
            }
        }
        

        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                textBox1.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog sv = new OpenFileDialog();
            sv.Filter = "All files *.* | *.*";
            sv.ShowDialog();

            if (sv.FileName.Length == 0)
            {
                MessageBox.Show("Sənəd seçilməyib", "Dayan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox1.Text = sv.FileName;         
                listBox1.Items.Add(sv.SafeFileName);  
            }
        }
    }
}