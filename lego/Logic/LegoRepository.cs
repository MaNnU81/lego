﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lego.model;
using Microsoft.EntityFrameworkCore;

namespace lego.Logic
{
    internal class LegoRepository<T> : IRepository<T> where T : class

    {

        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;   

        public LegoRepository(DbContext context) 
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }



        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(int id)
        {
            var entity = GetById(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList(); 
        }

        public T? GetById(int id)
        {
            return _dbSet.Find(id);

        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
