namespace webApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TabelaFuncionario : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Funcao = c.String(),
                        Turno = c.String(),
                        HorasTrabalhadas = c.Int(nullable: false),
                        ValorDaHora = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Funcionarios");
        }
    }
}
