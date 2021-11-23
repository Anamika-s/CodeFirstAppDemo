namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblStudent",
                c => new
                    {
                        StudentCode = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Photo = c.Binary(),
                        Weight = c.Single(nullable: false),
                        DoB = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.StudentCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblStudent");
        }
    }
}
