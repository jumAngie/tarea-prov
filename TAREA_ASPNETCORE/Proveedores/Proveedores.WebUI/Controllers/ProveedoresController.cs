using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Proveedores.BusinessLogic.Services;
using Proveedores.Entities.Entities;
using Proveedores.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proveedores.WebUI.Controllers
{
    public class ProveedoresController : Controller
    {
        private readonly GeneralesService _generalesService;
        private readonly IMapper _mapper;


        public ProveedoresController(GeneralesService generalesService, IMapper mapper)
        {
            _generalesService = generalesService;
            _mapper = mapper;
        }

        [HttpGet("/Proveedores/Listado")]
        public IActionResult Index()
        {
            var listado = _generalesService.Listado();
            var listadoMapeado = _mapper.Map<IEnumerable<ProveedoresViewModel>>(listado);
            return View(listadoMapeado);
        }

        [HttpGet("/Proveedores/Create")]

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProveedoresViewModel proveedorViewModel)
        {
            if (ModelState.IsValid)
            {
                var proveedor = _mapper.Map<tbProveedores>(proveedorViewModel);
                _generalesService.Create(proveedor);
                return RedirectToAction(nameof(Index));
            }
            return View(proveedorViewModel);
        }

        [HttpGet("/Proveedores/Edit")]

        public ActionResult Edit(int? id)
        {

            try
            {
                if (id == null)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    var proveedor = _generalesService.Buscar(id);
                    if(proveedor == null)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(proveedor);
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit([Bind("prov_ID,prov_Empresa,prov_NombreContacto,prov_TelefonoContacto,prov_DireccionExacta,prov_DireccionExactaEmpresa,prov_SexoContacto")] tbProveedores proveedorVM)
        {
            if (ModelState.IsValid)
            {
                if(proveedorVM.prov_NombreContacto != null && proveedorVM.prov_Empresa != null && proveedorVM.prov_TelefonoContacto != null 
                    && proveedorVM.prov_DireccionExacta != null && proveedorVM.prov_DireccionExactaEmpresa != NULL)
                {

                }
                var pros = _generalesService.Actualizar(proveedorVM);
                return RedirectToAction("Index");
            }
            else
            {
                return View(proveedorVM);
            }
            
        }
        
    }
}
