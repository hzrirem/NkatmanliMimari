using EntityLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
     public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand komut1 = new SqlCommand("select * from tbl_bilgi",Baglanti.sqlConnection);
            if (komut1.Connection.State!=ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel entityPersonel = new EntityPersonel();
                entityPersonel.Id = int.Parse(dr["Id"].ToString());
                entityPersonel.Ad = dr["Ad"].ToString();
                entityPersonel.Soyad = dr["Soyad"].ToString();
                entityPersonel.Sehir = dr["Sehir"].ToString();
                entityPersonel.Görev = dr["Gorev"].ToString();
                entityPersonel.Maas = short.Parse(dr["Maas"].ToString());
            }
            dr.Close();
            return degerler;

        }
        public static int PersonelEkle(EntityPersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into tbl_Bilgi(Ad,Soyad,Gorev,Sehir,Maas)values(@p1,@p2,@p3,@p4,@p5)", Baglanti.sqlConnection);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soyad);
            komut2.Parameters.AddWithValue("@p3", p.Görev);
            komut2.Parameters.AddWithValue("@p4", p.Sehir);
            komut2.Parameters.AddWithValue("@p5", p.Maas);
            return komut2.ExecuteNonQuery();
        }
        public static bool PersonelSİl(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete from tbl_bilgi where ıd=@p1", Baglanti.sqlConnection);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1",p);
            return komut3.ExecuteNonQuery() > 0;

        }
        public static bool PersonelGüncele(EntityPersonel ent)
        {
            SqlCommand komut4 = new SqlCommand("Update Tbl_Bilgi set Ad=@p1,Soyad=@p2,Sehir=@p3,Gorev=@p4,maas=@p5 where ıd=@p6", Baglanti.sqlConnection);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", ent.Ad);
            komut4.Parameters.AddWithValue("@p2", ent.Soyad);
            komut4.Parameters.AddWithValue("@p3", ent.Sehir);
            komut4.Parameters.AddWithValue("@p4", ent.Görev);
            komut4.Parameters.AddWithValue("@p5", ent.Maas);
            komut4.Parameters.AddWithValue("@p6", ent.Id);
            return komut4.ExecuteNonQuery() > 0;

        }
    }
}
