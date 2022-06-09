/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 09/06/2022
 * Time: 14:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Identitas
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.tbNama = new System.Windows.Forms.TextBox();
			this.tbAlamat = new System.Windows.Forms.TextBox();
			this.btnSimpan = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.cbAgama = new System.Windows.Forms.ComboBox();
			this.clbJK = new System.Windows.Forms.CheckedListBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(136, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(202, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "Identitas Diri";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(25, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(127, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Nama";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(25, 125);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Jenis Kelamin";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(25, 180);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(127, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "Alamat";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbNama
			// 
			this.tbNama.Location = new System.Drawing.Point(183, 74);
			this.tbNama.Name = "tbNama";
			this.tbNama.Size = new System.Drawing.Size(249, 22);
			this.tbNama.TabIndex = 6;
			// 
			// tbAlamat
			// 
			this.tbAlamat.Location = new System.Drawing.Point(183, 181);
			this.tbAlamat.Name = "tbAlamat";
			this.tbAlamat.Size = new System.Drawing.Size(249, 22);
			this.tbAlamat.TabIndex = 7;
			// 
			// btnSimpan
			// 
			this.btnSimpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSimpan.Location = new System.Drawing.Point(543, 125);
			this.btnSimpan.Name = "btnSimpan";
			this.btnSimpan.Size = new System.Drawing.Size(104, 47);
			this.btnSimpan.TabIndex = 11;
			this.btnSimpan.Text = "Simpan";
			this.btnSimpan.UseVisualStyleBackColor = true;
			this.btnSimpan.Click += new System.EventHandler(this.BtnSimpanClick);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(25, 215);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 23);
			this.label5.TabIndex = 12;
			this.label5.Text = "Agama";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(758, 74);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(561, 235);
			this.dataGridView1.TabIndex = 19;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(947, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(202, 33);
			this.label7.TabIndex = 20;
			this.label7.Text = "Data";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cbAgama
			// 
			this.cbAgama.FormattingEnabled = true;
			this.cbAgama.Location = new System.Drawing.Point(183, 216);
			this.cbAgama.Name = "cbAgama";
			this.cbAgama.Size = new System.Drawing.Size(249, 24);
			this.cbAgama.TabIndex = 21;
			// 
			// clbJK
			// 
			this.clbJK.FormattingEnabled = true;
			this.clbJK.Location = new System.Drawing.Point(183, 125);
			this.clbJK.Name = "clbJK";
			this.clbJK.Size = new System.Drawing.Size(249, 38);
			this.clbJK.TabIndex = 22;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1331, 362);
			this.Controls.Add(this.clbJK);
			this.Controls.Add(this.cbAgama);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSimpan);
			this.Controls.Add(this.tbAlamat);
			this.Controls.Add(this.tbNama);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Identitas";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckedListBox clbJK;
		private System.Windows.Forms.ComboBox cbAgama;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnSimpan;
		private System.Windows.Forms.TextBox tbAlamat;
		private System.Windows.Forms.TextBox tbNama;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
