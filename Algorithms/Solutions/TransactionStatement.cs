using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Solutions
{
    public class TransactionStatement
    {
        public static List<List<int>> getTxnAmountByLocation(int locationId, string txnType)
        {
            var result = new List<List<int>>();
            int defaultPageNumber = 1;
            try
            {
                List<Data> datas = new List<Data>();
                //Call GetTransactions using the defaultpage number 
                var response = GetTransactions(txnType, defaultPageNumber);
                datas.AddRange(response.Data);
                int totalPage = response.Total_pages;

                //Compare if the total pages in the response is greater than the current page
                //If yes, then, loop to get datas for other records
                if (response.Total_pages > response.Page)
                {
                    while (defaultPageNumber < totalPage)
                    {
                        defaultPageNumber += 1;
                        response = GetTransactions(txnType, defaultPageNumber);
                        //Add the result to list of datas
                        datas.AddRange(response.Data);
                    }
                }

                //Filter using the location
                datas = datas.Where(x => x.Location.Id == locationId).ToList();

                //Check if no record matches the filter
                if (datas.Count < 1)
                {
                    result.Add(new List<int> { -1, -1 });
                }

                //Sum the records based on User Id
                var summaryByUserIds = from user in datas
                                       group user by user.UserId into userGroup
                                       orderby userGroup.Key ascending
                                       select new
                                       {
                                           UserId = userGroup.Key,
                                           TotalAmount = userGroup.Sum(x => Decimal.Parse(x.Amount, NumberStyles.Currency))
                                       };

                foreach (var userDetail in summaryByUserIds)
                {
                    result.Add(new List<int> { userDetail.UserId, Convert.ToInt32(Math.Truncate(userDetail.TotalAmount)) });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        static ResponseObject GetTransactions(string txnType, int pageNumber)
        {
            string URL = "https://jsonmock.hackerrank.com/api/transactions/search?txnType=" + txnType + "&page=" + pageNumber;
            using (var _httpClient = new HttpClient())
            {
                try
                {
                    var response = _httpClient.GetAsync(URL);
                    var content = response.Result.Content.ReadAsStringAsync();
                    var result = Newtonsoft.Json.JsonConvert.DeserializeObject<ResponseObject>(content.Result);

                    return result;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public class Data
        {
            public int Id { get; set; }
            public double TimeStamp { get; set; }
            public int UserId { get; set; }
            public string UserName { get; set; }
            public string TxnType { get; set; }
            public string Amount { get; set; }
            public Location Location { get; set; }
            public string Ip { get; set; }
        }

        public class ResponseObject
        {
            public int Page { get; set; }
            public int Per_page { get; set; }
            public int Total { get; set; }
            public int Total_pages { get; set; }
            public List<Data> Data { get; set; }
        }

        public class Location
        {
            public int Id { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string ZipCode { get; set; }
        }
    }
}
