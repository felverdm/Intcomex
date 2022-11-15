using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IntomexApi.Data;
using IntomexApi.Models.DBModel;
using IntomexApi.Models;
using IntomexApi.Models.Request;

namespace IntomexApi
{
    [Route("api/ProductsXimagesController")]
    [ApiController]
    public class ProductsXimagesController : ControllerBase
    {
        //este controlador solo tiene metodos get ya que es de una vista
        private readonly IntomexApiContext _context;

        public ProductsXimagesController(IntomexApiContext context)
        {
            _context = context;
        }

        // GET: api/ProductsXimages
        [Route("~/api/Products")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductsXimage>>> GetProductsXimage(GetPaginatedProductRequest req)
        {
            //aca recibo el numero de items que deben salir en la paginación y la página... para saber cuantos items se debe saltar se hace la multiplicación del skip
            return await _context.ProductsXimage.Skip(req.NumerOfItems * req.Page).Take(req.NumerOfItems).ToListAsync();
        }

        // GET: api/ProductsXimages/5
        [Route("~/api/Products/id")]
        //[HttpGet("{id:int}")]
        public async Task<ActionResult<ProductsXimage>> GetProductsXimage(GetProductRequest req)
        {
            var productsXimage = await _context.ProductsXimage.FindAsync(req.ProductID);

            if (productsXimage == null)
            {
                return NotFound();
            }

            return productsXimage;
        }        

        private bool ProductsXimageExists(int id)
        {
            return _context.ProductsXimage.Any(e => e.ProductID == id);
        }
    }
}
