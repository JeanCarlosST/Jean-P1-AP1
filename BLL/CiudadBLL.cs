using Jean_P1_AP1.Entities;
using Jean_P1_AP1.DAL;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;

namespace Jean_P1_AP1.BLL
{
    public class CiudadBLL 
    {

        public static bool Existe(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try{
                paso = contexto.Ciudades.Any(c => c.CiudadID == id);
                
            } catch {
                throw;

            } finally {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Existe(string nombre)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try{
                paso = contexto.Ciudades.Any(c => c.Nombre.Equals(nombre));
                
            } catch {
                throw;

            } finally {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Insertar(Ciudad ciudad)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try{
                contexto.Ciudades.Add(ciudad);
                paso = contexto.SaveChanges() > 0;
                
            } catch {
                throw;

            } finally {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Modificar(Ciudad ciudad)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try{
                contexto.Entry(ciudad).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
                
            } catch {
                throw;

            } finally {
                contexto.Dispose();
            }

            return paso;
        }

        public static bool Guardar(Ciudad ciudad)
        {
            if(!Existe(ciudad.CiudadID))
                return Insertar(ciudad);
            else
                return Modificar(ciudad);
        }

        public static bool Eliminar(int id)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try{
                var ciudad = Buscar(id);
                if(ciudad != null)
                    contexto.Ciudades.Remove(ciudad);
                
                paso = contexto.SaveChanges() > 0;
                
            } catch {
                throw;

            } finally {
                contexto.Dispose();
            }

            return paso;
        }

        public static Ciudad Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Ciudad ciudad;

            try{
                ciudad = contexto.Ciudades.Find(id);
                
            } catch {
                throw;

            } finally {
                contexto.Dispose();
            }

            return ciudad;
        }

        public static List<Ciudad> GetList(Expression<Func<Ciudad, bool>> criterio)
        {
            Contexto contexto = new Contexto();
            List<Ciudad> lista;

            try{
                lista = contexto.Ciudades.Where(criterio).AsNoTracking().ToList();

            }catch{
                throw;
            } finally {
                contexto.Dispose();
            }

            return lista;
        }
    }
}