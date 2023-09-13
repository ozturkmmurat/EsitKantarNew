using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsitKantarNewUI.Controllers
{
    public class ProductsController : Controller
    {
        IProductService _proudctService;
        public ProductsController(IProductService productService)
        {
            _proudctService = productService;
        }
        public IActionResult HippoA()
        {
            var result = _proudctService.GetProductDetails("Hippo-A").Data;
            return View(result);
        }
        public IActionResult HippoS()
        {
            var result = _proudctService.GetProductDetails("Hippo-S").Data;
            return View(result);
        }
        public IActionResult HippoL()
        {
            var result = _proudctService.GetProductDetails("Hippo-L").Data;
            return View(result);
        }
        public IActionResult DinoA()
        {
            var result = _proudctService.GetProductDetails("Dino-A").Data;
            return View(result);
        }
        public IActionResult Dino()
        {
            var result = _proudctService.GetProductDetails("Dino").Data;
            return View(result);
        }
        public IActionResult Komodo()
        {
            var result = _proudctService.GetProductDetails("KOMODO").Data;
            return View(result);
        }
        public IActionResult KantarOtomasyonS()
        {
            var result = _proudctService.GetProductDetails("Kantar Otomasyon Sistemleri").Data;
            return View(result);
        }
    }
}
