using System;
using System.Windows.Forms;

using CalculatorExampleMVP.Presenters;
using CalculatorExampleMVP.Views;

namespace CalculatorExampleMVP
{
    public partial class Form1 : Form, ICalculator
    {
        private CalculatorPresenter presenter;

        public string TxtNumberOne { get => textBox1.Text; set => textBox1.Text=value; }
        public string TxtNumberTwo { get => textBox2.Text; set => textBox2.Text = value; }
        public string TxtResult { get => textBox3.Text; set => textBox3.Text = value; }

        public Form1()
        {
            InitializeComponent();
            presenter = new CalculatorPresenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.CalcSum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presenter.CalcMult();
        }
    }
}