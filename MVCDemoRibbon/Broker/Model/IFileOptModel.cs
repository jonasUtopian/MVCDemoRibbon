using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.Model
{
    interface IFileOptModel
    {
        string SourcePathName{ get; set; }
        string DesPathName { get; set; }       
    }
}
