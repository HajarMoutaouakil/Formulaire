using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Formulaire
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void InsererButton_Click(object sender, EventArgs e)
        {
            comboBox.Enabled = true;
            titretext.Enabled = false;
            prixtext.Enabled = false;
            InsererButton.Enabled = false;
            ModifierButton.Enabled = false;
            SupprimerButton.Enabled = false;
            ConfirmeButton.Enabled = true;
            AnnulerButton.Enabled = true;
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-43NSE72\\SQLEXPRESS;Initial Catalog=Livre1;Integrated Security=True");
            cnx.Open();
            cmd = new SqlCommand("insert into livre values (@Titre,@Prix)", cnx);
            
        }

        private void ModifierButton_Click(object sender, EventArgs e)
        {
            comboBox.Enabled = true;
            titretext.Enabled = false;
            prixtext.Enabled = false;
            InsererButton.Enabled = false;
            ModifierButton.Enabled = false;
            SupprimerButton.Enabled = false;
            ConfirmeButton.Enabled = true;
            AnnulerButton.Enabled = true;
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-43NSE72\\SQLEXPRESS;Initial Catalog=Livre1;Integrated Security=True");
            cnx.Open();
            cmd = new SqlCommand("Update livre set  Prix= @Prix, Titre=@Titre where Titre =@Titre", cnx);
            
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            comboBox.Enabled = true;
            titretext.Enabled = false;
            prixtext.Enabled = false;
            InsererButton.Enabled = false;
            ModifierButton.Enabled = false;
            SupprimerButton.Enabled = false;
            ConfirmeButton.Enabled = true;
            AnnulerButton.Enabled = true;
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-43NSE72\\SQLEXPRESS;Initial Catalog=Livre1;Integrated Security=True");
            cnx.Open();
            cmd = new SqlCommand("Delete livre where Titre =@Titre", cnx);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox.Enabled = true;
            InsererButton.Enabled = true;
            ModifierButton.Enabled = false;
            SupprimerButton.Enabled = false;
            ConfirmeButton.Enabled = false;
            AnnulerButton.Enabled = false;
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-43NSE72\\SQLEXPRESS;Initial Catalog=Livre1;Integrated Security=True");
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select Titre from livre", cnx);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable table = new DataTable();
            adapter.Fill(table);
            //Get selected value
            DataRow row = table.NewRow();
            row[0] = "Selectionnez un livre";
            table.Rows.InsertAt(row, 0);
            comboBox.DataSource = table;
            comboBox.DisplayMember = "Titre";
            
        }

        private void AnnulerButton_Click(object sender, EventArgs e)
        {
            titretext.Text = "";
            prixtext.Text = "";
            comboBox.Enabled = true;
            titretext.Enabled = true;
            prixtext.Enabled = true;
            InsererButton.Enabled = true;
            ModifierButton.Enabled = false;
            SupprimerButton.Enabled = false;
            ConfirmeButton.Enabled = false;
            AnnulerButton.Enabled = false;
        }

        private void ConfirmeButton_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-43NSE72\\SQLEXPRESS;Initial Catalog=Livre1;Integrated Security=True");
            cnx.Open();
            cmd.Parameters.AddWithValue("@Titre", titretext.Text);
            cmd.Parameters.AddWithValue("@Prix", int.Parse(prixtext.Text));
            cmd.ExecuteNonQuery();
            //MessageBox.Show("L'operation est bien faite");
            SqlCommand cmd2 = new SqlCommand("Select Titre from livre", cnx);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd2;
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow row = table.NewRow();
            row[0] = "Selectionnez un livre";
            table.Rows.InsertAt(row, 0);
            comboBox.DataSource = table;
            comboBox.DisplayMember = "Titre";
            cnx.Close();
            titretext.Text = "";
            prixtext.Text = "";
            InsererButton.Enabled = true;
            ModifierButton.Enabled = true;
            SupprimerButton.Enabled = true;
            ConfirmeButton.Enabled = false;
            AnnulerButton.Enabled = false;
            titretext.Enabled = true;
            prixtext.Enabled = true;
        }


        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection("Data Source=DESKTOP-43NSE72\\SQLEXPRESS;Initial Catalog=Livre1;Integrated Security=True");
            cnx.Open();
            cmd = new SqlCommand("Select * from livre where Titre ='" + comboBox.Text+ "'",cnx);
            DataTable dt = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                titretext.Text= dr["Titre"].ToString();
                prixtext.Text = dr["Prix"].ToString();
                InsererButton.Enabled = true;
                ModifierButton.Enabled = true;
                SupprimerButton.Enabled = true;
            }
            cnx.Close();
        }
    }
}
