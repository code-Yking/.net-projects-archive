namespace DMP.My.Resources
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.Resources;
    using System.Runtime.CompilerServices;

    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), StandardModule, DebuggerNonUserCode, HideModuleName, CompilerGenerated]
    internal sealed class Resources
    {
        private static System.Resources.ResourceManager resourceMan;
        private static CultureInfo resourceCulture;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (ReferenceEquals(resourceMan, null))
                {
                    resourceMan = new System.Resources.ResourceManager("DMP.Resources", typeof(DMP.My.Resources.Resources).Assembly);
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

        internal static Bitmap Download =>
            (Bitmap) ResourceManager.GetObject("Download", resourceCulture);

        internal static Bitmap Open_File =>
            (Bitmap) ResourceManager.GetObject("Open File", resourceCulture);

        internal static Bitmap Picture1 =>
            (Bitmap) ResourceManager.GetObject("Picture1", resourceCulture);

        internal static Bitmap Picture11 =>
            (Bitmap) ResourceManager.GetObject("Picture11", resourceCulture);

        internal static Bitmap Picture9 =>
            (Bitmap) ResourceManager.GetObject("Picture9", resourceCulture);
    }
}

