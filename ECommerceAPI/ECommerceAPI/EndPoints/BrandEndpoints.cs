using Microsoft.EntityFrameworkCore;
using ECommerceMAPI.Data.Data;
using EcommerceCAPI.Data.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace ECommerceAPI.EndPoints;

public static class BrandEndpoints
{
    public static void MapBrandEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Brand").WithTags(nameof(Brand));

        group.MapGet("/", async (ECommerceMAPIDbContext db) =>
        {
            return await db.Brands.ToListAsync();
        })
        .WithName("GetAllBrands");

        group.MapGet("/{id}", async Task<Results<Ok<Brand>, NotFound>> (int id, ECommerceMAPIDbContext db) =>
        {
            return await db.Brands.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Brand model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetBrandById");

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Brand brand, ECommerceMAPIDbContext db) =>
        {
            var affected = await db.Brands
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.BrandName, brand.BrandName)
                    .SetProperty(m => m.Description, brand.Description)
                    .SetProperty(m => m.Id, brand.Id)
                    .SetProperty(m => m.Status, brand.Status)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateBrand");

        group.MapPost("/", async (Brand brand, ECommerceMAPIDbContext db) =>
        {
            db.Brands.Add(brand);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Brand/{brand.Id}",brand);
        })
        .WithName("CreateBrand");

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ECommerceMAPIDbContext db) =>
        {
            var affected = await db.Brands
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteBrand");
    }
}
