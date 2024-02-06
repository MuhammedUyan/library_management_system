using System.Windows.Forms;

namespace LibraryManagementSystem
{
	partial class Giris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.uyeGirisButton = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(93, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(528, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "KÜTÜPHANE YÖNETİM SİSTEMİ";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.ForeColor = System.Drawing.Color.Red;
			this.button2.Location = new System.Drawing.Point(150, 116);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(200, 50);
			this.button2.TabIndex = 1;
			this.button2.Text = "Admin Girişi";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// uyeGirisButton
			// 
			this.uyeGirisButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uyeGirisButton.ForeColor = System.Drawing.Color.Red;
			this.uyeGirisButton.Location = new System.Drawing.Point(150, 172);
			this.uyeGirisButton.Name = "uyeGirisButton";
			this.uyeGirisButton.Size = new System.Drawing.Size(200, 50);
			this.uyeGirisButton.TabIndex = 2;
			this.uyeGirisButton.Text = "Üye Girişi";
			this.uyeGirisButton.UseVisualStyleBackColor = true;
			this.uyeGirisButton.Click += new System.EventHandler(this.uyeGirisButton_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Red;
			this.button4.Location = new System.Drawing.Point(150, 228);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(200, 50);
			this.button4.TabIndex = 3;
			this.button4.Text = "Çıkış";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Giris
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(684, 428);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.uyeGirisButton);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.Coral;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Giris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kütüphane Yönetim Sistemi";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private Button button2;
		private Button uyeGirisButton;
		private Button button4;
	}
}

