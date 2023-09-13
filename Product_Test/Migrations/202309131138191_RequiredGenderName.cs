namespace Product_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredGenderName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Genders", "GenderName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Genders", "GenderName", c => c.String());
        }
    }
}
