using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U1_QUIZZ_FPSM_RAAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            pictureBOX.Visible = true;
            pictureBox1.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void start()
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBOX.Visible = false;
            pictureBox1.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;

        }

        private void pictureBOX_Click(object sender, EventArgs e)
        {
            pictureBOX.Visible = false;
            pictureBox1.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBOX.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBOX.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            pictureBOX.Visible = false;
            pictureBox1.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = false;
            pictureBox1.Visible = false;
            pictureBOX.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = false;
            pictureBOX.Visible = false;
            pictureBox1.Visible = false;
            pictureBox9.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            pictureBox10.Visible = true;
            pictureBOX.Visible = false;
            pictureBox1.Visible = false;
            pictureBox9.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = false;
            pictureBox10.Visible = false;
            pictureBOX.Visible = false;
            pictureBox1.Visible = false;
            pictureBox9.Visible = false;
            pictureBox12.Visible = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            pictureBox11.Visible = true;
            pictureBox10.Visible = false;
            pictureBOX.Visible = false;
            pictureBox1.Visible = false;
            pictureBox9.Visible = false;
            pictureBox12.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = false;
            pictureBox11.Visible = false;
            pictureBox10.Visible = false;
            pictureBOX.Visible = false;
            pictureBox1.Visible = false;
            pictureBox9.Visible = false;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox12.Visible = true;
            pictureBox11.Visible = false;
            pictureBox10.Visible = false;
            pictureBOX.Visible = false;
            pictureBox1.Visible = false;
            pictureBox9.Visible = false;

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            
            Form2 log = new Form2();
            log.Show();
            


        }
    }
}
