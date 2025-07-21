
//Definition of variables
int pricepersmall = 25;
int priceperlarge = 35;
double taxprecentage = 6;
//Get the number of small rooms from the user
Console.WriteLine(" welcome Islam's Carpet Cleaning Service \n __please enter the number of small room");
int numofsmallroom = int.Parse(Console.ReadLine());
Console.WriteLine($"#_number of small room is  {numofsmallroom} \n ^^price per small room {pricepersmall}$\n");
//Get the number of large rooms from the user
Console.WriteLine("__please enter the number of large room");
int numoflargeroom = int.Parse(Console.ReadLine());
Console.WriteLine($"#_number of large room is  {numoflargeroom} \n ^^price per large room {priceperlarge}$\n");
//calculate price of small and large rooms
int calcsmall = pricepersmall * numofsmallroom;
int calclarge = priceperlarge * numoflargeroom;
int cost = calcsmall + calclarge;
Console.WriteLine($"total amount without tax = {cost}$\n");
//calculate tax 
double tax = cost * taxprecentage / 100;
Console.WriteLine($"tax = {tax}$");
Console.WriteLine("=================================");
//calculate total amount
double Totalestimate = cost + tax;
Console.WriteLine($"Totalestimate = {Totalestimate}");
Console.WriteLine("This estimate is valid for 30 days\n Thanks for using Islam's Carpet Cleaning Service");











