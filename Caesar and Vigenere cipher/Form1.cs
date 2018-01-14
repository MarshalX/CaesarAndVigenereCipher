using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace CaesarAndVigenereCipher {
    public partial class Form1 : Form {
        public static List<char> alphabetRU = new List<char>();
        public static List<char> alphabetEN = new List<char>();

        public Form1() {
            InitializeComponent();

            for (int i = 1072; i < 1104; ++i)
                alphabetRU.Add(Convert.ToChar(i));
            
            for (int i = 97; i < 123; ++i)
                alphabetEN.Add(Convert.ToChar(i));
        }

        private void ceasarStepTrackBar_Scroll(object sender, EventArgs e) {
            ceasarStepCountLbl.Text = Convert.ToString(ceasarStepTrackBar.Value);
        }

        private void caesarRadioBtn_Click(object sender, EventArgs e) {
            caesarSettingsGroup.Visible = true;
            vigenereSettingsGroup.Visible = false;
        }

        private void vigenerRadioBtn_Click(object sender, EventArgs e) {
            caesarSettingsGroup.Visible = false;
            vigenereSettingsGroup.Visible = true;
        }

        private void openFromFileBtn_Click(object sender, EventArgs e) {
            openFileDialog.ShowDialog();
        }

        private void saveToFileBtn_Click(object sender, EventArgs e) {
            saveFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e) {
            File input = new File(openFileDialog.FileName);
            string text = input.ReadFile();
            inputText.Text = text;
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e) {
            File output = new File(saveFileDialog.FileName);
            string text = outputText.Text;
            output.WriteFile(text);
        }

        private void encryptBtn_Click(object sender, EventArgs e) {
            string text = inputText.Text;
            string res = string.Empty;

            if (caesarRadioBtn.Checked) {
                Caesar cr = new Caesar(ceasarStepTrackBar.Value);
                res = cr.Encrypt(text);
            } else {
                Vigenere vg = new Vigenere(vigenereKeyEdt.Text);
                res = vg.Encrypt(text);
            }

            outputText.Text = res;
        }   

        private void decryptBtn_Click(object sender, EventArgs e) {
            string text = outputText.Text;
            string res = string.Empty;

            if (caesarRadioBtn.Checked) {
                Caesar cr = new Caesar(ceasarStepTrackBar.Value);
                res = cr.Decrypt(text);
            } else {
                Vigenere vg = new Vigenere(vigenereKeyEdt.Text);
                res = vg.Decrypt(text);
            }

            inputText.Text = res;
        }
    }
}
