
using AventusSharp.Tools;
using Core.Migrations;

namespace ${{DefaultApp}}.Migrations
{
    public class Migrator : Core.Migrations.Migrator
    {
        private Dictionary<int, Migration> migrations = new Dictionary<int, Migration>() { };

        public Migrator()
        {
            // add your Core.Migrations.Migration file here
            // migrations.Add(2, new Migration2());
        }

        protected override VoidWithError RunMigration(int? oldVersion, int currentVersion)
        {
            // Pas besoin de faire qqch vu que gérer automatiquement lors de la création
            if (oldVersion == null) return new();

            VoidWithError result = new VoidWithError();
            int v = (int)oldVersion;
            while (v <= currentVersion)
            {
                result.Run(
                    () => migrations[v].Run()
                );
                v++;
            }
            return result;
        }
    }
}