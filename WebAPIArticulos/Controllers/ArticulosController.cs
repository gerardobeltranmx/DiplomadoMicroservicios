﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIArticulos.Db;

/// <summary>
/// 
/// </summary>
namespace WebAPIArticulos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        // GET: api/<ArticulosController>
        [HttpGet]
        public ActionResult Get()

        {
            Datos Db = new Datos();

           var Resultados = Db.Articulos.Include("Familia").ToList();
            return Ok(Resultados);
        }

       /* 
        // GET api/<ArticulosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ArticulosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ArticulosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ArticulosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    */
    }
}
