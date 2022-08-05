using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfAdminDal : IAdminDal
    {
        Context context = new Context();
        public DbSet<Admin> admins { get; set; }
        public void Add(Admin admin)
        {
            context.Set<Admin>().Add(admin);
            context.SaveChanges();
        }

        public void Delete(Admin admin)
        {
            context.Set<Admin>().Remove(admin);
            context.SaveChanges();
        }

        public List<Admin> GetAll()
        {
            return context.Set<Admin>().ToList();
        }

        public void Update(Admin admin)
        {
                context.Set<Admin>().ToList();
        }
    }
}
