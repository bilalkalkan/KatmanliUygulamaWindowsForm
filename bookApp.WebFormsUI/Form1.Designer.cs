
namespace bookApp.WebFormsUI
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
            this.gbxCategoryId = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxBookName = new System.Windows.Forms.GroupBox();
            this.tbxBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.gbxBooktAdd = new System.Windows.Forms.GroupBox();
            this.tbxPublisher = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxNumberofPages = new System.Windows.Forms.TextBox();
            this.tbxAuthorName = new System.Windows.Forms.TextBox();
            this.cbxCategoryIdAdd = new System.Windows.Forms.ComboBox();
            this.tbxBookName2 = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblNumberofPages = new System.Windows.Forms.Label();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblBookName2 = new System.Windows.Forms.Label();
            this.gbxBookUpdate = new System.Windows.Forms.GroupBox();
            this.tbxPublisherUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxNumberofPagesUpdate = new System.Windows.Forms.TextBox();
            this.tbxAuthorNameUpdate = new System.Windows.Forms.TextBox();
            this.cbxBookCategoryUpdate = new System.Windows.Forms.ComboBox();
            this.tbxBookNameUpdate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).BeginInit();
            this.gbxCategoryId.SuspendLayout();
            this.gbxBookName.SuspendLayout();
            this.gbxBooktAdd.SuspendLayout();
            this.gbxBookUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwBooks
            // 
            this.dgwBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwBooks.Location = new System.Drawing.Point(624, 14);
            this.dgwBooks.Name = "dgwBooks";
            this.dgwBooks.Size = new System.Drawing.Size(782, 233);
            this.dgwBooks.TabIndex = 0;
            this.dgwBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellClick);
            this.dgwBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBooks_CellContentClick);
            // 
            // gbxCategoryId
            // 
            this.gbxCategoryId.Controls.Add(this.cbxCategory);
            this.gbxCategoryId.Controls.Add(this.lblCategory);
            this.gbxCategoryId.Location = new System.Drawing.Point(2, 14);
            this.gbxCategoryId.Name = "gbxCategoryId";
            this.gbxCategoryId.Size = new System.Drawing.Size(581, 71);
            this.gbxCategoryId.TabIndex = 1;
            this.gbxCategoryId.TabStop = false;
            this.gbxCategoryId.Text = "Kategoriye göre ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(85, 35);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(203, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(33, 35);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(46, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori";
            // 
            // gbxBookName
            // 
            this.gbxBookName.Controls.Add(this.tbxBookName);
            this.gbxBookName.Controls.Add(this.lblBookName);
            this.gbxBookName.Location = new System.Drawing.Point(2, 113);
            this.gbxBookName.Name = "gbxBookName";
            this.gbxBookName.Size = new System.Drawing.Size(577, 94);
            this.gbxBookName.TabIndex = 2;
            this.gbxBookName.TabStop = false;
            this.gbxBookName.Text = "Ktap adına göre ara";
            // 
            // tbxBookName
            // 
            this.tbxBookName.Location = new System.Drawing.Point(82, 40);
            this.tbxBookName.Name = "tbxBookName";
            this.tbxBookName.Size = new System.Drawing.Size(203, 20);
            this.tbxBookName.TabIndex = 1;
            this.tbxBookName.TextChanged += new System.EventHandler(this.tbxBookName_TextChanged);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(28, 43);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(31, 13);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.Text = "Kitap";
            // 
            // gbxBooktAdd
            // 
            this.gbxBooktAdd.Controls.Add(this.tbxPublisher);
            this.gbxBooktAdd.Controls.Add(this.lblPublisher);
            this.gbxBooktAdd.Controls.Add(this.btnAdd);
            this.gbxBooktAdd.Controls.Add(this.tbxPrice);
            this.gbxBooktAdd.Controls.Add(this.tbxNumberofPages);
            this.gbxBooktAdd.Controls.Add(this.tbxAuthorName);
            this.gbxBooktAdd.Controls.Add(this.cbxCategoryIdAdd);
            this.gbxBooktAdd.Controls.Add(this.tbxBookName2);
            this.gbxBooktAdd.Controls.Add(this.lblPrice);
            this.gbxBooktAdd.Controls.Add(this.lblNumberofPages);
            this.gbxBooktAdd.Controls.Add(this.lblAuthorName);
            this.gbxBooktAdd.Controls.Add(this.lblCategoryID);
            this.gbxBooktAdd.Controls.Add(this.lblBookName2);
            this.gbxBooktAdd.Location = new System.Drawing.Point(2, 259);
            this.gbxBooktAdd.Name = "gbxBooktAdd";
            this.gbxBooktAdd.Size = new System.Drawing.Size(694, 299);
            this.gbxBooktAdd.TabIndex = 4;
            this.gbxBooktAdd.TabStop = false;
            this.gbxBooktAdd.Text = "Yeni kitap ekle";
            // 
            // tbxPublisher
            // 
            this.tbxPublisher.Location = new System.Drawing.Point(505, 139);
            this.tbxPublisher.Name = "tbxPublisher";
            this.tbxPublisher.Size = new System.Drawing.Size(179, 20);
            this.tbxPublisher.TabIndex = 12;
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(423, 135);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(47, 13);
            this.lblPublisher.TabIndex = 11;
            this.lblPublisher.Text = "Yayınevi";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(501, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(501, 90);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(184, 20);
            this.tbxPrice.TabIndex = 9;
            // 
            // tbxNumberofPages
            // 
            this.tbxNumberofPages.Location = new System.Drawing.Point(501, 44);
            this.tbxNumberofPages.Name = "tbxNumberofPages";
            this.tbxNumberofPages.Size = new System.Drawing.Size(184, 20);
            this.tbxNumberofPages.TabIndex = 8;
            // 
            // tbxAuthorName
            // 
            this.tbxAuthorName.Location = new System.Drawing.Point(103, 128);
            this.tbxAuthorName.Name = "tbxAuthorName";
            this.tbxAuthorName.Size = new System.Drawing.Size(218, 20);
            this.tbxAuthorName.TabIndex = 7;
            // 
            // cbxCategoryIdAdd
            // 
            this.cbxCategoryIdAdd.FormattingEnabled = true;
            this.cbxCategoryIdAdd.Location = new System.Drawing.Point(98, 86);
            this.cbxCategoryIdAdd.Name = "cbxCategoryIdAdd";
            this.cbxCategoryIdAdd.Size = new System.Drawing.Size(222, 21);
            this.cbxCategoryIdAdd.TabIndex = 6;
            // 
            // tbxBookName2
            // 
            this.tbxBookName2.Location = new System.Drawing.Point(99, 44);
            this.tbxBookName2.Name = "tbxBookName2";
            this.tbxBookName2.Size = new System.Drawing.Size(222, 20);
            this.tbxBookName2.TabIndex = 5;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(423, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Fiyat";
            // 
            // lblNumberofPages
            // 
            this.lblNumberofPages.AutoSize = true;
            this.lblNumberofPages.Location = new System.Drawing.Point(423, 47);
            this.lblNumberofPages.Name = "lblNumberofPages";
            this.lblNumberofPages.Size = new System.Drawing.Size(64, 13);
            this.lblNumberofPages.TabIndex = 3;
            this.lblNumberofPages.Text = "Sayfa Sayısı";
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(31, 130);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(34, 13);
            this.lblAuthorName.TabIndex = 2;
            this.lblAuthorName.Text = "Yazar";
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
            // lblBookName2
            // 
            this.lblBookName2.AutoSize = true;
            this.lblBookName2.Location = new System.Drawing.Point(31, 47);
            this.lblBookName2.Name = "lblBookName2";
            this.lblBookName2.Size = new System.Drawing.Size(49, 13);
            this.lblBookName2.TabIndex = 0;
            this.lblBookName2.Text = "Kitap Adı";
            // 
            // gbxBookUpdate
            // 
            this.gbxBookUpdate.Controls.Add(this.tbxPublisherUpdate);
            this.gbxBookUpdate.Controls.Add(this.label1);
            this.gbxBookUpdate.Controls.Add(this.btnUpdate);
            this.gbxBookUpdate.Controls.Add(this.tbxPriceUpdate);
            this.gbxBookUpdate.Controls.Add(this.tbxNumberofPagesUpdate);
            this.gbxBookUpdate.Controls.Add(this.tbxAuthorNameUpdate);
            this.gbxBookUpdate.Controls.Add(this.cbxBookCategoryUpdate);
            this.gbxBookUpdate.Controls.Add(this.tbxBookNameUpdate);
            this.gbxBookUpdate.Controls.Add(this.label2);
            this.gbxBookUpdate.Controls.Add(this.label3);
            this.gbxBookUpdate.Controls.Add(this.label4);
            this.gbxBookUpdate.Controls.Add(this.label5);
            this.gbxBookUpdate.Controls.Add(this.label6);
            this.gbxBookUpdate.Location = new System.Drawing.Point(702, 259);
            this.gbxBookUpdate.Name = "gbxBookUpdate";
            this.gbxBookUpdate.Size = new System.Drawing.Size(707, 299);
            this.gbxBookUpdate.TabIndex = 5;
            this.gbxBookUpdate.TabStop = false;
            this.gbxBookUpdate.Text = "Kitap güncelle";
            // 
            // tbxPublisherUpdate
            // 
            this.tbxPublisherUpdate.Location = new System.Drawing.Point(505, 139);
            this.tbxPublisherUpdate.Name = "tbxPublisherUpdate";
            this.tbxPublisherUpdate.Size = new System.Drawing.Size(179, 20);
            this.tbxPublisherUpdate.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yayınevi";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 182);
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
            // tbxNumberofPagesUpdate
            // 
            this.tbxNumberofPagesUpdate.Location = new System.Drawing.Point(501, 44);
            this.tbxNumberofPagesUpdate.Name = "tbxNumberofPagesUpdate";
            this.tbxNumberofPagesUpdate.Size = new System.Drawing.Size(184, 20);
            this.tbxNumberofPagesUpdate.TabIndex = 8;
            // 
            // tbxAuthorNameUpdate
            // 
            this.tbxAuthorNameUpdate.Location = new System.Drawing.Point(103, 128);
            this.tbxAuthorNameUpdate.Name = "tbxAuthorNameUpdate";
            this.tbxAuthorNameUpdate.Size = new System.Drawing.Size(218, 20);
            this.tbxAuthorNameUpdate.TabIndex = 7;
            // 
            // cbxBookCategoryUpdate
            // 
            this.cbxBookCategoryUpdate.FormattingEnabled = true;
            this.cbxBookCategoryUpdate.Location = new System.Drawing.Point(98, 86);
            this.cbxBookCategoryUpdate.Name = "cbxBookCategoryUpdate";
            this.cbxBookCategoryUpdate.Size = new System.Drawing.Size(222, 21);
            this.cbxBookCategoryUpdate.TabIndex = 6;
            // 
            // tbxBookNameUpdate
            // 
            this.tbxBookNameUpdate.Location = new System.Drawing.Point(99, 44);
            this.tbxBookNameUpdate.Name = "tbxBookNameUpdate";
            this.tbxBookNameUpdate.Size = new System.Drawing.Size(222, 20);
            this.tbxBookNameUpdate.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sayfa Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yazar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Kategori";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kitap Adı";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(104, 220);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(182, 33);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1527, 759);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.gbxBookUpdate);
            this.Controls.Add(this.gbxBooktAdd);
            this.Controls.Add(this.gbxBookName);
            this.Controls.Add(this.gbxCategoryId);
            this.Controls.Add(this.dgwBooks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBooks)).EndInit();
            this.gbxCategoryId.ResumeLayout(false);
            this.gbxCategoryId.PerformLayout();
            this.gbxBookName.ResumeLayout(false);
            this.gbxBookName.PerformLayout();
            this.gbxBooktAdd.ResumeLayout(false);
            this.gbxBooktAdd.PerformLayout();
            this.gbxBookUpdate.ResumeLayout(false);
            this.gbxBookUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBooks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbxCategoryId;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxBookName;
        private System.Windows.Forms.TextBox tbxBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.GroupBox gbxBooktAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.TextBox tbxNumberofPages;
        private System.Windows.Forms.TextBox tbxAuthorName;
        private System.Windows.Forms.ComboBox cbxCategoryIdAdd;
        private System.Windows.Forms.TextBox tbxBookName2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblNumberofPages;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblBookName2;
        private System.Windows.Forms.TextBox tbxPublisher;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.GroupBox gbxBookUpdate;
        private System.Windows.Forms.TextBox tbxPublisherUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxPriceUpdate;
        private System.Windows.Forms.TextBox tbxNumberofPagesUpdate;
        private System.Windows.Forms.TextBox tbxAuthorNameUpdate;
        private System.Windows.Forms.ComboBox cbxBookCategoryUpdate;
        private System.Windows.Forms.TextBox tbxBookNameUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRemove;
    }
}

