namespace WinFormsAppDI
{
    public partial class MainForm : Form
    {
        private readonly IHelloDI _helloDI;

        public MainForm(IHelloDI helloDI)
        {
            InitializeComponent();
            _helloDI = helloDI;

            MessageBox.Show(_helloDI.SeyHello());
        }
    }
}
