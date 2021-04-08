using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace Easy_Webhooks
{
    public partial class EasyWebhooks : Form
    {
        public EasyWebhooks()
        {
            InitializeComponent();
        }
        public static void sendWebhook(string Url, string msg, string Username)
        {
            Http.Post(Url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    Username
                },
                {
                    "content",
                    msg
                }
            });
        }
        private void EasyWebhooks_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://niaso.cf");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string webhlink = lienwebhook.Text;
            string messagetxt = message.Text;
            string name = nomwebhook.Text;

            if (message.Text == "")
                MessageBox.Show("Entre un nom");

            else if (message.Text == "")
                MessageBox.Show("Entre un message");

            else {

            sendWebhook(lienwebhook.Text, message.Text, nomwebhook.Text);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void sendembed_Click(object sender, EventArgs e)
        {
            
        }
    }
}
