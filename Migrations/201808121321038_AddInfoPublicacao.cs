namespace Livraria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddInfoPublicacao : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Livroes", "DataPublicacao", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Livroes", "DataPublicacao", c => c.Int());
        }
    }
}
