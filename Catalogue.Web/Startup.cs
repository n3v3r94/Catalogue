using Catalogue.Data;
using Catalogue.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System.Threading.Tasks;

[assembly: OwinStartupAttribute(typeof(Catalogue.Web.Startup))]
namespace Catalogue.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //CreateAdmin();
        }
       
        //private async Task CreateAdmin()
        //{
        //    var db = new CatalogueDbContext();
        //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
        //    var UserManager = new UserManager<User>(new UserStore<User>(db));

        //    if (!roleManager.RoleExists("Admin"))
        //    {
        //       // var role = new IdentityRole();
        //       // role.Name = "Admin";
        //       // roleManager.Create(role);


        //        var admin = new User();
        //        admin.Email = "admin5@abv.bg";
        //        admin.UserName = "admin";
        //        string password = "123456";

        //      var check =  await UserManager.CreateAsync(admin, password);

        //        if (check.Succeeded)
        //        {
        //           await UserManager.AddToRoleAsync(admin.Id, "Admin");
        //        }

        //    }

        //}
    }
}
