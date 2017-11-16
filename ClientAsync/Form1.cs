using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientAsync.ServiceRef;

namespace ClientAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void GetPrimeAsync_Click(object sender, EventArgs e)
        {
            LiczbyPierwszeClient client = new LiczbyPierwszeClient();
            int bottomRange, topRange;
            int.TryParse(tbBottomRange.Text, out bottomRange);
            int.TryParse(tbTopRange.Text, out topRange);

            try
            {

                int[] primeNumbers = await client.GetPierwszeAsync(bottomRange, topRange);
                
                foreach(var prime in primeNumbers)
                {
                    rtbResult.Text += prime + ",   ";
                }

                client.Close();
            }
            catch
            {
                client.Abort();
            }
        }
    }
}
