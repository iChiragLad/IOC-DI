﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Abstraction.Dependency.Interfaces
{
    interface INotifier
    {
        void SendNotification(OrderInfo orderInfo);
    }
}
