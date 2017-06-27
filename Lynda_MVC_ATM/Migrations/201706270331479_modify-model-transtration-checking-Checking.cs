namespace Lynda_MVC_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifymodeltranstrationcheckingChecking : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Transactions", new[] { "checkingAccount_id" });
            CreateIndex("dbo.Transactions", "CheckingAccount_id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Transactions", new[] { "CheckingAccount_id" });
            CreateIndex("dbo.Transactions", "checkingAccount_id");
        }
    }
}
