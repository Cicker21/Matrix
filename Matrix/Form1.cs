using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Matrix
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            func();
            func3();
            
        }
        
        public async void func()
        {


            while (true) /// ■ > ■
            {

                string full = RandomString(838);

                string str = full.Substring(0, 28);
                string str2 = full.Substring(30, 28);
                string str3 = full.Substring(60, 28);
                string str4 = full.Substring(90, 28);
                string str6 = full.Substring(120, 28);
                string str7 = full.Substring(150, 28);
                string str8 = full.Substring(180, 28);
                string str9 = full.Substring(210, 28);
                string str10 = full.Substring(240, 28);
                string str11 = full.Substring(270, 28);
                string str12 = full.Substring(300, 28);
                string str13 = full.Substring(330, 28);
                string str14 = full.Substring(360, 28);
                string str15 = full.Substring(390, 28);
                string str16 = full.Substring(420, 28);
                string str17 = full.Substring(450, 28);
                string str18 = full.Substring(480, 28);
                string str19 = full.Substring(510, 28);
                string str20 = full.Substring(540, 28);
                string str21 = full.Substring(570, 28);
                string str22 = full.Substring(600, 28);
                string str23 = full.Substring(630, 28);
                string str24 = full.Substring(660, 28);
                string str25 = full.Substring(690, 28);
                string str26 = full.Substring(720, 28);




                textBox1.Text = str;
                textBox2.Text = str2;
                textBox3.Text = str3;
                textBox4.Text = str4;
                textBox5.Text = str16;
                textBox6.Text = str6;
                textBox7.Text = str7;
                textBox8.Text = str8;
                textBox9.Text = str9;
                textBox10.Text = str10;
                textBox11.Text = str11;
                textBox12.Text = str12;
                textBox13.Text = str13;
                textBox14.Text = str14;
                textBox15.Text = str15;
                textBox16.Text = str17;
                textBox17.Text = str18;
                textBox18.Text = str19;
                textBox19.Text = str20;
                textBox20.Text = str21;
                textBox21.Text = str22;
                textBox22.Text = str23;
                textBox23.Text = str24;
                textBox24.Text = str25;
                textBox25.Text = str26;
                



                await Task.Delay(1000);

            }



        }
        public void func2(string S)
        {
            
                int ancho = this.Width;
                int num = RandomNum(0, ancho);




            if (S == "textBox1")
            {
                textBox1.Left = num;
            }
            if ( S == "textBox2")
            {
                textBox2.Left = num;
            }
            if ( S == "textBox3")
            {
                textBox3.Left = num;
            }
            if ( S == "textBox4")
            {
                textBox4.Left = num;
            }
            if ( S == "textBox5")
            {
                textBox5.Left = num;
            }
            if ( S == "textBox6")
            {
                textBox6.Left = num;
            }
            if ( S == "textBox7")
            {
                textBox7.Left = num;
            }
            if ( S == "textBox8")
            {
                textBox8.Left = num;
            }
            if ( S == "textBox9")
            {
                textBox9.Left = num;
            }
            if ( S == "textBox10")
            {
                textBox10.Left = num;
            }
            if ( S == "textBox11")
            {
                textBox11.Left = num;
            }
            if ( S == "textBox12")
            {
                textBox12.Left = num;
            }
            if ( S == "textBox13")
            {
                textBox13.Left = num;
            }
            if ( S == "textBox14")
            {
                textBox14.Left = num;
            }
            if (S == "textBox15")
            {
                textBox15.Left = num;
            }
            if (S == "textBox16")
            {
                textBox16.Left = num;

            }
            if (S == "textBox17")
            {
                textBox17.Left = num;
            }
            if (S == "textBox18")
            {
                textBox18.Left = num;
            }
            if (S == "textBox19")
            {
                textBox19.Left = num;
            }
            if (S == "textBox20")
            {
                textBox20.Left = num;
            }
            if (S == "textBox21")
            {
                textBox21.Left = num;
            }
            if (S == "textBox22")
            {
                textBox22.Left = num;
            }
            if (S == "textBox23")
            {
                textBox23.Left = num;
            }
            if (S == "textBox24")
            {
                textBox24.Left = num;
            }
            if (S == "textBox25")
            {
                textBox25.Left = num;
            }




        }
        public async void func3()
        {
            int alto = this.Height;
            int vel = 5;
            while (true)
            {
                textBox1.Top = textBox1.Top + vel;
                textBox2.Top = textBox2.Top + vel;
                textBox3.Top = textBox3.Top + vel;
                textBox4.Top = textBox4.Top + vel;
                textBox5.Top = textBox5.Top + vel;
                textBox6.Top = textBox6.Top + vel;
                textBox7.Top = textBox7.Top + vel;
                textBox8.Top = textBox8.Top + vel;
                textBox9.Top = textBox9.Top + vel;
                textBox10.Top = textBox10.Top + vel;
                textBox11.Top = textBox11.Top + vel;
                textBox12.Top = textBox12.Top + vel;
                textBox13.Top = textBox13.Top + vel;
                textBox14.Top = textBox14.Top + vel;
                textBox15.Top = textBox15.Top + vel;
                textBox16.Top = textBox16.Top + vel;
                textBox17.Top = textBox17.Top + vel;
                textBox18.Top = textBox18.Top + vel;
                textBox19.Top = textBox19.Top + vel;
                textBox20.Top = textBox20.Top + vel;
                textBox21.Top = textBox21.Top + vel;
                textBox22.Top = textBox22.Top + vel;
                textBox23.Top = textBox23.Top + vel;
                textBox24.Top = textBox24.Top + vel;
                textBox25.Top = textBox25.Top + vel;

                if (textBox1.Top > this.Height)
                {
                    func2("textBox1");
                    textBox1.Top = 0;

                }
                if (textBox2.Top > this.Height)
                {
                    func2("textBox1");
                    textBox2.Top = 0;

                }
                if (textBox3.Top > this.Height)
                {
                    func2("textBox2");
                    textBox1.Top = 0;

                }
                if (textBox3.Top > this.Height)
                {
                    func2("textBox3");
                    textBox3.Top = 0;

                }
                if (textBox4.Top > this.Height)
                {
                    func2("textBox4");
                    textBox4.Top = 0;

                }
                if (textBox5.Top > this.Height)
                {
                    func2("textBox5");
                    textBox5.Top = 0;

                }
                if (textBox6.Top > this.Height)
                {
                    func2("textBox6");
                    textBox6.Top = 0;

                }
                if (textBox7.Top > this.Height)
                {
                    func2("textBox7");
                    textBox7.Top = 0;

                }
                if (textBox8.Top > this.Height)
                {
                    func2("textBox8");
                    textBox8.Top = 0;

                }
                if (textBox9.Top > this.Height)
                {
                    func2("textBox9");
                    textBox9.Top = 0;

                }
                if (textBox10.Top > this.Height)
                {
                    func2("textBox10");
                    textBox10.Top = 0;


                }
                if (textBox11.Top > this.Height)
                {
                    func2("textBox11");
                    textBox11.Top = 0;

                }
                if (textBox12.Top > this.Height)
                {
                    func2("textBox12");
                    textBox12.Top = 0;

                }
                if (textBox13.Top > this.Height)
                {
                    func2("textBox13");
                    textBox13.Top = 0;

                }
                if (textBox14.Top > this.Height)
                {
                    func2("textBox14");
                    textBox14.Top = 0;

                }
                if (textBox15.Top > this.Height)
                {
                    func2("textBox15");
                    textBox15.Top = 0;

                }
                if (textBox16.Top > this.Height)
                {
                    func2("textBox16");
                    textBox16.Top = 0;

                }
                if (textBox17.Top > this.Height)
                {
                    func2("textBox17");
                    textBox17.Top = 0;

                }
                if (textBox18.Top > this.Height)
                {
                    func2("textBox18");
                    textBox18.Top = 0;

                }
                if (textBox19.Top > this.Height)
                {
                    func2("textBox19");
                    textBox19.Top = 0;

                }
                if (textBox20.Top > this.Height)
                {
                    func2("textBox20");
                    textBox20.Top = 0;

                }
                if (textBox21.Top > this.Height)
                {
                    func2("textBox21");
                    textBox21.Top = 0;

                }
                if (textBox22.Top > this.Height)
                {
                    func2("textBox22");
                    textBox22.Top = 0;

                }
                if (textBox23.Top > this.Height)
                {
                    func2("textBox23");
                    textBox23.Top = 0;

                }
                if (textBox24.Top > this.Height)
                {
                    func2("textBox24");
                    textBox24.Top = 0;

                }
                if (textBox25.Top > this.Height)
                {
                    func2("textBox25");
                    textBox25.Top = 0;

                }


                ///this.Text = textBox1.Top.ToString() + " / " + this.Height;

                

                await Task.Delay(100);

            }

        }
        public string RandomString(int length)
        {
            const string valid = "帝阵是数字的的元素通常被称为冠状病毒大地死亡混蛋狗屎妓女便宜蟑螂脏脏阴暗葬礼饥饿感钚汞锶金币";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]+"\n");
            }
            return res.ToString();
        }
        public int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


