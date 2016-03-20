namespace TwitterLike.Controllers
{
    using Services;
    using System.Web.Mvc;
    using System.Linq;
    using Models;
    using Services.Contracts;
    public class UsersController : Controller
    {
        private IUserService userService;

        public UsersController(IUserService service)
        {
            userService = service;
        }

        public ActionResult All()
        {
            var users = userService.GetAllUsers().Select(u => new UsersViewModel
            {
                Name = u.UserName,
                Email = u.Email

            }).ToList();
            return View(users);
        }

        public ActionResult UserProfile()
        {
            var user = userService.GetUserByName(this.User.Identity.Name);
            var usesrVm = new UsersViewModel
            {
                Name = user.UserName,
                Email = user.Email,
                ImgUrl = user.ImgUrl
            };
            return View(usesrVm);
        }

        public ActionResult EditProfile()
        {
            return PartialView("_EditProfile");
        }
    }
}