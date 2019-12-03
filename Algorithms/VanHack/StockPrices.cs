using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.VanHack
{
    public class StockPrices
    {
        public static void openAndClosePrices(string firstDate, string lastDate, string weekDay)
        {
            int defaultPageNumber = 1;
            try
            {
                List<Data> datas = new List<Data>();
                DayOfWeek dayOfWeek;
                Enum.TryParse(weekDay, true, out dayOfWeek);
                var result = GetPrices(defaultPageNumber);
                datas.AddRange(result.Data);
                int totalPage = result.Total_pages;

                if (result.Total_pages > result.Page)
                {
                    while (defaultPageNumber < totalPage)
                    {
                        defaultPageNumber += 1;
                        result = GetPrices(defaultPageNumber);
                        datas.AddRange(result.Data);
                    }
                }


                if (!string.IsNullOrEmpty(firstDate) && !string.IsNullOrEmpty(lastDate))
                {
                    datas = datas.Where(x => Convert.ToDateTime(x.Date) >= Convert.ToDateTime(firstDate) && Convert.ToDateTime(x.Date) <= Convert.ToDateTime(lastDate)).ToList();
                }

                if (!string.IsNullOrEmpty(weekDay))
                {
                    datas = datas.Where(x => Convert.ToDateTime(x.Date).DayOfWeek == dayOfWeek).ToList();
                }

                foreach (var data in datas)
                {
                    Console.WriteLine($"{data.Date}   {data.Open}   {data.Close} \n");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        static ResponseObject GetPrices(int pageNumber)
        {
            string address = "https://jsonmock.hackerrank.com/api/stocks/?page=" + pageNumber;
            HttpClient _httpClient = new HttpClient();
            try
            {
                var response = _httpClient.GetAsync(address);
                var content = response.Result.Content.ReadAsStringAsync();
                var result = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseObject>(content.Result);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public class Data
        {
            public string Date { get; set; }
            public float Open { get; set; }
            public float Close { get; set; }
            public float High { get; set; }

            public float Low { get; set; }
        }

        public class ResponseObject
        {
            public int Page { get; set; }
            public int Per_page { get; set; }
            public int Total { get; set; }
            public int Total_pages { get; set; }
            public List<Data> Data { get; set; }
        }
    }
}
