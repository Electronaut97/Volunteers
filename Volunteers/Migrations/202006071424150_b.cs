namespace Volunteers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class b : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.volunteers", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.volunteers", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.volunteers", "Contact", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.volunteers", "Contact", c => c.Int(nullable: false));
            AlterColumn("dbo.volunteers", "Surname", c => c.String());
            AlterColumn("dbo.volunteers", "Name", c => c.String());
        }
    }
}
