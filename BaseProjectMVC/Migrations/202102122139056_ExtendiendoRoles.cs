namespace BaseProjectMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtendiendoRoles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetRoles", "Descripcion", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetRoles", "Discriminator");
            DropColumn("dbo.AspNetRoles", "Descripcion");
        }
    }
}
