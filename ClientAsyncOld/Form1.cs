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

        LiczbyPierwszeClient client;
        private BackgroundWorker worker = new BackgroundWorker();

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
                client.GetPierwszeAsync(bottomRange, topRange);

                client.Close();
            }
            catch
            {
                client.Abort();
            }
        }

        private void Client_GetPierwszeCompleted(object sender, GetPierwszeCompletedEventArgs e)
        {
            foreach (var prime in e.Result)
            {
                rtbResult.Text += prime + ",   ";
            }
        }


        //TODO do poprawy!!!
        private void bGetBeginEnd_Click(object sender, EventArgs e)
        {

            client = new LiczbyPierwszeClient();

            int bottomRange, topRange;
            int.TryParse(tbBottomRange.Text, out bottomRange);
            int.TryParse(tbTopRange.Text, out topRange);

            try
            {
                rtbResult.Text = string.Empty;
                client.BeginGetPierwsze(bottomRange, topRange, new AsyncCallback(GetPrimeCallback), null);
                client.Close();
            }
            catch
            {
                client.Abort();
            }
        }

        void GetPrimeCallback(IAsyncResult result)
        {
            int[] parameters = client.EndGetPierwsze(result);

            worker.DoWork += new DoWorkEventHandler(Worker_DoWork);
            worker.RunWorkerAsync(parameters);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] primeNumbers = e.Argument as int[];
            string result = string.Empty;
            foreach (var prime in primeNumbers)
                result += prime + ",   ";

            AddTextToTextBox(result);
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
