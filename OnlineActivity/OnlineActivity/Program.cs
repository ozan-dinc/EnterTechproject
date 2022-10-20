using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

//AdminManager adminManager = new AdminManager(new EfActivitiesDal());
//Activities activities =new Activities();
//activities.ActivityName = "Konser";
//adminManager.AddOfActivities(activities);
//ActivitiesManager activitiesManager = new ActivitiesManager(new EfActivitiesDal());
//UserOfGetAllActivities(activities);
//activitiesManager.Add(activities);

Admin admin = new Admin();
User user = new User();
Activities activities = new Activities();
admin.AdminMail = "ozan@gmail.com";
AdminManager adminManager = new AdminManager(new EfAdminDal(), new EfUserDal(), new EfActivitiesDal());
adminManager.AddOfAdmin(admin);
adminManager.UpdateOfUSer(user);
adminManager.DeleteOfActivities(activities);


UserManager userManager = new UserManager(new EfUserDal(), new EfActivitiesDal());
userManager.AddOfActivities(activities);
userManager.DeleteOfUser(user);



static void UserOfGetAllActivities(Activities activities)
{
    UserManager userManager = new UserManager(new EfUserDal());
    foreach (var activitie in userManager.GetAllActivities())
    {
        Console.WriteLine($"{activities.Id} {activities.ActivityName}");
    }
}

