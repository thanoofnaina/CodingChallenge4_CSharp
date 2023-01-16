//Accept the passenger Date of Birth.
DateTime dob = new DateTime();
Console.Write("Enter the Date of birth (Format YYYY-MM-DD): ");
DateTime.TryParse(Console.ReadLine(), out dob);

DateTime nowTime = DateTime.Now;

TimeSpan duration = nowTime - dob;


//Hours Lived.
double hours = duration.TotalHours;
Console.WriteLine($"Total Hours Lived: {hours} hours");

//Days Lived.
double days = duration.TotalDays;
Console.WriteLine($"Total Days Lived: {days} days");

//Weeks Lived.
double weeks = (duration.TotalDays / 7);
Console.WriteLine($"Total Weeks Lived: {weeks} weeks");

//Months Lived.
double months = (duration.TotalDays / 30);
Console.WriteLine($"Total Months Lived: {months} months");

//Years Lived.
double years = (duration.TotalDays / 365);
Console.WriteLine($"Total Years Lived: {years} years");

//Leap Years.
double year = dob.Year;
if (year % 4 == 0)
{
    Console.WriteLine("The birth year is a leap year");
}
else
{
    Console.WriteLine("The birth year is not a leap year");

}