using System.Collections.Generic;

namespace CaesarAndVigenereCipher {
    class Caesar {
        const int lettersRU = 32;
        const int lettersEN = 26;

        public int step = 0;

        private List<char> temp = null;
        private int letters = 0;
        private bool upper = false;

        public Caesar(int step=4) {
            this.step = step;
        }

        public void initAlphabet(char ch) {
            if (char.IsUpper(ch)) {
                this.upper = true;
                ch = char.ToLower(ch);
            } else
                this.upper = false;

            if (Form1.alphabetRU.Contains(ch)) {
                this.temp = Form1.alphabetRU;
                this.letters = lettersRU;
            } else if (Form1.alphabetEN.Contains(ch)) {
                this.temp = Form1.alphabetEN;
                this.letters = lettersEN;
            } else
                this.letters = 0;
        }

        public string Encrypt(string text) {
            string res = string.Empty;

            for (int i = 0; i < text.Length; ++i) {
                this.initAlphabet(text[i]);

                if (this.letters != 0) {
                    int encryptChar = (this.temp.IndexOf(char.ToLower(text[i])) + this.step) % this.letters;

                    if (this.upper)
                        res += char.ToUpper(this.temp[encryptChar]);
                    else
                        res += this.temp[encryptChar];
                } else
                    res += text[i];
            }

            return res;
        }

        public string Decrypt(string text) {
            string res = string.Empty;

            for (int i = 0; i < text.Length; ++i) {
                this.initAlphabet(text[i]);

                if (this.letters != 0) {
                    int decryptChar = this.temp.IndexOf(char.ToLower(text[i])) - this.step + this.letters;
                    decryptChar = (decryptChar % this.letters + this.letters) % this.letters;

                    if (this.upper)
                        res += char.ToUpper(this.temp[decryptChar]);
                    else
                        res += this.temp[decryptChar];
                } else
                    res += text[i];
            }

            return res;
        }
    }
}
