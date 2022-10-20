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
    public class UserManager : IUserService
    {
        IUserDal _userdal;
        IActivitiesDal _activitiesdal;

        public UserManager(IActivitiesDal activitiesdal)
        {
            _activitiesdal = activitiesdal;
        }

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }
        public UserManager(IUserDal userdal, IActivitiesDal activitiesdal):this(userdal)
        {
            _activitiesdal = activitiesdal;
        }
        public UserManager(IActivitiesDal activitiesdal, IUserDal userdal):this(activitiesdal)
        {
            _userdal = userdal;
        }

        public void AddOfActivities(Activities activities)
        {
            _activitiesdal.Add(activities);
        }

        public void AddOfUser(User user)
        {
            _userdal.Add(user);
        }

        public void DeleteOfActivities(Activities activities)
        {
            _activitiesdal.Delete(activities);

        }

        public void DeleteOfUser(User user)
        {
            _userdal.Delete(user);
        }

        public List<Activities> GetAllActivities()
        {
            return _activitiesdal.GetAll();
        }

        public void UpdateOfActivities(Activities activities)
        {
            _activitiesdal.Update(activities);
        }

        public void UpdateOfUSer(User user)
        {
            _userdal.Update(user);
        }
    }
}
