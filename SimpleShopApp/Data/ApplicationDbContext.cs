using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SimpleShopApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>().HasData(
                [
                new Category() { Id = 1, Name = "Smartphones" },
                new Category() { Id = 2, Name = "Sport" },
                new Category() { Id = 3, Name = "Fashion" },
                new Category() { Id = 4, Name = "Home & Garden" },
                new Category() { Id = 5, Name = "Speakers" },
                new Category() { Id = 6, Name = "Toys & Hobbies" },
                new Category() { Id = 7, Name = "Musical Instruments" },
                new Category() { Id = 8, Name = "Headphones" },
                new Category() { Id = 9, Name = "Other" }
               ]);

            builder.Entity<Product>().HasData([
                new Product()
                {
                    Id = 1,
                    Name = "iPhone 16 Pro",
                    Quantity = 0,
                    Discount = 0,
                    Price = 1199,
                    CategoryId = 1,
                    Description = "The Most Innovative Lineup Yet\r\n\r\niPhone 16 and iPhone 16 Plus are built for Apple Intelligence, and feature Camera Control, the Action button, a 48MP Fusion camera, and the A18 chip. Camera Control makes it even easier to capture memories on iPhone 16 Pro and iPhone 16.",
                    ImageUrl = @"https://my-apple.com.ua/image/catalog/products/iphone/iphone-16-pro-16-pro-max/desert-titanium-1.png"
                },
                new Product()
                {
                    Id = 2,
                    Name = "Marshall Emberton II",
                    Quantity = 2,
                    Discount = 15,
                    CategoryId = 5,
                    Price = 159,
                    Description = "Emberton II delivers sound that is rich, clear and loud, like the artist intended. Experience absolute 360° sound with True Stereophonic, a unique form of multi-directional sound fromMarshall – where every spot is a sweet spot. Emberton II offers 30+ hours of portable playtime on a single charge.",
                    ImageUrl = @"https://www.marshall.com.ua/components/com_jshopping/files/img_products/full_marshall-emberton-ii-cream_detail02.jpg"
                },
                new Product()
                {
                    Id = 3,
                    Name = "AirPods Max",
                    Discount = 0,
                    Quantity = 35,
                    CategoryId = 8,
                    Price = 499,
                    Description = "AirPods Max are wireless Bluetooth over-ear headphones designed by Apple, and released on December 15, 2020. They are Apple's highest-end option in the AirPods lineup, sold alongside the base model AirPods and mid-range AirPods Pro.\r\n\r\nThe main changes of the AirPods Max over the mid-range AirPods Pro are the over-ear design with larger speakers, inclusion of Apple's Digital Crown (found on the Apple Watch), more color options, and longer battery life.",
                    ImageUrl = @"https://skay.ua/109669-thickbox_default/besprovodnye-naushniki-apple-airpods-max-pink-mgym3.jpg"
                },
                new Product()
                {
                    Id = 4,
                    Name = "Xiaomi Redmi Note 13",
                    Discount = 10,
                    Quantity = 1,
                    CategoryId = 1,
                    Price = 359,
                    Description = "Redmi Note 13's display has been optimized for improved touch recognition and control, preventing accidental triggers from water. With MIUI exclusive optimization, Redmi Note 13 has also passed extensive testing to ensure minimal software aging and slowdowns, even after 48 months of use*.",
                    ImageUrl = @"https://content1.rozetka.com.ua/goods/images/big/428176969.jpg"
                }
            ]);
        }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public int CategoryId { get; set; }

        // navigation property
        public Category? Category { get; set; }
    }

    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Product>? Products { get; set; }
    }
}
