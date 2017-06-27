namespace Lynda_MVC_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifymodeltranstration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Transactions", "CheckingAccountId", "dbo.CheckingAccounts");
            DropIndex("dbo.Transactions", new[] { "CheckingAccountId" });
            AddColumn("dbo.Transactions", "checkingAccount_id", c => c.Int());
            AlterColumn("dbo.Transactions", "CheckingAccountId", c => c.String(nullable: false));
            CreateIndex("dbo.Transactions", "checkingAccount_id");
            AddForeignKey("dbo.Transactions", "checkingAccount_id", "dbo.CheckingAccounts", "id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "checkingAccount_id", "dbo.CheckingAccounts");
            DropIndex("dbo.Transactions", new[] { "checkingAccount_id" });
            AlterColumn("dbo.Transactions", "CheckingAccountId", c => c.Int(nullable: false));
            DropColumn("dbo.Transactions", "checkingAccount_id");
            CreateIndex("dbo.Transactions", "CheckingAccountId");
            AddForeignKey("dbo.Transactions", "CheckingAccountId", "dbo.CheckingAccounts", "id", cascadeDelete: true);
        }
    }
}
