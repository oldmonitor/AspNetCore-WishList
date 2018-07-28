﻿using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Item> items { get; set; }

        public ApplicationDbContext(DbContextOptions options): base(options)
        {

        }
    }
}
