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
    public partial class Kirjaudu : Form
    {
        public Kirjaudu()
        {
            InitializeComponent();
        }
        //Määritetään mitä tapahtuu, kun painetaan kirjaudu- painiketta
        private void BTNKirjaudu_Click(object sender, EventArgs e)
        {
            //Käytetään YHDISTA- luokkaa
            YHDISTA yht = new YHDISTA();

            //Muutujia yhdistämistä varten
            DataTable taulu = new DataTable();
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            MySqlCommand komento = new MySqlCommand();
            String kysely = "SELECT `tunnus`,`salasana`FROM koetiedot WHERE tunnus= @tun AND salasana= @ssa";

            komento.CommandText = kysely;
            komento.Connection = yht.OtaYhteytta();

                // Tunnusten tarkistus, mikäli oikein siirrytään pääsivulle
                if (TBKirjauduTunnus.Text.Trim().Equals("nina") && TBKirjauduSalasana.Text.Trim().Equals("Ja@kk0Ku1t4"))
            {
                 Paasivu paa = new Paasivu();
                 this.Hide();
                 paa.Show();
            }
            //Tarkistetaan onko tunnus- kenttä tyhjä
            else if(TBKirjauduTunnus.Text.Trim().Equals(""))
            {
                MessageBox.Show("Syötä käyttäjätunnus", "Käyttäjätunnus- kenttä on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Tarkistetaan onko salasanakenttä tyhjä
            else if(TBKirjauduSalasana.Text.Trim().Equals(""))
            {
                MessageBox.Show("Syötä salasana", "Salasana- kenttä on tyhjä", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Mikäli tunnus tai salasana on virheellinen
            else
            {
                MessageBox.Show("Tunnus tai salasana on vääin", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
