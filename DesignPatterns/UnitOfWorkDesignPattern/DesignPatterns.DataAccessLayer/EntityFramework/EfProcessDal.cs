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
    public class EfProcessDal : GenericRepository<Process>, IProcessDal
    {
        public EfProcessDal(Context context) : base(context)
        {
        }
    }
}
