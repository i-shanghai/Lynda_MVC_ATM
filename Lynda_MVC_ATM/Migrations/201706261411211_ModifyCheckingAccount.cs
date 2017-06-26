namespace Lynda_MVC_ATM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyCheckingAccount : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNo", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNo", c => c.String(nullable: false));
        }
    }
}
