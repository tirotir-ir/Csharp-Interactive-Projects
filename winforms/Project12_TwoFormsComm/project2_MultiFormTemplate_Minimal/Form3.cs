using System.Drawing;
using System.Windows.Forms;

namespace MultiFormTemplate_Minimal
{
    public class Form3 : Form
    {
        private Label lblPreview = null!;

        public Form3()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Form3 (Live Preview)";
            ClientSize = new Size(400, 200);

            lblPreview = new Label
            {
                Dock = DockStyle.Fill,
                Text = "(empty)",
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 14, FontStyle.Bold)
            };

            Controls.Add(lblPreview);
        }

        public void UpdatePreview(string text)
        {
            lblPreview.Text = string.IsNullOrWhiteSpace(text) ? "(empty)" : text;
        }
    }
}
