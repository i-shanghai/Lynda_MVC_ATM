namespace Lynda_MVC_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCheckingAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckingAccounts",
                c => new
                {
                    id = c.Int(nullable: false, identity: true),
                    AccountNo = c.String(nullable: false),
                    FirstName = c.String(nullable: false),
                    LastName = c.String(nullable: false),
                    Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    AplicationUserID = c.String(),
                    User_Id = c.String(maxLength: 128),
                })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);


            AlterColumn("dbo.CheckingAccounts", "AccountNo", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNo", c => c.String(nullable: false));
        }
    }
}
