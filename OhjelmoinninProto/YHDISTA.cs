using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace OhjelmoinninProto
{


    //Tällä luokalla luodaan yhetys ohjelman ja tietokannan välille
    class YHDISTA
    {
        private readonly MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=8012; username=root; password=; database=ttvkoe");
        // Funktio yhteyden ottamista varten
        public MySqlConnection OtaYhteytta()
        {
            return yhteys;
        }
        // Alla funktio yhteyden avaamista varten
        public void AvaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }
        // Tässä funktio yhteyden sulkemista varten
        public void SuljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }
    }
}
