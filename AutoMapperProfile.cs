using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnetproject.Dtos.Character;

namespace dotnetproject
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
        }
    }
}

//enum work behind the scenes as integers, if enum AutoIncremented, it will start at 1 because 0 is the default value. and enum is a value type, so it can't be null.