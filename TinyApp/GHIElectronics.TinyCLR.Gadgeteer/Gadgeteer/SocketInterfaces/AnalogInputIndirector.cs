﻿namespace Gadgeteer.SocketInterfaces
{
    using Gadgeteer;
    using Gadgeteer.Modules;
    using System;
    using System.Runtime.CompilerServices;

    public delegate AnalogInput AnalogInputIndirector(Socket socket, Socket.Pin pin, Module module);
}

