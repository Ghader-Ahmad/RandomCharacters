using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCharacters
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum enCharacterType { SmallLetter = 1, CapitalLetter = 2, Mix = 3 };


        Random RandNumber = new Random();

        private int RandomNumber(int From, int To)
        {
            return RandNumber.Next(From, To);
        }
     
        private char RandomCharacter(enCharacterType CharacterType)
        {
            if (CharacterType == enCharacterType.Mix)
            {
                CharacterType = (enCharacterType)RandomNumber(1, 3);
            }

            switch(CharacterType)
            {
                case enCharacterType.SmallLetter:
                    return Convert.ToChar(RandomNumber(97, 123));

                case enCharacterType.CapitalLetter:
                    return Convert.ToChar(RandomNumber(65, 91));

                default:
                    return Convert.ToChar(RandomNumber(65, 91));
            }
        }

        private bool ValidateNumber(string Input)
        {
            int Number = 0;

            bool isValideNumber = int.TryParse(Input, out Number) && Number >= 0;

            return isValideNumber;
        }

        private string GenerateWord(enCharacterType CharacterType, short Length)
        {
            string Word = "";

            for (int i = 1; i <= Length; i++)
            {
                Word += RandomCharacter(CharacterType).ToString();
            }
            
            return Word;
        }

        private string GenerateKey(enCharacterType CharacterType)
        {
            string Key = "";

            Key = GenerateWord(CharacterType, 4) + "-";
            Key += GenerateWord(CharacterType, 4) + "-";
            Key += GenerateWord(CharacterType, 4) + "-";
            Key += GenerateWord(CharacterType, 4);

            return Key;
        }

        private void GenerateKeys(enCharacterType CharacterType, short NumberOfKeys)
        {
            for (int i = 1; i <= NumberOfKeys; i++)
            {
                txtResult.AppendText("Key [" + i + "]: " + GenerateKey(CharacterType) + Environment.NewLine);
            }
        }

        private void Generate()
        {
            short NumberOfKeys = Convert.ToInt16(txtNumber.Text);

            if (rbSmallLetter.Checked)
            {
                GenerateKeys(enCharacterType.SmallLetter, NumberOfKeys);
                return;
            }

            if (rbCapitalLetter.Checked)
            {
                GenerateKeys(enCharacterType.CapitalLetter, NumberOfKeys);
                return;
            }

            if (rbMix.Checked)
            {
                GenerateKeys(enCharacterType.Mix, NumberOfKeys);
                return;
            }
        }

        private void ResetTextBox()
        {
            txtNumber.Text = "0";
            txtResult.Text = "";
        }

        private void UpdateUserInterface(bool Bool)
        {
            btnGenerate.Enabled = true;

            rbCapitalLetter.Enabled = Bool;
            rbMix.Enabled = Bool;
            rbSmallLetter.Enabled = Bool;
        }

        private void UpdateUserInterfaceAfterClickOnOptionButton()
        {
            panel1.Visible = true;
            txtResult.Visible = true;

            btnGenerate.Visible = true;
            btnReset.Visible = true;

            txtNumber.Focus();
        }

        private void Reset()
        {
            ResetTextBox();
            UpdateUserInterface(false);
        }








        private void txtNumber_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumber.Text) || !ValidateNumber(txtNumber.Text))
            {
                e.Cancel = true;
                txtNumber.Focus();
                errorProvider1.SetError(txtNumber, "Please Enter A Positive Number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNumber, "");

                UpdateUserInterface(true);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            UpdateUserInterfaceAfterClickOnOptionButton();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The text has been copied.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
