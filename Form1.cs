using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        private int speechRate = 0;
        private int speechVolume = 100;
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
            LBLSpeechRate.Text = speechRate.ToString(CultureInfo.InvariantCulture);
            TRBSpeechVolume.Value = speechVolume;
            LBLSpeechVolume.Text = speechVolume.ToString(CultureInfo.InvariantCulture);
            TRBSpeechRate.Value = speechRate;
            AddInstalledVoicesToList();
            BTNResume.Enabled = false;
            BTNPause.Enabled = false;
            BTNStop.Enabled = false;
        }

        private void TRBSpeechRate_Scroll(object sender, EventArgs e)
        {
            this.speechRate = TRBSpeechRate.Value;
            LBLSpeechRate.Text = this.speechRate.ToString(CultureInfo.InvariantCulture);
        }

        private void TRBSpeechVolume_Scroll(object sender, EventArgs e)
        {
            this.speechVolume = TRBSpeechVolume.Value;
            LBLSpeechVolume.Text = this.speechVolume.ToString(CultureInfo.InvariantCulture);
        }
        private void AddInstalledVoicesToList()
        {
            IReadOnlyCollection<InstalledVoice> installedVoices = synthesizer.GetInstalledVoices();
            for (int i = 0; i < installedVoices.Count; i++)
            {
                InstalledVoice voice = installedVoices.ElementAt(i);
                if (voice.Enabled)
                    DDLAvailableVoices.Items.Add(installedVoices.ElementAt(i).VoiceInfo.Name);
            }
            DDLAvailableVoices.SelectedIndex = 0;
        }

        private void BTNSpeak_Click(object sender, EventArgs e)
        {
            synthesizer.Dispose();
            synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = this.speechVolume;
            synthesizer.Rate = this.speechRate;
            synthesizer.SelectVoice(DDLAvailableVoices.SelectedItem.ToString());
            synthesizer.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(this.SpeakCompleted);

            BTNPause.Enabled = true;
            BTNStop.Enabled = true;
            synthesizer.SpeakAsync(TXTText.Text);
        }

        private void SpeakCompleted(object sender, EventArgs e)
        {
            BTNPause.Enabled = false;
            BTNStop.Enabled = false;
        }

        private void BTNResume_Click(object sender, EventArgs e)
        {
            if (synthesizer != null)
                if (synthesizer.State == SynthesizerState.Paused)
                {
                    synthesizer.Resume();
                    BTNResume.Enabled = false;
                    BTNSpeak.Enabled = true;
                }
        }

        private void BTNPause_Click(object sender, EventArgs e)
        {
            if (synthesizer != null)
                if (synthesizer.State == SynthesizerState.Speaking)
                {
                    synthesizer.Pause();
                    BTNResume.Enabled = true;
                    BTNSpeak.Enabled = false;
                }
        }

        private void BTNStop_Click(object sender, EventArgs e)
        {
            if (synthesizer != null)
                synthesizer.Dispose();
            BTNSpeak.Enabled = true;
            BTNResume.Enabled = false;
            BTNPause.Enabled = false;
            BTNStop.Enabled = false;
        }

        private void BTNSave_Click(object sender, EventArgs e)
        {
            synthesizer.Dispose();
            synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = this.speechVolume;
            synthesizer.Rate = this.speechRate;
            synthesizer.SelectVoice(DDLAvailableVoices.SelectedItem.ToString());
            synthesizer.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(this.SpeakCompleted);
            BTNPause.Enabled = false;
            BTNStop.Enabled = false;
            DateTime date = DateTime.Now;
            string fileName = date.Day + "_" + date.Month + "_" + date.Year + " " + date.Hour + "_" + date.Minute + "_" + date.Second + "_" + date.Millisecond + ".wav";
            synthesizer.SetOutputToWaveFile(fileName);
            synthesizer.Speak(TXTText.Text);
            synthesizer.Dispose();
        }
    }
}