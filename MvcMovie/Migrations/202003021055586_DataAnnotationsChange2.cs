namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationsChange2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Rating", c => c.String(maxLength: 5));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Rating", c => c.String(nullable: false, maxLength: 5));
        }
    }
}
