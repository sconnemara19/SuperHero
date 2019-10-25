namespace SuperHero.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Restart : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Superheroes");
            AddColumn("dbo.Superheroes", "SuperheroId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Superheroes", "Superheroname", c => c.String());
            AddPrimaryKey("dbo.Superheroes", "SuperheroId");
            DropColumn("dbo.Superheroes", "name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Superheroes", "name", c => c.String(nullable: false, maxLength: 128));
            DropPrimaryKey("dbo.Superheroes");
            DropColumn("dbo.Superheroes", "Superheroname");
            DropColumn("dbo.Superheroes", "SuperheroId");
            AddPrimaryKey("dbo.Superheroes", "name");
        }
    }
}
