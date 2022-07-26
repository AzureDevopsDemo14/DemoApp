using AutoMapper;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DemoApp.Application._Infrastructure.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            LoadStandardMappings();
            //LoadCustomMappings();
        }
        private void LoadStandardMappings()
        {
            var mapsFrom = MapperProfileHelper.LoadStandardMappings(Assembly.GetExecutingAssembly());
            foreach (var map in mapsFrom)
            {
                CreateMap(map.Souce, map.Destination).ReverseMap();
            }
        }
        //private void LoadCustomMappings()
        //{
        //    var mapsFrom = MapperProfileHelper.LoadCustomMappings(Assembly.GetExecutingAssembly());
        //    foreach (var map in mapsFrom)
        //    {
        //        map.CreateMappings(this);
        //    }
        //}
    }
}
