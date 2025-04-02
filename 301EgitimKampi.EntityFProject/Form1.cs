using System;
using System.CodeDom;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void button4_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var values = db.Guide.Where(x => x.GuideId == id).ToList(); // x =>  (x oyleki)
            dataGridView1.DataSource = values;

        }

        EFProjectDbEntities db = new EFProjectDbEntities(); // db isminde nesne turettik
        private void btnList_Click(object sender, EventArgs e)
        {
            
            var values =db.Guide.ToList(); //Guide tablosunu tum tabloyu dondur EntitiyFrameWork 
            dataGridView1.DataSource = values;  //
        }

     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Guide guide = new Guide(); // Guide tablosundan guide adinda nesne turettik
            guide.GuideName = txtName.Text; // GuideName i txtName isimli textboxtan gelen deger yap.
            guide.GuidSurname = txtSurname.Text;
            db.Guide.Add(guide); // Guide tablosuna guide icerisindeki degerleri ekle (GuidName ve GuideSurname)
            db.SaveChanges(); // Veritabanina Kaydet ExecuteNoneQuery gibi
            MessageBox.Show("Rehber Basariyla Eklendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txtId.Text);
            var removeValue = db.Guide.Find(id); //girilen id degerinin tum bilgisini hafizaya at.
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber Basariyla Silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text;
            updateValue.GuidSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber Basariyla Guncellendi", "Uyari",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
