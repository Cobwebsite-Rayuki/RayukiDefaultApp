using AventusSharp.Tools;

namespace ${{DefaultApp}}.Migrations
{
    public class Seeder : Core.Migrations.Seeder
    {
        protected override int DefineVersion()
        {
            return AppInfo.Version;
        }

        protected override VoidWithError LoadVersion(int version)
        {
            return new VoidWithError();
        }
    
    }
}