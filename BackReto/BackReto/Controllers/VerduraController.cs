using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackReto.Context;
using BackReto.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackReto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VerduraController :ControllerBase
    {

        private readonly ApiDBContext _dbContext;
        public VerduraController(ApiDBContext dBContext)
        {
            _dbContext = dBContext;
        }



        // GET: api/<GestoresController>
        [HttpGet]
        public ActionResult<string> Get()
        {
            try
            {
                return Ok(_dbContext.verdura.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GestoresController>/5
        [HttpGet("{id}", Name = "GetVerdura")]
        public ActionResult Get(int id)
        {
            try
            {
                var verdura = _dbContext.verdura.FirstOrDefault(x => x.idVerdura == id);
                return Ok(verdura);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST api/<GestoresController>
        [HttpPost]
        public ActionResult Post([FromBody] Verdura verdura)
        {
            try
            {
                _dbContext.Add(verdura);
                _dbContext.SaveChanges();
                return CreatedAtRoute("GetVerdura", new { id = verdura.idVerdura }, verdura);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<GestoresController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Verdura verdura)
        {
            try
            {
                if (verdura.idVerdura == id)
                {

                    _dbContext.Entry(verdura).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    _dbContext.SaveChanges();
                    return CreatedAtRoute("GetVerdura", new { id = verdura.idVerdura }, verdura);
                }
                else

                {
                    return BadRequest();
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<GestoresController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var v = _dbContext.verdura.FirstOrDefault(x => x.idVerdura == id);
                if (v != null)
                {
                    _dbContext.Remove(v);
                    _dbContext.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }


            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
