namespace PigeonSENT.Properties
{
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    [CompilerGenerated, DebuggerNonUserCode, GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    internal class Resources
    {
        private static System.Resources.ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        internal Resources()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (ReferenceEquals(resourceMan, null))
                {
                    resourceMan = new System.Resources.ResourceManager("PigeonSENT.Properties.Resources", typeof(Resources).Assembly);
                }
                return resourceMan;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture
        {
            get => 
                resourceCulture;
            set => 
                resourceCulture = value;
        }

        internal static Bitmap Cryptic_Pigeon =>
            (Bitmap) ResourceManager.GetObject("Cryptic-Pigeon", resourceCulture);

        internal static Bitmap giant_close_button =>
            (Bitmap) ResourceManager.GetObject("giant-close-button", resourceCulture);

        internal static Bitmap landing_digi_1_ =>
            (Bitmap) ResourceManager.GetObject("landing-digi[1]", resourceCulture);

        internal static Bitmap Picture1 =>
            (Bitmap) ResourceManager.GetObject("Picture1", resourceCulture);

        internal static Bitmap Picture11 =>
            (Bitmap) ResourceManager.GetObject("Picture11", resourceCulture);
    }
}

