namespace BusBookingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class businitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        MLicensePlateNo = c.String(),
                        MBusCapacity = c.Int(nullable: false),
                        MBusType = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Buses");
        }
    }
}
