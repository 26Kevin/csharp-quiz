// QUIZ KEVIN
Console.Clear();
#nullable disable
// Welcome
Console.WriteLine("Welcome to the Marvel quiz");

// Input
bool loop1 = true;
while(loop1) {
    double counter1 = 0;
    double percent1 = 0;
    Console.WriteLine("\n1. What is spiderman  real full name?: ");
    Console.Write("Q1 Answer:");
    string answer1 = Console.ReadLine().ToLower();

    // Input
    if (answer1 == "peter parker") {
        Console.WriteLine("Correct");
        counter1 ++;
        percent1 ++;
    } else {
        Console.WriteLine("Incorrect");
    }
}


