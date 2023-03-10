using System;

namespace Calculator.App.Services;

    public class AdditionService : ICalculatorService
    {
        public int Operate(int left, int right)
        {
            if (right == 17)
            {
             
            }
            return left + right;
        }
    }