﻿#pragma checksum "C:\Users\owner\Downloads\Applied-Project-4th-Year-master\4thYearAppliedProject\AttentionLevels\Picture Perfect\PicturePerfect6.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C595BF13E88D213C8B81EA9C831DD253"
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
    partial class PicturePerfect6 : 
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
                    this.btnBeginSmartPhone = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 11 "..\..\..\..\AttentionLevels\Picture Perfect\PicturePerfect6.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnBeginSmartPhone).Click += this.btnBeginSmartPhone_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnPicturePerfect = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\..\AttentionLevels\Picture Perfect\PicturePerfect6.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPicturePerfect).Click += this.btnPicturePerfect_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.imgPicturePerfectSmartPhone = (global::Windows.UI.Xaml.Controls.Image)(target);
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

