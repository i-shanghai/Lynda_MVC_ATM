namespace Lynda_MVC_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtranstration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CheckingAccountId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.CheckingAccounts", t => t.CheckingAccountId, cascadeDelete: true)
                .Index(t => t.CheckingAccountId);
            
            AlterColumn("dbo.CheckingAccounts", "AplicationUserID", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "CheckingAccountId", "dbo.CheckingAccounts");
            DropIndex("dbo.Transactions", new[] { "CheckingAccountId" });
            AlterColumn("dbo.CheckingAccounts", "AplicationUserID", c => c.String());
            DropTable("dbo.Transactions");
        }
    }
}
