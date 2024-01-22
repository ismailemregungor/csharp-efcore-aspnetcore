using BlogApp.Domain.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Domain.Repositories.Abstract
{
	public interface IBaseRepository<T> where T : class, IBaseEntity
	{
		Task<bool> EkleAsync(T entity);
		Task<bool> GuncelleAsync(T entity);
		Task<bool> SilAsync(T entity);
		Task<bool> Bul(Expression<Func<T, bool>> expression);
		Task<T> HerhangiBiriniBulAsync(Expression<Func<T, bool>> expression);
		Task<IEnumerable<T>> HepsiniBulAsync(Expression<Func<T, bool>> expression);
		IQueryable<T> HepsiniGetir();
	}
}
