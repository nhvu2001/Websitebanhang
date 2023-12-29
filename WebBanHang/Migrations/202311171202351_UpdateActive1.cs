namespace WebBanHang.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActive1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "IsFeature", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "IsFeature");
        }
    }
}
