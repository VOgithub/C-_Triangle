using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinKolmNurk
{
    public partial class Triangle_Work : Form
    {
        public Triangle_Work()
        {
            InitializeComponent();
        }
        
        private void stars_btn_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(A_txt.Text);
            b = Convert.ToDouble(B_txt.Text);
            c = Convert.ToDouble(C_txt.Text);
            Triangle t = new Triangle(a, b, c);
            lw.Items.Clear();
            lw.Items.Add("Külg A");
            lw.Items[0].SubItems.Add(t.OutputA());
            lw.Items.Add("Külg B");
            lw.Items[1].SubItems.Add(t.OutputB());
            lw.Items.Add("Külg C");
            lw.Items[2].SubItems.Add(t.OutputC());
            lw.Items.Add(t.TriangleType);
            if (t.TriangleType == "Ravnostoronnii !")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\opilane\Desktop\eq_triangle.jpg");
            }
            else if (t.TriangleType == "Ravnobedrennii !")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\opilane\Desktop\ravnobed_treugolnik.png");
            }
            else if (t.TriangleType == "Raznostoronnii !")
            {
                pictureBox1.Image = Image.FromFile(@"C:\Users\opilane\Desktop\ugol_triangle.png");
            }
            lw.Items.Add("Is real ..?:");
            lw.Items[4].SubItems.Add(t.ExistTriangle.ToString());
            lw.Items.Add("Perimeter:");
            lw.Items[5].SubItems.Add(t.Perimeter().ToString());
            lw.Items.Add("Perimeter 1/2:");
            lw.Items[6].SubItems.Add(t.Perimeter1_2().ToString());
            stars_btn.DoubleClick+= stars_btn_DoubleClick;

        }

        
        private void stars_btn_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("You are in the Button.DoubleClick event.");
        }

        //private void stars_btn_DoubleClick(object sender, EventArgs e)
        //{
        //    Form MyForm = new Form();
        //    MyForm .Show();
        //}

        private void Triangle_Work_Load(object sender, EventArgs e)
        {

        }
    }
}
