using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OhjelmoinninProto
{
    public partial class Rekisteroidy : Form
    {
        OPPILAAT oppilaat = new OPPILAAT();
        public Rekisteroidy()
        {
            InitializeComponent();
        }
      
        //Määritetään mitä tapahtuu, kun painetaan rekisteröidy- näppäintä
        private void BTNRekisteroidy_Click(object sender, EventArgs e)
        {
            String enimi = TBRekNimi.Text;
            String snimi = TBRekSukunimi.Text;
            String salasana = TBSalasanaRek.Text;
            String email = TBEmailRek.Text;
           
            //Tarkistetaan ikä
            DateTime SyntymaPaiva = DateTime.Parse(DTPRek.Text);
            DateTime TamaPaiva = DateTime.Today;
            int ika = TamaPaiva.Year - SyntymaPaiva.Year;

          //Tarkistetaan ovatko kentät tyhjät
          if (TBRekNimi.Text.Trim().Equals("") || TBRekSukunimi.Text.Trim().Equals("") || TBEmailRek.Text.Trim().Equals("")|| TBSalasanaRek.Text.Trim().Equals("") || TBVahvistaSalasanaRek.Text.Trim().Equals(""))

            {
                    MessageBox.Show("Pakollisia kenttiä täyttämättä", "TYHJIÄ KENTTIÄ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          //Tarkistetaan, että salasanat mätsäävät
          else if(TBVahvistaSalasanaRek.Text != TBSalasanaRek.Text)
            {
                MessageBox.Show("Salasanat eivät täsmää", "Tarkista salasana", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          else if(ika < 16)
            {
                MessageBox.Show("Sinun on oltava vähintään 16-vuotias", "Ikärajoitus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Luodaan tunnus
                string ekaOsa = TBRekNimi.Text.Substring(0, 3);
                string tokaOsa = TBRekSukunimi.Text.Substring(0, 5);
                string tunnus = ekaOsa + tokaOsa;
                

                MessageBox.Show("Tunnuksesi on luotu. Käyttäjätunnuksesi on: " + tunnus, "Uusi käyttäjätunnus", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Kirjaudu kirj = new Kirjaudu();
                this.Hide();
                kirj.Show();


                try
                {
                    Boolean lisaaOppilas = oppilaat.lisaaOppilas(enimi, snimi, tunnus, salasana, email, ika);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ID Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }
    }
}
