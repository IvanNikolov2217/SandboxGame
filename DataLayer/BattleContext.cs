using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLayer;

namespace DataLayer
{
	public class BattleContext : IDB<Battle, int>
	{
		private SandboxDbContext _context;

		public BattleContext(SandboxDbContext context)
		{
			this._context = context;
		}

		public void Create(Battle item)
		{
			try
			{
				_context.Battles.Add(item);
				_context.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public Battle Read(int key)
		{
			try
			{
				return _context.Battles.Find(key);
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public IEnumerable<Battle> ReadAll()
		{
			try
			{
				return _context.Battles.ToList();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public void Update(Battle item)
		{
			try
			{

				_context.Battles.Update(item);
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
				Battle battleFromDB = Read(key);

				_context.Battles.Remove(battleFromDB);
				_context.SaveChanges();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}


	}

}