using System.Windows.Forms;
using System.Drawing;

namespace SymmetricEncryptionApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private ComboBox comboBoxAlgorithm;
        private Button btnGenerateKeyIV;
        private TextBox textBoxKey;
        private TextBox textBoxIV;
        private TextBox textBoxPlainASCII;
        private TextBox textBoxCipherASCII;
        private TextBox textBoxCipherHEX;
        private TextBox textBoxEncryptTime;
        private TextBox textBoxDecryptTime;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Label labelKey;
        private Label labelIV;
        private Label labelPlainText;
        private Label labelCipherText;
        private Label labelEncryptTime;
        private Label labelDecryptTime;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxAlgorithm = new ComboBox();
            this.btnGenerateKeyIV = new Button();
            this.textBoxKey = new TextBox();
            this.textBoxIV = new TextBox();
            this.textBoxPlainASCII = new TextBox();
            this.textBoxCipherASCII = new TextBox();
            this.textBoxCipherHEX = new TextBox();
            this.textBoxEncryptTime = new TextBox();
            this.textBoxDecryptTime = new TextBox();
            this.btnEncrypt = new Button();
            this.btnDecrypt = new Button();
            this.labelKey = new Label();
            this.labelIV = new Label();
            this.labelPlainText = new Label();
            this.labelCipherText = new Label();
            this.labelEncryptTime = new Label();
            this.labelDecryptTime = new Label();

            // ComboBox - Algorithm
            this.comboBoxAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxAlgorithm.Location = new Point(12, 12);
            this.comboBoxAlgorithm.Size = new Size(200, 24);
            this.comboBoxAlgorithm.SelectedIndexChanged += new System.EventHandler(this.comboBoxAlgorithm_SelectedIndexChanged);

            // Button - Generate Key and IV
            this.btnGenerateKeyIV.Text = "Generate Key and IV";
            this.btnGenerateKeyIV.Location = new Point(230, 12);
            this.btnGenerateKeyIV.Size = new Size(200, 24);
            this.btnGenerateKeyIV.Click += new System.EventHandler(this.btnGenerateKeyIV_Click);

            // Label & TextBox - Key
            this.labelKey.Text = "Key";
            this.labelKey.Location = new Point(12, 50);
            this.labelKey.AutoSize = true;
            this.textBoxKey.Location = new Point(12, 70);
            this.textBoxKey.Width = 418;

            // Label & TextBox - IV
            this.labelIV.Text = "IV";
            this.labelIV.Location = new Point(12, 100);
            this.labelIV.AutoSize = true;
            this.textBoxIV.Location = new Point(12, 120);
            this.textBoxIV.Width = 418;

            // Label & TextBox - PlainText
            this.labelPlainText.Text = "PlainText (ASCII)";
            this.labelPlainText.Location = new Point(12, 150);
            this.labelPlainText.AutoSize = true;
            this.textBoxPlainASCII.Location = new Point(12, 170);
            this.textBoxPlainASCII.Width = 418;

            // Button - Encrypt
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Location = new Point(12, 200);
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);

            // Label & TextBoxes - CipherText
            this.labelCipherText.Text = "CipherText (ASCII / HEX)";
            this.labelCipherText.Location = new Point(12, 230);
            this.labelCipherText.AutoSize = true;
            this.textBoxCipherASCII.Location = new Point(12, 250);
            this.textBoxCipherASCII.Width = 418;
            this.textBoxCipherHEX.Location = new Point(12, 280);
            this.textBoxCipherHEX.Width = 418;

            // Button - Decrypt
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Location = new Point(12, 310);
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);

            // Label & TextBox - Encryption Time
            this.labelEncryptTime.Text = "Encryption Time";
            this.labelEncryptTime.Location = new Point(12, 340);
            this.labelEncryptTime.AutoSize = true;
            this.textBoxEncryptTime.Location = new Point(12, 360);
            this.textBoxEncryptTime.Width = 418;

            // Label & TextBox - Decryption Time
            this.labelDecryptTime.Text = "Decryption Time";
            this.labelDecryptTime.Location = new Point(12, 390);
            this.labelDecryptTime.AutoSize = true;
            this.textBoxDecryptTime.Location = new Point(12, 410);
            this.textBoxDecryptTime.Width = 418;

            // Form settings
            this.ClientSize = new Size(450, 460);
            this.Text = "Symmetric Encryption Test";
            this.Controls.AddRange(new Control[] {
                comboBoxAlgorithm, btnGenerateKeyIV,
                labelKey, textBoxKey,
                labelIV, textBoxIV,
                labelPlainText, textBoxPlainASCII,
                btnEncrypt,
                labelCipherText, textBoxCipherASCII, textBoxCipherHEX,
                btnDecrypt,
                labelEncryptTime, textBoxEncryptTime,
                labelDecryptTime, textBoxDecryptTime
            });
        }
    }
}
