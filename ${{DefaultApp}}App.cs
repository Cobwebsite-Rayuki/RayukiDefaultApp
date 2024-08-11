using Core.App;
using AventusSharp.Tools.Attributes;

namespace ${{DefaultApp}}
{
    [Typescript]
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
    }
}
