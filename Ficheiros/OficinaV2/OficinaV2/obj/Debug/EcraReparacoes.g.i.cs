﻿#pragma checksum "..\..\EcraReparacoes.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AE84AA001230C155D219F9B06C46BA374C17BE395346FE0DF9D4BC6ECEEA4B23"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DevExpress.Xpf.DXBinding;
using OficinaV2;
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


namespace OficinaV2 {
    
    
    /// <summary>
    /// EcraReparacoes
    /// </summary>
    public partial class EcraReparacoes : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 68 "..\..\EcraReparacoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox matricula_txt;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\EcraReparacoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker data_txt;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\EcraReparacoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox marca_txt;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\EcraReparacoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cor_txt;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\EcraReparacoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox idreparacao_txt;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\EcraReparacoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ReparacoesGrid;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\EcraReparacoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid PecasGrid;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\EcraReparacoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxIdPeca;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\EcraReparacoes.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantidade_reparacao_txt;
        
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
            System.Uri resourceLocater = new System.Uri("/OficinaV2;component/ecrareparacoes.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EcraReparacoes.xaml"
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
            
            #line 22 "..\..\EcraReparacoes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_NovaReparacao_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 28 "..\..\EcraReparacoes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Anular_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 34 "..\..\EcraReparacoes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Finalizar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 41 "..\..\EcraReparacoes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Gravar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.matricula_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.data_txt = ((System.Windows.Controls.DatePicker)(target));
            
            #line 69 "..\..\EcraReparacoes.xaml"
            this.data_txt.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DatePicker_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.marca_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.cor_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.idreparacao_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.ReparacoesGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 82 "..\..\EcraReparacoes.xaml"
            this.ReparacoesGrid.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ReparacoesGrid_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.PecasGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 12:
            this.ComboBoxIdPeca = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 13:
            this.quantidade_reparacao_txt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            
            #line 118 "..\..\EcraReparacoes.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Adicionar_Peca_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

