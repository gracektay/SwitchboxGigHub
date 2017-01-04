namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddFollowing : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Followings");
            AddColumn("dbo.Followings", "FollowerId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Followings", new[] { "FollowerId", "FolloweeId" });
            DropColumn("dbo.Followings", "FollowerId");
        }

        public override void Down()
        {
            AddColumn("dbo.Followings", "FollowerId", c => c.Int(nullable: false));
            DropPrimaryKey("dbo.Followings");
            DropColumn("dbo.Followings", "FollowerId");
            AddPrimaryKey("dbo.Followings", new[] { "FollowerId", "FolloweeId" });
        }
    }
}
