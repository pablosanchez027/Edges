using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Edges
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> _ImgInput;

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _ImgInput = new Image<Bgr, byte>(ofd.FileName);
                imageBox1.Image = _ImgInput;
            }
        }



        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro que ya no me quieres?", "System Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        //Aplicar Canny
        private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image<Gray, byte> _imgCanny = new Image<Gray, byte>(_ImgInput.Width, _ImgInput.Height, new Gray(0));
            _imgCanny = _ImgInput.Canny(50, 30);

            imageBox1.Image = _imgCanny;
        }
    }
}
