using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiFormTemplate_Minimal
{
    public class Form1 : Form
    {
        private TextBox txtInput = null!;
        private Button btnForm2 = null!;
        private Label lblResult = null!;
        private Form3? form3; // modeless

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Main Form";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(520, 300);

            // Menu
            var menu = new MenuStrip();
            var mFile = new ToolStripMenuItem("File");
            var mOpenForm2 = new ToolStripMenuItem("Open Form2...");
            var mOpenForm3 = new ToolStripMenuItem("Open Form3 (Preview)");
            var mExit = new ToolStripMenuItem("Exit");
            mOpenForm2.ShortcutKeys = Keys.Control | Keys.O;
            mOpenForm3.ShortcutKeys = Keys.Control | Keys.P;
            mExit.ShortcutKeys = Keys.Alt | Keys.F4;
            mFile.DropDownItems.AddRange(new ToolStripItem[] { mOpenForm2, mOpenForm3, new ToolStripSeparator(), mExit });
            menu.Items.Add(mFile);
            MainMenuStrip = menu;
            Controls.Add(menu);

            // Controls
            txtInput = new TextBox { Left = 20, Top = 50, Width = 360, PlaceholderText = "Type something..." };
            btnForm2 = new Button { Left = 390, Top = 48, Width = 100, Text = "Open Form2" };
            lblResult = new Label { Left = 20, Top = 100, Width = 470, Text = "Result: (none)" };

            Controls.Add(txtInput);
            Controls.Add(btnForm2);
            Controls.Add(lblResult);

            // Events
            btnForm2.Click += (_, __) => OpenForm2();
            mOpenForm2.Click += (_, __) => OpenForm2();
            mOpenForm3.Click += (_, __) => OpenOrFocusForm3();
            mExit.Click += (_, __) => Close();

            txtInput.TextChanged += (_, __) =>
            {
                if (form3 is { IsDisposed: false })
                    form3.UpdatePreview(txtInput.Text);
            };

            // UX: show placeholders
            Shown += (_, __) => ActiveControl = btnForm2;
            AcceptButton = btnForm2;
        }

        private void OpenForm2()
        {
            using var dlg = new Form2(txtInput.Text) { StartPosition = FormStartPosition.CenterParent };
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                txtInput.Text = dlg.ResultText;
                lblResult.Text = "Result: " + dlg.ResultText;
            }
        }

        private void OpenOrFocusForm3()
        {
            if (form3 == null || form3.IsDisposed)
            {
                form3 = new Form3 { StartPosition = FormStartPosition.CenterParent };
                form3.FormClosed += (_, __) => form3 = null;
                form3.Show(this);
            }
            else
            {
                form3.BringToFront();
            }
            form3.UpdatePreview(txtInput.Text);
        }
    }
}
