﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CleanCode.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Common {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Common() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CleanCode.Resources.Common", typeof(Common).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The options below help enforce certain practices that can be considered to leading to cleaner and more maintainable code..
        /// </summary>
        public static string Options_Header {
            get {
                return ResourceManager.GetString("Options_Header", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum Dependencies Check.
        /// </summary>
        public static string Options_LabelMaximumDependenciesCheck {
            get {
                return ResourceManager.GetString("Options_LabelMaximumDependenciesCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum Method Arguments Check.
        /// </summary>
        public static string Options_LabelMaximumMethodArgumentsCheck {
            get {
                return ResourceManager.GetString("Options_LabelMaximumMethodArgumentsCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum Lines Per Method Check
        ///.
        /// </summary>
        public static string Options_LabelMethodTooLongCheck {
            get {
                return ResourceManager.GetString("Options_LabelMethodTooLongCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maximum lines per method.
        /// </summary>
        public static string Options_LabelMethodTooLongLinesPerMethod {
            get {
                return ResourceManager.GetString("Options_LabelMethodTooLongLinesPerMethod", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set maximum dependencies to.
        /// </summary>
        public static string Options_LabelTooManyDependencies {
            get {
                return ResourceManager.GetString("Options_LabelTooManyDependencies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Set maximum arguments to.
        /// </summary>
        public static string Options_LabelTooManyMethodArguments {
            get {
                return ResourceManager.GetString("Options_LabelTooManyMethodArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Note: All references to Clean Code, including but not limited to the Clean Code icon are used with permission of Robert C. Martin (a.k.a. UncleBob).
        /// </summary>
        public static string Options_SubHeader {
            get {
                return ResourceManager.GetString("Options_SubHeader", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method is too long ({0} lines)..
        /// </summary>
        public static string Warning_MethodTooLong {
            get {
                return ResourceManager.GetString("Warning_MethodTooLong", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are too many interfaces being passed in to this constructor. You might be violating SRP.
        /// </summary>
        public static string Warning_TooManyDependencies {
            get {
                return ResourceManager.GetString("Warning_TooManyDependencies", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This method requires too many arguments..
        /// </summary>
        public static string Warning_TooManyMethodArguments {
            get {
                return ResourceManager.GetString("Warning_TooManyMethodArguments", resourceCulture);
            }
        }
    }
}