﻿#pragma checksum "C:\Users\DeveloperFF\Documents\Visual Studio 2010\Projects\FullBrowserSample\FullBrowserControlSample\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "85A9F40172ED684C33ADCBDC89C18BE4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FullBrowserControl;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace FullBrowserControlSample {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton BackBtn;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton RefreshBtn;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton ForwardBtn;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal FullBrowserControl.FullWebBrowser TheBrowser;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/FullBrowserControlSample;component/MainPage.xaml", System.UriKind.Relative));
            this.BackBtn = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("BackBtn")));
            this.RefreshBtn = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("RefreshBtn")));
            this.ForwardBtn = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("ForwardBtn")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.TheBrowser = ((FullBrowserControl.FullWebBrowser)(this.FindName("TheBrowser")));
        }
    }
}

