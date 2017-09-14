using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationApp.DAL
{
    public class UnitOfWork : IUnitOfWork    {
      
            private IUserRepository _userRepo;
            private Entity _entities;
            private bool disposed = false;

            public UnitOfWork(Entity Entities)
            {
                _entities = Entities;
            }

            public IUserRepository UserRepo
            {
                get
                {

                    if (_userRepo == null)
                    {
                        _userRepo = new UserRepository(_entities);
                    }
                    return _userRepo;
                }
            }

            public void Save()
            {
                _entities.SaveChanges();
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
                        _entities.Dispose();
                    }
                }
                this.disposed = true;
            }
        }
    }

