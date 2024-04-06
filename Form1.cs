using System.Text;

namespace HatFileTimeConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string FilePath { get; set; }

        private void browseButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Hat save file (*.hat)|*.hat";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameTextBox.Text = openFileDialog.SafeFileName;
                FilePath = openFileDialog.FileName;
            }
        }

        private void timeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' || (sender as TextBox).Text.IndexOf('.') != -1))
            {
                e.Handled = true;
            }
        }

        private void timeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(timeTextBox.Text, out var result))
            {
                try
                {
                    TimeSpan timeSpan = TimeSpan.FromSeconds(result);
                    timePreviewLabel.Text = timeSpan.ToString("hh':'mm':'ss'.'ff");
                    convertButton.Enabled = true;
                }
                catch (Exception)
                {
                    timePreviewLabel.Text = "TOO BIG";
                    convertButton.Enabled = false;
                }
            }
        }

        private void fileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            bool flag = string.IsNullOrWhiteSpace(fileNameTextBox.Text);
            timeTextBox.Enabled = !flag;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] array = File.ReadAllBytes(FilePath);
                string @string = Encoding.UTF8.GetString(array);
                if (@string.Contains("TotalPlayTime"))
                {
                    float value = float.Parse(timeTextBox.Text);
                    byte[] bytes = BitConverter.GetBytes(value);
                    Array.Copy(bytes, 0, array, 97, 4);
                    File.WriteAllBytes(FilePath, array);
                    MessageBox.Show("Time changed successfully.", "Success", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("File does not contain a total play time value. Please open the file in game and save and quit once.", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Hand);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("File is already in use.",
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Hand);
            }

        }
    }
}
