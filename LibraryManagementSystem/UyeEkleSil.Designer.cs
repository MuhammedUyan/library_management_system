namespace LibraryManagementSystem
{
	partial class UyeEkleSil
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
			this.geriButton = new System.Windows.Forms.Button();
			this.silButton = new System.Windows.Forms.Button();
			this.ekleButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UyeID_textBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.UyeSoyadi_textBox = new System.Windows.Forms.TextBox();
			this.UyeAdi_textBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// geriButton
			// 
			this.geriButton.Location = new System.Drawing.Point(267, 263);
			this.geriButton.Name = "geriButton";
			this.geriButton.Size = new System.Drawing.Size(80, 23);
			this.geriButton.TabIndex = 26;
			this.geriButton.Text = "Geri";
			this.geriButton.UseVisualStyleBackColor = true;
			this.geriButton.Click += new System.EventHandler(this.geriButton_Click);
			// 
			// silButton
			// 
			this.silButton.Location = new System.Drawing.Point(153, 263);
			this.silButton.Name = "silButton";
			this.silButton.Size = new System.Drawing.Size(70, 23);
			this.silButton.TabIndex = 24;
			this.silButton.Text = "Sil";
			this.silButton.UseVisualStyleBackColor = true;
			this.silButton.Click += new System.EventHandler(this.silButton_Click);
			// 
			// ekleButton
			// 
			this.ekleButton.Location = new System.Drawing.Point(77, 263);
			this.ekleButton.Name = "ekleButton";
			this.ekleButton.Size = new System.Drawing.Size(70, 23);
			this.ekleButton.TabIndex = 23;
			this.ekleButton.Text = "Ekle";
			this.ekleButton.UseVisualStyleBackColor = true;
			this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(74, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(40, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "Üye ID";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(74, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 21;
			this.label3.Text = "Üye Soyadı";
			// 
			// UyeID_textBox
			// 
			this.UyeID_textBox.Location = new System.Drawing.Point(77, 205);
			this.UyeID_textBox.Name = "UyeID_textBox";
			this.UyeID_textBox.Size = new System.Drawing.Size(276, 20);
			this.UyeID_textBox.TabIndex = 20;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(74, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 19;
			this.label2.Text = "Üye Adı";
			// 
			// UyeSoyadi_textBox
			// 
			this.UyeSoyadi_textBox.Location = new System.Drawing.Point(77, 148);
			this.UyeSoyadi_textBox.Name = "UyeSoyadi_textBox";
			this.UyeSoyadi_textBox.Size = new System.Drawing.Size(276, 20);
			this.UyeSoyadi_textBox.TabIndex = 18;
			// 
			// UyeAdi_textBox
			// 
			this.UyeAdi_textBox.Location = new System.Drawing.Point(77, 92);
			this.UyeAdi_textBox.Name = "UyeAdi_textBox";
			this.UyeAdi_textBox.Size = new System.Drawing.Size(276, 20);
			this.UyeAdi_textBox.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(117, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 25);
			this.label1.TabIndex = 16;
			this.label1.Text = "Üye Ekle / Sil";
			// 
			// UyeEkleSil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 311);
			this.Controls.Add(this.geriButton);
			this.Controls.Add(this.silButton);
			this.Controls.Add(this.ekleButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.UyeID_textBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.UyeSoyadi_textBox);
			this.Controls.Add(this.UyeAdi_textBox);
			this.Controls.Add(this.label1);
			this.Name = "UyeEkleSil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UyeEkleSil";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button geriButton;
		private System.Windows.Forms.Button silButton;
		private System.Windows.Forms.Button ekleButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox UyeID_textBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox UyeSoyadi_textBox;
		private System.Windows.Forms.TextBox UyeAdi_textBox;
		private System.Windows.Forms.Label label1;
	}
}