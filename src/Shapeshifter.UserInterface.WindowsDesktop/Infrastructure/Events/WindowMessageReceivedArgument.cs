﻿using System;

namespace Shapeshifter.UserInterface.WindowsDesktop.Services.Events
{
    public class WindowMessageReceivedArgument : EventArgs
    {
        public WindowMessageReceivedArgument(
            IntPtr windowHandle,
            int message,
            IntPtr wordParameter,
            IntPtr longParameter)
        {
            WindowHandle = windowHandle;
            Message = message;
            WordParameter = wordParameter;
            LongParameter = longParameter;
        }

        public IntPtr WindowHandle { get; private set; }
        public int Message { get; private set; }
        public IntPtr WordParameter { get; private set; }
        public IntPtr LongParameter { get; private set; }

        public bool Handled { get; set; }
    }
}