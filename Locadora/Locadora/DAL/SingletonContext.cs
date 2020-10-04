using Locadora.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.DAL
{
    class SingletonContext
    {
            private SingletonContext() { }
            private static Context ctx;
            public static Context GetInstance()
            {
                if (ctx == null)
                {
                    ctx = new Context();
                }
                return ctx;
            }
        }
}
