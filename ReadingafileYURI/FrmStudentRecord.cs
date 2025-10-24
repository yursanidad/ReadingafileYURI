using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadingafileYURI
{
    public partial class FrmStudentRecord : Form
    {
        public FrmStudentRecord()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration registrationForm = new FrmRegistration();
            registrationForm.Show();
            this.Hide();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            lvShowText_SelectedIndexChanged(sender, e);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Uploaded!");
            lvShowText.Items.Clear();
        }

        private void lvShowText_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Path.Combine(Application.StartupPath, "TextFiles"),
                Title = "Browse Text Files",
                DefaultExt = "txt",
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;

                try
                {
                    using (StreamReader streamReader = File.OpenText(path))
                    {
                        string _getText;
                        lvShowText.Items.Clear();

                        while ((_getText = streamReader.ReadLine()) != null)
                        {
                            lvShowText.Items.Add(_getText);
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
            }
        }

        private void FrmStudentRecord_Load(object sender, EventArgs e)
        {

        }
    }
}
