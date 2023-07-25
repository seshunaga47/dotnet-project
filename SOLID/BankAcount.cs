// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        //Console.WriteLine ("Hello Mono World");
        var objAcnt = new BankAcount();
        objAcnt.AcountNumber  = 1234;
        objAcnt.AcountBalance = 2234.23M;
        
        Console.WriteLine(objAcnt.PrintAcountInfo());
        
        var objAcnt2 = new BankAcount(23455, 1234.34M);
        Console.WriteLine(objAcnt2.PrintAcountInfo());
        
    }
}

public class BankAcount{
    private int _AcountNumber = 0;
    private decimal _AcountBalance;
    
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
    
    public string PrintAcountInfo(){
        var acntInfo = "Acount Number: " + _AcountNumber.ToString() + " and Acount Balance:" + _AcountBalance.ToString();
        
        return acntInfo;
    }
}
