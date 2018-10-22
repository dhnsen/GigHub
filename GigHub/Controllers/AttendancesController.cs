using GigHub.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GigHub.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        [HttpPost]
        
        public IHttpActionResult Attend([FromBody] int gigId)
        {
            var userId = User.Identity.GetUserId();
            
            if (_context.Attendances.Any(a => a.AttendeeId == userId && a.GigId == gigId)) return BadRequest("The Attendance already exists)");

            var attendance = new Attendance
            {
                GigId = gigId,
                AttendeeId = User.Identity.GetUserId()
            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}
