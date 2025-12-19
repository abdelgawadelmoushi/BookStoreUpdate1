using Microsoft.EntityFrameworkCore;
using ECommerceMAPI.Data.Data;
using EcommerceCAPI.Data.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace ECommerceAPI.EndPoints;

public static class ProductEndpoints
{
    public static void MapProductEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Product").WithTags(nameof(Product));

        group.MapGet("/", async (ECommerceMAPIDbContext db) =>
        {
            return await db.Products.ToListAsync();
        })
        .WithName("GetAllProducts");

        group.MapGet("/{id}", async Task<Results<Ok<Product>, NotFound>> (int id, ECommerceMAPIDbContext db) =>
        {
            return await db.Products.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Product model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetProductById");

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Product product, ECommerceMAPIDbContext db) =>
        {
            var affected = await db.Products
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.ProductName, product.ProductName)
                    .SetProperty(m => m.MainImg, product.MainImg)
                    .SetProperty(m => m.Description, product.Description)
                    .SetProperty(m => m.Price, product.Price)
                    .SetProperty(m => m.Discount, product.Discount)
                    .SetProperty(m => m.Quantity, product.Quantity)
                    .SetProperty(m => m.Rate, product.Rate)
                    .SetProperty(m => m.BrandId, product.BrandId)
                    .SetProperty(m => m.CategoryId, product.CategoryId)
                    .SetProperty(m => m.ImgPath, product.ImgPath)
                    .SetProperty(m => m.Id, product.Id)
                    .SetProperty(m => m.Status, product.Status)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateProduct");

        group.MapPost("/", async (Product product, ECommerceMAPIDbContext db) =>
        {
            db.Products.Add(product);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Product/{product.Id}",product);
        })
        .WithName("CreateProduct");

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ECommerceMAPIDbContext db) =>
        {
            var affected = await db.Products
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteProduct");
    }
}
