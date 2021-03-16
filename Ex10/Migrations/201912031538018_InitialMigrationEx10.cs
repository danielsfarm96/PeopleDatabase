namespace Ex10.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigrationEx10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        MiddleName = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        NickName = c.String(maxLength: 40),
                        BirthDate = c.DateTime(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonId);
            
            CreateTable(
                "dbo.Phones",
                c => new
                    {
                        PhoneId = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(),
                        Person_PersonId = c.Int(),
                    })
                .PrimaryKey(t => t.PhoneId)
                .ForeignKey("dbo.People", t => t.Person_PersonId)
                .Index(t => t.Person_PersonId);
            
            CreateTable(
                "dbo.PersonCompanies",
                c => new
                    {
                        Person_PersonId = c.Int(nullable: false),
                        Company_CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Person_PersonId, t.Company_CompanyId })
                .ForeignKey("dbo.People", t => t.Person_PersonId, cascadeDelete: true)
                .ForeignKey("dbo.Companies", t => t.Company_CompanyId, cascadeDelete: true)
                .Index(t => t.Person_PersonId)
                .Index(t => t.Company_CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Phones", "Person_PersonId", "dbo.People");
            DropForeignKey("dbo.PersonCompanies", "Company_CompanyId", "dbo.Companies");
            DropForeignKey("dbo.PersonCompanies", "Person_PersonId", "dbo.People");
            DropIndex("dbo.PersonCompanies", new[] { "Company_CompanyId" });
            DropIndex("dbo.PersonCompanies", new[] { "Person_PersonId" });
            DropIndex("dbo.Phones", new[] { "Person_PersonId" });
            DropTable("dbo.PersonCompanies");
            DropTable("dbo.Phones");
            DropTable("dbo.People");
            DropTable("dbo.Companies");
        }
    }
}
