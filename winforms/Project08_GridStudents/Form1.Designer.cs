#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project08_GridStudents
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private DataGridView data;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      data=new DataGridView(){Dock=DockStyle.Fill,AllowUserToAddRows=true}; data.Columns.Add("Name","Name"); data.Columns.Add("Age","Age");Controls.Add(data); Text="Students"; Width=400; Height=300;
    }
  }
}
