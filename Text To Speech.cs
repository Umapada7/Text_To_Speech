using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;


namespace Text_To_Speech
{
    public partial class textToSpeech : Form
    {
        public textToSpeech()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(reader!=null)
            {
                reader.Dispose();
            }
        }

        SpeechSynthesizer reader = new SpeechSynthesizer();
        private void listen_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                reader.Dispose();
                reader = new SpeechSynthesizer();
                reader.Volume = volumeBar.Value;
                reader.SpeakAsync(richTextBox1.Text);
            }
            else
            {
                string title = "Warning";
                string message = "Please write some text first";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            volume.Text = volumeBar.Value.ToString();
        }

        private void volume_Click(object sender, EventArgs e)
        {

        }

        private void pause_Click(object sender, EventArgs e)
        {
            if(reader!=null)
            {
                if(reader.State==SynthesizerState.Speaking)
                {
                    reader.Pause();
                }
            }
        }

        private void resume_Click(object sender, EventArgs e)
        {
            if (reader != null)
            {
                if (reader.State == SynthesizerState.Paused)
                {
                    reader.Volume = volumeBar.Value;
                    reader.Resume();
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }
    }
}
