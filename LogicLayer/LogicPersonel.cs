using DataAccessLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LLPersonelEkle(EntityPersonel p)
        {
            if (p.Ad!=" "&&p.Soyad!=" "&&p.Maas>=2500 && p.Ad.Length>=2)
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }

        }
        public static bool LLPErsonelSil (int per)
        {
            if (per>=1)
            {
                return DALPersonel.PersonelSİl(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLPersonelGüncelle(EntityPersonel ent)
        {
            if (ent.Ad.Length>=3 && ent.Ad!=" "&&ent.Maas>=4500 )
            {
                return DALPersonel.PersonelGüncele(ent);
            }
            else
            {
                return false;
            }
        }
        
            
	

	}
}



