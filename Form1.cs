using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IpLookupNull
{
    public partial class Form1 : MetroSuite.MetroForm
    {
        public static bool CheckIPValid(string strIP)
        {
            IPAddress result = null;
            return
                !String.IsNullOrEmpty(strIP) &&
                IPAddress.TryParse(strIP, out result);
        }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (CheckIPValid(guna2TextBox1.Text))
            {
                string api = $"https://ip-geolocation.whoisxmlapi.com/api/v1?apiKey=at_kAFXO0mbYmXrMT7Hr3Hg9zXUjweGB&ipAddress=" + guna2TextBox1.Text;
                var client = new WebClient();
                var json = client.DownloadString(api);
                dynamic ip = JsonConvert.DeserializeObject(json);


                richTextBox1.Text = "IP: " + ip.ip + Environment.NewLine + "Country: " + ip.location.country + Environment.NewLine + "Region: " + ip.location.region + Environment.NewLine + "City: " + ip.location.city + Environment.NewLine + "Lat: " + ip.location.lat + Environment.NewLine + "Long: " + ip.location.lng + Environment.NewLine + "Postal Code: " + ip.location.postalCode + Environment.NewLine + "Time Zone" + ip.location.timezone + Environment.NewLine + "Geo Name ID: " + ip.location.geonameId + Environment.NewLine + "ISP: " + ip.isp + Environment.NewLine + "Connection Type: " + ip.connectionType + Environment.NewLine + "Domains: " + ip.domains;
            }
            else
            {
                MessageBox.Show("IP invalida prueba de nuevo.");
            }
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/ct3YHYNsEw");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/HugoFastDEV/NullIPLookup/releases");
        }
    }
}
