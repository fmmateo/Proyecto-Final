namespace ProyectoFinalProgramacionIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clienteMmg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clientes", "mamaguevo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Clientes", "mamaguevo");
        }
    }
}
