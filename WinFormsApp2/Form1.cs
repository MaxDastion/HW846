namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object senderd, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = comboBox1.SelectedItem.ToString();

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                foreach (string temp in fileDialog.FileNames)
                {
                    listBox1.Items.Add(System.IO.Path.GetFileName(temp));
                }
            }


        }
    }
}
