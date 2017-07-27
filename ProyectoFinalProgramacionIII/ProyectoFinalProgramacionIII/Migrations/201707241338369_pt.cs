namespace ProyectoFinalProgramacionIII.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pt : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Clientes", "mamaguevo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clientes", "mamaguevo", c => c.String());
        }
    }
}
