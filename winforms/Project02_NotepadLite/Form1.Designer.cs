#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project02_NotepadLite
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private MenuStrip menu; private ToolStripMenuItem file; private ToolStripMenuItem open; private ToolStripMenuItem save; private TextBox txt;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      menu=new MenuStrip(); file=new ToolStripMenuItem("File"); open=new ToolStripMenuItem("Open"); save=new ToolStripMenuItem("Save");txt=new TextBox(){Multiline=true,ScrollBars=ScrollBars.Vertical,Dock=DockStyle.Fill};file.DropDownItems.AddRange(new ToolStripItem[]{open,save}); menu.Items.Add(file);Controls.Add(txt); Controls.Add(menu); MainMenuStrip=menu; Text="NotepadLite"; Width=600; Height=400;
    }
  }
}
