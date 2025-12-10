using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class FormLiczba : Form
    {

        public FormLiczba()
        {
            InitializeComponent();
        }
        // Our event
        public event EventHandler<TextEventArgs> MyEvent;
        /* Private field to hold the value that is passed around.
         * Exposed by the NewText property and passed in the NewTextChanged event. */
        protected virtual void OnMyEvent(TextEventArgs e)
        {
            // Create a copy of the event to work with
            EventHandler<TextEventArgs> handler = MyEvent;
            /* If there are no subscribers, eh will be null so we need to check
             * to avoid a NullReferenceException. */
            if (handler != null)
                handler(this, e);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = trackBar1.Value.ToString();
            OnMyEvent(new TextEventArgs(textBox1.Text));
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) > trackBar1.Maximum) textBox1.Text = trackBar1.Maximum.ToString();
                trackBar1.Value = Convert.ToInt32(textBox1.Text);
            }
            catch(Exception)
            {
                textBox1.Text = "0";
            }
        }
    }
}
