using System;
using System.Net.Http;
using System.Net;
using System.Collections.Generic;

namespace ParsingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Parsing(url: "https://www.lamoda.ru/c/15/shoes-women/?sitelink=topmenuW&l=4&brands=2047");
        if (result != null)
            {
                foreach(var item in result)
                {
                    // Console.WriteLine(item.Key, "--------", item.Value);
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }

        private static string[] Parsing(string url)
        {
            try
            {
                //Dictionary<string, string> result = new Dictionary<string, string>();
                string[] result = new string[130];
                using (HttpClientHandler hdl = new HttpClientHandler())
                {
                    using(var client = new HttpClient(hdl))
                    {
                        using (HttpResponseMessage resp = client.GetAsync(url).Result)
                        {
                            if (resp.IsSuccessStatusCode)
                            {
                                var html = resp.Content.ReadAsStringAsync().Result;
                                if (!string.IsNullOrEmpty(html))
                                {
                                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                                    doc.LoadHtml(html);
                                    //grid__catalog
                                    //div[@class='preloader preloader_1 preloader_wrapper']//
                                    ////div[@class='x-product-card__card']//div[@class='x-product-card__link x-product-card__hit-area']//div[@class='x-product-card-description']//div[@class='x-product-card-description__microdata-wrap']
                                    var products = doc.DocumentNode.SelectNodes(".//div[@class='grid__catalog']//div[@class='x-product-card__card']//div[@class='x-product-card-description__microdata-wrap']");
                                    if (products != null && products.Count > 0)
                                    {
                                        for(int i = 0; i < products.Count; i = i + 2)
                                        {
                                            result[i] = products[i].NextSibling.InnerText;
                                            result[i + 1] = products[i].LastChild.FirstChild.InnerText;
                                        }

                                        //foreach (var product in products)
                                        //{
                                        //    var NameProduct = product.InnerText;
                                        //    var NameProduct = product.SelectNodes(".//div[@class='x-product-card-description__brand-name']");
                                        //    var PriceProduct = product.SelectSingleNode(".//span[@class='x-product-card-description__price-single x-product-card-description__price-WEB8507_price_no_bold']");
                                        //    result.Add(product.NextSibling.InnerText, product.InnerText);
                                        //    result.
                                        //    Console.WriteLine(NameProduct);
                                        //}

                                    }
                                    else
                                    {
                                        Console.WriteLine("No data");
                                    }
                                    return result;
                                }
                            }
                            Console.WriteLine("Error");
                            return null;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
