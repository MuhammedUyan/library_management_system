namespace LibraryManagementSystem
{
	partial class UyeGiris
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeGiris));
			this.girisButton = new System.Windows.Forms.Button();
			this.geriButton = new System.Windows.Forms.Button();
			this.parola_textBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.kullaniciAdi_textBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// girisButton
			// 
			this.girisButton.Location = new System.Drawing.Point(231, 234);
			this.girisButton.Name = "girisButton";
			this.girisButton.Size = new System.Drawing.Size(75, 23);
			this.girisButton.TabIndex = 13;
			this.girisButton.Text = "Giriş";
			this.girisButton.UseVisualStyleBackColor = true;
			this.girisButton.Click += new System.EventHandler(this.girisButton_Click);
			// 
			// geriButton
			// 
			this.geriButton.Location = new System.Drawing.Point(136, 234);
			this.geriButton.Name = "geriButton";
			this.geriButton.Size = new System.Drawing.Size(75, 23);
			this.geriButton.TabIndex = 12;
			this.geriButton.Text = "Geri dön";
			this.geriButton.UseVisualStyleBackColor = true;
			this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
			// 
			// parola_textBox
			// 
			this.parola_textBox.Location = new System.Drawing.Point(136, 186);
			this.parola_textBox.Name = "parola_textBox";
			this.parola_textBox.Size = new System.Drawing.Size(170, 20);
			this.parola_textBox.TabIndex = 11;
			this.parola_textBox.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(136, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Parola";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(136, 123);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Kullanıcı Adı";
			// 
			// kullaniciAdi_textBox
			// 
			this.kullaniciAdi_textBox.Location = new System.Drawing.Point(136, 142);
			this.kullaniciAdi_textBox.Name = "kullaniciAdi_textBox";
			this.kullaniciAdi_textBox.Size = new System.Drawing.Size(170, 20);
			this.kullaniciAdi_textBox.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(132, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Üye Girişi";
			// 
			// UyeGiris
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.arkaplan1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(684, 428);
			this.Controls.Add(this.girisButton);
			this.Controls.Add(this.geriButton);
			this.Controls.Add(this.parola_textBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.kullaniciAdi_textBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "UyeGiris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UyeGiris";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button girisButton;
		private System.Windows.Forms.Button geriButton;
		private System.Windows.Forms.TextBox parola_textBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox kullaniciAdi_textBox;
		private System.Windows.Forms.Label label1;
	}
}