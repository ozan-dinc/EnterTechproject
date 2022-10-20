using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ActivitiesManager : IActivitiesService
    {
        IActivitiesDal _activitiesDal;

        public ActivitiesManager(IActivitiesDal activitiesDal)
        {
            _activitiesDal = activitiesDal;
        }

        public void Add(Activities activities)
        {
            _activitiesDal.Add(activities);
        }

        public void Delete(Activities activities)
        {
            _activitiesDal.Delete(activities);
        }

        public List<Activities> GetAll()
        {
           return _activitiesDal.GetAll();
        }

        public void Update(Activities activities)
        {
            _activitiesDal.Update(activities);
        }
    }
}
