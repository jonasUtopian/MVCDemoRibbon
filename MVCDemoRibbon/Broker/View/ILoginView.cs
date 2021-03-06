﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemoRibbon.Broker.View
{
    public interface ILoginView : IView 
    {
        string User { get; set; }
        string Password { get; set; }
        bool Remember { get; set; }
        string Message { get; set; }

        event EventHandler OnLogin;

        event EventHandler OnExit;

        event EventHandler OnKeyboard;
    }
}
