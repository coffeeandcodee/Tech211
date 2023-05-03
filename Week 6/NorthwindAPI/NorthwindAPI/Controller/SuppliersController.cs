﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NorthwindAPI.Data.Repositories;
using NorthwindAPI.Models;
using NorthwindAPI.Models.DTO;


namespace NorthwindAPI.Controller;

[Route("api/[controller]")]
[ApiController]
public class SuppliersController : ControllerBase
{
    private readonly NorthwindContext _context;

    private readonly ILogger _logger;
    private readonly INorthwindRepository<Supplier> _supplierRepository;


    public SuppliersController(NorthwindContext context, ILogger<SuppliersController> logger, INorthwindRepository<Supplier> supplierRepository)
    {
        _context = context;
        _logger = logger;
        _supplierRepository = supplierRepository;
    }

    // GET: api/Suppliers
    [HttpGet]
    public async Task<ActionResult<IEnumerable<SupplierDTO>>> GetSuppliers()
    {
        if (_context.Suppliers == null)
        {
            return NotFound();
        }
        return (await _supplierRepository.GetAllAsync())
            .Select(s => Utils.SupplierToDTO(s))
            .ToList();
    }

    // GET: api/Suppliers/5
    [HttpGet("{id}")]
    public async Task<ActionResult<SupplierDTO>> GetSupplier(int id)
    {
        if (_context.Suppliers == null)
        {
            return NotFound();
        }
        var supplier = await _context.Suppliers
            .Where(s => s.SupplierId == id)
            .Include(s => s.Products)
            .FirstOrDefaultAsync();


        if (supplier == null)
        {
            _logger.LogWarning($"Supplier with id: {id} was not found");
            return NotFound();
        }

        _logger.LogInformation($"Supplier with id:{id} was found");

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

        var supplier = await _context.Suppliers
            .Where(s => s.SupplierId == id)
            .Include(s => s.Products)
            .FirstOrDefaultAsync();


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

        _context.Entry(supplier).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!SupplierExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // POST: api/Suppliers
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<SupplierDTO>> PostSupplier([Bind("CompanyName, ContactName, ContactTitle, Country, Products")] Supplier supplier)
    {
        if (_context.Suppliers == null)
        {
            return Problem("Entity set 'NorthwindContext.Suppliers'  is null.");
        }
        _context.Suppliers.Add(supplier);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetSupplier",
            new { id = supplier.SupplierId },
            Utils.SupplierToDTO(supplier));
    }


    // DELETE: api/Suppliers/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteSupplier(int id)
    {
        if (_context.Suppliers == null)
        {
            return NotFound();
        }
        var supplier = await _context.Suppliers
            .Where(s => s.SupplierId == id)
            .Include(s => s.Products)
            .FirstOrDefaultAsync();

        if (supplier == null)
        {
            return NotFound();
        }

        supplier.Products.Select(p => p.SupplierId = null);

        _context.Suppliers.Remove(supplier);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool SupplierExists(int id)
    {
        return (_context.Suppliers?.Any(e => e.SupplierId == id)).GetValueOrDefault();
    }
}
