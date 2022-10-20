using Business.Abstract;
using Business.Concrete;
using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;
        IActivitiesDal _activitiesDal;
        IUserDal _userDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public AdminManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public AdminManager(IActivitiesDal activitiesDal)
        {
            _activitiesDal = activitiesDal;
        }
        public AdminManager(IAdminDal adminDal, IActivitiesDal activitiesDal, IUserDal userDal) : this(adminDal)
        {
            _activitiesDal = activitiesDal;
            _userDal = userDal;
        }

        public AdminManager(IAdminDal adminDal,  IUserDal userDal, IActivitiesDal activitiesDal) : this(adminDal)
        {
            _activitiesDal = activitiesDal;
            _userDal = userDal;
        }
        public AdminManager(IActivitiesDal activitiesDal, IUserDal userDal)
        {
            _activitiesDal = activitiesDal;
            _userDal = userDal;
        }
        public AdminManager(IAdminDal adminDal, IActivitiesDal activitiesDal):this(adminDal)
        {
            _activitiesDal = activitiesDal;
        }
        public AdminManager(IAdminDal adminDal, IUserDal userDal) : this(adminDal)
        {
            _userDal = userDal;
        }

        public void AddOfActivities(Activities activities)
        {
            _activitiesDal.Add(activities);
        }

        public void AddOfUser(User user)
        {
            _userDal.Add(user);
        }

        public void DeleteOfActivities(Activities activities)
        {
            _activitiesDal.Delete(activities);
        }

        public void DeleteOfUser(User user)
        {
            _userDal.Delete(user);
        }

        public void UpdateOfActivities(Activities activities)
        {
            _activitiesDal.Update(activities);
        }

        public void UpdateOfUSer(User user)
        {
            _userDal.Update(user);
        }

        public List<User> GetAllOfUser()
        {
           return  _userDal.GetAll();
        }

        public void AddOfAdmin(Admin admin)
        {
            _adminDal.Add(admin);
        }

        public void UpdateOfAdmin(Admin admin)
        {
            _adminDal.Update(admin);
        }

        public void DeleteOfAdmin(Admin admin)
        {
            _adminDal.Delete(admin);
        }
    }
}
