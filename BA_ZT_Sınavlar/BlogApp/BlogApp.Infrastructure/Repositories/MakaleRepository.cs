using BlogApp.Domain.Entites;
using BlogApp.Domain.Repositories.Abstract;
using BlogApp.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Infrastructure.Repositories
{
	public class MakaleRepository : BaseRepository<Makale>, IMakaleRepository
	{
		public MakaleRepository(BlogContext contex) : base(contex)
		{
		}
	}
}
