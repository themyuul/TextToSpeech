
namespace TextToSpeech
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNSpeak = new System.Windows.Forms.Button();
            this.TRBSpeechRate = new System.Windows.Forms.TrackBar();
            this.LBLSpeechRate = new System.Windows.Forms.Label();
            this.TRBSpeechVolume = new System.Windows.Forms.TrackBar();
            this.LBLSpeechVolume = new System.Windows.Forms.Label();
            this.DDLAvailableVoices = new System.Windows.Forms.ComboBox();
            this.LBLAvailableVoices = new System.Windows.Forms.Label();
            this.TXTText = new System.Windows.Forms.TextBox();
            this.BTNResume = new System.Windows.Forms.Button();
            this.BTNPause = new System.Windows.Forms.Button();
            this.BTNStop = new System.Windows.Forms.Button();
            this.BTNSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TRBSpeechRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRBSpeechVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNSpeak
            // 
            this.BTNSpeak.Location = new System.Drawing.Point(13, 393);
            this.BTNSpeak.Name = "BTNSpeak";
            this.BTNSpeak.Size = new System.Drawing.Size(75, 23);
            this.BTNSpeak.TabIndex = 0;
            this.BTNSpeak.Text = "Speak";
            this.BTNSpeak.UseVisualStyleBackColor = true;
            this.BTNSpeak.Click += new System.EventHandler(this.BTNSpeak_Click);
            // 
            // TRBSpeechRate
            // 
            this.TRBSpeechRate.Location = new System.Drawing.Point(601, 148);
            this.TRBSpeechRate.Minimum = -10;
            this.TRBSpeechRate.Name = "TRBSpeechRate";
            this.TRBSpeechRate.Size = new System.Drawing.Size(190, 45);
            this.TRBSpeechRate.TabIndex = 1;
            this.TRBSpeechRate.Scroll += new System.EventHandler(this.TRBSpeechRate_Scroll);
            // 
            // LBLSpeechRate
            // 
            this.LBLSpeechRate.AutoSize = true;
            this.LBLSpeechRate.Location = new System.Drawing.Point(614, 132);
            this.LBLSpeechRate.Name = "LBLSpeechRate";
            this.LBLSpeechRate.Size = new System.Drawing.Size(30, 13);
            this.LBLSpeechRate.TabIndex = 2;
            this.LBLSpeechRate.Text = "Rate";
            // 
            // TRBSpeechVolume
            // 
            this.TRBSpeechVolume.Location = new System.Drawing.Point(601, 84);
            this.TRBSpeechVolume.Maximum = 100;
            this.TRBSpeechVolume.Name = "TRBSpeechVolume";
            this.TRBSpeechVolume.Size = new System.Drawing.Size(190, 45);
            this.TRBSpeechVolume.TabIndex = 3;
            this.TRBSpeechVolume.Scroll += new System.EventHandler(this.TRBSpeechVolume_Scroll);
            // 
            // LBLSpeechVolume
            // 
            this.LBLSpeechVolume.AutoSize = true;
            this.LBLSpeechVolume.Location = new System.Drawing.Point(614, 68);
            this.LBLSpeechVolume.Name = "LBLSpeechVolume";
            this.LBLSpeechVolume.Size = new System.Drawing.Size(42, 13);
            this.LBLSpeechVolume.TabIndex = 4;
            this.LBLSpeechVolume.Text = "Volume";
            // 
            // DDLAvailableVoices
            // 
            this.DDLAvailableVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDLAvailableVoices.FormattingEnabled = true;
            this.DDLAvailableVoices.Location = new System.Drawing.Point(601, 40);
            this.DDLAvailableVoices.Name = "DDLAvailableVoices";
            this.DDLAvailableVoices.Size = new System.Drawing.Size(193, 21);
            this.DDLAvailableVoices.TabIndex = 5;
            // 
            // LBLAvailableVoices
            // 
            this.LBLAvailableVoices.AutoSize = true;
            this.LBLAvailableVoices.Location = new System.Drawing.Point(614, 16);
            this.LBLAvailableVoices.Name = "LBLAvailableVoices";
            this.LBLAvailableVoices.Size = new System.Drawing.Size(85, 13);
            this.LBLAvailableVoices.TabIndex = 6;
            this.LBLAvailableVoices.Text = "Available Voices";
            // 
            // TXTText
            // 
            this.TXTText.Location = new System.Drawing.Point(13, 13);
            this.TXTText.Multiline = true;
            this.TXTText.Name = "TXTText";
            this.TXTText.Size = new System.Drawing.Size(579, 349);
            this.TXTText.TabIndex = 7;
            // 
            // BTNResume
            // 
            this.BTNResume.Location = new System.Drawing.Point(175, 393);
            this.BTNResume.Name = "BTNResume";
            this.BTNResume.Size = new System.Drawing.Size(75, 23);
            this.BTNResume.TabIndex = 8;
            this.BTNResume.Text = "Resume";
            this.BTNResume.UseVisualStyleBackColor = true;
            this.BTNResume.Click += new System.EventHandler(this.BTNResume_Click);
            // 
            // BTNPause
            // 
            this.BTNPause.Location = new System.Drawing.Point(94, 393);
            this.BTNPause.Name = "BTNPause";
            this.BTNPause.Size = new System.Drawing.Size(75, 23);
            this.BTNPause.TabIndex = 9;
            this.BTNPause.Text = "Pause";
            this.BTNPause.UseVisualStyleBackColor = true;
            this.BTNPause.Click += new System.EventHandler(this.BTNPause_Click);
            // 
            // BTNStop
            // 
            this.BTNStop.Location = new System.Drawing.Point(256, 393);
            this.BTNStop.Name = "BTNStop";
            this.BTNStop.Size = new System.Drawing.Size(75, 23);
            this.BTNStop.TabIndex = 10;
            this.BTNStop.Text = "Stop";
            this.BTNStop.UseVisualStyleBackColor = true;
            this.BTNStop.Click += new System.EventHandler(this.BTNStop_Click);
            // 
            // BTNSave
            // 
            this.BTNSave.Location = new System.Drawing.Point(338, 393);
            this.BTNSave.Name = "BTNSave";
            this.BTNSave.Size = new System.Drawing.Size(75, 23);
            this.BTNSave.TabIndex = 11;
            this.BTNSave.Text = "Save to file";
            this.BTNSave.UseVisualStyleBackColor = true;
            this.BTNSave.Click += new System.EventHandler(this.BTNSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNSave);
            this.Controls.Add(this.BTNStop);
            this.Controls.Add(this.BTNPause);
            this.Controls.Add(this.BTNResume);
            this.Controls.Add(this.TXTText);
            this.Controls.Add(this.LBLAvailableVoices);
            this.Controls.Add(this.DDLAvailableVoices);
            this.Controls.Add(this.LBLSpeechVolume);
            this.Controls.Add(this.TRBSpeechVolume);
            this.Controls.Add(this.LBLSpeechRate);
            this.Controls.Add(this.TRBSpeechRate);
            this.Controls.Add(this.BTNSpeak);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TRBSpeechRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TRBSpeechVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSpeak;
        private System.Windows.Forms.TrackBar TRBSpeechRate;
        private System.Windows.Forms.Label LBLSpeechRate;
        private System.Windows.Forms.TrackBar TRBSpeechVolume;
        private System.Windows.Forms.Label LBLSpeechVolume;
        private System.Windows.Forms.ComboBox DDLAvailableVoices;
        private System.Windows.Forms.Label LBLAvailableVoices;
        private System.Windows.Forms.TextBox TXTText;
        private System.Windows.Forms.Button BTNResume;
        private System.Windows.Forms.Button BTNPause;
        private System.Windows.Forms.Button BTNStop;
        private System.Windows.Forms.Button BTNSave;
    }
}

