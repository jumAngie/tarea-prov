using Microsoft.EntityFrameworkCore;
using Proveedores.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proveedores.DataAccess.Repositories
{
    public class ProveedoresRepository : IRepository<tbProveedores>
    {
        public int Delete(int? id)
        {
            throw new NotImplementedException();
        }

        public tbProveedores Find(int? id)
        {
            using var db = new EmpresaContext();
            var result = db.tbProveedores.Find(id);

            return result;
        }

        public int Insert(tbProveedores item)
        {
            using var db = new EmpresaContext();

            db.tbProveedores.Add(item);
            db.SaveChanges();
            return item.prov_ID;
        }

        public IEnumerable<tbProveedores> List()
        {
            using var db = new EmpresaContext();
            var listado = db.tbProveedores.ToList();

            return listado;
        }

        public int Update(tbProveedores item)
        {
            using var db = new EmpresaContext();
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();

            return item.prov_ID;
        }
    }
}
