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
        public class SmsController : ControllerBase
        {
            private SmsContext _context;
            private IMapper _mapper;


            public SmsController(SmsContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            [HttpPost]
            public IActionResult AdicionaSms([FromBody] CreateSmsDto smsDto)
            {
                Sms sms = _mapper.Map<Sms>(smsDto);

                _context.Smss.Add(sms);

                _context.SaveChanges();

                return CreatedAtAction(nameof(RecuperaSmssPorId), new { Id = sms.Id }, sms);
            }

            [HttpGet]
            public IEnumerable<Sms> RecuparaSms()
            {
                return _context.Smss;
            }

            [HttpGet("{id}")]
            public IActionResult RecuperaSmssPorId(int id)
            {
                Sms sms = _context.Smss.FirstOrDefault(sms => sms.Id == id);

                if (sms != null)
                {
                    ReadSmsDto smsDto = _mapper.Map<ReadSmsDto>(sms);

                    return Ok(sms);
                }

                return NotFound();
            }

            [HttpPut("{id}")]
            public IActionResult AtualizaSms(int id, [FromBody] ReadSmsDto smsDto)
            {
                Sms sms = _context.Smss.FirstOrDefault(sms => sms.Id == id);

                if (sms == null)
                {
                    return NotFound();
                }

                _mapper.Map(smsDto, sms);

                _context.SaveChanges();

                return NoContent();

            }

            [HttpDelete("{id}")]
            public IActionResult DeletaSms(int id)
            {
                Sms sms = _context.Smss.FirstOrDefault(sms => sms.Id == id);

                if (sms == null)
                {
                    return NoContent();
                }
                _context.Smss.Remove(sms);

                _context.SaveChanges();

                return NoContent();
            }
        }
    }

