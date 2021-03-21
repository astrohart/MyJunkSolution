using MyJunkSolution.Interfaces;
using System;
using System.Runtime.InteropServices;

namespace MyJunkSolution.Displayers
{
    public class Dislpayer : IDisplayer
    {
        public void Dislpay()
            => Console.WriteLine("Have a wonderful Disney day!");
    }
}