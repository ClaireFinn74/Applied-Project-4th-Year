﻿#pragma checksum "C:\Users\owner\Downloads\Applied-Project-4th-Year-master\4thYearAppliedProject\AttentionLevels\Everything has a porpoise\PorpoiseLevel2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5EA21D3B64A09C3FF2641B7AB91A4D51"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _4thYearAppliedProject.AttentionLevels.Everything_has_a_porpoise
{
    partial class PorpoiseLevel2 : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.sbPorpoiseLevel1 = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 2:
                {
                    this.sbPorpoiseLevel2 = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 3:
                {
                    this.imgporpoise = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 86 "..\..\..\..\AttentionLevels\Everything has a porpoise\PorpoiseLevel2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgporpoise).Tapped += this.imgporpoise_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.imgporpoise2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 94 "..\..\..\..\AttentionLevels\Everything has a porpoise\PorpoiseLevel2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgporpoise2).Tapped += this.imgporpoise2_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    this.imgporpoise3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 99 "..\..\..\..\AttentionLevels\Everything has a porpoise\PorpoiseLevel2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgporpoise3).Tapped += this.imgporpoise3_Tapped;
                    #line default
                }
                break;
            case 6:
                {
                    this.txtbScore = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.imgporpoise4 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 110 "..\..\..\..\AttentionLevels\Everything has a porpoise\PorpoiseLevel2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgporpoise4).Tapped += this.imgporpoise4_Tapped;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

