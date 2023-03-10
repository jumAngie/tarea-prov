using AutoMapper;
using Proveedores.Entities.Entities;
using Proveedores.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proveedores.WebUI.Extensions
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            CreateMap<ProveedoresViewModel, tbProveedores>().ReverseMap();
        }
    }
}
