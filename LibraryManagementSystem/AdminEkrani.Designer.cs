using System;

namespace LibraryManagementSystem
{
	partial class AdminEkrani
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminEkrani));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.UyeAramaButton = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.uyeID_textBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.uyeSoyadi_textBox = new System.Windows.Forms.TextBox();
			this.uyeAdi_textBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.KitapAramaButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.KitapID_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.YazarAdi_textBox = new System.Windows.Forms.TextBox();
			this.KitapAdi_textBox = new System.Windows.Forms.TextBox();
			this.kitapEkleSilButon = new System.Windows.Forms.Button();
			this.UyeEkleSilButton = new System.Windows.Forms.Button();
			this.listView2 = new System.Windows.Forms.ListView();
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ExitButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(684, 200);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "ID";
			this.columnHeader3.Width = 40;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Kitap adı";
			this.columnHeader1.Width = 300;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Yazar adı";
			this.columnHeader2.Width = 221;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Durum";
			this.columnHeader4.Width = 119;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.UyeAramaButton);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.uyeID_textBox);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.uyeSoyadi_textBox);
			this.panel1.Controls.Add(this.uyeAdi_textBox);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.KitapAramaButton);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.KitapID_textBox);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.YazarAdi_textBox);
			this.panel1.Controls.Add(this.KitapAdi_textBox);
			this.panel1.Location = new System.Drawing.Point(0, 406);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(542, 231);
			this.panel1.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(358, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 20);
			this.label5.TabIndex = 15;
			this.label5.Text = "Üye Ara";
			// 
			// UyeAramaButton
			// 
			this.UyeAramaButton.Location = new System.Drawing.Point(278, 194);
			this.UyeAramaButton.Name = "UyeAramaButton";
			this.UyeAramaButton.Size = new System.Drawing.Size(248, 23);
			this.UyeAramaButton.TabIndex = 14;
			this.UyeAramaButton.Text = "Ara";
			this.UyeAramaButton.UseVisualStyleBackColor = true;
			this.UyeAramaButton.Click += new System.EventHandler(this.UyeAramaButton_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(278, 144);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Üye ID";
			// 
			// uyeID_textBox
			// 
			this.uyeID_textBox.Location = new System.Drawing.Point(278, 160);
			this.uyeID_textBox.Name = "uyeID_textBox";
			this.uyeID_textBox.Size = new System.Drawing.Size(248, 20);
			this.uyeID_textBox.TabIndex = 12;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(278, 92);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Üye soyadı";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(278, 44);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Üye adı";
			// 
			// uyeSoyadi_textBox
			// 
			this.uyeSoyadi_textBox.Location = new System.Drawing.Point(278, 108);
			this.uyeSoyadi_textBox.Name = "uyeSoyadi_textBox";
			this.uyeSoyadi_textBox.Size = new System.Drawing.Size(248, 20);
			this.uyeSoyadi_textBox.TabIndex = 9;
			// 
			// uyeAdi_textBox
			// 
			this.uyeAdi_textBox.Location = new System.Drawing.Point(278, 60);
			this.uyeAdi_textBox.Name = "uyeAdi_textBox";
			this.uyeAdi_textBox.Size = new System.Drawing.Size(248, 20);
			this.uyeAdi_textBox.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(89, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "Kitap Ara";
			// 
			// KitapAramaButton
			// 
			this.KitapAramaButton.Location = new System.Drawing.Point(9, 194);
			this.KitapAramaButton.Name = "KitapAramaButton";
			this.KitapAramaButton.Size = new System.Drawing.Size(248, 23);
			this.KitapAramaButton.TabIndex = 6;
			this.KitapAramaButton.Text = "Ara";
			this.KitapAramaButton.UseVisualStyleBackColor = true;
			this.KitapAramaButton.Click += new System.EventHandler(this.AramaButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Kitap ID";
			// 
			// KitapID_textBox
			// 
			this.KitapID_textBox.Location = new System.Drawing.Point(9, 160);
			this.KitapID_textBox.Name = "KitapID_textBox";
			this.KitapID_textBox.Size = new System.Drawing.Size(248, 20);
			this.KitapID_textBox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Yazar adı";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Kitap adı";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// YazarAdi_textBox
			// 
			this.YazarAdi_textBox.Location = new System.Drawing.Point(9, 108);
			this.YazarAdi_textBox.Name = "YazarAdi_textBox";
			this.YazarAdi_textBox.Size = new System.Drawing.Size(248, 20);
			this.YazarAdi_textBox.TabIndex = 1;
			// 
			// KitapAdi_textBox
			// 
			this.KitapAdi_textBox.Location = new System.Drawing.Point(9, 60);
			this.KitapAdi_textBox.Name = "KitapAdi_textBox";
			this.KitapAdi_textBox.Size = new System.Drawing.Size(248, 20);
			this.KitapAdi_textBox.TabIndex = 0;
			// 
			// kitapEkleSilButon
			// 
			this.kitapEkleSilButon.Location = new System.Drawing.Point(548, 406);
			this.kitapEkleSilButon.Name = "kitapEkleSilButon";
			this.kitapEkleSilButon.Size = new System.Drawing.Size(125, 30);
			this.kitapEkleSilButon.TabIndex = 2;
			this.kitapEkleSilButon.Text = "Kitap Ekle/Sil";
			this.kitapEkleSilButon.UseVisualStyleBackColor = true;
			this.kitapEkleSilButon.Click += new System.EventHandler(this.kitapEkleSilButon_Click);
			// 
			// UyeEkleSilButton
			// 
			this.UyeEkleSilButton.Location = new System.Drawing.Point(547, 442);
			this.UyeEkleSilButton.Name = "UyeEkleSilButton";
			this.UyeEkleSilButton.Size = new System.Drawing.Size(125, 30);
			this.UyeEkleSilButton.TabIndex = 3;
			this.UyeEkleSilButton.Text = "Üye Ekle/Sil";
			this.UyeEkleSilButton.UseVisualStyleBackColor = true;
			this.UyeEkleSilButton.Click += new System.EventHandler(this.UyeEkleSilButton_Click);
			// 
			// listView2
			// 
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
			this.listView2.Dock = System.Windows.Forms.DockStyle.Top;
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(0, 200);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(684, 200);
			this.listView2.TabIndex = 6;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "ID";
			this.columnHeader5.Width = 40;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Üye adı";
			this.columnHeader6.Width = 320;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Üye soyadı";
			this.columnHeader7.Width = 320;
			// 
			// ExitButton
			// 
			this.ExitButton.Location = new System.Drawing.Point(548, 600);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(125, 30);
			this.ExitButton.TabIndex = 7;
			this.ExitButton.Text = "Çıkış";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// AdminEkrani
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(684, 637);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.UyeEkleSilButton);
			this.Controls.Add(this.kitapEkleSilButon);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.listView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AdminEkrani";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kütüphane Yönetim Sistemi";
			this.Load += new System.EventHandler(this.AdminEkrani_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox KitapAdi_textBox;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox YazarAdi_textBox;
		private System.Windows.Forms.Button KitapAramaButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox KitapID_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button kitapEkleSilButon;
		private System.Windows.Forms.Button UyeEkleSilButton;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button UyeAramaButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox uyeID_textBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox uyeSoyadi_textBox;
		private System.Windows.Forms.TextBox uyeAdi_textBox;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.Button ExitButton;
	}
}