﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeButtonArray();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Shift";
            button1.Font = new Font("Arial", (float)12.5);
            button2.Text = "Caps";
            button2.Font = new Font("Arial", (float)12.5);
            button3.Text = "EN";
            button3.Font = new Font("Arial", (float)10.5);
            button3.BackColor = Color.Bisque;
            button4.Text = "UA";
            button4.Font = new Font("Arial", (float)10.5);
            button4.BackColor = Color.Beige;
            button5.Text = "Space";
            button5.Font = new Font("Arial", (float)12.5);
            button6.Text = "Shift";
            button6.Font = new Font("Arial", (float)12.5);
            button7.Text = "TAB";
            button7.Font = new Font("Arial", (float)12.5);
            button8.Text = "Backspace";
            button8.Font = new Font("Arial", (float)12.5);
            button9.Text = "Enter";
            button9.Font = new Font("Arial", (float)12.5);
            button10.Text = "`";
            button10.BackColor = Color.LightCyan;
            button10.Font = new Font("Arial", (float)15);
            button5.BackColor = Color.LightSalmon;
            button6.BackColor = Color.LightSalmon;
            button7.BackColor = Color.LightSalmon;
            button8.BackColor = Color.LightSalmon;
            button9.BackColor = Color.LightSalmon;
            button10.BackColor = Color.LightSalmon;
            button1.BackColor = Color.LightSalmon;
            button2.BackColor = Color.LightSalmon;
            richTextBox1.Font = new Font("Arial", 12);
        }
        private Button[] buttonArray;
        bool shift = false;
        bool capse = false;

        private void InitializeButtonArray()
        {
            buttonArray = new Button[26];

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                char c = (char)(i + 97);
                buttonArray[i].Text = c.ToString();
                buttonArray[i].BackColor = Color.LightCyan;
                buttonArray[i].Font = new Font("Arial", 15);
                buttonArray[i].Size = new System.Drawing.Size(45, 45);
                int x = 0; int y = 0;
                if (i < 13)
                {
                    y = 365;
                    x = 55 * i + 95;
                }
                else
                {
                    y = 415;
                    x = 55 * (i - 13) + 95;
                }
                buttonArray[i].Location = new System.Drawing.Point(x, y);
                // Используем замыкание для передачи индекса кнопки в обратном событии Click
                int index = i;
                buttonArray[i].Click += (sender, e) => Button_Click(sender, e, index);
                this.Controls.Add(buttonArray[i]);
            }
        }

        private void Button_Click(object sender, EventArgs e, int buttonIndex)
        {
            //label1.Text = "but: " + buttonArray[buttonIndex].Text;

            if (shift && capse)
            {
                richTextBox1.Text += buttonArray[buttonIndex].Text;
                shift = false;
                button1.BackColor = Color.White;
                button6.BackColor = Color.White;
                //buttonArray[e].BackColor = Color.White;
            }
            else if (shift || capse)
            {
                richTextBox1.Text += buttonArray[buttonIndex].Text.ToUpper();
                shift = false;
                button1.BackColor = Color.White;
                button6.BackColor = Color.White;
            }
            else
                richTextBox1.Text += buttonArray[buttonIndex].Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            shift = true;
            button1.BackColor = Color.MistyRose;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (capse)
            {
                capse = false;
                button2.BackColor = Color.White;
            }
            else
            {
                capse = true;
                button2.BackColor = Color.MistyRose;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Font = new Font("Arial", (float)10.5);
            button3.BackColor = Color.Bisque;
            button4.Text = "UA";
            button4.Font = new Font("Arial", (float)10.5);
            button4.BackColor = Color.Beige;

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                char c = (char)(i + 97);
                buttonArray[i].Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.Font = new Font("Arial", (float)10.5);
            button4.BackColor = Color.Bisque;
            button4.Text = "UA";
            button4.Font = new Font("Arial", (float)10.5);
            button3.BackColor = Color.Beige;

            for (int i = 0; i < buttonArray.Length; i++)
            {
                buttonArray[i] = new Button();
                char c = (char)(i + 160);
                buttonArray[i].Text = c.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = " ";
            richTextBox1.Text += str;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shift = true;
            button6.BackColor = Color.MistyRose;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string str = "    ";
            richTextBox1.Text += str;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string str = "`";
            richTextBox1.Text += str;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Environment.NewLine);
        }
    }
}