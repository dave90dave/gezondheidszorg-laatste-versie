using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Module_2_Les_3_Northwind_klantenservice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            //Connectionstring
            SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\Module 2 Les 3 Northwind klantenservice\Module 2 Les 3 Northwind klantenservice\Northwind.mdf;Integrated Security=True";
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", conn);
 

            //SQL datareader
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> lijst = new List<Customer>();
            while (reader.Read())
            {
                Customer p = new Customer();
                p._CustomerID = (string)reader["customerid"];
                p._CompanyName = (string)reader["companyname"];
                p._ContactName = (string)reader["contactname"];
                p._City = (string)reader["city"];
                p._Country = (string)reader["country"];
                p._Phone = (string)reader["phone"];
                lijst.Add(p);
            }
            dataGridView1.DataSource = lijst;


           // int verwijderid = 2; // zet in deze variabele het goede id

           // SqlCommand delcmd = new SqlCommand("DELETE FROM product WHERE id = @id", conn);


            

            //cmd.Parameters.AddWithValue("verwijderid", verwijderid);

           // int result = cmd.ExecuteNonQuery();

        }

        private void zoekbtn_Click(object sender, EventArgs e)
        {

            //Connectionstring
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\source\repos\Module 2 Les 3 Northwind klantenservice\Module 2 Les 3 Northwind klantenservice\Northwind.mdf;Integrated Security=True";
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers WHERE CustomerID LIKE @Zoeken ;", conn);
            cmd.Parameters.AddWithValue("@Zoeken", Zoeken.Text);

            //SQL datareader
            SqlDataReader reader = cmd.ExecuteReader();
            List<Customer> lijst = new List<Customer>();
            while (reader.Read())
            {
                Customer p = new Customer();
                p._CustomerID = (string)reader["customerid"];
                p._CompanyName = (string)reader["companyname"];
                p._ContactName = (string)reader["contactname"];
                p._City = (string)reader["city"];
                p._Country = (string)reader["country"];
                p._Phone = (string)reader["phone"];
                lijst.Add(p);
            }
            dataGridView1.DataSource = lijst;
        }
    }

    }

