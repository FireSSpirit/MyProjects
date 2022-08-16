using El_Store_WPF.Models;
using El_Store_WPF.Views;
using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Type = El_Store_WPF.Models.Type;

namespace El_Store_WPF.ViewModels
{
    //База данных
    public class BaseVM
    {
        #region Fields
        private readonly string connectionString;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private static int id;
        #endregion
        public BaseVM()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }
        #region Methods
        internal void StartDB()
        {
            // Считываем данные из БД и записываем в коллекции
            try
            {
                MainViewModel.Products = new ObservableCollection<Product>();
                MainViewModel.Phones = new ObservableCollection<Phone>();
                MainViewModel.Earphones = new ObservableCollection<Earphone>();

                con = new SqlConnection(connectionString);
                con.Open();
                cmd = new SqlCommand("select * from all_products_tb", con);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds, "all_products_tb");

                cmd = new SqlCommand("select * from phones_tb", con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "phones_tb");

                cmd = new SqlCommand("select * from earphones_tb", con);
                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds, "earphones_tb");

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    MainViewModel.Products.Add(new Product(Convert.ToInt32(dr[0].ToString()), dr[1].ToString(), Convert.ToDecimal(dr[2].ToString()), dr[3].ToString(), Convert.ToInt32(dr[4].ToString())));
                }
                if (MainViewModel.Products != null)
                {
                    id = MainViewModel.Products[MainViewModel.Products.Count - 1].Id;
                }
                else
                {
                    id = 0;
                }

                if (ds.Tables[1].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[1].Rows)
                    {
                        foreach (Product product in MainViewModel.Products)
                        {
                            if (product.Id == Convert.ToInt32(dr[0].ToString()))
                            {
                                MainViewModel.Phones.Add(new Phone(product.Id, product.Name, product.Price, product.Manufacturer, product.Count, Convert.ToDouble(dr[2].ToString()), dr[3].ToString()));
                                product.TypeProduct = Type.Phone;
                                break;
                            }
                        }
                    }
                }
                if (ds.Tables[2].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[2].Rows)
                    {
                        foreach (Product product in MainViewModel.Products)
                        {
                            if (product.Id == Convert.ToInt32(dr[0].ToString()))
                            {
                                MainViewModel.Earphones.Add(new Earphone(product.Id, product.Name, product.Price, product.Manufacturer, product.Count, Convert.ToInt32(dr[2].ToString()), Convert.ToInt32(dr[3].ToString()), Convert.ToBoolean(dr[4].ToString())));
                                product.TypeProduct = Type.Earphone;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка в базе данных.");
            }
        }

        internal void AddDB()
        {
            cmd = new SqlCommand();
            AddWindow addWindow = new AddWindow();
            Product pp = new Phone(0, "", 0, "", 0, 0, "");
            Product pe = new Earphone(0, "", 0, "", 0, 0, 0, false);
            addWindow.phonesTab.DataContext = (Phone)pp;
            addWindow.earphonesTab.DataContext = (Earphone)pe;
            // Добавляем данные, при этом, определяя, какая вкладка открыта
            if (addWindow.ShowDialog() == true)
            {
                if (addWindow.products.SelectedItem == addWindow.phonesTab)
                {
                    pp.Id = ++id;
                    MainViewModel.Products.Add(pp);
                    MainViewModel.Phones.Add((Phone)pp);
                    cmd = new SqlCommand(String.Format("insert into all_products_tb values('" + pp.Id + "{0}" + pp.Name + "{0}" + pp.Price + "{0}" + pp.Manufacturer + "{0}" + pp.Count + "{0}" + pp.TypeProduct + "');", "','"), con);
                    cmd.CommandText += String.Format("insert into phones_tb values('" + pp.Id + "{0}" + pp.Name + "{0}" + ((Phone)pp).Diagonal + "{0}" + ((Phone)pp).Color + "');", "','");
                }
                else
                if (addWindow.products.SelectedItem == addWindow.earphonesTab)
                {
                    pe.Id = ++id;
                    MainViewModel.Products.Add(pe);
                    MainViewModel.Earphones.Add((Earphone)pe);
                    cmd = new SqlCommand(String.Format("insert into all_products_tb values('" + pe.Id + "{0}" + pe.Name + "{0}" + pe.Price + "{0}" + pe.Manufacturer + "{0}" + pe.Count + "{0}" + pe.TypeProduct + "');", "','"), con);
                    cmd.CommandText += String.Format("insert into earphones_tb values('" + pe.Id + "{0}" + pe.Name + "{0}" + ((Earphone)pe).MinHz + "{0}" + ((Earphone)pe).MaxHz + "{0}" + ((Earphone)pe).Wireless + "');", "','");
                }
                cmd.ExecuteNonQuery();
            }
        }

        internal void UpdateDB(Product p)
        {
            cmd = new SqlCommand();
            AddWindow addWindow = new AddWindow();
            int index = MainViewModel.Products.IndexOf(p);
            // Определяем тип продукта и обновляем о нем данные, если внесены изменения
            switch (p.TypeProduct)
            {
                case Type.Phone:
                    Phone phone = MainViewModel.Phones.Where(x => x.Id == p.Id).FirstOrDefault();
                    addWindow.phonesTab.DataContext = phone;

                    if (addWindow.ShowDialog() == true)
                    {
                        p.Name = phone.Name;
                        p.Price = phone.Price;
                        p.Manufacturer = phone.Manufacturer;
                        p.Count = phone.Count;
                        cmd = new SqlCommand("update phones_tb set name_phone = '" + phone.Name + "', diagonal = '" + phone.Diagonal + "', color = '" + phone.Color + "' where phone_id = " + phone.Id + ";", con);
                    }
                    break;

                case Type.Earphone:
                    Earphone earphone = MainViewModel.Earphones.FirstOrDefault(x => x.Id == p.Id);
                    addWindow.earphonesTab.DataContext = earphone;
                    addWindow.products.SelectedItem = addWindow.earphonesTab;

                    if (addWindow.ShowDialog() == true)
                    {
                        p.Name = earphone.Name;
                        p.Price = earphone.Price;
                        p.Manufacturer = earphone.Manufacturer;
                        p.Count = earphone.Count;
                        cmd = new SqlCommand("update earphones_tb set name_earphone = '" + earphone.Name + "', minHZ = '" + earphone.MinHz + "', maxHZ = '" + earphone.MaxHz + "', wireless = '" + earphone.Wireless + "' where earphone_id = " + earphone.Id + ";", con);
                    }
                    break;
            }
            if (cmd.CommandText != "")
            {
                MainViewModel.Products.Remove(MainViewModel.Products[index]);
                MainViewModel.Products.Insert(index, p);
                cmd.CommandText += "update all_products_tb set name_product = '" + p.Name + "', price = '" + p.Price + "', manufacturer = '" + p.Manufacturer + "', count_Product = '" + p.Count + "' where id = " + p.Id + ";";
                cmd.ExecuteNonQuery();
            }

        }

        internal void DeleteDB(Product p)
        {
            // Удаляем запись из коллекции типа и продукта, а также из БД
            switch (p.TypeProduct)
            {
                case Type.Phone:
                    Phone phone = MainViewModel.Phones.Where(x => x.Id == p.Id).FirstOrDefault();
                    MainViewModel.Phones.Remove(phone);
                    cmd = new SqlCommand("delete from phones_tb where phone_id = " + p.Id + ";", con);
                    break;

                case Type.Earphone:
                    Earphone earphone = MainViewModel.Earphones.Where(x => x.Id == p.Id).FirstOrDefault();
                    MainViewModel.Earphones.Remove(earphone);
                    cmd = new SqlCommand("delete from earphones_tb where earphone_id = " + p.Id + ";", con); 
                    break;
            }
            cmd.CommandText += "delete from all_products_tb where id = " + p.Id + ";";
            cmd.ExecuteNonQuery();
        }
        #endregion
    }
}
