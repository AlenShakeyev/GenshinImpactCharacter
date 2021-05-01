using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace Project
{

    public partial class Characterinfo : Form
    {
        public static Characterinfo instance;
        public Label lb1;
        public Label lb2;
        public Label lb25;
        public Label lb26;
        public Label lb3;
        public Label lb4;
        public Label lb5;
        public Label lb6;
        public Label lb7;
        public Label lb8;
        public Label lb9;
        public Button btn;
        public Characterinfo()
        {
            InitializeComponent();
            instance = this;
            lb1 = ha;
            lb2 = label3;
            lb25 = label2;
            lb26 = label10;
            lb3 = label4;
            lb4 = label5;
            lb5 = label6;
            lb6 = label7;
            lb7 = label8;
            lb8 = label9;
            lb9 = label11;
            btn = button1;
        }
        public class GenshinCharacter
        {
            public int id { get; set; }

            public string Name { get; set; }

            public string description { get; set; }

            public string gender { get; set; }

            public string birthday { get; set; }

            public int rarity { get; set; }

            public string vision { get; set; }

            public string weapon { get; set; }


            public string obtain { get; set; } 
        }

            public static void Hello(string[] args)
            {
                

            {
            }
            }


        private void button1_Click(object sender, EventArgs e)
        {       
            string[] names = new string[26];
                names[0] = "Amber";
                names[1] = "Barbara";
                names[2] = "Beidou";
                names[3] = "Bennett";
                names[4] = "Chongyun";
                names[5] = "Diluc";
                names[6] = "Fischl";
                names[7] = "Jean";
                names[8] = "Kaeya";
                names[9] = "Keqing";
                names[10] = "Klee";
                names[11] = "Lisa";
                names[12] = "Mona";
                names[13] = "Ningguang";
                names[14] = "Noelle";
                names[15] = "Qiqi";
                names[16] = "Razor";
                names[17] = "Sucrose";
                names[18] = "Venti";
                names[19] = "Xiangling";
                names[20] = "Xiao";
                names[21] = "Xingqiu";
                names[22] = "Diona";
                names[23] = "Tartaglia";
                names[24] = "Xinyan";
                names[25] = "Zhongli";
        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Characterinfo_Load(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

