namespace ProyectoFinalProgramacionIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Cedula = c.String(nullable: false),
                        Telefono = c.Int(nullable: false),
                        Ciudad = c.String(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        Precio_compra = c.Int(nullable: false),
                        Precio_venta = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Cantidad_minima = c.Int(nullable: false),
                        Categoria = c.String(nullable: false),
                        Marca = c.String(nullable: false),
                        Cod_proveedor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Cod_user = c.Int(nullable: false, identity: true),
                        NickName = c.String(nullable: false),
                        Clave = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        Apellido = c.String(nullable: false),
                        Cedula = c.String(nullable: false),
                        Correo = c.String(),
                        Ciudad = c.String(nullable: false),
                        Telefono = c.Int(nullable: false),
                        Rol = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Cod_user);
            
            CreateTable(
                "dbo.ProductoClientes",
                c => new
                    {
                        Producto_Codigo = c.Int(nullable: false),
                        Cliente_Codigo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Producto_Codigo, t.Cliente_Codigo })
                .ForeignKey("dbo.Productoes", t => t.Producto_Codigo, cascadeDelete: true)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Codigo, cascadeDelete: true)
                .Index(t => t.Producto_Codigo)
                .Index(t => t.Cliente_Codigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProductoClientes", "Cliente_Codigo", "dbo.Clientes");
            DropForeignKey("dbo.ProductoClientes", "Producto_Codigo", "dbo.Productoes");
            DropIndex("dbo.ProductoClientes", new[] { "Cliente_Codigo" });
            DropIndex("dbo.ProductoClientes", new[] { "Producto_Codigo" });
            DropTable("dbo.ProductoClientes");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Productoes");
            DropTable("dbo.Clientes");
        }
    }
}
