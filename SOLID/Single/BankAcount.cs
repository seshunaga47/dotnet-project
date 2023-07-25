// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
        IBankAcount objAcnt = new BankAcount();
        objAcnt.AcountNumber  = 1234;
        objAcnt.AcountBalance = 2234.23M;
        objAcnt.AcountHolderName = "Test Holder Name";
        Console.WriteLine(objAcnt.PrintAcountInfo());
        
        var objInterestCalculator = new InterestCalculator();
        var interest = objInterestCalculator.CalculateInterest(objAcnt);
        Console.WriteLine("Calculated Interest : {0}", interest);
        
    }
}

public interface IBankAcount{
    
    int AcountNumber { get; set;}
    decimal AcountBalance {get; set;}
    string AcountHolderName {get; set; }
    string PrintAcountInfo();
}

public class BankAcount : IBankAcount{
    private int _AcountNumber = 0;
    private decimal _AcountBalance;
    private string _AcountHolderName;
    
    public BankAcount(){
    }
    
    public BankAcount(int pAcountNumber, decimal pAcountBalance){
        this._AcountNumber = pAcountNumber;
        this._AcountBalance = pAcountBalance;
    }
    
    public int AcountNumber{
        get{ return _AcountNumber;}
        set{ _AcountNumber = value;}
    }
    
    public decimal AcountBalance{
        get { return _AcountBalance; }
        set { _AcountBalance = value; }
    }
    
    public string AcountHolderName{
        get { return _AcountHolderName;}
        set { _AcountHolderName = value;}
    }
    
    public string PrintAcountInfo(){
        var acntInfo = string.Format("Acount Number: {0} and Acount Balance:{1} and Acount Holder Name : {2} ", _AcountNumber.ToString(), _AcountBalance.ToString(), _AcountHolderName);
        
        return acntInfo;
    }
}

public interface ICalculateInterest{
    decimal CalculateInterest(IBankAcount iBankAcount);
}

public class InterestCalculator: ICalculateInterest{
    public decimal CalculateInterest(IBankAcount iBankAcount){
        return 100.02M;
    }
}
