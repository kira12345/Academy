using MyProducts.WebApi;
using MyProducts.WebApi.Tests.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace MyProducts.WebApi.Tests.Controllers
{
    [EnableCors(origins: "http://localhost:60629", headers: "*", methods: "*")]
    public class ProductController : ApiController
    { 
        private ICECREAMEntities db = new ICECREAMEntities();
        // GET: api/Product
        public IEnumerable<Product> Get()
        {
            var products = db.Products.AsEnumerable();
            return products.ToList();
        }
    }
}