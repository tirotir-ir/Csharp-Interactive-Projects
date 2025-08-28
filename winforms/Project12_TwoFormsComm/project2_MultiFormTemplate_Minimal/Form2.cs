using System.Drawing;
using System.Windows.Forms;

namespace MultiFormTemplate_Minimal
{
    public class Form2 : Form
    {
        private TextBox txt = null!;
        private Button btnOK = null!;
        private Button btnCancel = null!;

        public string ResultText => txt.Text;

        public Form2(string initialText)
        {
            InitializeComponent();
            txt.Text = initialText;
        }

        private void InitializeComponent()
        {
            Text = "Form2 (Edit Text)";
            ClientSize = new Size(360, 180);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            var lbl = new Label { Left = 20, Top = 20, Width = 310, Text = "Edit the text and press OK:" };
            txt = new TextBox { Left = 20, Top = 50, Width = 310 };

            btnOK = new Button { Left = 175, Top = 100, Width = 70, Text = "OK", DialogResult = DialogResult.OK };
            btnCancel = new Button { Left = 260, Top = 100, Width = 70, Text = "Cancel", DialogResult = DialogResult.Cancel };

            AcceptButton = btnOK;
            CancelButton = btnCancel;

            Controls.Add(lbl);
            Controls.Add(txt);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
        }
    }
}
