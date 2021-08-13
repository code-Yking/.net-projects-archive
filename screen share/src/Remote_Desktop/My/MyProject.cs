namespace Remote_Desktop.My
{
    using Microsoft.VisualBasic;
    using Microsoft.VisualBasic.ApplicationServices;
    using Microsoft.VisualBasic.CompilerServices;
    using Remote_Desktop;
    using System;
    using System.CodeDom.Compiler;
    using System.Collections;
    using System.ComponentModel;
    using System.ComponentModel.Design;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [GeneratedCode("MyTemplate", "11.0.0.0"), HideModuleName, StandardModule]
    internal sealed class MyProject
    {
        private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();
        private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();
        private static readonly ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider = new ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();
        private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();
        private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

        [HelpKeyword("My.Computer")]
        internal static MyComputer Computer =>
            m_ComputerObjectProvider.GetInstance;

        [HelpKeyword("My.Application")]
        internal static MyApplication Application =>
            m_AppObjectProvider.GetInstance;

        [HelpKeyword("My.User")]
        internal static Microsoft.VisualBasic.ApplicationServices.User User =>
            m_UserObjectProvider.GetInstance;

        [HelpKeyword("My.Forms")]
        internal static MyForms Forms =>
            m_MyFormsObjectProvider.GetInstance;

        [HelpKeyword("My.WebServices")]
        internal static MyWebServices WebServices =>
            m_MyWebServicesObjectProvider.GetInstance;

        [EditorBrowsable(EditorBrowsableState.Never), MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
        internal sealed class MyForms
        {
            public Remote_Desktop.Form1 m_Form1;
            public Remote_Desktop.Form2 m_Form2;
            public Remote_Desktop.Form3 m_Form3;
            public Remote_Desktop.Form4 m_Form4;
            [ThreadStatic]
            private static Hashtable m_FormBeingCreated;

            [DebuggerHidden]
            private static T Create__Instance__<T>(T Instance) where T: Form, new()
            {
                T local;
                if ((((Instance == null) || Instance.IsDisposed) ? 1 : 0) == 0)
                {
                    local = Instance;
                }
                else
                {
                    TargetInvocationException exception;
                    bool flag1;
                    if (ReferenceEquals(m_FormBeingCreated, null))
                    {
                        m_FormBeingCreated = new Hashtable();
                    }
                    else if (m_FormBeingCreated.ContainsKey(typeof(T)))
                    {
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
                    }
                    m_FormBeingCreated.Add(typeof(T), null);
                    try
                    {
                        local = Activator.CreateInstance<T>();
                    }
                    catch (TargetInvocationException exception1) when ((() => // NOTE: To create compilable code, filter at IL offset 0097 was represented using lambda expression.
                    {
                        ProjectData.SetProjectError(exception = exception1);
                        flag1 = !ReferenceEquals(exception.InnerException, null);
                        return (T) flag1;
                    })())
                    {
                        string[] args = new string[] { exception.InnerException.Message };
                        throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", args), exception.InnerException);
                    }
                    finally
                    {
                        m_FormBeingCreated.Remove(typeof(T));
                    }
                }
                return local;
            }

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance) where T: Form
            {
                instance.Dispose();
                T local = default(T);
                instance = local;
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o) => 
                base.Equals(o);

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode() => 
                base.GetHashCode();

            [EditorBrowsable(EditorBrowsableState.Never)]
            internal Type GetType() => 
                typeof(MyProject.MyForms);

            [EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => 
                base.ToString();

            public Remote_Desktop.Form1 Form1
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_Form1 = Create__Instance__<Remote_Desktop.Form1>(this.m_Form1);
                    return this.m_Form1;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_Form1))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Remote_Desktop.Form1>(ref this.m_Form1);
                    }
                }
            }

            public Remote_Desktop.Form2 Form2
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_Form2 = Create__Instance__<Remote_Desktop.Form2>(this.m_Form2);
                    return this.m_Form2;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_Form2))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Remote_Desktop.Form2>(ref this.m_Form2);
                    }
                }
            }

            public Remote_Desktop.Form3 Form3
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_Form3 = Create__Instance__<Remote_Desktop.Form3>(this.m_Form3);
                    return this.m_Form3;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_Form3))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Remote_Desktop.Form3>(ref this.m_Form3);
                    }
                }
            }

            public Remote_Desktop.Form4 Form4
            {
                [DebuggerNonUserCode]
                get
                {
                    this.m_Form4 = Create__Instance__<Remote_Desktop.Form4>(this.m_Form4);
                    return this.m_Form4;
                }
                [DebuggerNonUserCode]
                set
                {
                    if (!ReferenceEquals(value, this.m_Form4))
                    {
                        if (!ReferenceEquals(value, null))
                        {
                            throw new ArgumentException("Property can only be set to Nothing");
                        }
                        this.Dispose__Instance__<Remote_Desktop.Form4>(ref this.m_Form4);
                    }
                }
            }
        }

        [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", ""), EditorBrowsable(EditorBrowsableState.Never)]
        internal sealed class MyWebServices
        {
            [DebuggerHidden]
            private static T Create__Instance__<T>(T instance) where T: new() => 
                (instance != null) ? instance : Activator.CreateInstance<T>();

            [DebuggerHidden]
            private void Dispose__Instance__<T>(ref T instance)
            {
                T local = default(T);
                instance = local;
            }

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public override bool Equals(object o) => 
                base.Equals(o);

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public override int GetHashCode() => 
                base.GetHashCode();

            [EditorBrowsable(EditorBrowsableState.Never), DebuggerHidden]
            internal Type GetType() => 
                typeof(MyProject.MyWebServices);

            [DebuggerHidden, EditorBrowsable(EditorBrowsableState.Never)]
            public override string ToString() => 
                base.ToString();
        }

        [EditorBrowsable(EditorBrowsableState.Never), ComVisible(false)]
        internal sealed class ThreadSafeObjectProvider<T> where T: new()
        {
            [CompilerGenerated, ThreadStatic]
            private static T m_ThreadStaticValue;

            internal T GetInstance
            {
                [DebuggerHidden]
                get
                {
                    if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
                    {
                        MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
                    }
                    return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
                }
            }
        }
    }
}

