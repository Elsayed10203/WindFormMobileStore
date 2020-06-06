using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreMobileApp.PresentationLayer
{
    public partial class FrmService : Form
    {
        public FrmService()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (System.Net.WebClient client = new System.Net.WebClient())
            {
                try
                {
                    string url = "http://smsc.vianett.no/v3/send.ashx?" +
                        "src=" + txt_phon.Text + "+&" +
                        "dst=" + txt_phon.Text + "&" +
                        "msg=" + System.Web.HttpUtility.UrlEncode(txt_mess.Text, System.Text.Encoding.GetEncoding("ISO-8859-1")) + "" +
                        "username" + System.Web.HttpUtility.UrlEncode(txt_name.Text) +
                        "password=" + System.Web.HttpUtility.UrlEncode(txt_pass.Text);
                    string result = client.DownloadString(url);
                    if (result.Contains("OK"))
                        MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Message send failure.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
