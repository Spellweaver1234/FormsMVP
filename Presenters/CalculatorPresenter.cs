using System;

using CalculatorExampleMVP.Models;
using CalculatorExampleMVP.Views;

namespace CalculatorExampleMVP.Presenters
{
    class CalculatorPresenter
    {
        private Calculator calculator = new Calculator();
        private ICalculator calculatorView;

        public CalculatorPresenter(ICalculator view)
        {
            calculatorView = view;
        }

        public void ConnectBetweenModelAndView()
        {
            calculator.NumberOne = Convert.ToDouble(calculatorView.TxtNumberOne);
            calculator.NumberTwo = Convert.ToDouble(calculatorView.TxtNumberTwo);
        }
        public void CalcSum()
        {
            ConnectBetweenModelAndView();
            calculatorView.TxtResult = calculator.CalculateSumation().ToString();
        }
        public void CalcMult()
        {
            ConnectBetweenModelAndView();
            calculatorView.TxtResult = calculator.CalculateMultiplication().ToString();
        }
    }
}