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
    public partial class Form2 : Form
    {
        public static string valueText1 = "";
        public static string valueText2 = "";

        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
        private void sesion()
        {
            valueText1 = usertxt.Text;
            string password = passtxt.Text;

            if (valueText1 == "" && valueText2 == "")
            {
                MessageBox.Show("Llene todos los campos");
                return;
            }
            if (usertxt.Text == "EQUIPO_AV" && passtxt.Text == "admin01")
            {

                valueText1 = usertxt.Text;
                this.Hide();
                Form4 loading = new Form4();
                loading.ShowDialog();
                password = passtxt.Text;
                valueText2 = usertxt.Text;
                Form3 interfaz = new Form3();
                interfaz.Show();

            }
            else
            {
                MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTO");
            }


        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sesion();
            this.Dispose();
            
            
        }
    }
}
