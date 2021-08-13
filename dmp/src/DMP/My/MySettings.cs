namespace DMP.My
{
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.CodeDom.Compiler;
    using System.ComponentModel;
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0"), CompilerGenerated, EditorBrowsable(EditorBrowsableState.Advanced)]
    internal sealed class MySettings : ApplicationSettingsBase
    {
        private static MySettings defaultInstance = ((MySettings) Synchronized(new MySettings()));
        private static bool addedHandler;
        private static object addedHandlerLockObject = new object();

        [EditorBrowsable(EditorBrowsableState.Advanced), DebuggerNonUserCode]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (MyProject.Application.SaveMySettingsOnExit)
            {
                MySettingsProperty.Settings.Save();
            }
        }

        public static MySettings Default
        {
            get
            {
                if (!addedHandler)
                {
                    object addedHandlerLockObject = MySettings.addedHandlerLockObject;
                    ObjectFlowControl.CheckForSyncLockOnValueType(addedHandlerLockObject);
                    lock (addedHandlerLockObject)
                    {
                        if (!addedHandler)
                        {
                            MyProject.Application.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
                            addedHandler = true;
                        }
                    }
                }
                return defaultInstance;
            }
        }
    }
}

