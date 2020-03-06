using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxConsole
{
    class AbstractClassVsInterface : BankTask, SchoolTask
    {
        public static void Main(string[] arg)
        {
            
        }

        public override void Deposit(int accountId, double amount)
        {
            //Statements
        }

        public override void Withdraw(int accountId, double amount)
        {
            //Statements
        }

        public void StudentAdmission(int studentId, double amount)
        {
            //Statements
        }

        public void AppointTeacher(int studentId, double amount)
        {
            //Statements
        }
    }

    public abstract class BankTask
    {
        public int bankAcountID = 1001;
        public string branchCode = "Bank0001";

        const string IFSC = "POWE1248";

        public abstract void Deposit(int accountId, double amount);

        public abstract void Withdraw(int accountId, double amount);
    }  
  
    interface SchoolTask
    {
        const string IFSC = "POWE1248";

        void StudentAdmission(int studentId, double amount);
        void AppointTeacher(int studentId, double amount); 
    }
}
