using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clac
{
    public partial class Calculator : Form
    {
        enum Operator
        {
            Addition,
            Subtraction,
            Multiplication,
            Division,
        }
        private int OldValue;
        private Operator OperatorVar = Operator.Addition;

        public Calculator()
        {
            InitializeComponent();
            OutputTextBot.Text = "0";
            
        }

        private int AddNumber(int Number, string Value) {
            
            return (Convert.ToInt32(Value) * 10) + Number;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if (sender is Button BtnSender)
            {
                int BtnValue = Convert.ToInt32(BtnSender.Text);
                int NewValue = this.AddNumber(BtnValue, OutputTextBot.Text);
                OutputTextBot.Text = NewValue.ToString();
            }
            else
            {
                MessageBox.Show("Key Not Found");
                return;
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            OutputTextBot.Text = "0";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int Value = Convert.ToInt32(OutputTextBot.Text);
            int NewValue = Value / 10;
            OutputTextBot.Text = NewValue.ToString();
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            this.OperatorVar = Operator.Addition;
            OldValue = Convert.ToInt32(OutputTextBot.Text);
            OutputTextBot.Text = "0";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            int Res = 0;
            int Value = Convert.ToInt32(OutputTextBot.Text);
            switch (this.OperatorVar)
            {
                case Operator.Addition:
                    Res = this.OldValue + Value;
                    OutputTextBot.Text = Res.ToString();
                    break;

                case Operator.Subtraction:
                    Res = this.OldValue - Value;
                    OutputTextBot.Text = Res.ToString();
                    break;

                case Operator.Multiplication:
                    Res = this.OldValue * Value;
                    OutputTextBot.Text = Res.ToString();
                    break;

                case Operator.Division:
                    Res = this.OldValue / Value;
                    OutputTextBot.Text = Res.ToString();
                    break;

            }
            
        }

        private void SubtractionBtn_Click(object sender, EventArgs e)
        {
            this.OperatorVar = Operator.Subtraction;
            OldValue = Convert.ToInt32(OutputTextBot.Text);
            OutputTextBot.Text = "0";
        }

        private void MultiplicationBtn_Click(object sender, EventArgs e)
        {
            this.OperatorVar = Operator.Multiplication;
            OldValue = Convert.ToInt32(OutputTextBot.Text);
            OutputTextBot.Text = "0";
        }

        private void DivisionBtn_Click(object sender, EventArgs e)
        {
            this.OperatorVar = Operator.Division;
            OldValue = Convert.ToInt32(OutputTextBot.Text);
            OutputTextBot.Text = "0";
        }
    }
}
