using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Project
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.DodgerBlue;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/9/93/Character_Barbara_Card.jpg/revision/latest?cb=20201024042228";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Barbara";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: Every denizen of Mondstadt ";
            i.Show();
            Characterinfo.instance.lb25.Text = "adores Barbara. However, she learned ";
            i.Show();
            Characterinfo.instance.lb26.Text = "the word idol from a magazine.";
            i.Show();
            Characterinfo.instance.lb9.Text = "";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: July 5";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Hydro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Catalyst";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.BlueViolet;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/8/84/Character_Beidou_Card.jpg/revision/latest?cb=20200401024902";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Beidou";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: Beidou is the leader of the   ";
            i.Show();
            Characterinfo.instance.lb25.Text = "Crux an armed fleet based in Liyue Harbor.   ";
            i.Show();
            Characterinfo.instance.lb26.Text = "An armed fleet means exactly what it sounds   ";
            i.Show();
            Characterinfo.instance.lb9.Text = "like: a fleet of ships armed to the teeth. ";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: February 14";;
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Electro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Claymore";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.MediumAquamarine;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/0/0e/Character_Jean_Card.jpg/revision/latest/scale-to-width-down/281?cb=20190703155524";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Jean";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: The righteous and rigorous ";
            i.Show();
            Characterinfo.instance.lb25.Text = "Dandelion Knight, and Acting Grand Master ";
            i.Show();
            Characterinfo.instance.lb26.Text = "of the Knights of Favonius in Mondstadt.";
            i.Show();
            Characterinfo.instance.lb9.Text = " ";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: March 14";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Anemo";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Sword";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.MediumAquamarine;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/7/76/Character_Venti_Card.jpg/revision/latest/scale-to-width-down/281?cb=20201024042752";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Venti";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: One of the many bards of  ";
            i.Show();
            Characterinfo.instance.lb25.Text = "Mondstadt, who freely wanders the city's ";
            i.Show();
            Characterinfo.instance.lb26.Text = "streets and alleys.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Male";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: June 16";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Anemo";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Bow";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Firebrick;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/2/26/Character_Amber_Card.jpg/revision/latest?cb=20201024042115";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Amber";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: Always energetic and full  ";
            i.Show();
            Characterinfo.instance.lb25.Text = "of life, Ambers the best -albeit only- ";
            i.Show();
            Characterinfo.instance.lb26.Text = "Outrider of the Knights of Favonius.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: August 24";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Pyro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Bow";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Quest";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Firebrick;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/7/7f/Character_Bennett_Card.jpg/revision/latest?cb=20201024042332";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Bennett";
            i.Show();
            Characterinfo.instance.lb2.Text = "Desription: A righteous and good-natured  ";
            i.Show();
            Characterinfo.instance.lb25.Text = "adventurer from Mondstadt whos ";
            i.Show();
            Characterinfo.instance.lb26.Text = "unfortunately extremely unlucky.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Male";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: February 29";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Pyro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Sword";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.LightSkyBlue;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/f/fa/Character_Chongyun_Card.jpg/revision/latest/scale-to-width-down/281?cb=20201024042420";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Chongyun";
            i.Show();
            Characterinfo.instance.lb2.Text = "Desription: A young exortcist from a family  ";
            i.Show();
            Characterinfo.instance.lb25.Text = "of exorcists. He does everything he can";
            i.Show();
            Characterinfo.instance.lb26.Text = "to suppress his pure positive energy.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Male";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: September 7";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Cryo ";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Claymore";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Firebrick;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/4/45/Character_Diluc_Card.jpg/revision/latest/scale-to-width-down/281?cb=20200220072322";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Diluc";
            i.Show();
            Characterinfo.instance.lb2.Text = "Desription: The tycoon of a winery empire  ";
            i.Show();
            Characterinfo.instance.lb25.Text = "in Mondstadt, unmatched in every possible";
            i.Show();
            Characterinfo.instance.lb26.Text = "way.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Male";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: April 30";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Pyro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Claymore";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.BlueViolet;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/4/48/Character_Fischl_Card.jpg/revision/latest/scale-to-width-down/281?cb=20200331202523";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Fischl";
            i.Show();
            Characterinfo.instance.lb2.Text = "Desription: A mysterious girl who calls  ";
            i.Show();
            Characterinfo.instance.lb25.Text = "herself Prinzessia der Verurteilung and  ";
            i.Show();
            Characterinfo.instance.lb26.Text = "travels with a nightraven named Oz. ";
            i.Show();
            Characterinfo.instance.lb9.Text = "of ships armed to the teeth. ";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: May 27";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Electro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Bow";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.LightSkyBlue;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/6/64/Character_Kaeya_Card.jpg/revision/latest/scale-to-width-down/281?cb=20190704215128";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Kaeya";
            i.Show();
            Characterinfo.instance.lb2.Text = "A thinker in the Knights of Favonius with ";
            i.Show();
            Characterinfo.instance.lb25.Text = "a somewhat exotic appearance. ";
            i.Show();
            Characterinfo.instance.lb26.Text = " ";
            i.Show();
            Characterinfo.instance.lb9.Text = " ";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Male";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: November 30";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Cryo";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Sword";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Quest";
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.BlueViolet;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/f/f4/Character_Keqing_Card.jpg/revision/latest/scale-to-width-down/281?cb=20201024042513";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Keqing";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description:The Yuheng of the Liyue Qixing.";
            i.Show();
            Characterinfo.instance.lb25.Text = "Has much to say about RexLapis unilateral ";
            i.Show();
            Characterinfo.instance.lb26.Text = "approach to policymaking in Liyue-but in ";
            i.Show();
            Characterinfo.instance.lb9.Text = "truth,gods admire skeptics like her a lot.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: November 20";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Electro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Sword";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Firebrick;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/7/78/Character_Klee_Card.jpg/revision/latest/scale-to-width-down/281?cb=20201024041912";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Klee";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description:An explosives expert and a  ";
            i.Show();
            Characterinfo.instance.lb25.Text = "regular at the Knights of Favonius\r\n ";
            i.Show();
            Characterinfo.instance.lb26.Text = "confinement room. Also known as Fleeing";
            i.Show();
            Characterinfo.instance.lb9.Text = "Sunlight.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: July 27";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Pyro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Catalyst";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.BlueViolet;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/d/dc/Character_Lisa_Card.jpg/revision/latest/scale-to-width-down/281?cb=20201024042621";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Lisa";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description:The languid but knowledgeable";
            i.Show();
            Characterinfo.instance.lb25.Text = "Librarian of KoF who was deemed by Sumeru";
            i.Show();
            Characterinfo.instance.lb26.Text = "Academia to be their most distinguised";
            i.Show();
            Characterinfo.instance.lb9.Text = "graduate in the past two centuries.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: June 9";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Pyro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Catalyst";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.DodgerBlue;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/6/69/Character_Mona_Card.jpg/revision/latest/scale-to-width-down/281?cb=20210323193416";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Mona";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description:A mysterious young astrologer   ";
            i.Show();
            Characterinfo.instance.lb25.Text = "who proclaims herself to be Astrologist ";
            i.Show();
            Characterinfo.instance.lb26.Text = "Mona Megistus, and who possesses abilities ";
            i.Show();
            Characterinfo.instance.lb9.Text = "to match the title.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: August 31";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Hydro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Catalyst";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Goldenrod;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/3/3e/Character_Ningguang_Card.jpg/revision/latest/scale-to-width-down/281?cb=20200401040354";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Ningguang";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description:The Tianquan of Liyue Qixing. ";
            i.Show();
            Characterinfo.instance.lb25.Text = "Her wealth is unsurpassed in all of";
            i.Show();
            Characterinfo.instance.lb26.Text = "Teyvat. ";
            i.Show();
            Characterinfo.instance.lb9.Text = " ";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: August 26";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Geo";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Catalyst";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Goldenrod;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/9/92/Character_Noelle_Card.jpg/revision/latest/scale-to-width-down/281?cb=20200403111008";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Noelle";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description:A maid in the service of   ";
            i.Show();
            Characterinfo.instance.lb25.Text = "the Knights of Favonius that dreams";
            i.Show();
            Characterinfo.instance.lb26.Text = "of joining their ranks someday. ";
            i.Show();
            Characterinfo.instance.lb9.Text = " ";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: March 21";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Geo";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Claymore";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.LightSkyBlue;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/b/b9/Character_Qiqi_Card.jpg/revision/latest/scale-to-width-down/281?cb=20200904131037";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Qiqi";
            i.Show(); 
            Characterinfo.instance.lb2.Text = "Description: An apprentice and herb-picker ";
            i.Show();
            Characterinfo.instance.lb25.Text = "Bubu Pharmacy. An undead with a ";
            i.Show();
            Characterinfo.instance.lb26.Text = "bone-white complexion, she seldom has ";
            i.Show();
            Characterinfo.instance.lb9.Text = "much in the way of words or emotion. ";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: March 3";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Cryo";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Sword";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label19_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.BlueViolet;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/6/68/Character_Razor_Card.jpg/revision/latest/scale-to-width-down/281?cb=20201024043017";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage; i.Show();
            Characterinfo.instance.lb1.Text = "Name: Razor";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: boy who lives among the ";
            i.Show();
            Characterinfo.instance.lb25.Text = "wolves in Wolvendom of Mondstadt,away from";
            i.Show();
            Characterinfo.instance.lb26.Text = "human civilization. As agile as lightning. ";
            i.Show();
            Characterinfo.instance.lb9.Text = "";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Male";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: September 9";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Electro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Claymore";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label20_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.MediumAquamarine;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/2/22/Character_Sucrose_Card.jpg/revision/latest/scale-to-width-down/281?cb=20201024043113";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Sucrose";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: An alchemist filled with   ";
            i.Show();
            Characterinfo.instance.lb25.Text = "curiosity about all things. She researches";
            i.Show();
            Characterinfo.instance.lb26.Text = "bio-alchemy.";
            i.Show();
            Characterinfo.instance.lb9.Text = "";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: May 11";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Anemo";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Catalyst";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Firebrick;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/f/f1/Character_Xiangling_Card.jpg/revision/latest/scale-to-width-down/281?cb=202003311915453";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage; i.Show();
            Characterinfo.instance.lb1.Text = "Name: Xiangling";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: A renowned chef from Liyue.   ";
            i.Show();
            Characterinfo.instance.lb25.Text = "Shes extremely passionate about cooking ";
            i.Show();
            Characterinfo.instance.lb26.Text = "and excels at making hers ignature hot ";
            i.Show();
            Characterinfo.instance.lb9.Text = "and spicy dishes.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: November 2";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Pyro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Polearm";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.MediumAquamarine;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/8/88/Character_Xiao_Card.jpg/revision/latest/scale-to-width-down/281?cb=20200331193542";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Xiao";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: A yaksha adeptus that defends  ";
            i.Show();
            Characterinfo.instance.lb25.Text = "Liyue. Also heralded as the Conqueror of ";
            i.Show();
            Characterinfo.instance.lb26.Text = "Demons or Vigilant Yaksha. ";
            i.Show();
            Characterinfo.instance.lb9.Text = "";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Male";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: April 17";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Anemo";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Polearm";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label24_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.DodgerBlue;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/c/c2/Character_Xingqiu_Card.jpg/revision/latest/scale-to-width-down/281?cb=20201024043209";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Xingqiu";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: A young man carrying a   ";
            i.Show();
            Characterinfo.instance.lb25.Text = "longsword who is frequently seen at book  ";
            i.Show();
            Characterinfo.instance.lb26.Text = "booths. He has a chivalrous heart and ";
            i.Show();
            Characterinfo.instance.lb9.Text = "yearns for justice and fairness for all.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Male";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: October 9";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Hydro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Sword";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label25_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.LightSkyBlue;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/0/08/Character_Diona_Card.png/revision/latest/scale-to-width-down/281?cb=20201107193459";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Diona";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: A young lady who has ";
            i.Show();
            Characterinfo.instance.lb25.Text = "inherited trace amounts of non-human ";
            i.Show();
            Characterinfo.instance.lb26.Text = "blood. She is the incredible popular ";
            i.Show();
            Characterinfo.instance.lb9.Text = "bartender of the Cats Tail tavern.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: January 18";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Cryo";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Bow";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.DodgerBlue;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/4/4c/Character_Tartaglia_Card.png/revision/latest/scale-to-width-down/281?cb=20201106023840";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Tartaglia";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: Cunning Snezhnayan whose ";
            i.Show();
            Characterinfo.instance.lb25.Text = "unpredictable personality keeps people  ";
            i.Show();
            Characterinfo.instance.lb26.Text = "guessing his every move.";
            i.Show();
            Characterinfo.instance.lb9.Text = "";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Male";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: July 20";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Hydro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Bow";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Firebrick;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/4/4c/Character_Xinyan_Card.jpeg/revision/latest/scale-to-width-down/281?cb=20201128161752";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Xinyan";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: Liyue's sole rock 'n' roll   ";
            i.Show();
            Characterinfo.instance.lb25.Text = "musician. She rebels against ossified ";
            i.Show();
            Characterinfo.instance.lb26.Text = "prejudices using her music and passionate";
            i.Show();
            Characterinfo.instance.lb9.Text = "singing.";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: November 4";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Pyro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Claymore";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }
        private void label28_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Goldenrod;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/7/79/Character_Zhongli_Card.png/revision/latest/scale-to-width-down/281?cb=20201217052506";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Zhongli";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: A mysterious guest invited ";
            i.Show();
            Characterinfo.instance.lb25.Text = "by the Wangsheng Funeral Parlor. Extremely ";
            i.Show();
            Characterinfo.instance.lb26.Text = "knowledgeable in all things.";
            i.Show();
            Characterinfo.instance.lb9.Text = "";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Male";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: December 31";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Geo";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Polearm";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Firebrick;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/2/22/Character_Hu_Tao_Card.jpg/revision/latest/scale-to-width-down/281?cb=20210227051236";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Hu Tao";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: The 77th Director of the  ";
            i.Show();
            Characterinfo.instance.lb25.Text = "Wangsheng Funeral Parlor. She took over ";
            i.Show();
            Characterinfo.instance.lb26.Text = "the business at a rather young age.";
            i.Show();
            Characterinfo.instance.lb9.Text = "";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: July 15";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Pyro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Polearm";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }

        private void label30_Click_1(object sender, EventArgs e)
        {
            Characterinfo i = new Characterinfo();
            i.BackColor = Color.Firebrick;
            i.pictureBox1.ImageLocation = "https://static.wikia.nocookie.net/gensin-impact/images/2/22/Character_Hu_Tao_Card.jpg/revision/latest/scale-to-width-down/281?cb=20210227051236";
            i.pictureBox2.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox3.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox4.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox5.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox6.ImageLocation = "https://pngimg.com/uploads/star/star_PNG41474.png";
            i.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            i.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            i.Show();
            Characterinfo.instance.lb1.Text = "Name: Hu Tao";
            i.Show();
            Characterinfo.instance.lb2.Text = "Description: The 77th Director of the  ";
            i.Show();
            Characterinfo.instance.lb25.Text = "Wangsheng Funeral Parlor. She took over ";
            i.Show();
            Characterinfo.instance.lb26.Text = "the business at a rather young age.";
            i.Show();
            Characterinfo.instance.lb9.Text = "";
            i.Show();
            Characterinfo.instance.lb3.Text = "Gender: Female";
            i.Show();
            Characterinfo.instance.lb4.Text = "Birthday: July 15";
            i.Show();
            Characterinfo.instance.lb6.Text = "Element: Pyro";
            i.Show();
            Characterinfo.instance.lb7.Text = "Weapon type: Polearm";
            i.Show();
            Characterinfo.instance.lb8.Text = "How to obtain: Wish";
        }
    }


}
