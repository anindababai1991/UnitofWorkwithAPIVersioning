using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationApp.DAL
{
    public class UserRepository : IUserRepository
    {
        private Entity context;
        private bool disposed = false;
        public UserRepository(Entity context)
        {
            this.context = context;
        }

        public List<User> GetUsers()
        {
            List<User> _usersList = new List<User>();
            _usersList = (from a in context.Users select a).ToList();
            return _usersList;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
    }
}
