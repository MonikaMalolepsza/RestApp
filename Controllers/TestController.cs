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
    public class TestController : ApiController
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
        public IHttpActionResult Post([FromBody] string value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            TestModelClass tmc = JsonConvert.DeserializeObject<TestModelClass>(value);
            Controller c = new Controller();
            c.DataList.Add(tmc);
            return Ok();

        }

        // PUT: api/Default/5
        public IHttpActionResult Put(int id, [FromBody] string value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            TestModelClass tmc = JsonConvert.DeserializeObject<TestModelClass>(value);
            Controller c = new Controller();
            if (c.DataList.Where(x => x.Id == tmc.Id).ToList().Count == 1)
            {
                c.DataList.First(x => x.Id == tmc.Id).Copy(tmc);
            }
            else
            {
                c.DataList.Add(tmc);
            }
            return Ok();
        }

        // DELETE: api/Default/5
        public IHttpActionResult Delete(int id)
        {
            Controller c = new Controller();
            c.DataList.RemoveAll(x => x.Id == id);
            return Ok();

        }

    }
}