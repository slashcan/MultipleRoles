using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAppCRUD.Repository;

namespace MyAppCRUD.Controllers
{
    public class BaseController : Controller
    {
        public WEBDBSYSEntities _db;
        public BaseRepository<UserAccount> _userRepo;
        public BaseController()
        {
            _db = new WEBDBSYSEntities();
            _userRepo = new BaseRepository<UserAccount>();
        }
    }
}