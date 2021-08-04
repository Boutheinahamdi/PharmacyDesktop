
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;

namespace pharmacy
{
    class FormMetier
    {
        private MySqlConnection con;
        public FormMetier()
        {
         
            

        }
        /*public List<string> GetCat()
        {
            List<string> list = new List<string>();
            try
            {
                this.con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=boutheina@2907; database=pharmacy");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from produit", con);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    list.Add(dr.GetString(1));
                    Console.WriteLine(dr.GetString(1));
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return list;
        }*/
        public void AjouterMed(string nom,decimal  p,string d,int selc)
        {
            try
            {

                this.con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=boutheina@2907; database=pharmacy");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("insert into produit (nameprod,prix,designation,idcat) values(@x,@y,@z,@t);", con);
                MySqlParameter p1 = new MySqlParameter("@x", nom);
                MySqlParameter p2 = new MySqlParameter("@y", p);
                MySqlParameter p3 = new MySqlParameter("@z", d);
                MySqlParameter p4 = new MySqlParameter("@t", selc);

                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          


        }
        public void Supprimermed(string d)
        {
            

            try
            {
                this.con = new MySqlConnection("datasource=localhost; port=3306; username=root; password=boutheina@2907; database=pharmacy");
                con.Open();
                MySqlCommand cmd = new MySqlCommand("delete from produit where designation=@x;", con);
                MySqlParameter p1 = new MySqlParameter("@x", d);
               

                cmd.Parameters.Add(p1);
                
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
       

    }
}
