using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Jungle_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Jungle_DataAccess.Repository;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Jungle_DataAccess.Initializer
{
    public class DbInitializer : IDbInitializer
    {
        private readonly JungleDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(JungleDbContext db, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }




        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }

            if (_db.Roles.Any(r => r.Name == AppConstants.AdminRole)) return;

            _roleManager.CreateAsync(new IdentityRole(AppConstants.AdminRole)).GetAwaiter().GetResult();
            // Autres roles

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "9999999@cegepmontpetit.ca",
                Email = "9999999@cegepmontpetit.ca",
                EmailConfirmed = true,
                NickName = "AdminJungle",
                PhoneNumber = "111111111111"
            }, "Jungle1234*").GetAwaiter().GetResult();

            ApplicationUser user = _db.ApplicationUser.FirstOrDefault(u => u.Email == "9999999@cegepmontpetit.ca");
            _userManager.AddToRoleAsync(user, AppConstants.AdminRole).GetAwaiter().GetResult();



            if (_db.Roles.Any(r => r.Name == AppConstants.CustomerRole)) return;

            _roleManager.CreateAsync(new IdentityRole(AppConstants.CustomerRole)).GetAwaiter().GetResult();
            // Autres roles

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "1676459@cegepmontpetit.ca",
                Email = "1676459@cegepmontpetit.ca",
                EmailConfirmed = true,
                NickName = "CustomerJungle",
                PhoneNumber = "211111111111"
            }, "Jungle1234*").GetAwaiter().GetResult();

            ApplicationUser user = _db.ApplicationUser.FirstOrDefault(u => u.Email == "1676459@cegepmontpetit.ca");
            _userManager.AddToRoleAsync(user, Jungle_Utility.AppConstants.CustomerRole).GetAwaiter().GetResult();
        }
    }
}
