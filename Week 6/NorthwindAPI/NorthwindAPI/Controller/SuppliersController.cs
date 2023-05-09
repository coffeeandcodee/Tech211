using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Data.Repositories;
using NorthwindAPI.Models;
using NorthwindAPI.Models.DTO;
using NorthwindAPI.Services;

namespace NorthwindAPI.Controller;

[Route("api/[controller]")]
[ApiController]
public class SuppliersController : ControllerBase
{
    private readonly NorthwindContext _context;

    private readonly ILogger _logger;
    private readonly INorthwindRepository<Supplier> _supplierRepository;
    private readonly INorthwindService<Supplier> _supplierService;

    public SuppliersController(INorthwindService<Supplier> supplierService)
    {
        _supplierService = supplierService;
    }

    // GET: api/Suppliers
    [HttpGet]

    public async Task<ActionResult<IEnumerable<SupplierDTO>>> GetSuppliers()
    {
        if (_supplierService is null)
        {
            return NotFound();
        }
        return (await _supplierService.GetAllAsync())
        .Select(s => Utils.SupplierToDTO(s)).ToList();
    }


    // GET: api/Suppliers/5
    [HttpGet("{id}")]
    public async Task<ActionResult<SupplierDTO>> GetSupplier(int id)
    {
        var supplier = await _supplierService.GetAsync(id);
        if (supplier == null)
        {
            return NotFound();
        }
        
        return Utils.SupplierToDTO(supplier);

    }

    // GET: api/Suppliers/5/products
    [HttpGet("{id}/products")]
    public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProductsListBySupplier(int id)
    {
        if (_context.Suppliers == null)
        {
            return NotFound();
        }

        var supplier = await _supplierRepository.FindAsync(id);

        //BEfore supplierRepository
        /*await _context.Suppliers
        .Where(s => s.SupplierId == id)
        .Include(s => s.Products)
        .FirstOrDefaultAsync();*/


        if (supplier == null)
        {
            return NotFound();
        }

        return supplier.Products
                .Select(p => Utils.ProductToDTO(p))
                .ToList();
    }


    // PUT: api/Suppliers/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutSupplier(int id, [Bind("SupplierId, CompanyName, ContactTitle, Country")] Supplier supplier)
    {
        if (id != supplier.SupplierId)
        {
            return BadRequest();
        }

        if(await _supplierService.UpdateAsync(id, supplier))
        {
            return NoContent();
        }

        return NotFound();

       
    }


    // DELETE: api/Suppliers/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSupplier(int id)
    {
        if (_supplierRepository.IsNull)
        {
            return NotFound();
        }
        var supplier = await _supplierRepository.FindAsync(id);
        /*
        .Where(s => s.SupplierId == id)
        .Include(s => s.Products)
        .FirstOrDefaultAsync();
        */

        if (supplier == null)
        {
            return NotFound();
        }

        foreach (var item in _context.Products.Where(p => p.SupplierId == id)) item.SupplierId = null;

        supplier.Products.Select(p => p.SupplierId = null);

        _supplierRepository.Remove(supplier);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool SupplierExists(int id)
    {
        return (_context.Suppliers?.Any(e => e.SupplierId == id)).GetValueOrDefault();
    }
}
