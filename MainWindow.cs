namespace DB_Uploader
{
    public partial class MainWindow : Form
    {
        private List<string> Tables;
        private List<string> Fields;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDBConnect_Click(object sender, EventArgs e)
        {
            Tables = DBini.GetTableNames(Fields);
        }

        private void btnClrFields_Click(object sender, EventArgs e)
        {
            ClrFields();
        }

        private void btnDSSave_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnDSRemove_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void ClrFields()
        {
            TBUsername.Text = "";
            TBPassword.Text = "";
            TBIp.Text = "";
            TBDBName.Text = "";
        }
    }
}
