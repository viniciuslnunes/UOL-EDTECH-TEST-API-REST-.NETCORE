using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UolEdtech.Data.Dtos;
using UolEdtech.Models;

namespace UolEdtech.Profiles
{
    public class EmailProfile : Profile
    {
        public EmailProfile()
        {
            CreateMap<CreateEmailDto, Email>();
            CreateMap<Email, ReadEmailDto>();
            CreateMap<UpdateEmailDto, Email>();
        }
    }
}
