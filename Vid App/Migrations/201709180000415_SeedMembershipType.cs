namespace Vid_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate) VALUES (3, 60, 3, 25)");
            Sql("INSERT INTO MembershipTypes (Id, SignupFee, DurationInMonths, DiscountRate) VALUES (4, 90, 12, 50)");
        }
        
        public override void Down()
        {
        }
    }
}
