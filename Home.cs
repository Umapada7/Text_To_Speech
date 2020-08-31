using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_To_Speech
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            textToSpeech tts = new textToSpeech();
            tts.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Speech_To_Text stt = new Speech_To_Text();
            stt.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
