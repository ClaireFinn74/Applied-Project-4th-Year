﻿#pragma checksum "C:\Users\owner\Downloads\Applied-Project-4th-Year-master\4thYearAppliedProject\Common\QuickStartTask.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "0D95C6CD2F5F619255DB5F4B8D501C8A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _4thYearAppliedProject.Common
{
    partial class QuickStartTask : 
        global::Windows.UI.Xaml.Controls.UserControl, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class QuickStartTask_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IQuickStartTask_Bindings
        {
            private global::_4thYearAppliedProject.Common.QuickStartTask dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.Border obj3;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;
            private global::Windows.UI.Xaml.Controls.TextBlock obj6;

            private QuickStartTask_obj1_BindingsTracking bindingsTracking;

            public QuickStartTask_obj1_Bindings()
            {
                this.bindingsTracking = new QuickStartTask_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.Border)target;
                        break;
                    case 4:
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5:
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 6:
                        this.obj6 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IQuickStartTask_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // QuickStartTask_obj1_Bindings

            public void SetDataRoot(global::_4thYearAppliedProject.Common.QuickStartTask newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::_4thYearAppliedProject.Common.QuickStartTask obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_LayoutFormatVisibility(obj.LayoutFormatVisibility, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Title(obj.Title, phase);
                        this.Update_Description(obj.Description, phase);
                        this.Update_Number(obj.Number, phase);
                    }
                }
            }
            private void Update_LayoutFormatVisibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj3, obj);
                    XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj4, obj);
                }
            }
            private void Update_Title(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj4, obj, null);
                }
            }
            private void Update_Description(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj5, obj, null);
                }
            }
            private void Update_Number(global::System.Int32 obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj6, obj.ToString(), null);
                }
            }

            private class QuickStartTask_obj1_BindingsTracking
            {
                global::System.WeakReference<QuickStartTask_obj1_Bindings> WeakRefToBindingObj; 

                public QuickStartTask_obj1_BindingsTracking(QuickStartTask_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<QuickStartTask_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                }

                public void DependencyPropertyChanged_Title(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    QuickStartTask_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::_4thYearAppliedProject.Common.QuickStartTask obj = sender as global::_4thYearAppliedProject.Common.QuickStartTask;
        if (obj != null)
        {
            bindings.Update_Title(obj.Title, DATA_CHANGED);
        }
                    }
                }
                public void DependencyPropertyChanged_Description(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    QuickStartTask_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::_4thYearAppliedProject.Common.QuickStartTask obj = sender as global::_4thYearAppliedProject.Common.QuickStartTask;
        if (obj != null)
        {
            bindings.Update_Description(obj.Description, DATA_CHANGED);
        }
                    }
                }
                public void DependencyPropertyChanged_Number(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    QuickStartTask_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::_4thYearAppliedProject.Common.QuickStartTask obj = sender as global::_4thYearAppliedProject.Common.QuickStartTask;
        if (obj != null)
        {
            bindings.Update_Number(obj.Number, DATA_CHANGED);
        }
                    }
                }
                private long tokenDPC_Title = 0;
                private long tokenDPC_Description = 0;
                private long tokenDPC_Number = 0;
                public void UpdateChildListeners_(global::_4thYearAppliedProject.Common.QuickStartTask obj)
                {
                    QuickStartTask_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        if (bindings.dataRoot != null)
                        {
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::_4thYearAppliedProject.Common.QuickStartTask.TitleProperty, tokenDPC_Title);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::_4thYearAppliedProject.Common.QuickStartTask.DescriptionProperty, tokenDPC_Description);
                            bindings.dataRoot.UnregisterPropertyChangedCallback(global::_4thYearAppliedProject.Common.QuickStartTask.NumberProperty, tokenDPC_Number);
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            tokenDPC_Title = obj.RegisterPropertyChangedCallback(global::_4thYearAppliedProject.Common.QuickStartTask.TitleProperty, DependencyPropertyChanged_Title);
                            tokenDPC_Description = obj.RegisterPropertyChangedCallback(global::_4thYearAppliedProject.Common.QuickStartTask.DescriptionProperty, DependencyPropertyChanged_Description);
                            tokenDPC_Number = obj.RegisterPropertyChangedCallback(global::_4thYearAppliedProject.Common.QuickStartTask.NumberProperty, DependencyPropertyChanged_Number);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.large = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.TitleTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.DescriptionTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.TaskNumberTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.UserControl element1 = (global::Windows.UI.Xaml.Controls.UserControl)target;
                    QuickStartTask_obj1_Bindings bindings = new QuickStartTask_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}

