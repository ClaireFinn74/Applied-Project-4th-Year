﻿#pragma checksum "C:\Users\owner\Downloads\Applied-Project-4th-Year-master\4thYearAppliedProject\ProblemSolvingLevels\ManicMaths.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "26B5E14908A56F9282D52BB0131AF7EC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AppliedProject4thYear
{
    partial class ManicMath : 
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
                    this.TimerLog = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.TimerStatus = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.PSGBackBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 13 "..\..\..\ProblemSolvingLevels\ManicMaths.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.PSGBackBtn).Click += this.PSGBackBtn_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.txtMathQuestion = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.btn_MMStart = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\ProblemSolvingLevels\ManicMaths.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btn_MMStart).Click += this.btn_MMStart_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.lblAnswer = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.txtAnswer = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.btnAnswer = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\ProblemSolvingLevels\ManicMaths.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnAnswer).Click += this.btnAnswer_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.txtScore = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 10:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

