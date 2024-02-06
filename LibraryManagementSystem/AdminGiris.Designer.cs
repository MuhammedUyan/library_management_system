using System.Windows.Forms;

namespace LibraryManagementSystem
{
	partial class AdminGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
			this.label1 = new System.Windows.Forms.Label();
			this.kullaniciAdi_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.parola_textBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.GirisButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(138, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Admin Girişi";
			// 
			// kullaniciAdi_textBox
			// 
			this.kullaniciAdi_textBox.Location = new System.Drawing.Point(142, 144);
			this.kullaniciAdi_textBox.Name = "kullaniciAdi_textBox";
			this.kullaniciAdi_textBox.Size = new System.Drawing.Size(170, 20);
			this.kullaniciAdi_textBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(142, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Kullanıcı Adı";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(142, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Parola";
			// 
			// parola_textBox
			// 
			this.parola_textBox.Location = new System.Drawing.Point(142, 188);
			this.parola_textBox.Name = "parola_textBox";
			this.parola_textBox.Size = new System.Drawing.Size(170, 20);
			this.parola_textBox.TabIndex = 4;
			this.parola_textBox.UseSystemPasswordChar = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(142, 236);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Geri dön";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// GirisButton
			// 
			this.GirisButton.Location = new System.Drawing.Point(237, 236);
			this.GirisButton.Name = "GirisButton";
			this.GirisButton.Size = new System.Drawing.Size(75, 23);
			this.GirisButton.TabIndex = 6;
			this.GirisButton.Text = "Giriş";
			this.GirisButton.UseVisualStyleBackColor = true;
			this.GirisButton.Click += new System.EventHandler(this.GirisButton_Click);
			// 
			// AdminGiris
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(684, 428);
			this.Controls.Add(this.GirisButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.parola_textBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.kullaniciAdi_textBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AdminGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kütüphane Yönetim Sistemi";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox kullaniciAdi_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox parola_textBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button GirisButton;
	}
}