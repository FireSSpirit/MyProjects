using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Сountry_dates.Models;

namespace Сountry_dates.ViewModels
{
    public class CountriesViewModel : INotifyPropertyChanged
    {
        static String connectionString = @"Data Source=vibes\sqlexpress;Initial Catalog=ParallelCodes;User ID=sa;Password=789;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        public ObservableCollection<Countries> countries { get; set; }
        public String txtSelectedItem { get; set; }
        public CountriesViewModel()
        {
            txtSelectedItem = "Please select a country";
            FillList();
        }

        public void FillList()
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("select * from tblCountries", con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "tblCountries");

                if (countries == null)
                    countries = new ObservableCollection<Countries>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    countries.Add(new Countries
                    {
                        id = Convert.ToInt32(dr[0].ToString()),
                        country = dr[1].ToString(),
                        ondate = Convert.ToDateTime(dr[2].ToString())
                    });
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ds = null;
                adapter.Dispose();
                con.Close();
                con.Dispose();
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
