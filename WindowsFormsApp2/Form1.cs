using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            button4.Text = "UA";
            button4.Font = new Font("Arial", (float)10.5);
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
                //buttonArray[i].Text = "Кнопка " + (buttonArray[i]);
                //buttonArray[i].Location = new System.Drawing.Point(20, 20 + i * 30);
                buttonArray[i].BackColor = Color.LightCyan;
                buttonArray[i].Size = new System.Drawing.Size(30, 23);
                int x = 0; int y = 0;
                if (i < 10)
                {
                    y = 300;
                    x = 40 * i + 40;
                }
                else
                {
                    y = 350;
                    x = 40 * (i - 10) + 40;
                }
                buttonArray[i].Location = new System.Drawing.Point(20, 20 + i * 30);
                // Используем замыкание для передачи индекса кнопки в обратном событии Click
                int index = i;
                buttonArray[i].Click += (sender, e) => Button_Click(sender, e, index);
                this.Controls.Add(buttonArray[i]);
            }
        }

        private void Button_Click(object sender, EventArgs e, int buttonIndex)
        {
            label1.Text = "but: " + buttonArray[buttonIndex].Text;

            //if (shift && capse)
            //{
            //    richTextBox1.Text += b1.Text;
            //    shift = false;
            //    button1.BackColor = Color.White;
            //    buttonArray[e].BackColor = Color.White;
            //}
            //else if (shift || capse)
            //{
            //    richTextBox1.Text += b1.Text.ToUpper();
            //    shift = false;
            //    button1.BackColor = Color.White;
            //}
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
        
    }
}