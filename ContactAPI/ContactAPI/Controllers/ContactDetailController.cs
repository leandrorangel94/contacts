using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ContactAPI.Models;

namespace ContactAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactDetailController : ControllerBase
    {
        private readonly ContactDetailContext _context;

        public ContactDetailController(ContactDetailContext context)
        {
            _context = context;
        }

        // GET: api/ContactDetail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContactDetail>>> GetContactDetails()
        {
            return await _context.ContactDetails.ToListAsync();
        }

        // GET: api/ContactDetail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ContactDetail>> GetContactDetail(int id)
        {
            var contactDetail = await _context.ContactDetails.FindAsync(id);

            if (contactDetail == null)
            {
                return NotFound();
            }

            return contactDetail;
        }

        // PUT: api/ContactDetail/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContactDetail(int id, ContactDetail contactDetail)
        {
            if (id != contactDetail.ContactDetailId)
            {
                return BadRequest();
            }

            _context.Entry(contactDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactDetailExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ContactDetail
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ContactDetail>> PostContactDetail(ContactDetail contactDetail)
        {
            _context.ContactDetails.Add(contactDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContactDetail", new { id = contactDetail.ContactDetailId }, contactDetail);
        }

        // DELETE: api/ContactDetail/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactDetail(int id)
        {
            var contactDetail = await _context.ContactDetails.FindAsync(id);
            if (contactDetail == null)
            {
                return NotFound();
            }

            _context.ContactDetails.Remove(contactDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContactDetailExists(int id)
        {
            return _context.ContactDetails.Any(e => e.ContactDetailId == id);
        }
    }
}
