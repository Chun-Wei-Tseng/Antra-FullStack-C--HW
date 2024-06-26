// See https://aka.ms/new-console-template for more information

DateTime birthDate = new DateTime(1999, 9, 9);
DateTime currentDate = DateTime.Now;
TimeSpan ageSpan = currentDate - birthDate;
int daysOld = ageSpan.Days;
int daysToNextAnniversary = 10000 - (daysOld % 10000);
DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);
Console.WriteLine($"You are {daysOld} days old.");
Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversary.ToShortDateString()}.");