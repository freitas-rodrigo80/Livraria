namespace Livraria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livroes",
                c => new
                {
                    IdLivro = c.Int(nullable: false, identity: true),
                    Titulo = c.String(),
                    Resumo = c.String(),
                    Autor = c.String(),
                    Quantidade = c.Int(nullable: false),
                    Valor = c.Double(nullable: false),
                    Categoria = c.String(),
                })
                .PrimaryKey(t => t.IdLivro);

        }
        
        public override void Down()
        {
            DropTable("dbo.Livroes");
        }
    }
}
