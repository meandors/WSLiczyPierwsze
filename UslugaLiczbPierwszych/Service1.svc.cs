using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UslugaLiczbPierwszych
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LiczbyPierwsze : ILiczbyPierwsze
    {
        public int[] GetPierwsze(int dolnyZakres, int gornyZakres)
        {
            List<int> listaPierwszych = new List<int>();
            int liczby;
            bool czyNieJestPierwsza;

            for (int i = dolnyZakres; i <= gornyZakres; i = i + 2)
            {
                czyNieJestPierwsza = false;
                for (liczby = 2; liczby <= i / 2; liczby++)
                {
                    if (i % liczby == 0)
                    {
                        czyNieJestPierwsza = true;
                        break;
                    }
                }

                if (!czyNieJestPierwsza)
                {
                    listaPierwszych.Add(i);
                }
            }

            return listaPierwszych.ToArray();
        }
    }
}
