﻿#pragma checksum "..\..\..\Viems\TournamentInfo.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "909555FA9FE97311678CEAAF3B32496218B2E939"
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
    /// TournamentInfo
    /// </summary>
    public partial class TournamentInfo : System.Windows.ResourceDictionary, System.Windows.Markup.IComponentConnector {
        
        /// <summary>
        /// TournamentInfo1 Name Field
        /// </summary>
        
        #line 6 "..\..\..\Viems\TournamentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        public Main.TournamentInfo TournamentInfo1;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Viems\TournamentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock game_completed;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Viems\TournamentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock gamecount;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Viems\TournamentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock result;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Viems\TournamentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock title;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Viems\TournamentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox gamesList;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\Viems\TournamentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button generate;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\Viems\TournamentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newround;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\Viems\TournamentInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelTournament;
        
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
            System.Uri resourceLocater = new System.Uri("/TableTUR;component/viems/tournamentinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Viems\TournamentInfo.xaml"
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
            this.TournamentInfo1 = ((Main.TournamentInfo)(target));
            return;
            case 2:
            this.game_completed = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.gamecount = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.result = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.title = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.gamesList = ((System.Windows.Controls.ListBox)(target));
            return;
            case 7:
            this.generate = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\Viems\TournamentInfo.xaml"
            this.generate.Click += new System.Windows.RoutedEventHandler(this.Generate);
            
            #line default
            #line hidden
            return;
            case 8:
            this.newround = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\..\Viems\TournamentInfo.xaml"
            this.newround.Click += new System.Windows.RoutedEventHandler(this.NextRound);
            
            #line default
            #line hidden
            return;
            case 9:
            this.CancelTournament = ((System.Windows.Controls.Button)(target));
            
            #line 101 "..\..\..\Viems\TournamentInfo.xaml"
            this.CancelTournament.Click += new System.Windows.RoutedEventHandler(this.CancelTournamentall);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

