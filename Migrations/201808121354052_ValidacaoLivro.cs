namespace Livraria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ValidacaoLivro : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Livroes", "Titulo", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Livroes", "Resumo", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Livroes", "Resumo", c => c.String());
            AlterColumn("dbo.Livroes", "Titulo", c => c.String());
        }
    }
}
