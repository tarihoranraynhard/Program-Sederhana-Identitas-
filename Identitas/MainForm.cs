/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 09/06/2022
 * Time: 14:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Identitas
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		MySqlConnection co = new MySqlConnection("Server = localhost; Database = identitas; Uid = root");
		MySqlCommand mycommand = new MySqlCommand();
		MySqlDataAdapter myadapter = new MySqlDataAdapter();
		
		
		public void ReadData(){
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "select * from tbl_identitas";
				DataSet ds = new DataSet();

				if (myadapter.Fill(ds,"tbl_identitas") > 0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_identitas";
				}
				co.Close();
			}
			catch (Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}
		
		
		public void ResetData(){
			tbNama.Text="";
			clbJK.Text="";
			tbAlamat.Text="";
			cbAgama.Text="";
		}
		
		public void agama(){
			cbAgama.Items.Add("Islam");
			cbAgama.Items.Add("Kristen");
			cbAgama.Items.Add("Katolik");
			cbAgama.Items.Add("Hindu");
			cbAgama.Items.Add("Buddha");
			cbAgama.Items.Add("Konghucu");
		}
		
		public void JenisKelamin(){
			clbJK.Items.Add("Laki-Laki");
			clbJK.Items.Add("Perempuan");
		}
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			ReadData();
			ResetData();
			agama();
			JenisKelamin();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnSimpanClick(object sender, EventArgs e)
		{
			if(tbNama.Text.Trim() == "" || clbJK.Text.Trim() == "" || tbAlamat.Text.Trim() == ""|| cbAgama.Text.Trim() == ""){
				MessageBox.Show("Isi Setiap Kolom yang Tersedia Terlebih Dahulu");
			}
			else{			
			try{
				mycommand.Connection = co;
				myadapter.SelectCommand = mycommand;
				mycommand.CommandText = "INSERT INTO  tbl_identitas VALUES ('"+tbNama.Text+"','"+clbJK.Text+"','"+tbAlamat.Text+"','"+cbAgama.Text+"')";
				DataSet ds = new DataSet();
				if (myadapter.Fill(ds, "tbl_identitas")>0){
					dataGridView1.DataSource = ds;
					dataGridView1.DataMember = "tbl_identitas";
				}
				MessageBox.Show("Data berhasil dimasukan","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
					ReadData();
					ResetData();
				co.Close();
			}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}
		}				
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				tbNama.Text = row.Cells["nama"].Value.ToString();
				clbJK.Text = row.Cells["jk"].Value.ToString();
				tbAlamat.Text = row.Cells["alamat"].Value.ToString();
				cbAgama.Text = row.Cells["agama"].Value.ToString();
				}
			catch(Exception ex){
				MessageBox.Show(ex.ToString());
			}	
		}
	}
}
