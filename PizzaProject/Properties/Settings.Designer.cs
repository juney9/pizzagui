﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PizzaProject.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.5")]
        public double SmallToppingPrice {
            get {
                return ((double)(this["SmallToppingPrice"]));
            }
            set {
                this["SmallToppingPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.75")]
        public double MediumToppingPrice {
            get {
                return ((double)(this["MediumToppingPrice"]));
            }
            set {
                this["MediumToppingPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double LargeToppingPrice {
            get {
                return ((double)(this["LargeToppingPrice"]));
            }
            set {
                this["LargeToppingPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1.25")]
        public double ExtraLargeToppingPrice {
            get {
                return ((double)(this["ExtraLargeToppingPrice"]));
            }
            set {
                this["ExtraLargeToppingPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public double SmallPizzaPrice {
            get {
                return ((double)(this["SmallPizzaPrice"]));
            }
            set {
                this["SmallPizzaPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public double MediumPizzaPrice {
            get {
                return ((double)(this["MediumPizzaPrice"]));
            }
            set {
                this["MediumPizzaPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public double LargePizzaPrice {
            get {
                return ((double)(this["LargePizzaPrice"]));
            }
            set {
                this["LargePizzaPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public double ExtraLargePizzaPrice {
            get {
                return ((double)(this["ExtraLargePizzaPrice"]));
            }
            set {
                this["ExtraLargePizzaPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double BeveragePrice {
            get {
                return ((double)(this["BeveragePrice"]));
            }
            set {
                this["BeveragePrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public double CookiePrice {
            get {
                return ((double)(this["CookiePrice"]));
            }
            set {
                this["CookiePrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4")]
        public double BreadsticksPrice {
            get {
                return ((double)(this["BreadsticksPrice"]));
            }
            set {
                this["BreadsticksPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public double BreadstickBitesPrice {
            get {
                return ((double)(this["BreadstickBitesPrice"]));
            }
            set {
                this["BreadstickBitesPrice"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>Pepsi</string>
  <string>Diet Pepsi</string>
  <string>Orange</string>
  <string>Diet Orange</string>
  <string>Root Beer</string>
  <string>Diet Root Beer</string>
  <string>Sierra Mist</string>
  <string>Lemonade</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection BeverageList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["BeverageList"]));
            }
            set {
                this["BeverageList"] = value;
            }
        }
    }
}
