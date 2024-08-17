namespace ${{DefaultApp}}.Migrations
{
    public class Seeder : Core.Migrations.Seeder
    {
        protected override int DefineVersion()
        {
            return AppInfo.Version;
        }

        protected override bool LoadVersion(int version)
        {
            
            return true;
        }
    
    }
}