using AventusSharp.Tools.Attributes;
using Core.App;
using Core.Logic.FileSystem;
using ${{DefaultApp}}.Migrations;

namespace ${{DefaultApp}}
{
    [Export]
    public class AppInfo {
        public static int Version = 1;
    }
    public class ${{DefaultApp}}App : RayukiApp
    {
        public override int Version()
        {
            return AppInfo.Version;
        }

        public override string DisplayName()
        {
            return "${{DefaultApp}}";
        }


        public override Core.Migrations.Seeder? DefineSeeder()
        {
            return new Seeder();
        }

        public override Core.Migrations.Migrator? DefineMigrator()
        {
            return new Migrator();
        }
    }

    public static class App
    {
        public static FileStorage FileStorage
        {
            get
            {
                return FileStorage.Get<${{DefaultApp}}App>();
            }
        }
    }
}
