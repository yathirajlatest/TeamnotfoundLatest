﻿#pragma checksum "C:\Users\bajajdi\Documents\GitHub\TeamnotfoundLatest\teamnotfound_Windows_CS\teamnotfound\View\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8A4A5C692D39F1315B73D601B71AA00B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeamNotFound.View
{
    partial class Login : 
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
                    this.ErrorMessage = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.UsernameTextBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.PasswordTextBox = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            case 4:
                {
                    this.ErrorTextBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.PassportSignInButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 24 "..\..\..\View\Login.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.PassportSignInButton).Click += this.PassportSignInButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.RegisterButtonTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 29 "..\..\..\View\Login.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.RegisterButtonTextBlock).Tapped += this.RegisterButtonTextBlock_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    this.PassportStatus = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 8:
                {
                    this.PassportStatusText = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

