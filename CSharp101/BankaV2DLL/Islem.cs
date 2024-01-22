using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaV2DLL
{
    public class Islem
    {
        public IslemTipi IslemTipi { get; set; }

        public int Sure { get; set; }

        public Islem(IslemTipi islemTipi)
        {
            IslemTipi = islemTipi;
            switch (islemTipi)
            {
                case IslemTipi.Havale:
                    Sure = 5;
                    break;
                case IslemTipi.ParaCekme:
                    Sure = 7;
                    break;
                case IslemTipi.ParaYatirma:
                    Sure = 2;
                    break;
            }
        }
    }
}
