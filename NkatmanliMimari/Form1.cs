using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NkatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel entityPersonel = new EntityPersonel();
            entityPersonel.Ad = txtad.Text;
            entityPersonel.Soyad = txtsoyad.Text;
            entityPersonel.Sehir = txtsehir.Text;
            entityPersonel.Maas = short.Parse(txtmaas.Text);
            entityPersonel.Görev = txtgorev.Text;
            LogicPersonel.LLPersonelEkle(entityPersonel);
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            EntityPersonel entityPersonel = new EntityPersonel();
            entityPersonel.Id = Convert.ToInt32(txtıd.Text);
            LogicPersonel.LLPErsonelSil(entityPersonel.Id);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel entityPersonel = new EntityPersonel();
            entityPersonel.Id = Convert.ToInt32(txtıd.Text);
            entityPersonel.Ad = txtad.Text;
            entityPersonel.Soyad = txtsoyad.Text;
            entityPersonel.Sehir = txtsehir.Text; 
            entityPersonel.Görev = txtgorev.Text;
            entityPersonel.Maas = short.Parse(txtmaas.Text);
            LogicPersonel.LLPersonelGüncelle(entityPersonel);

        }
    }
}
