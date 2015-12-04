﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Maintainability.Analyzers {
    using System;
    using System.Reflection;
    
    
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
    internal class MicrosoftMaintainabilityAnalyzersResources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal MicrosoftMaintainabilityAnalyzersResources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Maintainability.Analyzers.MicrosoftMaintainabilityAnalyzersResources", typeof(MicrosoftMaintainabilityAnalyzersResources).GetTypeInfo().Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An instance of an assembly-level type is not created by code in the assembly..
        /// </summary>
        internal static string AvoidUninstantiatedInternalClassesDescription {
            get {
                return ResourceManager.GetString("AvoidUninstantiatedInternalClassesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid uninstantiated internal classes.
        /// </summary>
        internal static string AvoidUninstantiatedInternalClassesMessage {
            get {
                return ResourceManager.GetString("AvoidUninstantiatedInternalClassesMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid uninstantiated internal classes.
        /// </summary>
        internal static string AvoidUninstantiatedInternalClassesTitle {
            get {
                return ResourceManager.GetString("AvoidUninstantiatedInternalClassesTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Private fields were detected that do not appear to be accessed in the assembly..
        /// </summary>
        internal static string AvoidUnusedPrivateFieldsDescription {
            get {
                return ResourceManager.GetString("AvoidUnusedPrivateFieldsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid unused private fields.
        /// </summary>
        internal static string AvoidUnusedPrivateFieldsMessage {
            get {
                return ResourceManager.GetString("AvoidUnusedPrivateFieldsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Avoid unused private fields.
        /// </summary>
        internal static string AvoidUnusedPrivateFieldsTitle {
            get {
                return ResourceManager.GetString("AvoidUnusedPrivateFieldsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Maintainability.
        /// </summary>
        internal static string CategoryMaintainability {
            get {
                return ResourceManager.GetString("CategoryMaintainability", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Performance.
        /// </summary>
        internal static string CategoryPerformance {
            get {
                return ResourceManager.GetString("CategoryPerformance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A new object is created but never used; or a method that creates and returns a new string is called and the new string is never used; or a COM or P/Invoke method returns an HRESULT or error code that is never used..
        /// </summary>
        internal static string DoNotIgnoreMethodResultsDescription {
            get {
                return ResourceManager.GetString("DoNotIgnoreMethodResultsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} calls {1} but does not use the HRESULT or error code that the method returns. This could lead to unexpected behavior in error conditions or low-resource situations. Use the result in a conditional statement, assign the result to a variable, or pass it as an argument to another method..
        /// </summary>
        internal static string DoNotIgnoreMethodResultsMessageHResultOrErrorCode {
            get {
                return ResourceManager.GetString("DoNotIgnoreMethodResultsMessageHResultOrErrorCode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} creates a new instance of {1} which is never used. Pass the instance as an argument to another method, assign the instance to a variable, or remove the object creation if it is unnecessary..
        /// </summary>
        internal static string DoNotIgnoreMethodResultsMessageObjectCreation {
            get {
                return ResourceManager.GetString("DoNotIgnoreMethodResultsMessageObjectCreation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} calls {1} but does not use the new string instance that the method returns. Pass the instance as an argument to another method, assign the instance to a variable, or remove the call if it is unnecessary..
        /// </summary>
        internal static string DoNotIgnoreMethodResultsMessageStringCreation {
            get {
                return ResourceManager.GetString("DoNotIgnoreMethodResultsMessageStringCreation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} calls {1} but does not explicitly check whether the conversion succeeded. Either use the return value in a conditional statement or verify that the call site expects that the out argument will be set to the default value when the conversion fails..
        /// </summary>
        internal static string DoNotIgnoreMethodResultsMessageTryParse {
            get {
                return ResourceManager.GetString("DoNotIgnoreMethodResultsMessageTryParse", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Do not ignore method results.
        /// </summary>
        internal static string DoNotIgnoreMethodResultsTitle {
            get {
                return ResourceManager.GetString("DoNotIgnoreMethodResultsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unused local variables and unnecessary assignments increase the size of an assembly and decrease performance..
        /// </summary>
        internal static string RemoveUnusedLocalsDescription {
            get {
                return ResourceManager.GetString("RemoveUnusedLocalsDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unused locals.
        /// </summary>
        internal static string RemoveUnusedLocalsMessage {
            get {
                return ResourceManager.GetString("RemoveUnusedLocalsMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove unused locals.
        /// </summary>
        internal static string RemoveUnusedLocalsTitle {
            get {
                return ResourceManager.GetString("RemoveUnusedLocalsTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A method signature includes a parameter that is not used in the method body..
        /// </summary>
        internal static string ReviewUnusedParametersDescription {
            get {
                return ResourceManager.GetString("ReviewUnusedParametersDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Review unused parameters.
        /// </summary>
        internal static string ReviewUnusedParametersMessage {
            get {
                return ResourceManager.GetString("ReviewUnusedParametersMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Review unused parameters.
        /// </summary>
        internal static string ReviewUnusedParametersTitle {
            get {
                return ResourceManager.GetString("ReviewUnusedParametersTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An instance method declares a parameter or a local variable whose name matches an instance field of the declaring type, leading to errors..
        /// </summary>
        internal static string VariableNamesShouldNotMatchFieldNamesDescription {
            get {
                return ResourceManager.GetString("VariableNamesShouldNotMatchFieldNamesDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}, a variable declared in {1}, has the same name as an instance field on the type. Change the name of one of these items..
        /// </summary>
        internal static string VariableNamesShouldNotMatchFieldNamesMessageLocal {
            get {
                return ResourceManager.GetString("VariableNamesShouldNotMatchFieldNamesMessageLocal", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}, a parameter declared in {1}, has the same name as an instance field on the type. Change the name of one of these items..
        /// </summary>
        internal static string VariableNamesShouldNotMatchFieldNamesMessageParameter {
            get {
                return ResourceManager.GetString("VariableNamesShouldNotMatchFieldNamesMessageParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Variable names should not match field names.
        /// </summary>
        internal static string VariableNamesShouldNotMatchFieldNamesTitle {
            get {
                return ResourceManager.GetString("VariableNamesShouldNotMatchFieldNamesTitle", resourceCulture);
            }
        }
    }
}
