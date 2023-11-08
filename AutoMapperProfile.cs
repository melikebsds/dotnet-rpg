using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Models;
using dotnet_rpg.Dtos.Weapon;
using dotnet_rpg.Dtos.Skill;
using dotnet_rpg.Dtos.Fight;

namespace dotnet_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            //CreateMap<UpdateCharacterDto, Character>();//bu satırı eklemek için CharacterService'de _mapper satırı eklemem gerekir
        
            CreateMap<Weapon, GetWeaponDto>();

            CreateMap<Skill, GetSkillDto>();

            CreateMap<Character, HighScoreDto>();
            
        }
    }
}