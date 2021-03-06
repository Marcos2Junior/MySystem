﻿using Microsoft.EntityFrameworkCore;
using MySystem.Domain.Entitys;

namespace MySystem.Domain.DataContext
{
    public class MySystemDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<KeyAcess> KeyAcesses { get; set; }
        public DbSet<TypePassword> TypePasswords { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public MySystemDbContext(DbContextOptions<MySystemDbContext> options) : base(options)
        {  
        }
    }
}
