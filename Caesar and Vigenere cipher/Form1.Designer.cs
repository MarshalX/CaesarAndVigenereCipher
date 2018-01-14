namespace CaesarAndVigenereCipher {
    partial class Form1 {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.caesarSettingsGroup = new System.Windows.Forms.GroupBox();
            this.ceasarStepCountLbl = new System.Windows.Forms.Label();
            this.ceasarStepTrackBar = new System.Windows.Forms.TrackBar();
            this.vigenereSettingsGroup = new System.Windows.Forms.GroupBox();
            this.vigenereKeyEdt = new System.Windows.Forms.TextBox();
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.openFromFileBtn = new System.Windows.Forms.Button();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.outputGroup = new System.Windows.Forms.GroupBox();
            this.saveToFileBtn = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.actionGroup = new System.Windows.Forms.GroupBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.methodGroup = new System.Windows.Forms.GroupBox();
            this.vigenerRadioBtn = new System.Windows.Forms.RadioButton();
            this.caesarRadioBtn = new System.Windows.Forms.RadioButton();
            this.caesarSettingsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceasarStepTrackBar)).BeginInit();
            this.vigenereSettingsGroup.SuspendLayout();
            this.inputGroup.SuspendLayout();
            this.outputGroup.SuspendLayout();
            this.actionGroup.SuspendLayout();
            this.methodGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // caesarSettingsGroup
            // 
            this.caesarSettingsGroup.Controls.Add(this.ceasarStepCountLbl);
            this.caesarSettingsGroup.Controls.Add(this.ceasarStepTrackBar);
            this.caesarSettingsGroup.Location = new System.Drawing.Point(12, 12);
            this.caesarSettingsGroup.Name = "caesarSettingsGroup";
            this.caesarSettingsGroup.Size = new System.Drawing.Size(1058, 92);
            this.caesarSettingsGroup.TabIndex = 0;
            this.caesarSettingsGroup.TabStop = false;
            this.caesarSettingsGroup.Text = "Шаг шифрования";
            // 
            // ceasarStepCountLbl
            // 
            this.ceasarStepCountLbl.AutoSize = true;
            this.ceasarStepCountLbl.Location = new System.Drawing.Point(1036, 25);
            this.ceasarStepCountLbl.Name = "ceasarStepCountLbl";
            this.ceasarStepCountLbl.Size = new System.Drawing.Size(16, 17);
            this.ceasarStepCountLbl.TabIndex = 1;
            this.ceasarStepCountLbl.Text = "4";
            // 
            // ceasarStepTrackBar
            // 
            this.ceasarStepTrackBar.LargeChange = 1;
            this.ceasarStepTrackBar.Location = new System.Drawing.Point(6, 21);
            this.ceasarStepTrackBar.Maximum = 32;
            this.ceasarStepTrackBar.Minimum = 1;
            this.ceasarStepTrackBar.Name = "ceasarStepTrackBar";
            this.ceasarStepTrackBar.Size = new System.Drawing.Size(1024, 56);
            this.ceasarStepTrackBar.TabIndex = 0;
            this.ceasarStepTrackBar.Value = 4;
            this.ceasarStepTrackBar.Scroll += new System.EventHandler(this.ceasarStepTrackBar_Scroll);
            // 
            // vigenereSettingsGroup
            // 
            this.vigenereSettingsGroup.Controls.Add(this.vigenereKeyEdt);
            this.vigenereSettingsGroup.Location = new System.Drawing.Point(12, 12);
            this.vigenereSettingsGroup.Name = "vigenereSettingsGroup";
            this.vigenereSettingsGroup.Size = new System.Drawing.Size(1058, 92);
            this.vigenereSettingsGroup.TabIndex = 2;
            this.vigenereSettingsGroup.TabStop = false;
            this.vigenereSettingsGroup.Text = "Ключевое слово";
            this.vigenereSettingsGroup.Visible = false;
            // 
            // vigenereKeyEdt
            // 
            this.vigenereKeyEdt.Location = new System.Drawing.Point(6, 25);
            this.vigenereKeyEdt.Name = "vigenereKeyEdt";
            this.vigenereKeyEdt.Size = new System.Drawing.Size(1046, 22);
            this.vigenereKeyEdt.TabIndex = 0;
            // 
            // inputGroup
            // 
            this.inputGroup.Controls.Add(this.openFromFileBtn);
            this.inputGroup.Controls.Add(this.inputText);
            this.inputGroup.Location = new System.Drawing.Point(12, 110);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(400, 530);
            this.inputGroup.TabIndex = 1;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Исходный текст";
            // 
            // openFromFileBtn
            // 
            this.openFromFileBtn.Location = new System.Drawing.Point(6, 501);
            this.openFromFileBtn.Name = "openFromFileBtn";
            this.openFromFileBtn.Size = new System.Drawing.Size(388, 23);
            this.openFromFileBtn.TabIndex = 1;
            this.openFromFileBtn.Text = "Открыть исходный текст";
            this.openFromFileBtn.UseVisualStyleBackColor = true;
            this.openFromFileBtn.Click += new System.EventHandler(this.openFromFileBtn_Click);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(6, 21);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(388, 474);
            this.inputText.TabIndex = 0;
            this.inputText.Text = "";
            // 
            // outputGroup
            // 
            this.outputGroup.Controls.Add(this.saveToFileBtn);
            this.outputGroup.Controls.Add(this.outputText);
            this.outputGroup.Location = new System.Drawing.Point(670, 110);
            this.outputGroup.Name = "outputGroup";
            this.outputGroup.Size = new System.Drawing.Size(400, 530);
            this.outputGroup.TabIndex = 2;
            this.outputGroup.TabStop = false;
            this.outputGroup.Text = "Зашифрованный текст";
            // 
            // saveToFileBtn
            // 
            this.saveToFileBtn.Location = new System.Drawing.Point(6, 501);
            this.saveToFileBtn.Name = "saveToFileBtn";
            this.saveToFileBtn.Size = new System.Drawing.Size(388, 23);
            this.saveToFileBtn.TabIndex = 2;
            this.saveToFileBtn.Text = "Сохранить зашифрованный текст";
            this.saveToFileBtn.UseVisualStyleBackColor = true;
            this.saveToFileBtn.Click += new System.EventHandler(this.saveToFileBtn_Click);
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(6, 21);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(388, 474);
            this.outputText.TabIndex = 1;
            this.outputText.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "output.txt";
            this.saveFileDialog.Filter = "Текстовый файл (*.txt)|*.txt";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // actionGroup
            // 
            this.actionGroup.Controls.Add(this.decryptBtn);
            this.actionGroup.Controls.Add(this.encryptBtn);
            this.actionGroup.Location = new System.Drawing.Point(418, 110);
            this.actionGroup.Name = "actionGroup";
            this.actionGroup.Size = new System.Drawing.Size(246, 100);
            this.actionGroup.TabIndex = 3;
            this.actionGroup.TabStop = false;
            this.actionGroup.Text = "Действие";
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(6, 60);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(234, 34);
            this.decryptBtn.TabIndex = 1;
            this.decryptBtn.Text = "Расшифровать";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(6, 21);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(234, 33);
            this.encryptBtn.TabIndex = 0;
            this.encryptBtn.Text = "Зашифровать";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // methodGroup
            // 
            this.methodGroup.Controls.Add(this.vigenerRadioBtn);
            this.methodGroup.Controls.Add(this.caesarRadioBtn);
            this.methodGroup.Location = new System.Drawing.Point(418, 216);
            this.methodGroup.Name = "methodGroup";
            this.methodGroup.Size = new System.Drawing.Size(246, 100);
            this.methodGroup.TabIndex = 4;
            this.methodGroup.TabStop = false;
            this.methodGroup.Text = "Метод шифрования";
            // 
            // vigenerRadioBtn
            // 
            this.vigenerRadioBtn.AutoSize = true;
            this.vigenerRadioBtn.Location = new System.Drawing.Point(6, 59);
            this.vigenerRadioBtn.Name = "vigenerRadioBtn";
            this.vigenerRadioBtn.Size = new System.Drawing.Size(95, 21);
            this.vigenerRadioBtn.TabIndex = 1;
            this.vigenerRadioBtn.Text = "Виженера";
            this.vigenerRadioBtn.UseVisualStyleBackColor = true;
            this.vigenerRadioBtn.Click += new System.EventHandler(this.vigenerRadioBtn_Click);
            // 
            // caesarRadioBtn
            // 
            this.caesarRadioBtn.AutoSize = true;
            this.caesarRadioBtn.Checked = true;
            this.caesarRadioBtn.Location = new System.Drawing.Point(6, 32);
            this.caesarRadioBtn.Name = "caesarRadioBtn";
            this.caesarRadioBtn.Size = new System.Drawing.Size(79, 21);
            this.caesarRadioBtn.TabIndex = 0;
            this.caesarRadioBtn.TabStop = true;
            this.caesarRadioBtn.Text = "Цезаря";
            this.caesarRadioBtn.UseVisualStyleBackColor = true;
            this.caesarRadioBtn.Click += new System.EventHandler(this.caesarRadioBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.vigenereSettingsGroup);
            this.Controls.Add(this.methodGroup);
            this.Controls.Add(this.actionGroup);
            this.Controls.Add(this.outputGroup);
            this.Controls.Add(this.inputGroup);
            this.Controls.Add(this.caesarSettingsGroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Шифры Цезаря и Виженера";
            this.caesarSettingsGroup.ResumeLayout(false);
            this.caesarSettingsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceasarStepTrackBar)).EndInit();
            this.vigenereSettingsGroup.ResumeLayout(false);
            this.vigenereSettingsGroup.PerformLayout();
            this.inputGroup.ResumeLayout(false);
            this.outputGroup.ResumeLayout(false);
            this.actionGroup.ResumeLayout(false);
            this.methodGroup.ResumeLayout(false);
            this.methodGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox caesarSettingsGroup;
        private System.Windows.Forms.TrackBar ceasarStepTrackBar;
        private System.Windows.Forms.Label ceasarStepCountLbl;
        private System.Windows.Forms.GroupBox inputGroup;
        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.Button openFromFileBtn;
        private System.Windows.Forms.Button saveToFileBtn;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox actionGroup;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.GroupBox methodGroup;
        private System.Windows.Forms.RadioButton vigenerRadioBtn;
        private System.Windows.Forms.RadioButton caesarRadioBtn;
        private System.Windows.Forms.GroupBox vigenereSettingsGroup;
        private System.Windows.Forms.TextBox vigenereKeyEdt;
        private System.Windows.Forms.GroupBox outputGroup;
    }
}

