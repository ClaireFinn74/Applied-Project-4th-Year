﻿#pragma checksum "C:\Users\owner\Downloads\Applied-Project-4th-Year-master\4thYearAppliedProject\EverythingHasAPorpoise.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "394B0A07B3BF2C0396367128261314D4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppliedProject4thYear.AttentionLevels
{
    partial class Everything_Has_A_Purpoise : 
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
                    this.imgporpoise = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 39 "..\..\..\EverythingHasAPorpoise.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgporpoise).Tapped += this.imgporpoise_Tapped;
                    #line default
                }
                break;
            case 3:
                {
                    this.imgporpoise2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 47 "..\..\..\EverythingHasAPorpoise.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgporpoise2).Tapped += this.imgporpoise2_Tapped;
                    #line default
                }
                break;
            case 4:
                {
                    this.imgporpoise3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 52 "..\..\..\EverythingHasAPorpoise.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.imgporpoise3).Tapped += this.imgporpoise3_Tapped;
                    #line default
                }
                break;
            case 5:
                {
                    this.txtbScore = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

