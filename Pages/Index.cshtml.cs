using Microsoft.AspNetCore.Mvc.RazorPages;
using WarehouseWMS.Services;
using WarehouseWMS.Models;

















}    }        RecentTransactions = await _service.GetRecentTransactionsAsync(10);        LowStockCount = await _service.GetLowStockCountAsync();        TotalProducts = await _service.GetTotalProductsAsync();    {
n    public async Task OnGetAsync()    }        _service = service;    {
n    public IndexModel(InventoryService service)    public List<InventoryTransaction> RecentTransactions { get; set; }    public int LowStockCount { get; set; }    public int TotalProducts { get; set; }    private readonly InventoryService _service;{npublic class IndexModel : PageModel