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
        private BackendController bc = Global.ControllerB;

        // GET: api/Test
        public List<TestModelClass> Get()
        {
            //List<TestModelClass> neu = new List<TestModelClass>();
            //neu.Add(new TestModelClass(1, "Test"));
            return bc.DataList;
        }

        // GET: api/Test/5
        public TestModelClass Get(int id)
        {
            return bc.DataList.FirstOrDefault(x => x.Id == id);
        }

        // POST: api/Test
        public IHttpActionResult Post([FromBody] string value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            TestModelClass tmc = JsonConvert.DeserializeObject<TestModelClass>(value);
            bc.DataList.Add(tmc);
            return Ok("Success");
        }

        // PUT: api/Test/5
        public IHttpActionResult Put(int id, [FromBody] string value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            TestModelClass tmc = JsonConvert.DeserializeObject<TestModelClass>(value);
            if (bc.DataList.Where(x => x.Id == tmc.Id).ToList().Count == 1)
            {
                bc.DataList.First(x => x.Id == tmc.Id).Copy(tmc);
            }
            else
            {
                bc.DataList.Add(tmc);
            }
            return Ok("Success");
        }

        // DELETE: api/Test/5
        public IHttpActionResult Delete(int id)
        {
            if (bc.DataList.Exists(x => x.Id == id))
            {
                bc.DataList.RemoveAll(x => x.Id == id);
                return Ok("Success");
            }
            else
            {
                return BadRequest("Invalid Id");
            }
        }
    }
}