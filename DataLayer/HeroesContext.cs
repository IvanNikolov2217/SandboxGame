using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;

namespace DataLayer
{
	public class HeroesContext : IDB<Heroes, int>
	{
		private SandboxDbContext _context;

		public HeroesContext(SandboxDbContext context)
		{
			this._context = context;
		}

		public void Create(Heroes item)
		{
			try
			{
				_context.Heroes.Add(item);
				_context.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public Heroes Read(int key)
		{
			try
			{
				return _context.Heroes.Find(key);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public IEnumerable<Heroes> ReadAll()
		{
			try
			{
				return _context.Heroes.ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Update(Heroes item)
		{
			try
			{

				_context.Heroes.Update(item);
				_context.SaveChanges();


			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Delete(int key)
		{
			try
			{
				Heroes heroesFromDB = Read(key);

				_context.Heroes.Remove(heroesFromDB);
				_context.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


	}

}