namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotationsAddPhotoUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "PhotoUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "PhotoUrl");
        }
    }
}
