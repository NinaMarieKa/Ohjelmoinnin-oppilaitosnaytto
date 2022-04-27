using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OhjelmoinninProto
{
    public partial class Etusivu : Form
    {
        public Etusivu()
        {
            InitializeComponent();
        }

        private void LBKirjaudu_Click(object sender, EventArgs e)
        {
            Kirjaudu kirjaudu = new Kirjaudu();
            this.Hide();
            kirjaudu.Show();
           
        }

        private void SLBRekisteroidy_Click(object sender, EventArgs e)
        {
            Rekisteroidy rek = new Rekisteroidy();
            this.Hide();
            rek.Show();
        }
    }
}
