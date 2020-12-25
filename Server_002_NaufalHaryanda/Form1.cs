using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service_002_NaufalHaryanda;
using System.ServiceModel;

namespace Server_002_NaufalHaryanda
{
    public partial class Form1 : Form
    {
        ServiceHost hostObject;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           hostObject = null;

            try
            {
                hostObject = new ServiceHost(typeof(TI_UMY));
                hostObject.Open();
                button1.Enabled = false;
                button2.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                hostObject = new ServiceHost(typeof(TI_UMY));
                hostObject.Open();
                button1.Enabled = true;
                button2.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
