using Microsoft.AspNetCore.Mvc;
using manasome.Models;
using System.Linq;

namespace manasome.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            // 仮の認証ロジック
            if (username == "admin" && password == "password")
            {
                // 認証成功時の処理（セッション保存など）
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "ユーザー名またはパスワードが違います";
            return View();
        }
    }
} 