﻿#pragma checksum "..\..\..\Viems\First.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7D982AD049384C7ACFF00B788D3D881D0ABF1F25"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Main;
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


namespace Main {
    
    
    /// <summary>
    /// First
    /// </summary>
    public partial class First : System.Windows.ResourceDictionary, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// First1 Name Field
        /// </summary>
        
        #line 6 "..\..\..\Viems\First.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public Main.First First1;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\Viems\First.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tx1;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\Viems\First.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bn1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Viems\First.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bn2;
        
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
            System.Uri resourceLocater = new System.Uri("/TableTUR;component/viems/first.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Viems\First.xaml"
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
            this.First1 = ((Main.First)(target));
            return;
            case 2:
            this.tx1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.bn1 = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\Viems\First.xaml"
            this.bn1.Click += new System.Windows.RoutedEventHandler(this.Bn1_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.bn2 = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\Viems\First.xaml"
            this.bn2.Click += new System.Windows.RoutedEventHandler(this.Bn2_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

