using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WarehouseWMS.Data;
using WarehouseWMS.Models;

public class ProductsIndexModel : PageModel
{
    private readonly WarehouseContext _db;
    public string Query { get; set; }
    public List<Product> Products { get; set; }

    public ProductsIndexModel(WarehouseContext db)
    {
        _db = db;
    }

    public async Task OnGetAsync(string q)
    {
        Query = q;
        var query = _db.Products.Include(p => p.Category).Include(p => p.Supplier).AsQueryable();
        if (!string.IsNullOrWhiteSpace(q))
        {
            query = query.Where(p => p.Name.Contains(q) || p.SKU.Contains(q));
        }
        Products = await query.OrderBy(p => p.Name).ToListAsync();
    }
}