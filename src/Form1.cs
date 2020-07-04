using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Operators

        private void equalsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }

        private void negationButton_Click(object sender, EventArgs e)
        {

        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
            FocusInputText();
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
            FocusInputText();
        }

        private void mulButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");
            FocusInputText();
        }

        private void divButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
            FocusInputText();
        }

        private void oneOverXButton_Click(object sender, EventArgs e)
        {

        }

        private void secondPowerButton_Click(object sender, EventArgs e)
        {

        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {

        }

        private void percentButton_Click(object sender, EventArgs e)
        {

        }

        private void Cbutton_Click(object sender, EventArgs e)
        {

        }

        private void CEbutton_Click(object sender, EventArgs e)
        {
            userInputText.Text = string.Empty;
            FocusInputText();
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (userInputText.SelectionStart < 1)
            {
                userInputText.Focus();
                return;
            }

            var selectionStart = userInputText.SelectionStart;

            userInputText.Text = userInputText.Text.Remove(userInputText.SelectionStart-1, 1);

            userInputText.SelectionStart = selectionStart - 1;

            FocusInputText();
        }

        #endregion Operators

        #region Numbers

        private void dotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
            FocusInputText();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            FocusInputText();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
            FocusInputText();
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
            FocusInputText();
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
            FocusInputText();
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
            FocusInputText();
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
            FocusInputText();
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
            FocusInputText();
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
            FocusInputText();
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
            FocusInputText();
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
            FocusInputText();
        }
        #endregion

        private void CalculateEquation()
        {
            



            resultLabel.Text = ParseOperation();
            FocusInputText();
        }

        private string ParseOperation()
        {
            string numbers = "0123456789.";
            string operators = "+-*/";

            try
            {
                string userInput = this.userInputText.Text;
                userInput = userInput.Replace(" ", ""); //remove spaces

                if (userInput.Length == 0)
                    throw new ArgumentNullException();

                var operation = new Operation();
                var leftSide = true;

                for(int i = 0; i < userInput.Length; i++)
                {
                    if(numbers.Any(c => userInput[i] == c))
                    {
                        if (leftSide)
                        {
                            operation.LeftSide = AddNumberPart(operation.LeftSide, userInput[i]);
                        } 
                        else
                        {
                            operation.RightSide = AddNumberPart(operation.RightSide, userInput[i]);
                        }
                    } 
                    else if (operators.Any(c => userInput[i] == c))
                    {
                        if (!leftSide)
                        {
                            var operatorType = GetOperationType(userInput[i]);

                            if(operation.RightSide.Length == 0)
                            {
                                if (operatorType != OperartionType.Minus)
                                    throw new InvalidOperationException();

                                operation.RightSide += userInput[i];
                            }
                            else
                            {
                                operation.LeftSide = operation.Calculate();
                                operation.operartionType = operatorType;
                                operation.RightSide = string.Empty;
                            }
                        }
                        else
                        {
                            var operatorType = GetOperationType(userInput[i]);

                            if(operation.LeftSide.Length == 0)
                            {
                                if (operatorType != OperartionType.Minus)
                                    throw new InvalidOperationException();

                                operation.RightSide += userInput[i];
                            }
                            else
                            {
                                operation.operartionType = operatorType;

                                leftSide = false;
                            }
                        }
                    }
                }

                return operation.Calculate();
            } 
            catch(Exception e)
            {
                return e.Message;
            }
        }

        private OperartionType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperartionType.Add;
                case '-':
                    return OperartionType.Minus;
                case '*':
                    return OperartionType.Multiply;
                case '/':
                    return OperartionType.Divide;
                default:
                    throw new InvalidOperationException();
            }
        }

        private string AddNumberPart(string currNumber, char newChar)
        {
            if (newChar == '.' && currNumber.Contains('.'))
                throw new ArgumentException();

            return currNumber + newChar;
        }

        private void FocusInputText()
        {
            userInputText.Focus();
        }

        private void InsertTextValue(string s)
        {
            var selectionStart = userInputText.SelectionStart;

            userInputText.Text = userInputText.Text.Insert(userInputText.SelectionStart, s);

            userInputText.SelectionStart = selectionStart + s.Length;
        }
    }
}
