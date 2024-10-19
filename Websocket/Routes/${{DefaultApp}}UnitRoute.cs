using AventusSharp.Data.Manager;
using AventusSharp.WebSocket;
using AventusSharp.WebSocket.Attributes;
using Core.Websocket;
using ${{DefaultApp}}.Data;
using ${{DefaultApp}}.Logic.DM;

namespace ${{DefaultApp}}.Websocket.Routes {

    public class ${{DefaultApp}}UnitRoute : StorableWsRoute<${{DefaultApp}}Unit>
    {
        protected override IGenericDM<${{DefaultApp}}Unit>? GetDM()
        {
            return ${{DefaultApp}}UnitDM.GetInstance();
        }
    }
}