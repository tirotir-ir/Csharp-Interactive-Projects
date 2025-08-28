using System;
using System.Windows.Forms;

namespace Project03_CalculatorGui
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
      btnCalc.Click += btnCalc_Click;



     }

    private void btnCalc_Click(object? s, EventArgs e){ double.TryParse(a.Text, out double x); double.TryParse(b.Text, out double y);result.Text=(op.Text=="+"?x+y: op.Text=="-"?x-y: op.Text=="*"?x*y: y!=0?x/y: double.NaN).ToString(); }
  }
}





//a.PlaceholderText = "a";
//op.PlaceholderText = "+  -  *  /";
//b.PlaceholderText = "b";

//this.Shown += (s, e) => this.ActiveControl = btnCalc;