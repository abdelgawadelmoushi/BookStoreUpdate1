using Microsoft.EntityFrameworkCore;
using ECommerceMAPI.Data.Data;
using EcommerceCAPI.Data.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
namespace ECommerceAPI;

public static class CategoryEndpoints
{
    public static void MapCategoryEndpoints (this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Category").WithTags(nameof(Category));

        group.MapGet("/", async (ECommerceMAPIDbContext db) =>
        {
            return await db.Categories.ToListAsync();
        })
        .WithName("GetAllCategories");

        group.MapGet("/{id}", async Task<Results<Ok<Category>, NotFound>> (int id, ECommerceMAPIDbContext db) =>
        {
            return await db.Categories.AsNoTracking()
                .FirstOrDefaultAsync(model => model.Id == id)
                is Category model
                    ? TypedResults.Ok(model)
                    : TypedResults.NotFound();
        })
        .WithName("GetCategoryById");

        group.MapPut("/{id}", async Task<Results<Ok, NotFound>> (int id, Category category, ECommerceMAPIDbContext db) =>
        {
            var affected = await db.Categories
                .Where(model => model.Id == id)
                .ExecuteUpdateAsync(setters => setters
                    .SetProperty(m => m.CategoryName, category.CategoryName)
                    .SetProperty(m => m.Description, category.Description)
                    .SetProperty(m => m.MainImg, category.MainImg)
                    .SetProperty(m => m.ImgPath, category.ImgPath)
                    .SetProperty(m => m.Id, category.Id)
                    .SetProperty(m => m.Status, category.Status)
                    );
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("UpdateCategory");

        group.MapPost("/", async (Category category, ECommerceMAPIDbContext db) =>
        {
            db.Categories.Add(category);
            await db.SaveChangesAsync();
            return TypedResults.Created($"/api/Category/{category.Id}",category);
        })
        .WithName("CreateCategory");

        group.MapDelete("/{id}", async Task<Results<Ok, NotFound>> (int id, ECommerceMAPIDbContext db) =>
        {
            var affected = await db.Categories
                .Where(model => model.Id == id)
                .ExecuteDeleteAsync();
            return affected == 1 ? TypedResults.Ok() : TypedResults.NotFound();
        })
        .WithName("DeleteCategory");
    }
}
