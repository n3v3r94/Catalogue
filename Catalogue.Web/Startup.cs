using Catalogue.Data;
using Catalogue.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Catalogue.Web.Startup))]
namespace Catalogue.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
           // CreateAdmin();
        }
        //!!!!
        //private void CreateAdmin()
        //{
        //    var db = new CatalogueDbContext();
        //    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
        //    var UserManager = new UserManager<User>(new UserStore<User>(db));

        //    if (roleManager.RoleExists("Admin"))
        //    {
        //       // var role = new IdentityRole();
        //       // role.Name = "Admin";
        //       // roleManager.Create(role);


        //        var admin = new User();
        //        admin.Email = "admin2@abv.bg";
        //        admin.UserName = "admin2";
        //        string password = "123456";

        //        var ckeck = UserManager.Create(admin, password);

        //        if (ckeck.Succeeded)
        //        {
        //            UserManager.AddToRole(admin.Id, "Admin");
        //        }



        //    }

        //}
    }
}
