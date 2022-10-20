using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IActivitiesService
    {
        List<Activities> GetAll();
        void Add(Activities activities);
        void Update(Activities activities);
        void Delete(Activities activities);
    }
}
