namespace Perficient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateClientAndAttendee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        Client_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id, cascadeDelete: true)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Phone = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 255),
                        Street = c.String(nullable: false, maxLength: 255),
                        City = c.String(nullable: false, maxLength: 255),
                        State = c.String(nullable: false),
                        ZipCode = c.String(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Attendees", "Client_Id", "dbo.Clients");
            DropIndex("dbo.Attendees", new[] { "Client_Id" });
            DropTable("dbo.Clients");
            DropTable("dbo.Attendees");
        }
    }
}
