#pragma checksum "..\..\Level2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0BA58094D98A152B2B6930222B0544314DFD6B1D314A4D731DBDC83EA0B5BCF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Clicker;
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


namespace Clicker {
    
    
    /// <summary>
    /// Level2
    /// </summary>
    public partial class Level2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\Level2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Clicker.Level2 level2Window;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\Level2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid level2Grid;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Level2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image backToMenu;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Level2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button upgradesBtn;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Level2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button clickerBtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Level2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock balanceTB;
        
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
            System.Uri resourceLocater = new System.Uri("/Clicker;component/level2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Level2.xaml"
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
            this.level2Window = ((Clicker.Level2)(target));
            
            #line 8 "..\..\Level2.xaml"
            this.level2Window.KeyUp += new System.Windows.Input.KeyEventHandler(this.level2Window_KeyUp);
            
            #line default
            #line hidden
            return;
            case 2:
            this.level2Grid = ((System.Windows.Controls.Grid)(target));
            
            #line 9 "..\..\Level2.xaml"
            this.level2Grid.Loaded += new System.Windows.RoutedEventHandler(this.level2Grid_Loaded);
            
            #line default
            #line hidden
            return;
            case 3:
            this.backToMenu = ((System.Windows.Controls.Image)(target));
            
            #line 14 "..\..\Level2.xaml"
            this.backToMenu.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.backToMenu_MouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.upgradesBtn = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\Level2.xaml"
            this.upgradesBtn.Click += new System.Windows.RoutedEventHandler(this.upgradesBtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.clickerBtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Level2.xaml"
            this.clickerBtn.Click += new System.Windows.RoutedEventHandler(this.clickerBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.balanceTB = ((System.Windows.Controls.TextBlock)(target));
            
            #line 18 "..\..\Level2.xaml"
            this.balanceTB.Loaded += new System.Windows.RoutedEventHandler(this.balanceTB_Loaded);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

