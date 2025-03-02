﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License. 

using System;
using System.Windows.Forms;
using Microsoft.UI;
using Microsoft.UI.Windowing;

namespace winforms_unpackaged_app
{
    public static class AppWindowExtensions
    {
        public static AppWindow GetAppWindowFromWinformsWindow(this IWin32Window winformsWindow)
        {
            // Get the HWND of the top level WinForms window
            IntPtr hwnd = winformsWindow.Handle;        
            
            // Get the WindowId from the HWND.
            WindowId windowId;
            windowId = Win32Interop.GetWindowIdFromWindow(hwnd);

            // Get an AppWindow from the WindowId.
            AppWindow appWindow =
            AppWindow.GetFromWindowId(windowId);

            return appWindow;
        }
    }
}
