namespace iAttended.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredStudentProps : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Students", "Gender", c => c.String(nullable: false, maxLength: 6));
            AlterColumn("dbo.Students", "ContactNumber", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Students", "EmailAddress", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "EmailAddress", c => c.String());
            AlterColumn("dbo.Students", "ContactNumber", c => c.String());
            AlterColumn("dbo.Students", "Gender", c => c.String());
            AlterColumn("dbo.Students", "Name", c => c.String());
        }
    }
}
