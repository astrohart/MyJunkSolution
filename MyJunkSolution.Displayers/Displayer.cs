using MyJunkSolution.Displayers.Interfaces;
using System;

namespace MyJunkSolution.Displayers
{
    public class Displayer : IDisplayer
    {
        public void Dislpay()
            => Console.WriteLine("Have a wonderful Disney day!");
    }
}