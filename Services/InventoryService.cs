using Microsoft.EntityFrameworkCore;
using WarehouseWMS.Data;
using WarehouseWMS.Models;

namespace WarehouseWMS.Services
{
    public class InventoryService
    {
        private readonly WarehouseContext _db;
        public InventoryService(WarehouseContext db) => _db = db;

        public async Task<InventoryTransaction> AdjustStockAsync(InventoryTransaction tx)
        {
            if (tx == null) throw new ArgumentNullException(nameof(tx));
            if (tx.Quantity <= 0) throw new ArgumentException("Quantity must be > 0");




































}    }            => await _db.InventoryTransactions.Include(t => t.Product).OrderByDescending(t => t.Date).Take(limit).ToListAsync();
n        public async Task<List<InventoryTransaction>> GetRecentTransactionsAsync(int limit = 10)
n        public async Task<int> GetLowStockCountAsync(int threshold = 5) => await _db.Products.CountAsync(p => p.Quantity <= threshold);        public async Task<int> GetTotalProductsAsync() => await _db.Products.CountAsync();        }            }                throw;                await dbTx.RollbackAsync();            {            catch            }                return tx;                await dbTx.CommitAsync();
n                await _db.SaveChangesAsync();                _db.Products.Update(product);                _db.InventoryTransactions.Add(tx);
n                tx.Date = DateTime.UtcNow;                }                    product.Quantity += tx.Quantity;                {                else                }
n                    product.Quantity -= tx.Quantity;                        throw new InvalidOperationException("Insufficient stock for product SKU: " + product.SKU);                    if (product.Quantity < tx.Quantity)                {                if (tx.Type == TransactionType.Out)                if (product == null) throw new InvalidOperationException("Product not found");                var product = await _db.Products.Where(p => p.Id == tx.ProductId).FirstOrDefaultAsync();            {            tryn            using var dbTx = await _db.Database.BeginTransactionAsync();