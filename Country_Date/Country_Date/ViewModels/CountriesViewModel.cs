using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Country_Date.Models;

namespace Country_Date.ViewModels
{
    public class CountriesViewModel : INotifyPropertyChanged
    {
        static String connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Country_DB;Integrated Security=True;";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        private ObservableCollection<Countries> countries;
        public ObservableCollection<Countries> Countries
        {
            get { return countries; }
            set
            {
                countries = value;
                OnPropertyChanged("Countries");
            }
        }
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

                if (Countries == null)
                    Countries = new ObservableCollection<Countries>();

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    Countries.Add(new Countries
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
