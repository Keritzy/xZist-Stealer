// Decompiled with JetBrains decompiler
// Type: xZCodeStealer.Program
// Assembly: xZCodeStealer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C59B54FE-9430-4A55-9E31-E9237A48FD97
// Assembly location: C:\Users\gorno\Desktop\malware\stealer\Samples\Out\System Disk.exe

using System;
using System.Windows.Forms;

namespace xZCodeStealer
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
