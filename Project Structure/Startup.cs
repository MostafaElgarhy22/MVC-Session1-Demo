using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Project_Structure
{

    #region Dependency Injection
    //class ProductsController : Controller
    //{
    //    private ProductService _productService;

    //    public ProductsController()
    //    {
    //        _productService = new ProductService();
    //    }

    //    //Action: baseUrl/Products/GetProduct?id=10
    //    public IActionResult GetPtoduct(int id)
    //    {
    //        var Product = _productService.GetProductById(id);

    //        return View(Product);
    //    }

    //}

    //class ProductService
    //{
    //    private ProductRepository _ProductRepository;
    //    private CategoryRepository _CategoryRepository;

    //    public ProductService()
    //    {
    //        _ProductRepository = new ProductRepository();
    //        _CategoryRepository = new CategoryRepository();
    //    }
    //    public Product GetProductById(int id)
    //    {
    //        // Business Logic

    //        var categories = _CategoryRepository.GetAll();

    //        return _ProductRepository.Get(id);
    //    }
    //}

    //class ProductRepository
    //{
    //    private ApplicationDbContext _dbcontext;
    //    public ProductRepository()
    //    {
    //        _dbcontext = new ApplicationDbContext(new DbContextOptions());
    //    }
    //    public Product Get(int id)
    //    {
    //        return _dbcontext.Products.Find(id);
    //    }
    //}
    //class CategoryRepository
    //{
    //    private ApplicationDbContext _dbcontext;
    //    public CategoryRepository()
    //    {
    //        _dbcontext = new ApplicationDbContext(new DbContextOptions());
    //    }
    //    public List<Categoy> GetAll(int id)
    //    {
    //        return _dbcontext.Categories.ToList(id);
    //    }
    //}

    //class ApplicationDbContext : DbContext
    //{
    //    public ApplicationDbContext(DbContextOptions options) : base(options)
    //    {

    //    }
    //    public DbSet<Product> Products { get; set; }
    //    public DbSet<Categoy> Categories { get; set; }

    //}
    //    class Product
    //    {
    //        public int Id { get; set; }
    //        public string? Name { get; set; }
    //        public string? Description { get; set; }
    //        public decimal UnitPrice { get; set; }
    //    }
    //    class Categoy
    //    {
    //        public int Id { get; set; }
    //        public string? Name{ get; set; }
    //    } 
    #endregion

    public class Startup
        {
            // This method gets called by the runtime. Use this method to add services to the container.
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
            public void ConfigureServices(IServiceCollection services)
            {
            //services.AddControllers();

            //services.AddControllersWithView();

           // services.AddRazorPages();

            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage(); //Middleware
                }

                app.UseRouting();

                app.UseEndpoints(endpoints =>
                {
                    endpoints.MapGet("/", async context =>
                    {
                        await context.Response.WriteAsync("Hello World!");
                    });

                    endpoints.MapGet("/Hamada", async context =>
                    {
                        await context.Response.WriteAsync("Hello Hamada");
                    });

                    endpoints.MapAreaControllerRoute(
                        name: "default",
                        pattern: "{controller}/{action}/{id}"
                        );
                });
            }
        }
    }

