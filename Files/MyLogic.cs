using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevPackageClio.API;
using Terrasoft.Core.Factories;

namespace DevPackageClio.Files
{
    [DefaultBinding(typeof(IMyLogic))]
    public class MyLogic: IMyLogic
    {
        public int MyMethod(int a, int b)
        {
            return (a + b) * 10;
        }
    }
}
