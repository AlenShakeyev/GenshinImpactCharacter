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

    public partial class Form3 : Form
    {
        public static Form3 instance;
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
        public Form3()
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
            btn = button1;
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

