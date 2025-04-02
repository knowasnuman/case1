using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301EgitimKampi.EntityFProject
{
    public partial class FrmStatistic : Form
    {
        public FrmStatistic()
        {
            InitializeComponent();
        }

        EFProjectDbEntities db = new EFProjectDbEntities();
        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            // Toplam Lokasyon Sayisi
            lblLocationCount.Text = db.Location.Count().ToString();
            // Toplam Kapasite
            lblSumCapaticity.Text = db.Location.Sum(x=> x.Capacity).ToString();
            // Toplam Rehber Sayisi
            lblSumGuide.Text = db.Guide.Count().ToString();
            // Ortalama Kapasite
            lblAvarageCapaticity.Text = db.Location.Average(x=> x.Capacity)?.ToString("0.00");
            // Ortalama Tur Fiyati
            lblAvgLocationPrice.Text = db.Location.Average(x=>x.Price)?.ToString("0.00") + " TL" ;
            //Eklenen Son Ulke
            int lastId = db.Location.Max(x => x.Location1);
            lblLastCountry.Text = db.Location.Where(x => x.Location1 == lastId).Select(y => y.Country).FirstOrDefault(); 
            // Kapadokya Turu Kapasitesi
            lblCappadociaLocationCapacity.Text = db.Location.Where(x=>x.City=="Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            // Turkiye Turlarinin Ortalama Kapasitesi
            lblTrCapatictAvg.Text = db.Location.Where(x=>x.Country=="Turkiye").Average(y=> y.Capacity)?.ToString("0.00");
            // Roma Gezisinin Rehberinin Ismi
            var romeGuideId = db.Location.Where(x=>x.City=="Roma Turistik").Select(y=>y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.Guide.Where(x=>x.GuideId==romeGuideId).Select(y=>y.GuideName + " " + y.GuidSurname).FirstOrDefault().ToString();
            // En Yuksek Kapasiteli Tur
            var maxCapacity = db.Location.Max(x=>x.Capacity);
            lblMaxCapacityLocation.Text = db.Location.Where(x=>x.Capacity==maxCapacity).Select(y=>y.City).FirstOrDefault().ToString();
            // En Yuksek Fiyatli Tur
            var maxPrice = db.Location.Max(x=>x.Price);
            lblMaxLocationPrice.Text = db.Location.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();
            // Numan Kotan'in Tur Sayisi
            var guideNameByNumanKotan = db.Guide.Where(x => x.GuideName == "Numan" && x.GuidSurname == "Kotan").Select(y => y.GuideId).FirstOrDefault();
            lblNumanLocationCount.Text = db.Location.Where(x=>x.GuideId==guideNameByNumanKotan).Count().ToString();
            
            

        }

      
    }
}
