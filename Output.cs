using System.Windows.Forms;

namespace BF4MapListGenerator
{
    public partial class Output : Form
    {
        public Output()
        {
            InitializeComponent();
        }

        private void Output_Load(object sender, System.EventArgs e)
        {
            //label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            //label1.Top = 5;
        }

        private void btnCopy_Click(object sender, System.EventArgs e)
        {
            Clipboard.SetText(txOutput.Text);
        }
    }
}