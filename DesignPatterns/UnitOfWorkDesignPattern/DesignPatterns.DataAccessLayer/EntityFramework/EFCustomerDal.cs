using DesignPatterns.DataAccessLayer.Abstract;
using DesignPatterns.DataAccessLayer.Repositories;
using DesignPatterns.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DataAccessLayer.EntityFramework
{
    public class EFCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public EFCustomerDal(Context context) : base(context)
        {
            
        }
    }
}
