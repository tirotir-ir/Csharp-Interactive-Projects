#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project04_TodoList
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private TextBox txt; private Button btnAdd, btnDel; private ListBox list;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      txt=new TextBox(){Left=20,Top=20,Width=200}; btnAdd=new Button(){Left=230,Top=18,Text="Add"};btnDel=new Button(){Left=290,Top=18,Text="Delete"}; list=new ListBox(){Left=20,Top=50,Width=260,Height=200};Controls.AddRange(new Control[]{txt,btnAdd,btnDel,list}); Text="Todo"; ClientSize=new Size(320,280);
    }
  }
}
