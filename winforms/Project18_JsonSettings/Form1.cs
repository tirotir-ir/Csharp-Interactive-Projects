using System;
using System.Windows.Forms;

namespace Project18_JsonSettings
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      if(System.IO.File.Exists(path)){ var s=System.Text.Json.JsonSerializer.Deserialize<Settings>(System.IO.File.ReadAllText(path)); txt.Text=s?.Username??""; } btnSave.Click+=(s,e)=>{ var json=System.Text.Json.JsonSerializer.Serialize(new Settings(txt.Text)); System.IO.File.WriteAllText(path,json); MessageBox.Show("Saved"); };
    }

    private record Settings(string Username);
  }
}
