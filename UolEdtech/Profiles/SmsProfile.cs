using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UolEdtech.Data.Dtos;
using UolEdtech.Models;

namespace UolEdtech.Profiles
{
    public class SmsProfile : Profile
    {
        public SmsProfile()
        {
            CreateMap<CreateSmsDto, Sms>();
            CreateMap<Sms, ReadSmsDto>();
            CreateMap<UpdateSmsDto, Sms>();
        }
    }
}
