﻿#pragma checksum "C:\Users\owner\Downloads\Applied-Project-4th-Year-master\4thYearAppliedProject\AttentionLevels\Picture Perfect\PicturePerfect2.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CD74D7332BF6D6AEECC3453480109B79"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _4thYearAppliedProject.AttentionLevels.Picture_Perect
{
    partial class PicturePerfect2 : 
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
                    this.btnPicturePerfect = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 11 "..\..\..\..\AttentionLevels\Picture Perfect\PicturePerfect2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPicturePerfect).Click += this.btnPicturePerfect_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.imgPicturePerfectHare = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3:
                {
                    this.btnBeginHare = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\..\AttentionLevels\Picture Perfect\PicturePerfect2.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBeginHare).Click += this.btnBeginHare_Click;
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

