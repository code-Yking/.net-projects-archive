namespace Remote_Desktop.My
{
    using Microsoft.VisualBasic.ApplicationServices;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    [GeneratedCode("MyTemplate", "11.0.0.0"), EditorBrowsable(EditorBrowsableState.Never)]
    internal class MyApplication : WindowsFormsApplicationBase
    {
        private static List<WeakReference> __ENCList = new List<WeakReference>();

        [DebuggerStepThrough]
        public MyApplication() : base(AuthenticationMode.Windows)
        {
            __ENCAddToList(this);
            this.IsSingleInstance = false;
            this.EnableVisualStyles = true;
            this.SaveMySettingsOnExit = true;
            this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
        }

        [DebuggerNonUserCode]
        private static void __ENCAddToList(object value)
        {
            List<WeakReference> list = __ENCList;
            lock (list)
            {
                if (__ENCList.Count == __ENCList.Capacity)
                {
                    int index = 0;
                    int num3 = __ENCList.Count - 1;
                    int num2 = 0;
                    while (true)
                    {
                        int num4 = num3;
                        if (num2 > num4)
                        {
                            __ENCList.RemoveRange(index, __ENCList.Count - index);
                            __ENCList.Capacity = __ENCList.Count;
                            break;
                        }
                        WeakReference reference = __ENCList[num2];
                        if (reference.IsAlive)
                        {
                            if (num2 != index)
                            {
                                __ENCList[index] = __ENCList[num2];
                            }
                            index++;
                        }
                        num2++;
                    }
                }
                __ENCList.Add(new WeakReference(value));
            }
        }

        [MethodImpl(MethodImplOptions.NoOptimization | MethodImplOptions.NoInlining), DebuggerHidden, EditorBrowsable(EditorBrowsableState.Advanced), STAThread]
        internal static void Main(string[] Args)
        {
            try
            {
                Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
            }
            finally
            {
            }
            MyProject.Application.Run(Args);
        }

        [DebuggerStepThrough]
        protected override void OnCreateMainForm()
        {
            this.MainForm = MyProject.Forms.Form2;
        }
    }
}

