using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Tasks
{

    class Ware
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("WareID")]
        public int WareID { get; set; }
        public Painting Painting { get; set; }
        public int Amount { get; set; }
        //public ICollection<Painting> Paintings { get; set; }
    }

    class Cart
    {
        [ForeignKey("PaintingID")]
        public int PaintingID { get; set; }
        public virtual Painting Paintings { get; set; }
        public int Amount { get; set; }
        public int CustomerID { get; set; }
        public virtual Recep Receipt { get; set; }
        [Key]
        public int ID { get; set; }
        [ForeignKey("PersonID")]
        public virtual Person People { get; set; }
    }
    class Person
    {
        [Key]
        public int PersonID { get; set; }
        public string FIO { get; set; }
        public int PhoneNumber { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int AccType { get; set; }
    }
    class Painting
    {
        [Key]
        //[ForeignKey("PaintingID")]
        public int PaintingID { get; set; }
        public virtual Cart Carts { get; set; }
        public virtual Ware Ware { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Description { get; set; }
        public Byte[] Photo { get; set; }
        public int Price { get; set; }
    }
    class Recep
    {
        [Key]
        public int ReceiptID { get; set; }
        [ForeignKey("CartID")]
        public int CartID { get; set; }
        public virtual Cart Cart { get; set; }
        public string status { get; set; }
       
    }
    class MagazinContext : DbContext
    {
        public MagazinContext() : base("MagazinDBContext") { Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MagazinContext>()); }
        public DbSet<Ware> Wares { get; set; }
        public DbSet<Recep> Receipts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Painting> Paintings { get; set; }
        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.Entity<Painting>()
                .HasOptional(s => s.Ware) 
                .WithRequired(ad => ad.Painting);
            mb.Entity<Cart>()
                .HasOptional(m => m.Paintings)
                .WithMany()
                .HasForeignKey(p => p.PaintingID);
            mb.Entity<Recep>()
                .HasOptional(m => m.Cart)
                .WithRequired();
            mb.Entity<Cart>()
                .HasOptional(m => m.People)
                .WithMany()
                .HasForeignKey(p => p.CustomerID);
        }
    }
}

