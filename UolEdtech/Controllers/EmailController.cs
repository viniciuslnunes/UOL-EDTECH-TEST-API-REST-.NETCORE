using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UolEdtech.Data;
using UolEdtech.Data.Dtos;
using UolEdtech.Models;

namespace UolEdtech.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class EmailController : ControllerBase
        {
            private AppDbContext _context;
            private IMapper _mapper;


            public EmailController(AppDbContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            [HttpPost]
            public IActionResult AdicionaEmail([FromBody] CreateEmailDto emailDto)
            {
                Email email = _mapper.Map<Email>(emailDto);

                _context.Emails.Add(email);

                _context.SaveChanges();

                return CreatedAtAction(nameof(RecuperaEmailsPorId), new { Id = email.Id }, email);
            }

            [HttpGet]
            public IEnumerable<Email> RecuparaEmail()
            {
                return _context.Emails;
            }

            [HttpGet("{id}")]
            public IActionResult RecuperaEmailsPorId(int id)
            {
                Email email = _context.Emails.FirstOrDefault(email => email.Id == id);

                if (email != null)
                {
                    ReadEmailDto emailDto = _mapper.Map<ReadEmailDto>(email);

                    return Ok(email);
                }

                return NotFound();
            }

            [HttpPut("{id}")]
            public IActionResult AtualizaEmail(int id, [FromBody] UpdateEmailDto emailDto)
            {
                Email email = _context.Emails.FirstOrDefault(email => email.Id == id);

                if (email == null)
                {
                    return NotFound();
                }

                _mapper.Map(emailDto, email);

                _context.SaveChanges();

                return NoContent();

            }

            [HttpDelete("{id}")]
            public IActionResult DeletaEmail(int id)
            {
                Email email = _context.Emails.FirstOrDefault(email => email.Id == id);

                if (email == null)
                {
                    return NoContent();
                }
                _context.Emails.Remove(email);

                _context.SaveChanges();

                return NoContent();
            }
        }
    }