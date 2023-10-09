﻿#pragma checksum "..\..\..\VM Config.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A7849FC2C79F4A0301F41021432491982DBC57C86B973322A60B28AE3F35D9AA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ms.Palmer;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Ms.Palmer {
    
    
    /// <summary>
    /// VM_Config
    /// </summary>
    public partial class VM_Config : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Background;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView SuggestedVMConfigView;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ISOPathQuery;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ISOPath;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ConfirmISOButton;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox OperatingSystemType;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Logo;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox VMUsername;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox VMPassword;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton InstallGuestAdditions;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox OSKey;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeployVM;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\VM Config.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox VMSize;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Ms.Palmer;component/vm%20config.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VM Config.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Background = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.SuggestedVMConfigView = ((System.Windows.Controls.ListView)(target));
            
            #line 25 "..\..\..\VM Config.xaml"
            this.SuggestedVMConfigView.Initialized += new System.EventHandler(this.SuggestedVMConfigView_Initialized);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ISOPathQuery = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.ISOPath = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\VM Config.xaml"
            this.ISOPath.Initialized += new System.EventHandler(this.ISOPath_Initialized);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ConfirmISOButton = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\..\VM Config.xaml"
            this.ConfirmISOButton.Click += new System.Windows.RoutedEventHandler(this.ConfirmISOButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.OperatingSystemType = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\..\VM Config.xaml"
            this.OperatingSystemType.Loaded += new System.Windows.RoutedEventHandler(this.OperatingSystemType_Loaded);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Logo = ((System.Windows.Controls.Image)(target));
            return;
            case 8:
            this.VMUsername = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.VMPassword = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 10:
            this.InstallGuestAdditions = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 11:
            this.OSKey = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.DeployVM = ((System.Windows.Controls.Button)(target));
            
            #line 67 "..\..\..\VM Config.xaml"
            this.DeployVM.Click += new System.Windows.RoutedEventHandler(this.DeployVM_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.VMSize = ((System.Windows.Controls.ComboBox)(target));
            
            #line 77 "..\..\..\VM Config.xaml"
            this.VMSize.Loaded += new System.Windows.RoutedEventHandler(this.VMSize_Loaded_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

