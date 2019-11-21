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
using Reklamacja.Models;

namespace Reklamacja.Controllers
{
    public class ComplaintsController : ApiController
    {
        private Complaint_context db = new Complaint_context();

        // GET: api/Complaints
        public IQueryable<Complaint> GetComplaint()
        {
            return db.Complaint;
        }

        // GET: api/Complaints/5
        [ResponseType(typeof(Complaint))]
        public IHttpActionResult GetComplaint(int id)
        {
            Complaint complaint = db.Complaint.Find(id);
            if (complaint == null)
            {
                return NotFound();
            }

            return Ok(complaint);
        }

        // PUT: api/Complaints/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutComplaint(int id, Complaint complaint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != complaint.Id)
            {
                return BadRequest();
            }

            db.Entry(complaint).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ComplaintExists(id))
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

        // POST: api/Complaints
        [ResponseType(typeof(Complaint))]
        public IHttpActionResult PostComplaint(Complaint complaint)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Complaint.Add(complaint);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = complaint.Id }, complaint);
        }

        // DELETE: api/Complaints/5
        [ResponseType(typeof(Complaint))]
        public IHttpActionResult DeleteComplaint(int id)
        {
            Complaint complaint = db.Complaint.Find(id);
            if (complaint == null)
            {
                return NotFound();
            }

            db.Complaint.Remove(complaint);
            db.SaveChanges();

            return Ok(complaint);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ComplaintExists(int id)
        {
            return db.Complaint.Count(e => e.Id == id) > 0;
        }
    }
}