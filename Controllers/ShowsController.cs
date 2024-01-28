using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ShowsProject.DTOs;
using ShowsProject.Models;

namespace ShowsProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase
    {
        private readonly LibraryDbContext _context;
        private readonly IMapper _mapper;
        private readonly UserManager<IdentityUser> _userManager;


        public ShowsController(LibraryDbContext context, IMapper mapper, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;

        }

        // GET: api/Shows
        [HttpGet]
        public IEnumerable<ShowDTO> Get()
        {
            var result = _context.Shows;
            return _mapper.Map<List<ShowDTO>>(result);
        }


        /*  public async Task<ActionResult<IEnumerable<Show>>> GetShows()
          {
            if (_context.Shows == null)
            {
                return NotFound();
            }
              return await _context.Shows.ToListAsync();
          }*/

        // GET: api/Shows/5
       
        [HttpGet("{id}")]
        public async Task<ActionResult<Show>> GetShow(int id)
        {
            if (_context.Shows == null)
            {
                return NotFound();
            }
            var show = await _context.Shows.FindAsync(id);

            if (show == null)
            {
                return NotFound();
            }

            return show;
        }

        // PUT: api/Shows/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShow(int id, Show show)
        {
            if (id != show.Id)
            {
                return BadRequest();
            }

            _context.Entry(show).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ShowExists(id))
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

        // POST: api/Shows

        [Authorize(Roles ="Owner")]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ShowDTO showDTO)
        {
            if (showDTO == null)
            {
                return BadRequest("ShowDTO cannot be null");
            }

            var show = _mapper.Map<Show>(showDTO);

            // Get the current user's ID from the HttpContext
            string userId = GetCurrentUserId(HttpContext);

            if (string.IsNullOrEmpty(userId))
            {
                // Handle the case when userId is not found
                return BadRequest("User ID not provided or invalid");
            }

            // Retrieve the Owner based on the comparison of userId with Owner's UserId
            var currentOwner = await _context.Owners
                .SingleOrDefaultAsync(o => string.Equals(o.UserId, userId, StringComparison.OrdinalIgnoreCase));

            if (currentOwner == null)
            {
                // Handle the case when currentOwner is not found
                return NotFound("Current owner not found");
            }

            show.OwnerId = currentOwner.Id;

            // Associate the show with the current owner
            show.Owner = currentOwner;

            _context.Shows.Add(show);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log the exception
                return StatusCode(500, "Error saving the show to the database");
            }

            var savedShowDTO = _mapper.Map<ShowDTO>(show);

            return CreatedAtAction("Get", new { id = savedShowDTO.Id }, savedShowDTO);
        }

        /* public async Task<ActionResult<Show>> PostShow(Show show)
         {
           if (_context.Shows == null)
           {
               return Problem("Entity set 'LibraryDbContext.Shows'  is null.");
           }
             _context.Shows.Add(show);
             await _context.SaveChangesAsync();

             return CreatedAtAction("GetShow", new { id = show.Id }, show);
         }
        */
        // DELETE: api/Shows/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShow(int id)
        {
            if (_context.Shows == null)
            {
                return NotFound();
            }
            var show = await _context.Shows.FindAsync(id);
            if (show == null)
            {
                return NotFound();
            }

            _context.Shows.Remove(show);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ShowExists(int id)
        {
            return (_context.Shows?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        private HttpContext GetHttpContext()
        {
            return HttpContext;
        }

        private string GetCurrentUserId(HttpContext httpContext)
        {
            var user = httpContext?.User;

            if (user?.Identity?.IsAuthenticated ?? false)
            {
                var userIdClaim = user.FindFirst("sub");

                if (userIdClaim != null)
                {
                    return userIdClaim.Value;
                }
            }

            return null;
        }


    }

}
