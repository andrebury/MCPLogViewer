using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCPLOGViewer.Model;

namespace MCPLOGViewer.View
{
    interface IForm1: IManipulation
    {
        IManipulation manipulation { get; set; }
    }
}
