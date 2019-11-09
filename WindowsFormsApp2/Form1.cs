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
        Label l = new Label();
        Label res = new Label();
        List<string> list = new List<string>();
        List<string> listTotal = new List<string>();


        List<string> listPlayer1 = new List<string>();
        List<string> listPlayer2 = new List<string>();
        List<string> listPlayer3 = new List<string>();
        List<string> listPlayer4 = new List<string>();
        List<string> listPlayer5 = new List<string>();
                        
        int resultPlayer1 = 0;
        int resultPlayer2 = 0;
        int resultPlayer3 = 0;
        int resultPlayer4 = 0;
        int resultPlayer5 = 0;

        public Form1()
        {
            InitializeComponent();
            l.Text += "Player 1: \n";

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            l.Size = new Size(307, 156);

            bool repeat = false;
            for (int i=0; i<listTotal.Count; i++)
            {
               
                if (listTotal[i].ToString() == textBox1.Text.ToString())
                {
                    repeat = true;
                }
                
            }

            if (!repeat) {
            repeatLabel.Text = "";
            list.Add(textBox1.Text);
            listTotal.Add(textBox1.Text);
            l.Text += textBox1.Text + Environment.NewLine;
            textBox1.Text = string.Empty;
            panel1.Controls.Add(l);
            }
            else
            {
                repeatLabel.Text = "Repeat!";
            }
            
        }
        

        private void Finish_Click(object sender, EventArgs e)
        {

            Enter.Enabled = false;

            radioButton5.Enabled = false;
            radioButton5.Checked = false;

            resultPlayer5 = GetResult(listPlayer5);

            res.Size = new Size(307, 100);
            res.Text =
                "Player 1 result is: " + resultPlayer1
                + "\n Player 2 result is: " + resultPlayer2
                + "\n Player 3 result is: " + resultPlayer3
                + "\n Player 4 result is: " + resultPlayer4
                + "\n Player 5 result is: " + resultPlayer5 ;

            panel2.Controls.Add(res);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            list.Clear();
            l.Text = "";
            res.Text = "";
            Enter.Enabled = true;

            resultPlayer1 = 0;
            resultPlayer2 = 0;
            resultPlayer3 = 0;
            resultPlayer4 = 0;
            resultPlayer5 = 0;

            listPlayer1.Clear();
            listPlayer2.Clear();
            listPlayer3.Clear();
            listPlayer4.Clear();
            listPlayer5.Clear();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) { 
            radioButton1.Checked = false;
            radioButton1.Enabled = false;
            radioButton3.Enabled = true;
            
            listPlayer1 = list;
            resultPlayer1 = GetResult(listPlayer1);

                l.Text += "Player 2: \n";
                foreach (var item in list)
                {

                    listTotal.Add(item);
                }


            list.Clear();
}


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton2.Checked = false;
                radioButton2.Enabled = false;
                radioButton4.Enabled = true;
                l.Text += "Player 3: \n";

                listPlayer2 = list;
                resultPlayer2 = GetResult(listPlayer2);
                foreach (var item in list)
                {
                    listTotal.Add(item);
                }
                list.Clear();

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                radioButton3.Checked = false;
                radioButton3.Enabled = false;
                radioButton5.Enabled = true;
                l.Text += "Player 4: \n";

                listPlayer3 = list;
                resultPlayer3 = GetResult(listPlayer3);
                foreach (var item in list)
                {
                    listTotal.Add(item);
                }
                list.Clear();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                radioButton4.Checked = false;
                radioButton4.Enabled = false;

                l.Text += "Player 5: \n";
                listPlayer4 = list;
                resultPlayer4 = GetResult(listPlayer4);
                foreach (var item in list)
                {
                    listTotal.Add(item);
                }
                list.Clear();

            }
        }

        private int GetResult (List<string> wordslist)
        {
            int playerresult=0;
            for (int i = 0; i < wordslist.Count; i++)
            {
                if (list[i].Length == 3 || list[i].Length == 4)
                {
                    playerresult = playerresult + 1;
                }
                else if (list[i].Length == 5)
                {
                    playerresult = playerresult + 2;
                }
                else if (list[i].Length == 6)
                {
                    playerresult = playerresult + 3;
                }
                else if (list[i].Length == 7)
                {
                    playerresult = playerresult + 5;
                }
                else if (list[i].Length >= 8)
                {
                    playerresult = playerresult + 11;
                }


               

            }
            return playerresult;
        }
        
    }
}
