using ECommerceAPI.EndPoints;
using ECommerceAPI.Migrations;
using EcommerceCAPI.Data.Data;
using EcommerceCAPI.Data.DTOs;
using ECommerceMAPI.Data.Data;
using Humanizer;
using Microex.Swagger.SwaggerGen.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

var connection = builder.Configuration.GetConnectionString("DefaultConnection");
//ECommerceMAPIDbContext is the bridge to the dataBase
builder.Services.AddDbContext<ECommerceMAPIDbContext>(options =>
{
    options.UseSqlServer(
        connection,
        b => b.MigrationsAssembly("ECommerceAPI")
    );
});



// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy => policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
});

builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
};

app.UseHttpsRedirection();
app.UseCors("AllowAll");


app.MapGet("/Products", async (ECommerceMAPIDbContext context) =>
{
    //var products = await context.Products.ToListAsync();
    //return Results.Ok(products);

    return await context.Products.ToListAsync();

});

// another example
//app.MapGet("/Products",async (ECommerceMAPIDbContext context) =>
//{
//    var products = await context.Products.Select(p=>

//    new ProductResponse 
//    {
//        Id=p.Id,
//        ProductName = p.ProductName,
//        MainImg = p.MainImg,
//        Description = p.Description,
//        Price = p.Price,
//        Discount = p.Discount,
//        Quantity = p.Quantity,

//    }).ToListAsync();

//    return Results.Ok(products);

//}
//);
//app.MapGet("/Products/{id}", async (ECommerceMAPIDbContext context, int id) =>
//{
//    // is the result of type Product is product which we provided then give result ok(product)                      
//    return await context.Products.FindAsync(id) is Product product ? Results.Ok(product) : Results.NotFound();

//});

// another way for GetById
app.MapGet("/Products/{id}",async(ECommerceMAPIDbContext context , int id)=>
{
    var record = await context.Products.Select(p =>

    new ProductResponse {
        Id = p.Id,
        ProductName = p.ProductName,
        MainImg = p.MainImg,
        ImgPath = p.ImgPath,
        Description = p.Description,
        Price = p.Price,
        Discount = p.Discount,
        Quantity = p.Quantity,

    }).FirstOrDefaultAsync();

        return await context.Products.FindAsync(id) is Product product ? Results.Ok(product) : Results.NotFound();

}
);




//post => create and Put =>update                           // we need it with the request so we have to added it to be created
app.MapPost("/Products/{id}", async ( CreateProductDto dto,ECommerceMAPIDbContext context , int id,  IWebHostEnvironment env) =>
{
    var prod = await context.Products.FindAsync(id);

    if (prod != null && dto is IFormFile authorImg && authorImg.Length > 0)
    {
        var uploads = Path.Combine(env.WebRootPath, "images", "product_images");
        Directory.CreateDirectory(uploads);

        var fileName = Guid.NewGuid() + Path.GetExtension(authorImg.FileName);
        var filePath = Path.Combine(uploads, fileName);

        using var stream = new FileStream(filePath, FileMode.Create);
        await authorImg.CopyToAsync(stream);



        prod.ImgPath = fileName;
    }
    var product = new Product
    {
        Status = dto.Status,
        ProductName = dto.ProductName,
        MainImg = dto.MainImg,
        Description = dto.Description,
        Price = dto.Price,
        Discount = dto.Discount,
        Quantity = dto.Quantity,
        ImgPath=dto.ImgPath,
        Rate = dto.Rate,
        BrandId = dto.BrandId,
        CategoryId = dto.CategoryId
    };

    context.Products.Add(product);
    await context.SaveChangesAsync();

    return Results.Created($"/Products/{product.Id}", product);
});

//CreateProductDto dto ,
app.MapPut("/Products/{id:int}", async (
    int id,
    UpdateProductDto dto,
    ECommerceMAPIDbContext context, IWebHostEnvironment env) =>
{
    var product = await context.Products.FindAsync(id);
    if (product == null)
        return Results.NotFound();

    if (product != null && dto is IFormFile MainImg && MainImg.Length > 0)
    {
        var uploads = Path.Combine(env.WebRootPath, "images", "Product_images");
        Directory.CreateDirectory(uploads);
        var fileName = Guid.NewGuid() + Path.GetExtension(MainImg.FileName);
        var filePath = Path.Combine(uploads, fileName);
        using var stream = new FileStream(filePath, FileMode.Create);
        await MainImg.CopyToAsync(stream);
        // ��� �������
        if (!string.IsNullOrEmpty(product.ImgPath))
        {
            var oldPath = Path.Combine(uploads, product.ImgPath);
            if (File.Exists(oldPath)) File.Delete(oldPath);
        }
        product.ImgPath = fileName;
        await context.SaveChangesAsync();
    }
    product.Status = dto.Status;
    product.ProductName = dto.ProductName;
    product.MainImg = dto.MainImg;
    product.Description = dto.Description;
    product.Price = dto.Price;
    product.Discount = dto.Discount;
    product.Quantity = dto.Quantity;
    product.Rate = dto.Rate;
    product.BrandId = dto.BrandId;
    product.ImgPath = dto.ImgPath;
    product.CategoryId = dto.CategoryId;

    await context.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/Product/{id}",async(ECommerceMAPIDbContext context , int id) =>
{
    var record = await context.Products.FindAsync(id);
    if (record is null) return Results.NotFound();

    
    context.Remove(record);

    await context.SaveChangesAsync();
    return Results.NoContent();

});

app.MapProductEndpoints();





app.Run();


