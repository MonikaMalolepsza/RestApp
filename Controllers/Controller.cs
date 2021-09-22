using Newtonsoft.Json;
using RestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace RestApp.Controllers
{
    public class Controller
    {
        #region Attributes

        private List<TestModelClass> _dataList;

        #endregion Attributes

        #region Properties

        public List<TestModelClass> DataList { get => _dataList; set => _dataList = value; }

        #endregion Properties

        #region Constructors

        public Controller()
        {
            DataList = new List<TestModelClass>();
            DataList.Add(new TestModelClass(1, "Test1"));
            DataList.Add(new TestModelClass(2, "Test2"));
            DataList.Add(new TestModelClass(3, "Test3"));
            DataList.Add(new TestModelClass(4, "Test4"));
            DataList.Add(new TestModelClass(5, "Test5"));
        }

        #endregion Constructors

        #region Methods

        public void DeleteApiTest(int id)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:44395/api/Default/{id}";

            Task<HttpResponseMessage> response = client.DeleteAsync(url);
            try
            {
                response.Wait();
            }
            catch (Exception e)
            {
                //Fehlermeldung
                return;
            }

            HttpResponseMessage result = response.Result;
            Task<string> content = result.Content.ReadAsStringAsync();

            try
            {
                content.Wait();
            }
            catch (Exception e)
            {
                return;
            }

            string empfang = content.Result;
        }

        public void GetApiTest(int id)
        {
            HttpClient client = new HttpClient();
            string url = $"https://localhost:44395/api/Default/{id}";

            Task<HttpResponseMessage> response = client.GetAsync(url);
            try
            {
                response.Wait();
            }
            catch (Exception e)
            {
                //Fehlermeldung
                return;
            }

            HttpResponseMessage result = response.Result;
            Task<string> content = result.Content.ReadAsStringAsync();

            try
            {
                content.Wait();
            }
            catch (Exception e)
            {
                return;
            }

            string empfang = content.Result;
        }

        public void PutApiTest()
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44395/api/Default/4";
            var json = JsonConvert.SerializeObject(new TestModelClass(10, "Test10"));
            Task<HttpResponseMessage> response = client.PutAsJsonAsync(url, json);

            try
            {
                response.Wait();
            }
            catch (Exception e)
            {
                //Fehlermeldung
                return;
            }

            HttpResponseMessage result = response.Result;
            Task<string> content = result.Content.ReadAsStringAsync();

            try
            {
                content.Wait();
            }
            catch (Exception e)
            {
                return;
            }

            string empfang = content.Result;
        }

        public void PostApiTest()
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44395/api/Default";
            var json = JsonConvert.SerializeObject(new TestModelClass(10, "Test10"));
            Task<HttpResponseMessage> response = client.PostAsJsonAsync(url, json);

            try
            {
                response.Wait();
            }
            catch (Exception e)
            {
                //Fehlermeldung
                return;
            }

            HttpResponseMessage result = response.Result;
            Task<string> content = result.Content.ReadAsStringAsync();

            try
            {
                content.Wait();
            }
            catch (Exception e)
            {
                return;
            }

            string empfang = content.Result;
        }

        public void GetApiTest()
        {
            HttpClient client = new HttpClient();
            string url = "https://localhost:44395/api/Default";

            Task<HttpResponseMessage> response = client.GetAsync(url);

            //Task<HttpResponseMessage> response = client.PostAsJsonAsync(url, json);
            //Task<HttpResponseMessage> response = client.PutAsJsonAsync(url, json);
            //Task<HttpResponseMessage> response = client.DeleteAsync(); -> andere URL
            try
            {
                response.Wait();
            }
            catch (Exception e)
            {
                //Fehlermeldung
                return;
            }

            HttpResponseMessage result = response.Result;
            Task<string> content = result.Content.ReadAsStringAsync();

            try
            {
                content.Wait();
            }
            catch (Exception e)
            {
                return;
            }

            string empfang = content.Result;
        }

        #endregion Methods
    }
}