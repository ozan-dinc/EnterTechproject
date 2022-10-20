using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {

        List<Activities> GetAllActivities();
        void AddOfUser(User user);
        void UpdateOfUSer(User user);
        void DeleteOfUser(User user);

        void AddOfActivities(Activities activities);
        void UpdateOfActivities(Activities activities);
        void DeleteOfActivities(Activities activities);
    }
}
