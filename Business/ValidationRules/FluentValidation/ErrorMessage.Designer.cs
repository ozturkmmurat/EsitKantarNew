﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Business.ValidationRules.FluentValidation {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ErrorMessage {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ErrorMessage() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Business.ValidationRules.FluentValidation.ErrorMessage", typeof(ErrorMessage).Assembly);
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
        ///   Looks up a localized string similar to Ad Soyad boş geçilemez..
        /// </summary>
        internal static string AdSoyad {
            get {
                return ResourceManager.GetString("AdSoyad", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ad Soyad alanı 4 karakterden kısa ve 30 karakterden uzun olamaz..
        /// </summary>
        internal static string AdSoyadUzunluk {
            get {
                return ResourceManager.GetString("AdSoyadUzunluk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email adresi boş geçilemez..
        /// </summary>
        internal static string Email {
            get {
                return ResourceManager.GetString("Email", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email adresinizi kontrol ediniz..
        /// </summary>
        internal static string EmailKontrol {
            get {
                return ResourceManager.GetString("EmailKontrol", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mail içeriği boş bırakılamaz..
        /// </summary>
        internal static string MailIcerik {
            get {
                return ResourceManager.GetString("MailIcerik", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mail içeriği en az 20 karakter uzunluğunda ve  en fazla 500 karakter uzunluğunda olabilir..
        /// </summary>
        internal static string MailIcerikUzunluk {
            get {
                return ResourceManager.GetString("MailIcerikUzunluk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Telefon numarası boş geçilemez..
        /// </summary>
        internal static string Telefon {
            get {
                return ResourceManager.GetString("Telefon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Telefon numarası 10 veya 11 karakterden uzunluğuna olmalıdır..
        /// </summary>
        internal static string TelefonUzunluk {
            get {
                return ResourceManager.GetString("TelefonUzunluk", resourceCulture);
            }
        }
    }
}
