using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomCharacters
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       enum enCharacterType { SmallLetter = 1, CapitalLetter = 2, Digit = 3, SymbolsLetter = 4, Mix = 5 };
        
        Random RandNumber = new Random();
        private int RandomNumber (int From, int To)
        {
            return RandNumber.Next(From, To);
        }

        private char RandomCharacters(enCharacterType CharacterType)
        {
            if (CharacterType == enCharacterType.Mix)
            {
                CharacterType = (enCharacterType)RandomNumber(1, 5);
            }

            switch(CharacterType)
            {
                case enCharacterType.SmallLetter:
                    return Convert.ToChar(RandomNumber(97, 123));

                case enCharacterType.CapitalLetter:
                    return Convert.ToChar(RandomNumber(65, 91));

                case enCharacterType.SymbolsLetter:
                    return Convert.ToChar(RandomNumber(33, 48));

                case enCharacterType.Digit:
                    return Convert.ToChar(RandomNumber(48, 58));

                default:
                    return Convert.ToChar(RandomNumber(97,123));
            }
        }

        private bool ValidateNumber(string Input)
        {
            int Number = 0;

            bool isValidNumber = int.TryParse(Input, out Number) && Number >= 0;

            return isValidNumber;
        }

        private string GenerateWord(enCharacterType CharacterType, int Length)
        {
            string Word = "";

            for (int i = 1; i <= Length; i++)
            {
                Word += Convert.ToString(RandomCharacters(CharacterType));
            }

            return Word;
        }

        private void Generate()
        {
            int Number = Convert.ToInt32(txtNumber.Tag);

            if (rbLetter.Checked)
            {
                if (rbLetter.Text == "Small Letter")
                {
                    txtResult.Text = GenerateWord(enCharacterType.SmallLetter, Number);
                }
                else if (rbLetter.Text == "Capital Letter")
                {
                    txtResult.Text = GenerateWord(enCharacterType.CapitalLetter, Number);
                }
                else
                    txtResult.Text = GenerateWord(enCharacterType.SmallLetter, Number);
            }

            if (rbNumber.Checked)
            {
                txtResult.Text = GenerateWord(enCharacterType.Digit, Number);
            }

            if (rbSymbol.Checked)
            {
                txtResult.Text = GenerateWord(enCharacterType.SymbolsLetter, Number);
            }

            if (rbMix.Checked)
            {
                txtResult.Text = GenerateWord(enCharacterType.Mix, Number);
            }

            
        }

        private void ResetTextBox()
        {
            txtNumber.Text = "0";
            txtResult.Text = "";
        }

        private void UpdateUserInterface(bool Bool)
        {

            rbLetter.Enabled = Bool;
            rbMix.Enabled = Bool;
            rbNumber.Enabled = Bool;
            rbSymbol.Enabled = Bool;
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







        private void smallLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbLetter.Text = "Small Letter";
        }

        private void capitalLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbLetter.Text = "Capital Letter";
        }





        private void txtNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumber.Text) || !ValidateNumber(txtNumber.Text))
            {
                e.Cancel = true;
                txtNumber.Focus();
                errorProvider1.SetError(txtNumber, "Please Enter a Positive Number!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtNumber, "");

                txtNumber.Tag = txtNumber.Text;

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

        private void btnExist_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }




        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The text has been copied.", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
