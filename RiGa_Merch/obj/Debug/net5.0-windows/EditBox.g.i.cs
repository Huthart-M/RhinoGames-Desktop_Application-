﻿#pragma checksum "..\..\..\EditBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "FC9B1808A51A7A21ACD8A92C74E1691988FC785D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using RiGa_Merch;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace RiGa_Merch {
    
    
    /// <summary>
    /// EditBox
    /// </summary>
    public partial class EditBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\EditBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TableENT;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\EditBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RowENT;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\EditBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ColumEnt;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\EditBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EditENT;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\EditBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelBTN;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\EditBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditBTN;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/RiGa_Merch;V1.0.0.0;component/editbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\EditBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.12.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TableENT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.RowENT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ColumEnt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.EditENT = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CancelBTN = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\EditBox.xaml"
            this.CancelBTN.Click += new System.Windows.RoutedEventHandler(this.CancelBTN_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.EditBTN = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\EditBox.xaml"
            this.EditBTN.Click += new System.Windows.RoutedEventHandler(this.EditBTN_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
