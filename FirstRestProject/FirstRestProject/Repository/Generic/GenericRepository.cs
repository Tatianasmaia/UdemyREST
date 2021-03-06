using FirstRestProject.Model.Base;
using FirstRestProject.Model.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstRestProject.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {

        private MySqlContext _context;
        private DbSet<T> dataset;

        public GenericRepository(MySqlContext context)
        {
            _context = context;
            //Vai buscar dinamicamente que tipo vai ser do repositorio, em vez de se ter que especificar
            dataset = _context.Set<T>();
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }

        public T FindById(long id)
        {
            return dataset.SingleOrDefault(p => p.Id == id);
        }
        public T Create(T item)
        {
            try
            {
                dataset.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public T Update(T item)
        {
            var result = dataset.SingleOrDefault(p => p.Id == item.Id);

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(item);
                    _context.SaveChanges();
                    return result;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                return null;
            }
        }

        public void Delete(long id)
        {
            var result = dataset.SingleOrDefault(p => p.Id == id);

            if (result != null)
            {
                try
                {
                    dataset.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public bool Exists(long id)
        {
            return dataset.Any(p => p.Id.Equals(id));
        }
    }
}
