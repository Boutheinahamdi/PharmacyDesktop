using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace pharmacy
{
    public partial class Form1 : Form
    {
        FormMetier formMetier = new FormMetier();
        FormMetier F = new FormMetier();
        private MySqlConnection con;
        public Form1()
        {
            InitializeComponent();
            //List<String> data_ = formMetier.GetCat();


        }

        private void nom_TextChanged(object sender, EventArgs e)
        {
            if (nom.Text.Trim() == string.Empty)
            {
                MessageBox.Show("il doit contenir un string ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nom.Focus();
            }
        }

       

        private void prix_TextChanged(object sender, EventArgs e)
        {
            
            Decimal p;
            bool ok = Decimal.TryParse(prix.Text.Trim(), out p);
            if (!ok || p < 0)
            {
                // msg d'erreur
                MessageBox.Show("Salaire incorrect", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                prix.Focus();
            }
        }

       

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
           if((prix.Text.Equals("")) || (nom.Text.Equals("")) || (design.Text.Equals("")) )
            {
               
               
                MessageBox.Show("les champs ne doit pas rester vide ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                prix.Focus();
            }
           else
            {
                int a=0;
                this.con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=boutheina@2907; database=pharmacy");
                con.Open();
                MySqlCommand cmd1 = new MySqlCommand("select idcat from categorie where namecat like @t", con);
                string b = this.list1.GetItemText(this.list1.SelectedItem);
                MySqlParameter p4 = new MySqlParameter("@t", b);
                cmd1.Parameters.Add(p4);
                MySqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    a = dr.GetInt32(0);
                }
                decimal price = Decimal.Parse(prix.Text);
                formMetier.AjouterMed(nom.Text, price, design.Text,a);
            }

        }

        private void buttonsupprimer_Click(object sender, EventArgs e)
        {



            formMetier.Supprimermed(design.Text);
            

        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=boutheina@2907; database=pharmacy");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select namecat from categorie;", con);
            MySqlDataAdapter dap = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            dap.Fill(ds, "categorie");
            foreach (DataRow x in ds.Tables[0].Rows)
            {
                list1.Items.Add(x[0]);
            }
        }

        private void recherche_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = null;
            this.con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=boutheina@2907; database=pharmacy");
            con.Open();
            MySqlCommand cmd0 = new MySqlCommand("select nameprod from produit where designation like @x ", con);
            string y = recherche.Text;
            MySqlParameter p5 = new MySqlParameter("@x", y);
            cmd0.Parameters.Add(p5);
            MySqlDataReader dr = cmd0.ExecuteReader();
            
            if (dr.Read())
            {
                a = dr.GetString(0);
                MessageBox.Show("le produit existe ", "vrai", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("le produit n'existe pas ", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void buttonsupcat_Click(object sender, EventArgs e)
        {
            string a = null;
            
                this.con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=boutheina@2907; database=pharmacy");
                con.Open();
                MySqlCommand cmd3 = new MySqlCommand("delete from categorie where namecat like @x;", con);
                string b = this.list1.GetItemText(this.list1.SelectedItem);
            
            MySqlParameter p1 = new MySqlParameter("@x", b);
                cmd3.Parameters.Add(p1);
            MySqlDataReader dr = cmd3.ExecuteReader();

            if (dr.Read())
            {
                a = dr.GetString(0);
                MessageBox.Show("categorie supprimer! ", "vrai", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        private void buttonaddcat_Click(object sender, EventArgs e)
        {

            this.con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=boutheina@2907; database=pharmacy");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into categorie (namecat) values(@x);", con);
            string b = textcat.Text;

            MySqlParameter p1 = new MySqlParameter("@x", b);
            cmd.Parameters.Add(p1);
            MySqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
               
                MessageBox.Show("categorie supprimer! ", "vrai", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
