//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SewingFactory.BD
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FactoryEntities3 : DbContext
    {
        public FactoryEntities3()
            : base("name=FactoryEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Accessories> Accessories { get; set; }
        public virtual DbSet<AccessoriesProduct> AccessoriesProduct { get; set; }
        public virtual DbSet<Cloth> Cloth { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderProducts> OrderProducts { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<StorageAccessories> StorageAccessories { get; set; }
        public virtual DbSet<StorageCloth> StorageCloth { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
