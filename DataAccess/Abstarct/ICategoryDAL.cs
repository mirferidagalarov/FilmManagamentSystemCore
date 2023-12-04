using Core.DataAccess.Abstract;
using Entities.TableModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstarct
{
    public interface ICategoryDAL:IBaseRepository<Category>
    {
        //View model metodlari
    }
}
