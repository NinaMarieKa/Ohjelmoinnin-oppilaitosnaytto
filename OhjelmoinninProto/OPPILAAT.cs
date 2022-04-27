using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OhjelmoinninProto
{
    class OPPILAAT
    {

        YHDISTA yht = new YHDISTA();

        public bool lisaaOppilas(string etunimi, string sukunimi, string tunnus, string salasana, string email, int ika)
        {
            MySqlCommand komento = new MySqlCommand();
            String lisaaKysely = "INSERT INTO `koetiedot`(`etunimi`, `sukunimi`, `tunnus`, `salasana`, `email`, `ika`) VALUES (@eni,@sni,@tun,@ssa,@eml,@ika)";
            komento.CommandText = lisaaKysely;
            komento.Connection = yht.OtaYhteytta();
            komento.CommandText = lisaaKysely;
            komento.Connection = yht.OtaYhteytta();


            //@eni,@sni,@tun,@ssa,@eml,@ika
            komento.Parameters.Add("@eni", MySqlDbType.VarChar).Value = etunimi;
            komento.Parameters.Add("@sni", MySqlDbType.VarChar).Value = sukunimi;
            komento.Parameters.Add("@tun", MySqlDbType.VarChar).Value = tunnus;
            komento.Parameters.Add("@ssa", MySqlDbType.VarChar).Value = salasana;
            komento.Parameters.Add("@eml", MySqlDbType.VarChar).Value = email;
            komento.Parameters.Add("@ika", MySqlDbType.VarChar).Value = ika;
           
            yht.AvaaYhteys();
            // Avataan ja suljetaan yhteys
            if (komento.ExecuteNonQuery() == 1)
            {
                yht.SuljeYhteys();
                return true;

            }
            else
            {
                yht.SuljeYhteys();
                return false;
            }


        }
     
        }
       
    }


