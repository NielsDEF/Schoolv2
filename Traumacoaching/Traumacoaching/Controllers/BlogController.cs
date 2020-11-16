using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using Traumacoaching.Models;

namespace Traumacoaching.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create() 
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(Blog b) 
        {
            string connection = "DefaultConnection";
            using (SqlConnection sqlconn = new SqlConnection(connection))
            {
                string sqlquery = "insert into Blog(Btitle,BDesc) values ('" + b.Btitle + "','" + b.BDesc + "')";
                using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn)) {
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    ViewData["Message"] = "De blogpost" + b.Btitle + "is toegevoegd!";
                }
            }
            return View(b);
        }
    }
}
