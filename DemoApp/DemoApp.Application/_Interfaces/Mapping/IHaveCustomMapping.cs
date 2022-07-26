using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp.Application._Interfaces.Mapping
{
    internal interface IHaveCustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
