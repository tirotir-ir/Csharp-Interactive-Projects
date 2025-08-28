#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project18_JsonSettings
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private TextBox txt; private Button btnSave; private string path;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      txt=new TextBox(){Left=20,Top=20,Width=220,PlaceholderText="Username"}; btnSave=new Button(){Left=20,Top=55,Text="Save"}; Controls.AddRange(new Control[]{txt,btnSave}); Text="JsonSettings"; ClientSize=new Size(270,100); path=System.IO.Path.Combine(AppContext.BaseDirectory, "settings.json");
    }
  }
}
