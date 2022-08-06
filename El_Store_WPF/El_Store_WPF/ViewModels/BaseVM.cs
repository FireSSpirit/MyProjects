using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using El_Store_WPF.Models;
using System.Collections.ObjectModel;

namespace El_Store_WPF.ViewModels
{
    public class BaseVM
    {
        //string connectionString;
        //SqlDataAdapter adapter;
        //DataTable productsTable;

        static String connectionString;
        SqlConnection con;
        SqlCommand cmd;
        static public SqlDataAdapter adapter;
        //DataTable productsTable;
        static public DataSet ds;
        
        public BaseVM()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        internal void StartDB()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("select * from all_products_tb", con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                //productsTable = new DataTable();
                adapter.Fill(ds, "all_products_tb");
                //adapter.Fill(productsTable);
                if (MainViewModel.products == null)
                    MainViewModel.products = new ObservableCollection<Product>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                //    foreach (DataRow dr in productsTable.Rows)
                    {
                    MainViewModel.products.Add(new Product
                    {
                        Id = Convert.ToInt32(dr[0].ToString()),
                        Name = dr[1].ToString(),
                        Price = Convert.ToDecimal(dr[2].ToString()),
                        Manufacturer = dr[3].ToString(),
                        Count = Convert.ToInt32(dr[4].ToString())
                    });
                }
            }
            catch (Exception ex)
            {

            }
            //finally
            //{
            //    ds = null;
            //    adapter.Dispose();
            //    con.Close();
            //    con.Dispose();
            //}
        }

        internal void AddDB(Product p)
        {
            cmd = new SqlCommand(String.Format("insert into all_products_tb values('" + p.Id + "{0}" + p.Name + "{0}" + p.Price + "{0}" + p.Manufacturer + "{0}" + p.Count + "')", "','"), con);
            cmd.ExecuteNonQuery();
        }

        internal void UpdateDB(Product p)
        {
            cmd = new SqlCommand(String.Format("update all_products_tb set name_product = '" + p.Name + "', price = '" + p.Price + "', manufacturer = '" + p.Manufacturer + "', count_Product = '" + p.Count + "' where id = " + p.Id, "','"), con);
            cmd.ExecuteNonQuery();
        }

        internal void DeleteDB(int id)
        {
            cmd = new SqlCommand("delete from all_products_tb where id = " + id, con);
            cmd.ExecuteNonQuery();           
        }
    }
}
