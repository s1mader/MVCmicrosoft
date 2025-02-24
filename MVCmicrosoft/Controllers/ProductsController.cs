using Microsoft.AspNetCore.Mvc;
using MVCmicrosoft.Data;
using MVCmicrosoft.Models;

public class ProductsController : Controller
{
    private readonly AppDbContext _context;

    public ProductsController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult Create()
    {

        return View();
    }
    [HttpGet]
    public IActionResult Index()
    {
        var products = _context.Products.ToList();
        return View(products);
    }

    [HttpPost]
    public IActionResult Create(ProductModel product)
    {
        if (!ModelState.IsValid)
        {
            return View(product);
        }

        // Actually save to DB
        _context.Products.Add(product);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}
