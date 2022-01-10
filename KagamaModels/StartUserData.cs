using System.Linq;
using KagamaModels.Entities;

namespace KagamaModels
{
    public static class StartUserData
    {
        public static void Initialize(EFDBContext context)
        {
            if (!context.AdminUsers.Any())
            {
                context.AdminUsers.AddRange(new AdminUser
                {
                    Login = "admin",
                    Password = "admin@123"
                });
                context.SaveChanges();
            }

            //if (!context.Contacts.Any())
            //{
            //    context.Contacts.AddRange(new Contact
            //    {
            //        Address = "",
            //        Email = "",
            //        Phone = "",
            //        Schedule = ""
            //    });
            //    context.SaveChanges();
            //}
        }
    }
}
