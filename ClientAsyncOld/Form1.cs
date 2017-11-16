using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientAsyncOld.ServiceRef;
using System.Threading;

namespace ClientAsyncOld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetPrimeAsync_Click(object sender, EventArgs e)
        {
            LiczbyPierwszeClient client = new LiczbyPierwszeClient();
            client.GetPierwszeCompleted += Client_GetPierwszeCompleted;

            int bottomRange, topRange;
            int.TryParse(tbBottomRange.Text, out bottomRange);
            int.TryParse(tbTopRange.Text, out topRange);

            try
            {
                rtbResult.Text = string.Empty;
                client.GetPierwszeAsync(bottomRange, topRange, client);

            }
            catch
            {
                client.Abort();
            }
        }

        private void Client_GetPierwszeCompleted(object sender, GetPierwszeCompletedEventArgs e)
        {
            LiczbyPierwszeClient client = (LiczbyPierwszeClient)e.UserState;
            rtbResult.Text = string.Join(", ", e.Result);
            client.Close();
        }

        private void bGetBeginEnd_Click(object sender, EventArgs e)
        {

            LiczbyPierwszeClient client = new LiczbyPierwszeClient();

            int bottomRange, topRange;
            int.TryParse(tbBottomRange.Text, out bottomRange);
            int.TryParse(tbTopRange.Text, out topRange);

            try
            {
                rtbResult.Text = string.Empty;
                client.BeginGetPierwsze(bottomRange, topRange, new AsyncCallback(GetPrimeCallback), client);
                
            }
            catch
            {
                client.Abort();
            }
        }

        void GetPrimeCallback(IAsyncResult result)
        {
            LiczbyPierwszeClient client = (LiczbyPierwszeClient)result.AsyncState;
            int[] parameters = client.EndGetPierwsze(result);

            string text = string.Join(", ", parameters);

            AddTextToTextBox(text);

            try
            {
                client.Close();
            }
            catch
            {
                client.Abort();
            }
        }

        private delegate void AddTextDelegate(string s);

        void AddTextToTextBox(string text)
        {
            if (rtbResult.InvokeRequired)
            {
                AddTextDelegate sd = new AddTextDelegate(AddTextToTextBox);
                this.Invoke(sd, new object[] { text });
            }
            else
            {
                rtbResult.Text = text;
            }
            
        }
    }
}
