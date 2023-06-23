﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }


        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox2.Text);
            textBox2.Text = "";
            textBox2.Focus();
        }

        
        
        private void button3_Click(object sender, EventArgs e)
        {
            foreach(var items in listBox1.Items)
            {
                listBox2.Items.Add(items);

            }
            listBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int index = listBox1.SelectedIndex;
                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(index);
            }

            if(listBox1.SelectedItem != null)
            {
                listBox1.SelectedIndex = 0;
                listBox2.Items.Add(listBox1.SelectedItem);
            }
            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                int index = listBox2.SelectedIndex;
                listBox1.Items.Add(listBox2.SelectedItem);
                listBox2.Items.RemoveAt(index);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (var items in listBox2.Items)
            {
                listBox1.Items.Add(items);
            }
            listBox2.Items.Clear();

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox2.Items.Add(textBox2.Text);
                textBox2.Text = "";
                textBox2.Focus();
            }
        }
    }
}
