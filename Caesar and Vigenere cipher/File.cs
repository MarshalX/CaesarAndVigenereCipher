using System;
using System.IO;

namespace CaesarAndVigenereCipher {
    class File {
        public string fileName = string.Empty;

        public File(string fileName) {
            this.fileName = fileName;
        }

        public string ReadFile() {
            try {
                StreamReader sr = new StreamReader(this.fileName);
                string res = string.Empty;

                string line = sr.ReadLine();
                while (line != null) {
                    res += line + Convert.ToChar(13);
                    line = sr.ReadLine();
                }

                sr.Close();

                return res;
            } catch (Exception) {
                return "";
            }
        }

        public void WriteFile(string text) {
            try {
                StreamWriter sw = new StreamWriter(this.fileName);
                sw.WriteLine(text);

                sw.Close();
            } catch(Exception) {

            }
        }
    }
}
