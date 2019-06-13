using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ex1
{
    public partial class Form1 : Form
    {
        SqlConnection myCon = new SqlConnection();
        DataSet dsUniv;
        DataSet dsFac;
        public Form1()
        {
            System.Diagnostics.Debug.WriteLine("Entered the constructor AAAAAAAAAAA");
            InitializeComponent();
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename =|DataDirectory|\\Database1.mdf;Integrated Security = True";
            readUniversitati();
        }

        private void readUniversitati()
        { 
            myCon.Open();
            dsUniv = new DataSet();
            dsFac = new DataSet();
            listBox_Univ.Items.Clear();
            SqlDataAdapter daUniv = new SqlDataAdapter("SELECT * FROM Universitati", myCon);
            daUniv.Fill(dsUniv, "Universitati");
            SqlDataAdapter daFac = new SqlDataAdapter("SELECT * FROM Facultati", myCon);
            daFac.Fill(dsFac, "Facultati");
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                String name = dr.ItemArray.GetValue(1).ToString();
                listBox_Univ.Items.Add(name);
            }
             myCon.Close();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListBox_Fac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox_Univ_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Entered the method AAAAAAAAAAA");
            listBox_Fac.Items.Clear();
            textBox_City.Clear();
            int code = 0;
            String UnivSelected = listBox_Univ.SelectedItem.ToString();
            foreach (DataRow dr in dsUniv.Tables["Universitati"].Rows)
            {
                if (UnivSelected == dr.ItemArray.GetValue(1).ToString())
                {
                    textBox_City.Text = dr.ItemArray.GetValue(2).ToString();
                    code = Convert.ToInt16(dr.ItemArray.GetValue(3));
                    textBox_CodeUniv.Text = code.ToString();
                }
            }
            foreach (DataRow dr in dsFac.Tables["Facultati"].Rows)
            {
                if (code == Convert.ToInt16(dr.ItemArray.GetValue(1)))
                {
                    String nameFac = dr.ItemArray.GetValue(2).ToString();
                    listBox_Fac.Items.Add(nameFac);
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String nameUniv = "UBB";
            String city = "Cluj-Napoca";
            int code = 2;

            DataRow dr = dsUniv.Tables["Universitati"].NewRow();
            dr.SetField(0, 2);
            dr.SetField(1, nameUniv);
            dr.SetField(2, city);
            dr.SetField(3, code);

            dsUniv.Tables["Universitati"].Rows.Add(dr);

            myCon.Open();
            SqlCommand cmdInsert = new SqlCommand("INSERT INTO Universitati (Id , NameUniv,City,Code) " +
                "VALUES (@value1 , @value2, @value3,@value4)", myCon);
            cmdInsert.Parameters.AddWithValue("@value1", 2);
            cmdInsert.Parameters.AddWithValue("@value2", nameUniv);
            cmdInsert.Parameters.AddWithValue("@value3", city);
            cmdInsert.Parameters.AddWithValue("@value4", code);
            cmdInsert.ExecuteNonQuery();

           
            myCon.Close();
            readUniversitati();

        }
    }
}
