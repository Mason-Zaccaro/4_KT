using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            MessageBox.Show("Пойдешь на встречу?", "Опрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
        }
    }
}
