using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
namespace Text_To_Speech
{
    public partial class Speech_To_Text : Form
    {
        public Speech_To_Text()
        {
            InitializeComponent();
            button1.Text = "First Click and then Speak!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine writer = new SpeechRecognitionEngine();
            Grammar words = new DictationGrammar();
            writer.LoadGrammar(words);

            try
            {
                //MessageBox.Show("Speak Now!!!");
                writer.SetInputToDefaultAudioDevice();
                RecognitionResult result = writer.Recognize();
                textbox.Text = result.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                writer.UnloadAllGrammars();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hm = new Home();
            hm.Show();
        }
    }
}
