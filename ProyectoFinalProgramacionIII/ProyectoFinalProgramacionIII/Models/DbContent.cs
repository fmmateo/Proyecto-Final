namespace ProyectoFinalProgramacionIII.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DbContent : DbContext
    {
        
        public DbContent()
            : base("name=DbContent")
        {
        }

        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}