using System.ComponentModel;
using System.Diagnostics;

using Humanizer;

string testString = "This Is mY TEsT sTrinG";

// registers 
Console.WriteLine(testString.Transform(To.SentenceCase));
Console.WriteLine(testString.Transform(To.TitleCase));
Console.WriteLine(testString.Transform(To.UpperCase));
Console.WriteLine(testString.Transform(To.LowerCase));

// truncate 
Console.WriteLine(testString.Truncate(10, "..."));

// enums
Console.WriteLine(Book.SelfHelp);
Console.WriteLine(Book.SelfHelp.Humanize());
Console.WriteLine(Book.SelfHelp.Humanize().Transform(To.TitleCase));
Console.WriteLine(Book.MathAndPhysics.Humanize());
Console.WriteLine(Book.Physics.Humanize());

Book bookType = "Self help".DehumanizeTo<Book>();
Console.WriteLine(bookType);
bookType = "The scary math categories".DehumanizeTo<Book>();
Console.WriteLine(bookType);

// date and time 
Console.WriteLine(DateTime.Now.AddDays(1).AddSeconds(1).Humanize());
Console.WriteLine(DateTime.Now.AddDays(0).AddSeconds(1).Humanize());
Console.WriteLine(DateTime.Now.AddDays(-1).Humanize());
Console.WriteLine(DateTime.Now.AddHours(3.5).Humanize());
Console.WriteLine(TimeSpan.FromHours(42).Humanize(2));
Console.WriteLine(new TimeOnly(15, 45).ToClockNotation());

// numeric
Console.WriteLine(7843.ToWords());
Console.WriteLine(7843.ToWords(false));
Console.WriteLine(7843.ToOrdinalWords());
Console.WriteLine(53.ToRoman());
Console.WriteLine("LII".FromRoman());

var size = 250.Gigabytes();
Console.WriteLine(size.Megabytes);
Console.WriteLine(size.Terabytes);
Console.WriteLine(size.Humanize());

size = (.25).Terabytes();
Console.WriteLine(size.Megabytes);
Console.WriteLine(size.Terabytes);
Console.WriteLine(size.Humanize());

Console.WriteLine(315d.ToHeading(HeadingStyle.Full));
Debug.Print(315d.ToHeadingArrow().ToString());

enum Book
{
    SelfHelp,
    SelfDestruction,
    [Description("The scary math categories")]
    MathAndPhysics,
    Physics
}


