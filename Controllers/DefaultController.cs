using Newtonsoft.Json;
using RestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestApp.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: api/Default
        public string Get()
        {
            Controller c = new Controller();
            return JsonConvert.SerializeObject(c.DataList);
        }

        // GET: api/Default/5
        public string Get(int id)
        {
            Controller c = new Controller();
            return JsonConvert.SerializeObject(c.DataList.FirstOrDefault(x => x.Id == id));
        }

        // POST: api/Default
        public void Post([FromBody] string value)
        {
            TestModelClass tmc = JsonConvert.DeserializeObject<TestModelClass>(value);
            Controller c = new Controller();
            c.DataList.Add(tmc);
        }

        // PUT: api/Default/5
        public void Put(int id, [FromBody] string value)
        {
            TestModelClass tmc = JsonConvert.DeserializeObject<TestModelClass>(value);
            Controller c = new Controller();
            if (c.DataList.Where(x => x.Id == tmc.Id).ToList().Count == 1)
            {
                c.DataList.First(x => x.Id == tmc.Id).Kopieren(tmc);
            }
            else
            {
                c.DataList.Add(tmc);
            }
        }

        // DELETE: api/Default/5
        public void Delete(int id)
        {
            Controller c = new Controller();
            c.DataList.RemoveAll(x => x.Id == id);
        }
    }
}