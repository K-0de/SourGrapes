using System;

class PersonalInfo
{
    static void Main()
    {

        string name = "Lucinda Potter";
        DateTime birthdate = new DateTime(1992, 6, 24);
        string workPhone = "000-000-0101";
        string cellPhone = "000-000-0189";
           Console.WriteLine(name);
           Console.WriteLine(birthdate.ToString("MM/dd/yyyy"));
           Console.WriteLine("workphone " + workPhone);
           Console.WriteLine("cellphone " + cellPhone);
        
        }
}