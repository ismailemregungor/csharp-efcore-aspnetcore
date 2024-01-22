using BlogApp.Domain.Entites.Abstract;
using BlogApp.Domain.Repositories.Abstract;
using BlogApp.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Infrastructure.Repositories
{
	public class BaseRepository<T> : IBaseRepository<T> where T : class, IBaseEntity
	{

		private readonly BlogContext _context;
		protected readonly DbSet<T> _dbSet;

		public BaseRepository(BlogContext context)
		{
			_context = context;
			_dbSet = _context.Set<T>();
		}
		public async Task<bool> Bul(Expression<Func<T, bool>> expression)
		{
			return await _dbSet.AnyAsync(expression);
		}

		public async Task<bool> EkleAsync(T entity)
		{
			await _dbSet.AddRangeAsync(entity);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<bool> GuncelleAsync(T entity)
		{
			_dbSet.Update(entity);
			return _context.SaveChanges() > 0;
		}

		public async Task<IEnumerable<T>> HepsiniBulAsync(Expression<Func<T, bool>> expression)
		{
			return await _dbSet.Where(expression).ToListAsync();
		}

		public IQueryable<T> HepsiniGetir()
		{
			return _dbSet.Select(x => x);
		}

		public async Task<T> HerhangiBiriniBulAsync(Expression<Func<T, bool>> expression)
		{
			return await _dbSet.FirstOrDefaultAsync(expression);
		}

		public async Task<bool> SilAsync(T entity)
		{
			_dbSet.Remove(entity);
			return await _context.SaveChangesAsync() > 0;
		}
	}
}
