﻿using Newtonsoft.Json;
using RestAnwendung.Controllers;
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
        BackendController bc = new BackendController();


        // GET: api/Test
        public string Get()
        {
            return JsonConvert.SerializeObject(bc.DataList);
        }

        // GET: api/Test/5
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(bc.DataList.FirstOrDefault(x => x.Id == id));
        }

        // POST: api/Test
        public IHttpActionResult Post([FromBody] string value)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid data.");
            TestModelClass tmc = JsonConvert.DeserializeObject<TestModelClass>(value);
            bc.DataList.Add(tmc);
            return Ok();

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
            return Ok();
        }

        // DELETE: api/Test/5
        public IHttpActionResult Delete(int id)
        {
            if (bc.DataList.Exists(x => x.Id == id))
            {
                bc.DataList.RemoveAll(x => x.Id == id);
                return Ok();
            }
            else
            {
                return BadRequest("Invalid Id");
            }
        }

    }
}