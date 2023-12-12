// Name: Elizabeth Trotter

// Date Revised: 9/15/2023

// Exercise: Mini Challenge # 9 - Restaurant Picker 

// Brief Description: Displays Randomly Generated Restaurant
// Must have at least 3 categories & 10 restaurants per category + Allow user to choose category

// Peer Reviewer: Jared Ly
// Peer Comments: Code works great, the spacing is very nice making it easy to read

Console.Clear();

string title = "Mini Challenge # 9 - Restaurant Picker";
Console.WriteLine(title);
string breakPoint = "---------------------------------------";
Console.WriteLine(breakPoint);

Console.WriteLine("INSTRUCTIONS: Pick one of the 3 food categories, and I will then choose a random restaurant for you.");
Console.WriteLine(breakPoint);
Console.WriteLine("There are so many options! But for now, we will stick to either pizza, sushi, or burgers.");

string[] pizzaCategory = { "Dominoes", "Mountain Mikes", "Costco Pizza", "Pizza Hut", "Papa Johns", "Little Cesears", "Dante's Pizza & Cafe", "Round Table", "Blaze Pizza", "Pieology" };
string[] sushiCategory = { "Sushi Kinoya", "Shogun", "Shirasoni", "Domo Sushi Grill", "Sushi Villa Buffet", "ShoMi Japanese Cuisine", "Hana Sushi", "Toyo Sushi", "Matsuyama", "Sushi Hub"};
string[] burgersCategory = { "In N Out", "The Habit", "Five Star Burger", "Moo Moo's Burger Barn", "Squeeze Burger and Brew", "Carl's Jr.", "Wendy's", "Burger King", "Five Guys", "Jack in the Box"};

void Function(string restaurant){
    Console.WriteLine(breakPoint); 
    Console.WriteLine($"Hmm... I recommend you have {restaurant} today!");
}

bool success = true;
while (success)
{
    Random number = new Random();
    int numberRestaurant = number.Next(0, 10); //Max number is NOT included
    Console.WriteLine(breakPoint);
    Console.Write("Enter your selection (pizza, sushi, or burgers): ");
    string? userChoice = Console.ReadLine()?.ToLower();
    if (userChoice == "pizza")
    {
        Function(pizzaCategory[numberRestaurant]);
        success = false;
    }
    else if (userChoice == "sushi")
    {
        Function(sushiCategory[numberRestaurant]);
        success = false;
    }
    else if (userChoice == "burgers")
    {
        Function(burgersCategory[numberRestaurant]);
        success = false;
    }
    else
    {
        Console.WriteLine("Sorry I didn't get that...");
    }

    bool formatAns = true;
    while (success == false && formatAns)
    {
        Console.WriteLine(breakPoint);
        Console.WriteLine("Would you like to try again? (Enter yes or no)");
        string? playerAns = Console.ReadLine()?.ToLower();
        if (playerAns == "yes")
        {
            success = true;
            formatAns = false;
        }
        else if (playerAns == "no")
        {
            success = false;
            formatAns = false;
            Console.WriteLine("Have a good day!");
            Console.WriteLine(breakPoint);
        }
        else
        {
            Console.WriteLine(breakPoint);
            Console.WriteLine("I didn't get that...");
        }
    }
}
