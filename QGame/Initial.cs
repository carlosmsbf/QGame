using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CBarros
{
    public partial class Initial : Form
    {

        private Designs form;
        private PlayGame formPlay;

        public Initial()
        {
            InitializeComponent();
        }

        private void btnDesigns_Click(object sender, EventArgs e)
        {
            form = new Designs();
            form.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            formPlay = new PlayGame();
            formPlay.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
