using Registro_Articulos.DAL;
using Registro_Articulos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Articulos.BLL
{
    public class ArticulosBLL
    {
           // Guarda las entidad de articulos
        public static bool Guardar(Articulos articulos)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Articulo.Add(articulos);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

          //permite Modificar una entidad en la base de datos de articulos

        public static bool Modificar(Articulos articulos)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                db.Entry(articulos).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }
                 //Elimina los articulos o entidad de la base de datos
        public static bool Eliminar(int Id)
        {
            bool flag = false;

            try
            {
                Contexto db = new Contexto();
                Articulos ar = db.Articulo.Find(Id);
                db.Articulo.Remove(ar);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }
                    //Busca los articulos en la base de datos
        public static Articulos Buscar(int Id)
        {
            Articulos ar = null;
            try
            {
                Contexto db = new Contexto();
                ar = db.Articulo.Find(Id);
            }
            catch (Exception)
            {
                throw;
            }
            return ar;
        }
                     //Retorna o extrae una lista de los articulos
        public static List<Articulos> GetList(Expression<Func<Articulos, bool>> filter)
        {
            List<Articulos> list = null;

            try
            {
                Contexto db = new Contexto();
                list = db.Articulo.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }

        public static List<Articulos> GetList()
        {
            List<Articulos> list = null;

            try
            {
                Contexto db = new Contexto();
                list = db.Articulo.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return list;
        }
    }
}
