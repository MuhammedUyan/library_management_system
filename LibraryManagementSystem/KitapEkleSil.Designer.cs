namespace LibraryManagementSystem
{
	partial class KitapEkleSil
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkleSil));
			this.label1 = new System.Windows.Forms.Label();
			this.kitapAdi_textBox = new System.Windows.Forms.TextBox();
			this.yazarAdi_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.kitapID_textBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.ekleButton = new System.Windows.Forms.Button();
			this.silButton = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.geriButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(123, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(167, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kitap Ekle / Sil";
			// 
			// kitapAdi_textBox
			// 
			this.kitapAdi_textBox.Location = new System.Drawing.Point(83, 99);
			this.kitapAdi_textBox.Name = "kitapAdi_textBox";
			this.kitapAdi_textBox.Size = new System.Drawing.Size(276, 20);
			this.kitapAdi_textBox.TabIndex = 1;
			// 
			// yazarAdi_textBox
			// 
			this.yazarAdi_textBox.Location = new System.Drawing.Point(83, 155);
			this.yazarAdi_textBox.Name = "yazarAdi_textBox";
			this.yazarAdi_textBox.Size = new System.Drawing.Size(276, 20);
			this.yazarAdi_textBox.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Kitap Adı";
			// 
			// kitapID_textBox
			// 
			this.kitapID_textBox.Location = new System.Drawing.Point(83, 212);
			this.kitapID_textBox.Name = "kitapID_textBox";
			this.kitapID_textBox.Size = new System.Drawing.Size(276, 20);
			this.kitapID_textBox.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(80, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Yazar Adı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(80, 196);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Kitap ID";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// ekleButton
			// 
			this.ekleButton.Location = new System.Drawing.Point(83, 311);
			this.ekleButton.Name = "ekleButton";
			this.ekleButton.Size = new System.Drawing.Size(70, 23);
			this.ekleButton.TabIndex = 11;
			this.ekleButton.Text = "Ekle";
			this.ekleButton.UseVisualStyleBackColor = true;
			this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
			// 
			// silButton
			// 
			this.silButton.Location = new System.Drawing.Point(159, 311);
			this.silButton.Name = "silButton";
			this.silButton.Size = new System.Drawing.Size(70, 23);
			this.silButton.TabIndex = 12;
			this.silButton.Text = "Sil";
			this.silButton.UseVisualStyleBackColor = true;
			this.silButton.Click += new System.EventHandler(this.silButton_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(83, 262);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(85, 17);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Mevcut mu?";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// geriButton
			// 
			this.geriButton.Location = new System.Drawing.Point(273, 311);
			this.geriButton.Name = "geriButton";
			this.geriButton.Size = new System.Drawing.Size(80, 23);
			this.geriButton.TabIndex = 15;
			this.geriButton.Text = "Geri";
			this.geriButton.UseVisualStyleBackColor = true;
			this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
			// 
			// KitapEkleSil
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(434, 361);
			this.Controls.Add(this.geriButton);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.silButton);
			this.Controls.Add(this.ekleButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.kitapID_textBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.yazarAdi_textBox);
			this.Controls.Add(this.kitapAdi_textBox);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KitapEkleSil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kitap Ekle Sil";
			this.Load += new System.EventHandler(this.KitapEkleSil_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox kitapAdi_textBox;
		private System.Windows.Forms.TextBox yazarAdi_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox kitapID_textBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button ekleButton;
		private System.Windows.Forms.Button silButton;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button geriButton;
	}
}