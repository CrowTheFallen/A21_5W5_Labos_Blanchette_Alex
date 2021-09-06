using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JungleDataAcess;

namespace JungleDataAcess.Repository.IRepository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JungleDbContext _db;

        public UnitOfWork(JungleDbContext db)
        {
            _db = db;
        }


        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
