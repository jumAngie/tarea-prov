using Proveedores.DataAccess.Repositories;
using Proveedores.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proveedores.BusinessLogic.Services
{
    public class GeneralesService
    {
        private readonly ProveedoresRepository _proveedoresRepository;

        public GeneralesService(ProveedoresRepository proveedoresRepository)
        {
            _proveedoresRepository = proveedoresRepository;
        }

        #region Proveedores

        public IEnumerable<tbProveedores> Listado()
        {
            try
            {
                var result = _proveedoresRepository.List();
                return result;
            }
            catch (Exception)
            {

                return Enumerable.Empty<tbProveedores>();
            }
        }

        public void Create(tbProveedores proveedores)
        {
            try
            {
                _proveedoresRepository.Insert(proveedores);
               
            }
            catch (Exception)
            {
                
                
            }
        }

        public tbProveedores Buscar(int? id)
        {
            try
            {
                var tbProveedores =  _proveedoresRepository.Find(id);
                return tbProveedores;
                
            }
            catch (Exception)
            {

                throw new Exception("Error");
            }

        }

        public int Actualizar(tbProveedores id)
        {
            try
            {
               var registro = _proveedoresRepository.Update(id);
                return registro;

            }
            catch (Exception x)
            {

                throw new Exception("Erro al actualizar Proveedores", x);
            }
           
        }
        #endregion
    }
}
