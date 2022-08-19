namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "LastName2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "LastName2");
        }
    }
}
