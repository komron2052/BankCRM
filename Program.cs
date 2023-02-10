using BankCRM.IUserInterface;
using System;
namespace BankCRM
{
    internal class Bank
    {
        internal static void Main(string[] args)
        {
            MainInterface mainInterface = new MainInterface();
            mainInterface.Demonstrate();
        }
    }
}