///This code is offered as is without any warranties.
///For any information or comments pleas contact:
///Francisco Fernandez
///fj.fernandez@live.com
///Developer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace FullBrowserControlSample
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            TheBrowser.NavigateBack();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            TheBrowser.RefreshBrowser();
        }

        private void ForwardBtn_Click(object sender, EventArgs e)
        {
            TheBrowser.NavigateForward();
        }

        protected override void OnBackKeyPress(System.ComponentModel.CancelEventArgs e)
        {
            if (TheBrowser.CanNavigateBack)
            {
                e.Cancel = true;
                TheBrowser.NavigateBack();
            }
            else
                base.OnBackKeyPress(e);
        }
    }
}