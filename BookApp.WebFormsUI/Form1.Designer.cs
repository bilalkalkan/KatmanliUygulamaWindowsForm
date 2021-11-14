
namespace BookApp.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwBooks = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxCategori = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxBooktName = new System.Windows.Forms.GroupBox();
            this.tbxBooktName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.gbxBookAdd = new System.Windows.Forms.GroupBox();
            this.tbxPublisherAdd = new System.Windows.Forms.TextBox();
            this.lblPublisherAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxPageofNumberAdd = new System.Windows.Forms.TextBox();
            this.tbxAuthorNameAdd = new System.Windows.Forms.TextBox();
            this.cbxCategoryIdAdd = new System.Windows.Forms.ComboBox();
            this.tbxBookNameAdd = new System.Windows.Forms.TextBox();
            this.lblPriceAdd = new System.Windows.Forms.Label();
            this.lblPageOfNumberAdd = new System.Windows.Forms.Label();
            this.lblAuthorNameAdd = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblBookNameAdd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbxPublisherUpdate = new System.Windows.Forms.TextBox();
            this.lblPublisherUpdate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxNumberOfPageUpdate = new System.Windows.Forms.TextBox();
            this.tbxAuthorNameUpdate = new System.Windows.Forms.TextBox();
            this.cbxCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxBookNameUpdate = new System.Windows.Forms.TextBox();
            this.lblPriceUpdate = new System.Windows.Forms.Label();
            this.lblNumberOfPageUpdate = new System.Windows.Forms.Label();
            this.lblAuthorNameUpdate = new System.Windows.Forms.Label();
            this.lblCategoryUpdate = new System.Windows.Forms.Label();
            this.lblBookNameUpdate = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gbxCategoryAdd = new System.Windows.Forms.GroupBox();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.tbxCategoryAdd = new System.Windows.Forms.TextBox();
            this.lblCategoryAdd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.gbxCategori.SuspendLayout();
            this.gbxBooktName.SuspendLayout();
            this.gbxBookAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxCategoryAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Location = new System.Drawing.Point(435, 12);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.Size = new System.Drawing.Size(912, 218);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            // 
            // gbxCategori
            // 
            this.gbxCategori.Controls.Add(this.cbxCategory);
            this.gbxCategori.Controls.Add(this.lblCategory);
            this.gbxCategori.Location = new System.Drawing.Point(12, 12);
            this.gbxCategori.Name = "gbxCategori";
            this.gbxCategori.Size = new System.Drawing.Size(336, 70);
            this.gbxCategori.TabIndex = 2;
            this.gbxCategori.TabStop = false;
            this.gbxCategori.Text = "Kategoriye göre ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(90, 30);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(192, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(34, 38);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxBooktName
            // 
            this.gbxBooktName.Controls.Add(this.tbxBooktName);
            this.gbxBooktName.Controls.Add(this.lblBookName);
            this.gbxBooktName.Location = new System.Drawing.Point(9, 120);
            this.gbxBooktName.Name = "gbxBooktName";
            this.gbxBooktName.Size = new System.Drawing.Size(339, 69);
            this.gbxBooktName.TabIndex = 3;
            this.gbxBooktName.TabStop = false;
            this.gbxBooktName.Text = "Kitap adına göre ara";
            // 
            // tbxBooktName
            // 
            this.tbxBooktName.Location = new System.Drawing.Point(90, 38);
            this.tbxBooktName.Name = "tbxBooktName";
            this.tbxBooktName.Size = new System.Drawing.Size(192, 20);
            this.tbxBooktName.TabIndex = 1;
            this.tbxBooktName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(22, 38);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(49, 13);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Kitap Adı";
            // 
            // gbxBookAdd
            // 
            this.gbxBookAdd.Controls.Add(this.tbxPublisherAdd);
            this.gbxBookAdd.Controls.Add(this.lblPublisherAdd);
            this.gbxBookAdd.Controls.Add(this.btnAdd);
            this.gbxBookAdd.Controls.Add(this.tbxPriceAdd);
            this.gbxBookAdd.Controls.Add(this.tbxPageofNumberAdd);
            this.gbxBookAdd.Controls.Add(this.tbxAuthorNameAdd);
            this.gbxBookAdd.Controls.Add(this.cbxCategoryIdAdd);
            this.gbxBookAdd.Controls.Add(this.tbxBookNameAdd);
            this.gbxBookAdd.Controls.Add(this.lblPriceAdd);
            this.gbxBookAdd.Controls.Add(this.lblPageOfNumberAdd);
            this.gbxBookAdd.Controls.Add(this.lblAuthorNameAdd);
            this.gbxBookAdd.Controls.Add(this.lblCategoryID);
            this.gbxBookAdd.Controls.Add(this.lblBookNameAdd);
            this.gbxBookAdd.Location = new System.Drawing.Point(22, 251);
            this.gbxBookAdd.Name = "gbxBookAdd";
            this.gbxBookAdd.Size = new System.Drawing.Size(747, 190);
            this.gbxBookAdd.TabIndex = 4;
            this.gbxBookAdd.TabStop = false;
            this.gbxBookAdd.Text = "Yeni Kitap ekle";
            // 
            // tbxPublisherAdd
            // 
            this.tbxPublisherAdd.Location = new System.Drawing.Point(500, 123);
            this.tbxPublisherAdd.Name = "tbxPublisherAdd";
            this.tbxPublisherAdd.Size = new System.Drawing.Size(184, 20);
            this.tbxPublisherAdd.TabIndex = 12;
            // 
            // lblPublisherAdd
            // 
            this.lblPublisherAdd.AutoSize = true;
            this.lblPublisherAdd.Location = new System.Drawing.Point(423, 130);
            this.lblPublisherAdd.Name = "lblPublisherAdd";
            this.lblPublisherAdd.Size = new System.Drawing.Size(47, 13);
            this.lblPublisherAdd.TabIndex = 11;
            this.lblPublisherAdd.Text = "Yayınevi";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(500, 156);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxPriceAdd
            // 
            this.tbxPriceAdd.Location = new System.Drawing.Point(501, 86);
            this.tbxPriceAdd.Name = "tbxPriceAdd";
            this.tbxPriceAdd.Size = new System.Drawing.Size(184, 20);
            this.tbxPriceAdd.TabIndex = 9;
            // 
            // tbxPageofNumberAdd
            // 
            this.tbxPageofNumberAdd.Location = new System.Drawing.Point(501, 40);
            this.tbxPageofNumberAdd.Name = "tbxPageofNumberAdd";
            this.tbxPageofNumberAdd.Size = new System.Drawing.Size(184, 20);
            this.tbxPageofNumberAdd.TabIndex = 8;
            // 
            // tbxAuthorNameAdd
            // 
            this.tbxAuthorNameAdd.Location = new System.Drawing.Point(103, 128);
            this.tbxAuthorNameAdd.Name = "tbxAuthorNameAdd";
            this.tbxAuthorNameAdd.Size = new System.Drawing.Size(218, 20);
            this.tbxAuthorNameAdd.TabIndex = 7;
            // 
            // cbxCategoryIdAdd
            // 
            this.cbxCategoryIdAdd.FormattingEnabled = true;
            this.cbxCategoryIdAdd.Location = new System.Drawing.Point(98, 86);
            this.cbxCategoryIdAdd.Name = "cbxCategoryIdAdd";
            this.cbxCategoryIdAdd.Size = new System.Drawing.Size(222, 21);
            this.cbxCategoryIdAdd.TabIndex = 6;
            // 
            // tbxBookNameAdd
            // 
            this.tbxBookNameAdd.Location = new System.Drawing.Point(99, 44);
            this.tbxBookNameAdd.Name = "tbxBookNameAdd";
            this.tbxBookNameAdd.Size = new System.Drawing.Size(222, 20);
            this.tbxBookNameAdd.TabIndex = 5;
            // 
            // lblPriceAdd
            // 
            this.lblPriceAdd.AutoSize = true;
            this.lblPriceAdd.Location = new System.Drawing.Point(423, 90);
            this.lblPriceAdd.Name = "lblPriceAdd";
            this.lblPriceAdd.Size = new System.Drawing.Size(29, 13);
            this.lblPriceAdd.TabIndex = 4;
            this.lblPriceAdd.Text = "Fiyat";
            // 
            // lblPageOfNumberAdd
            // 
            this.lblPageOfNumberAdd.AutoSize = true;
            this.lblPageOfNumberAdd.Location = new System.Drawing.Point(423, 47);
            this.lblPageOfNumberAdd.Name = "lblPageOfNumberAdd";
            this.lblPageOfNumberAdd.Size = new System.Drawing.Size(64, 13);
            this.lblPageOfNumberAdd.TabIndex = 3;
            this.lblPageOfNumberAdd.Text = "Sayfa Sayısı";
            // 
            // lblAuthorNameAdd
            // 
            this.lblAuthorNameAdd.AutoSize = true;
            this.lblAuthorNameAdd.Location = new System.Drawing.Point(31, 130);
            this.lblAuthorNameAdd.Name = "lblAuthorNameAdd";
            this.lblAuthorNameAdd.Size = new System.Drawing.Size(52, 13);
            this.lblAuthorNameAdd.TabIndex = 2;
            this.lblAuthorNameAdd.Text = "Yazar Adı";
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(31, 90);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryID.TabIndex = 1;
            this.lblCategoryID.Text = "Kategori";
            // 
            // lblBookNameAdd
            // 
            this.lblBookNameAdd.AutoSize = true;
            this.lblBookNameAdd.Location = new System.Drawing.Point(31, 47);
            this.lblBookNameAdd.Name = "lblBookNameAdd";
            this.lblBookNameAdd.Size = new System.Drawing.Size(49, 13);
            this.lblBookNameAdd.TabIndex = 0;
            this.lblBookNameAdd.Text = "Kitap Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbxPublisherUpdate);
            this.groupBox1.Controls.Add(this.lblPublisherUpdate);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.tbxPriceUpdate);
            this.groupBox1.Controls.Add(this.tbxNumberOfPageUpdate);
            this.groupBox1.Controls.Add(this.tbxAuthorNameUpdate);
            this.groupBox1.Controls.Add(this.cbxCategoryUpdate);
            this.groupBox1.Controls.Add(this.tbxBookNameUpdate);
            this.groupBox1.Controls.Add(this.lblPriceUpdate);
            this.groupBox1.Controls.Add(this.lblNumberOfPageUpdate);
            this.groupBox1.Controls.Add(this.lblAuthorNameUpdate);
            this.groupBox1.Controls.Add(this.lblCategoryUpdate);
            this.groupBox1.Controls.Add(this.lblBookNameUpdate);
            this.groupBox1.Location = new System.Drawing.Point(22, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 194);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // tbxPublisherUpdate
            // 
            this.tbxPublisherUpdate.Location = new System.Drawing.Point(500, 123);
            this.tbxPublisherUpdate.Name = "tbxPublisherUpdate";
            this.tbxPublisherUpdate.Size = new System.Drawing.Size(184, 20);
            this.tbxPublisherUpdate.TabIndex = 12;
            // 
            // lblPublisherUpdate
            // 
            this.lblPublisherUpdate.AutoSize = true;
            this.lblPublisherUpdate.Location = new System.Drawing.Point(426, 130);
            this.lblPublisherUpdate.Name = "lblPublisherUpdate";
            this.lblPublisherUpdate.Size = new System.Drawing.Size(47, 13);
            this.lblPublisherUpdate.TabIndex = 11;
            this.lblPublisherUpdate.Text = "Yayınevi";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 160);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 28);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxPriceUpdate
            // 
            this.tbxPriceUpdate.Location = new System.Drawing.Point(501, 90);
            this.tbxPriceUpdate.Name = "tbxPriceUpdate";
            this.tbxPriceUpdate.Size = new System.Drawing.Size(184, 20);
            this.tbxPriceUpdate.TabIndex = 9;
            // 
            // tbxNumberOfPageUpdate
            // 
            this.tbxNumberOfPageUpdate.Location = new System.Drawing.Point(501, 44);
            this.tbxNumberOfPageUpdate.Name = "tbxNumberOfPageUpdate";
            this.tbxNumberOfPageUpdate.Size = new System.Drawing.Size(184, 20);
            this.tbxNumberOfPageUpdate.TabIndex = 8;
            // 
            // tbxAuthorNameUpdate
            // 
            this.tbxAuthorNameUpdate.Location = new System.Drawing.Point(103, 128);
            this.tbxAuthorNameUpdate.Name = "tbxAuthorNameUpdate";
            this.tbxAuthorNameUpdate.Size = new System.Drawing.Size(218, 20);
            this.tbxAuthorNameUpdate.TabIndex = 7;
            // 
            // cbxCategoryUpdate
            // 
            this.cbxCategoryUpdate.FormattingEnabled = true;
            this.cbxCategoryUpdate.Location = new System.Drawing.Point(98, 86);
            this.cbxCategoryUpdate.Name = "cbxCategoryUpdate";
            this.cbxCategoryUpdate.Size = new System.Drawing.Size(222, 21);
            this.cbxCategoryUpdate.TabIndex = 6;
            // 
            // tbxBookNameUpdate
            // 
            this.tbxBookNameUpdate.Location = new System.Drawing.Point(99, 44);
            this.tbxBookNameUpdate.Name = "tbxBookNameUpdate";
            this.tbxBookNameUpdate.Size = new System.Drawing.Size(222, 20);
            this.tbxBookNameUpdate.TabIndex = 5;
            // 
            // lblPriceUpdate
            // 
            this.lblPriceUpdate.AutoSize = true;
            this.lblPriceUpdate.Location = new System.Drawing.Point(423, 90);
            this.lblPriceUpdate.Name = "lblPriceUpdate";
            this.lblPriceUpdate.Size = new System.Drawing.Size(29, 13);
            this.lblPriceUpdate.TabIndex = 4;
            this.lblPriceUpdate.Text = "Fiyat";
            // 
            // lblNumberOfPageUpdate
            // 
            this.lblNumberOfPageUpdate.AutoSize = true;
            this.lblNumberOfPageUpdate.Location = new System.Drawing.Point(423, 47);
            this.lblNumberOfPageUpdate.Name = "lblNumberOfPageUpdate";
            this.lblNumberOfPageUpdate.Size = new System.Drawing.Size(64, 13);
            this.lblNumberOfPageUpdate.TabIndex = 3;
            this.lblNumberOfPageUpdate.Text = "Sayfa Sayısı";
            // 
            // lblAuthorNameUpdate
            // 
            this.lblAuthorNameUpdate.AutoSize = true;
            this.lblAuthorNameUpdate.Location = new System.Drawing.Point(31, 130);
            this.lblAuthorNameUpdate.Name = "lblAuthorNameUpdate";
            this.lblAuthorNameUpdate.Size = new System.Drawing.Size(52, 13);
            this.lblAuthorNameUpdate.TabIndex = 2;
            this.lblAuthorNameUpdate.Text = "Yazar Adı";
            // 
            // lblCategoryUpdate
            // 
            this.lblCategoryUpdate.AutoSize = true;
            this.lblCategoryUpdate.Location = new System.Drawing.Point(31, 90);
            this.lblCategoryUpdate.Name = "lblCategoryUpdate";
            this.lblCategoryUpdate.Size = new System.Drawing.Size(46, 13);
            this.lblCategoryUpdate.TabIndex = 1;
            this.lblCategoryUpdate.Text = "Kategori";
            // 
            // lblBookNameUpdate
            // 
            this.lblBookNameUpdate.AutoSize = true;
            this.lblBookNameUpdate.Location = new System.Drawing.Point(31, 47);
            this.lblBookNameUpdate.Name = "lblBookNameUpdate";
            this.lblBookNameUpdate.Size = new System.Drawing.Size(49, 13);
            this.lblBookNameUpdate.TabIndex = 0;
            this.lblBookNameUpdate.Text = "Kitap Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(967, 528);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(183, 46);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gbxCategoryAdd
            // 
            this.gbxCategoryAdd.Controls.Add(this.btnCategoryAdd);
            this.gbxCategoryAdd.Controls.Add(this.tbxCategoryAdd);
            this.gbxCategoryAdd.Controls.Add(this.lblCategoryAdd);
            this.gbxCategoryAdd.Location = new System.Drawing.Point(888, 260);
            this.gbxCategoryAdd.Name = "gbxCategoryAdd";
            this.gbxCategoryAdd.Size = new System.Drawing.Size(423, 181);
            this.gbxCategoryAdd.TabIndex = 8;
            this.gbxCategoryAdd.TabStop = false;
            this.gbxCategoryAdd.Text = "Yeni Kategori ekle";
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(144, 100);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(129, 24);
            this.btnCategoryAdd.TabIndex = 2;
            this.btnCategoryAdd.Text = "Ekle";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            // 
            // tbxCategoryAdd
            // 
            this.tbxCategoryAdd.Location = new System.Drawing.Point(144, 54);
            this.tbxCategoryAdd.Name = "tbxCategoryAdd";
            this.tbxCategoryAdd.Size = new System.Drawing.Size(129, 20);
            this.tbxCategoryAdd.TabIndex = 1;
            // 
            // lblCategoryAdd
            // 
            this.lblCategoryAdd.AutoSize = true;
            this.lblCategoryAdd.Location = new System.Drawing.Point(50, 57);
            this.lblCategoryAdd.Name = "lblCategoryAdd";
            this.lblCategoryAdd.Size = new System.Drawing.Size(64, 13);
            this.lblCategoryAdd.TabIndex = 0;
            this.lblCategoryAdd.Text = "Kategori Adı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 831);
            this.Controls.Add(this.gbxCategoryAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxBookAdd);
            this.Controls.Add(this.gbxBooktName);
            this.Controls.Add(this.gbxCategori);
            this.Controls.Add(this.dgwBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.gbxCategori.ResumeLayout(false);
            this.gbxCategori.PerformLayout();
            this.gbxBooktName.ResumeLayout(false);
            this.gbxBooktName.PerformLayout();
            this.gbxBookAdd.ResumeLayout(false);
            this.gbxBookAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxCategoryAdd.ResumeLayout(false);
            this.gbxCategoryAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxCategori;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxBooktName;
        private System.Windows.Forms.TextBox tbxBooktName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.GroupBox gbxBookAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxPriceAdd;
        private System.Windows.Forms.TextBox tbxPageofNumberAdd;
        private System.Windows.Forms.TextBox tbxAuthorNameAdd;
        private System.Windows.Forms.ComboBox cbxCategoryIdAdd;
        private System.Windows.Forms.TextBox tbxBookNameAdd;
        private System.Windows.Forms.Label lblPriceAdd;
        private System.Windows.Forms.Label lblPageOfNumberAdd;
        private System.Windows.Forms.Label lblAuthorNameAdd;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblBookNameAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxPriceUpdate;
        private System.Windows.Forms.TextBox tbxNumberOfPageUpdate;
        private System.Windows.Forms.TextBox tbxAuthorNameUpdate;
        private System.Windows.Forms.ComboBox cbxCategoryUpdate;
        private System.Windows.Forms.TextBox tbxBookNameUpdate;
        private System.Windows.Forms.Label lblPriceUpdate;
        private System.Windows.Forms.Label lblNumberOfPageUpdate;
        private System.Windows.Forms.Label lblAuthorNameUpdate;
        private System.Windows.Forms.Label lblCategoryUpdate;
        private System.Windows.Forms.Label lblBookNameUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbxPublisherAdd;
        private System.Windows.Forms.Label lblPublisherAdd;
        private System.Windows.Forms.TextBox tbxPublisherUpdate;
        private System.Windows.Forms.Label lblPublisherUpdate;
        private System.Windows.Forms.GroupBox gbxCategoryAdd;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.TextBox tbxCategoryAdd;
        private System.Windows.Forms.Label lblCategoryAdd;
    }
}

