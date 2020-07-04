using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Operation
    {
        public string LeftSide { get; set; }
        public string RightSide { get; set; }
        public OperartionType operartionType { get; set; }
        public Operation innerOperation { get; set; }

        public Operation()
        {
            LeftSide = string.Empty;
            RightSide = string.Empty;
        }

        public string Calculate()
        {
            decimal left, right;

            if (string.IsNullOrEmpty(RightSide) || !decimal.TryParse(RightSide, out right))
                throw new InvalidOperationException();

            if (string.IsNullOrEmpty(LeftSide) || !decimal.TryParse(LeftSide, out left))
                throw new InvalidOperationException();


            switch (operartionType)
            {
                case OperartionType.Add:
                    return (left + right).ToString();
                case OperartionType.Minus:
                    return (left - right).ToString();
                case OperartionType.Multiply:
                    return (left * right).ToString();
                case OperartionType.Divide:
                    return (left / right).ToString();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
