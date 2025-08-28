#nullable disable
using System.Windows.Forms;
using System.Drawing;

namespace Project03_CalculatorGui
{
  partial class Form1
  {
    private System.ComponentModel.IContainer components = null;
    private TextBox a,b,op; private Label result; private Button btnCalc;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

        private void InitializeComponent()
        {
            a = new TextBox();
            op = new TextBox();
            b = new TextBox();
            btnCalc = new Button();
            result = new Label();
            SuspendLayout();
            // 
            // a
            // 
            a.Location = new Point(12, 11);
            a.Name = "a";
            a.Size = new Size(100, 23);
            a.TabIndex = 0;
            // 
            // op
            // 
            op.Location = new Point(118, 11);
            op.Name = "op";
            op.Size = new Size(100, 23);
            op.TabIndex = 1;
            // 
            // b
            // 
            b.Location = new Point(224, 11);
            b.Name = "b";
            b.Size = new Size(100, 23);
            b.TabIndex = 2;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(118, 40);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 3;
            // 
            // result
            // 
            result.Location = new Point(107, 66);
            result.Name = "result";
            result.Size = new Size(100, 23);
            result.TabIndex = 4;
            // 
            // Form1
            // 
            ClientSize = new Size(369, 108);
            Controls.Add(a);
            Controls.Add(op);
            Controls.Add(b);
            Controls.Add(btnCalc);
            Controls.Add(result);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
