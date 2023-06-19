using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mapper
{
    public static class AutoMapper
    {
        public static void AutoMapperConfig(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                // Mapping Example
                //mc.CreateMap<ApplicationGetDTO, Domain.Models.Application>().ReverseMap();
                //mc.CreateMap<ApplicationCreateDTO, Domain.Models.Application>().ReverseMap();
                //mc.CreateMap<ApplicationUpdateDTO, Domain.Models.Application>().ReverseMap();
            });

            IMapper Automapper = mapperConfig.CreateMapper();
            services.AddSingleton(Automapper);
        }
    }
}
