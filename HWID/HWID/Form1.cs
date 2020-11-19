using System;
using System.Net;
using System.Windows.Forms;

namespace HWID
{
    public partial class Form1 : Form
    {
        string HWID;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(HWID); //Copy HWID to Clipboard
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string HWIDLIST = wb.DownloadString("YOUR TEXT FILE IN GITHUB/SELECT BLAME IN GITHUB"); //Downloads the file then checks if it have your hwid.
            if (HWIDLIST.Contains(HWID))
            {
                label1.Text = "Authorized";
            }
            else
            {
                label1.Text = "Unauthorized";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
        }
    }
}
