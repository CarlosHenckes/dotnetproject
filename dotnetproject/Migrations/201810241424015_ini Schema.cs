namespace dotnetproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iniSchema : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyModels");
        }
    }
}
