// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime exitDate = new DateTime(2025, 12, 11);
System.Console.WriteLine(exitDate);

bool isDaylightSavings = exitDate.IsDaylightSavingTime();
System.Console.WriteLine(isDaylightSavings);

DateTime startHour = DateTime.Now;
TimeSpan workTime = new TimeSpan(8,35,0);
DateTime endHour = startHour.Add(workTime);

System.Console.WriteLine(startHour.ToLongDateString());
System.Console.WriteLine(endHour.ToShortTimeString());

DateTime endDate =  DateTime.Now.Date;
System.Console.WriteLine(endDate);

// implicit typing is available in C# 
var a = 124.3; // double 
var b = true; // boolean

System.Console.WriteLine(a.GetType() + " " + b.GetType());

int i = 1;
while(i<11){
  Console.WriteLine(i);
  i+=1;
}