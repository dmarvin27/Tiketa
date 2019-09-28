using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TiketeApi.Models;

namespace TiketeApi.Controllers
{

    [ApiController]
    public class TicketController : ControllerBase
    {

        private readonly City_TicketaContext _ticketaContext;

        public TicketController(City_TicketaContext ticketaContext)
        {
            _ticketaContext = ticketaContext;
        }

        [Route("api/1.0/ticket")]
        [HttpPost]
        public IActionResult Ticket(Ticket ticket)
        {
            _ticketaContext.Ticket.Add(ticket);
            _ticketaContext.SaveChanges();

            return Ok();
        }

        [Route("api/1.0/municipal/{municipalid}")]
        [HttpGet]
        public IActionResult TicketByMunicipal(int municipalid)
        {
            var ticketlist = _ticketaContext.Ticket.ToList();
            return Ok(ticketlist);
        }

    }
}