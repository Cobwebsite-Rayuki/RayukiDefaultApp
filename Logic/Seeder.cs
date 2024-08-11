namespace ${{DefaultApp}}.Logic
{
    public class Seeder : Core.Logic.Seeder
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