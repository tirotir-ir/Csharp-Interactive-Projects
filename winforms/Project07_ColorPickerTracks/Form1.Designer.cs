#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project07_ColorPickerTracks
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private TrackBar r,g,b; private Panel preview;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      r=new TrackBar(){Maximum=255,TickFrequency=5}; g=new TrackBar(){Maximum=255,TickFrequency=5}; b=new TrackBar(){Maximum=255,TickFrequency=5};preview=new Panel(){Dock=DockStyle.Fill,BackColor=Color.Black}; var table=new TableLayoutPanel(){Dock=DockStyle.Fill,ColumnCount=2,RowCount=4};table.Controls.Add(new Label(){Text="R"},0,0); table.Controls.Add(r,1,0);table.Controls.Add(new Label(){Text="G"},0,1); table.Controls.Add(g,1,1);table.Controls.Add(new Label(){Text="B"},0,2); table.Controls.Add(b,1,2);table.Controls.Add(preview,0,3); table.SetColumnSpan(preview,2); Controls.Add(table);Text="ColorPicker"; Width=400; Height=300;
    }
  }
}
