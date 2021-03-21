using MyJunkSolution.Interfaces;
using System;

namespace MyJunkSolution.Displayers
{
    public class Dislpayer : IDisplayer
    {
        public void Dislpay()
            => Console.WriteLine("Have a wonderful Disney day!");
    }
}