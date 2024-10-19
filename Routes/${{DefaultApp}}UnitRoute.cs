using AventusSharp.Routes;
using AventusSharp.Routes.Attributes;
using ${{DefaultApp}}.Logic.DM;
using ${{DefaultApp}}.Data;
using Path = AventusSharp.Routes.Attributes.Path;

namespace ${{DefaultApp}}.Routes
{
    public class ${{DefaultApp}}UnitRoute : StorableRoute<${{DefaultApp}}Unit>
    {
        [Get, Path("/custom")]
        public List<${{DefaultApp}}Unit> MyCustomRoute()
        {
           return ${{DefaultApp}}UnitDM.GetInstance().Where(p => p.Name.StartsWith("Example"));
        }


    }
}
