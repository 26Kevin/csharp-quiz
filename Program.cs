// QUIZ KEVIN
Console.Clear();
#nullable disable
// Welcome
Console.WriteLine("Welcome to the Marvel quiz");


    double counter = 0;
    double percent = 0;
    Console.WriteLine("\n1. What is spiderman  real full name?: ");
    Console.Write("Q1 Answer:");
    string answer1 = Console.ReadLine().ToLower();

    
    if (answer1 == "peter parker") {
        Console.WriteLine("Correct");
        counter ++;
        percent +=25;
    } else {
        Console.WriteLine("Incorrect");
    }

    
    Console.WriteLine("\n2. What was the first MCU Movie created?: ");
    Console.Write("Q2 Answer:");
    string answer2 = Console.ReadLine().ToLower();

    if (answer2 == "iron man") {
        Console.WriteLine("Correct");
        counter ++;
        percent +=25;
    } else {
        Console.WriteLine("Incorrect");
    }

    
    Console.WriteLine("\n3. What is Captain America's shield made of?: ");
    Console.Write("Q3 Answer:");
    string answer3 = Console.ReadLine().ToLower();

    if (answer3 == "vibranium") {
        Console.WriteLine("Correct");
        counter ++;
        percent +=25;
    } else {
        Console.WriteLine("Incorrect");
    }

    
    Console.WriteLine("\n4. What is Iron Man's real name?: ");
    Console.Write("Q4 Answer:");
    string answer4 = Console.ReadLine().ToLower();

    if (answer4 == "tony stark") {
        Console.WriteLine("Correct");
        counter ++;
        percent +=25;
    } else {
        Console.WriteLine("Incorrect");
    }

    // Process 
Console.WriteLine("\nYOUR RESULTS:");
Console.WriteLine($"{counter}/4 (${percent}%)");
if (counter > 2 && percent > 50) {
    Console.WriteLine("Good Job");
} else {
    Console.WriteLine("You need to study");
}




