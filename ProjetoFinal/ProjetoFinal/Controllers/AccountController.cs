using ProjetoFinal.DBModel;
using ProjetoFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoFinal.Controllers
{
    public class AccountController : Controller
    {
        UserDBEntities objUserDBEntities = new UserDBEntities();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            UserModel objUserModel = new UserModel();
            return View(objUserModel);
        }

        [HttpPost]
        public ActionResult Register(UserModel objUserModel)
        {
            if (ModelState.IsValid)
            {
                if (!objUserDBEntities.Users.Any(m => m.Email == objUserModel.Email))
                {
                    User objUser = new DBModel.User();
                    objUser.CreateOn = DateTime.Now;
                    objUser.Email = objUserModel.Email;
                    objUser.FirstName = objUserModel.FirstName;
                    objUser.LastName = objUserModel.LastName;
                    objUser.Password = objUserModel.Password;
                    objUserDBEntities.Users.Add(objUser);
                    objUserDBEntities.SaveChanges();
                    objUserModel = new UserModel();
                    objUserModel.SuccessMessage = "Usuário Cadastrado Com Sucesso!";
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Error", "E-Mail Já Cadastrado!");
                    return View();
                }
            }
            return View();
        }

        public ActionResult Login()
        {
            LoginModel objLoginModel = new LoginModel();
            return View(objLoginModel);
        }

        [HttpPost]
        public ActionResult Login(LoginModel objLoginModel)
        {
            if (ModelState.IsValid)
            {
                if(objUserDBEntities.Users.Where(m=>m.Email == objLoginModel.Email && m.Password == objLoginModel.Password).FirstOrDefault() == null){
                    ModelState.AddModelError("Error", "E-Mail ou Senha Incorretos!");
                    return View();
                }
                else
                {
                    Session["Email"] = objLoginModel.Email;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}