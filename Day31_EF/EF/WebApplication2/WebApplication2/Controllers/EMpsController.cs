using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication2;

namespace WebApplication2.Controllers
{
    public class EMpsController : ApiController
    {
        private sqlpracticeEntities db = new sqlpracticeEntities();

        // GET: api/EMps
        public IQueryable<EMp> GetEMps()
        {
            return db.EMps;
        }

        // GET: api/EMps/5
        [ResponseType(typeof(EMp))]
        public IHttpActionResult GetEMp(int id)
        {
            EMp eMp = db.EMps.Find(id);
            if (eMp == null)
            {
                return NotFound();
            }

            return Ok(eMp);
        }

        // PUT: api/EMps/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEMp(int id, EMp eMp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eMp.Empno)
            {
                return BadRequest();
            }

            db.Entry(eMp).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EMpExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/EMps
        [ResponseType(typeof(EMp))]
        public IHttpActionResult PostEMp(EMp eMp)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.EMps.Add(eMp);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (EMpExists(eMp.Empno))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = eMp.Empno }, eMp);
        }

        // DELETE: api/EMps/5
        [ResponseType(typeof(EMp))]
        public IHttpActionResult DeleteEMp(int id)
        {
            EMp eMp = db.EMps.Find(id);
            if (eMp == null)
            {
                return NotFound();
            }

            db.EMps.Remove(eMp);
            db.SaveChanges();

            return Ok(eMp);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EMpExists(int id)
        {
            return db.EMps.Count(e => e.Empno == id) > 0;
        }
    }
}