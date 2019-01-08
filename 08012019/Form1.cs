using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static _08012019.MyClass;

namespace _08012019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<DortgenKutu> klist = new List<DortgenKutu>();
        private void Form1_Load(object sender, EventArgs e)
        {
            DortgenKutu kutu = new DortgenKutu();
            kutu.Id = 1;
            kutu.UrunAd = "Kutu";
            kutu.Yukseklik = 50;
            kutu.UzunKenar = 20;
            kutu.KısaKenar = 10;
            klist.Add(kutu);

            kutu = new DortgenKutu();
            kutu.Id = 2;
            kutu.UrunAd = "Kutu2";
            kutu.Yukseklik = 30;
            kutu.UzunKenar = 15;
            kutu.KısaKenar = 25;
            klist.Add(kutu);

            kutu = new DortgenKutu();
            kutu.Id = 3;
            kutu.UrunAd = "Kutu3";
            kutu.Yukseklik = 40;
            kutu.UzunKenar = 35;
            kutu.KısaKenar = 10;
            klist.Add(kutu);

            dataGridView1.DataSource = klist;

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DortgenKutu kutu = (DortgenKutu)dataGridView1.CurrentRow.DataBoundItem;
            int Hacim = kutu.Hacim();
            int Fire = kutu.Fire();
            MessageBox.Show("Fire + Hacim:" + Fire + " " + Hacim);

        }
    }
}
