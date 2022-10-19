using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quieropizzaBL
{
    public class productosBL
    {
       public List<producto> Obtenerproductos()
        {


            var producto1 = new producto();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 6 quesos";
            producto1.precio = 200;

            var producto2 = new producto();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza 4 estaciones";
            producto2.precio = 500; 

            var producto3 = new producto();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza jamon y queso";
            producto3.precio = 790;

            var listadeproductos = new List<producto>();
            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);

            return listaProductos;
    }
}
}