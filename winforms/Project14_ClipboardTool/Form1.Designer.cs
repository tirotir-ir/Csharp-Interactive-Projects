#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project14_ClipboardTool
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private TextBox txt; private Button btnCopy, btnPaste;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      txt=new TextBox(){Left=20,Top=20,Width=220}; btnCopy=new Button(){Left=20,Top=55,Text="Copy"}; btnPaste=new Button(){Left=100,Top=55,Text="Paste"}; Controls.AddRange(new Control[]{txt,btnCopy,btnPaste}); Text="Clipboard"; ClientSize=new Size(270,100);
    }
  }
}
