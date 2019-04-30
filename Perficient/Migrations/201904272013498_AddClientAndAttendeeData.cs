namespace Perficient.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddClientAndAttendeeData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Clients ON");
            Sql("INSERT INTO Clients (Id,Name,Phone,Email,Street,City,State,ZipCode,DateTime) VALUES (1,'Client 1','727-123-4567','info@client1.com','1234 Landmark Way','Pal Harbor','FL','34684',getdate())");
            Sql("INSERT INTO Clients (Id,Name,Phone,Email,Street,City,State,ZipCode,DateTime) VALUES (2,'Client 2','281-123-4568','info@client2.com','4321 Quial Field Dr','Houston','TX','77095',getdate())");
            Sql("INSERT INTO Clients (Id,Name,Phone,Email,Street,City,State,ZipCode,DateTime) VALUES (3,'Client 3','312-636-9898','info@client3.com','120 W Wacker Dr','Chicago','IL','60606',getdate())");
            Sql("SET IDENTITY_INSERT Clients OFF");

            Sql("SET IDENTITY_INSERT Attendees ON");
            Sql("INSERT INTO Attendees (Id,FirstName,LastName,Email,DateTime,Client_Id) VALUES (1,'Bill','Smith','Bill@client1.com',getdate(),1)");
            Sql("INSERT INTO Attendees (Id,FirstName,LastName,Email,DateTime,Client_Id) VALUES (2,'Jim','Smith','jim@client1.com',getdate(),1)");
            Sql("INSERT INTO Attendees (Id,FirstName,LastName,Email,DateTime,Client_Id) VALUES (3,'Donna','White','donna@client1.com',getdate(),1)");
            Sql("INSERT INTO Attendees (Id,FirstName,LastName,Email,DateTime,Client_Id) VALUES (4,'Travis','Alford','travis@client2.com',getdate(),2)");
            Sql("INSERT INTO Attendees (Id,FirstName,LastName,Email,DateTime,Client_Id) VALUES (5,'Alec','Barlow','alec@client2.com',getdate(),2)");
            Sql("INSERT INTO Attendees (Id,FirstName,LastName,Email,DateTime,Client_Id) VALUES (6,'Matt','Tyrrell','matt@client3.com',getdate(),3)");
            Sql("SET IDENTITY_INSERT Attendees OFF");
        }

        public override void Down()
        {
            Sql("DELETE FROM Attendees WHERE ID in (1,2,3,4,5,6)");

            Sql("DELETE FROM Clients WHERE ID in (1,2,3)");
        }
    }
}
