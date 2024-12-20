﻿using AventusSharp.Routes;
using AventusSharp.Tools.Attributes;
using Core.Routes;

namespace ${{DefaultApp}}.Routes
{
    public class MainRouter : Router
    {
        [NoExport]
        public Component Index()
        {
            return new Component("Main");
        }
    }
}
