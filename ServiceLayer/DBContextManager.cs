using DataLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public static class DBContextManager
    {
        private static SandboxDbContext _context;
        private static BattleContext _battleContext;
        private static HeroesContext _heroesContext;
        private static RolesContext _rolesContext;
        private static RoundsContext _roundsContext;
        private static UsersContext _usersContext;

        #region DB Context

        public static SandboxDbContext CreateContext()
        {
            _context = new SandboxDbContext();
            return _context;
        }

        public static SandboxDbContext GetContext()
        {
            return _context;
        }

        public static void SetChangeTracking(bool value)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = value;
        }

        #endregion

        #region TContexts

        public static BattleContext CreateBattleContext(SandboxDbContext context)
        {
            _battleContext = new BattleContext(context);
            return _battleContext;
        }

        public static BattleContext GetBattleContext()
        {
            return _battleContext;
        }

        public static HeroesContext CreateHeroesContext(SandboxDbContext context)
        {
            _heroesContext = new HeroesContext(context);
            return _heroesContext;
        }

        public static HeroesContext GetHeroesContext()
        {
            return _heroesContext;
        }
        public static RolesContext CreateRolesContext(SandboxDbContext context)
        {
            _rolesContext = new RolesContext(context);
            return _rolesContext;
        }

        public static RolesContext GetRolesContext()
        {
            return _rolesContext;
        }
        public static RoundsContext CreateRoundsContext(SandboxDbContext context)
        {
            _roundsContext = new RoundsContext(context);
            return _roundsContext;
        }

        public static RoundsContext GetRoundsContext()
        {
            return _roundsContext;
        }
        public static UsersContext CreateUsersContext(SandboxDbContext context)
        {
            _usersContext = new UsersContext(context);
            return _usersContext;
        }

        public static UsersContext GetUsersContext()
        {
            return _usersContext;
        }

        #endregion

    }
}
