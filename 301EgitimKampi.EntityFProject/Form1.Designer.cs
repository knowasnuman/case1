﻿namespace _301EgitimKampi.EntityFProject
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rehber Id:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 43);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(203, 20);
            this.txtId.TabIndex = 1;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Gold;
            this.btnList.Location = new System.Drawing.Point(139, 155);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(203, 33);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(360, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 300);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 80);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 20);
            this.txtName.TabIndex = 5;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rehber Adi:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(139, 116);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(203, 20);
            this.txtSurname.TabIndex = 7;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Rehber Soyadi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gold;
            this.btnAdd.Location = new System.Drawing.Point(139, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(203, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gold;
            this.btnDelete.Location = new System.Drawing.Point(139, 232);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.Color.Gold;
            this.btnGetById.Location = new System.Drawing.Point(139, 310);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(203, 33);
            this.btnGetById.TabIndex = 10;
            this.btnGetById.Text = "Id\'ye Gore Getir";
            this.btnGetById.UseVisualStyleBackColor = false;
            this.btnGetById.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.Location = new System.Drawing.Point(139, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 33);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Guncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 368);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rehber Islemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGetById;
        private System.Windows.Forms.Button btnUpdate;
    }
}

