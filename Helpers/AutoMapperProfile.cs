using AutoMapper;
using DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap< User, UserDTO >();
            CreateMap< UserDTO, User >();

        }
    }
}
