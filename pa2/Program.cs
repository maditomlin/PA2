// menu
string userInput = GetMenuChoice();

while (userInput != "3"){
    RouteEm(userInput);
    userInput = GetMenuChoice();

}

static string GetMenuChoice(){
    DisplayMenu();
    return Console.ReadLine();
}

static void DisplayMenu(){
    System.Console.WriteLine("Make a selection:\n1. Unit Conversion App\n2. Bakery POS\n3. Exit");
}

static void RouteEm(string userInput){
    switch(userInput){
        case "1":
            UnitCon();
            break;
        case "2":
            PointOfSale();
            break;
        default:
            System.Console.WriteLine("Invaild Input");
            break;
    }
}
//unit conversion


static void UnitCon(){
    int number;
    System.Console.WriteLine("Please pick number for unit input type: \n 1.Tsp\n 2.Tbsp\n 3.Cup\n 4.Pint\n 5.Quart\n 6.Gallons");
    int currentMeasurement = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Please enter amount: ");
    number = int.Parse(Console.ReadLine());

    System.Console.WriteLine(UnitMeasurements);

//extra: conversions of everything to and from
    static void UnitMeasurements(double number, int currentMeasurement)
    {
        double tsp= 0;
        double tbsp = 0;
        double cup = 0;
        double pint = 0;
        double quart = 0;
        double gallon = 0;

        if (currentMeasurement == 1) {
//tsp
            tsp = number;
                tbsp = tsp * 0.333333;
                cup = tsp * 0.0208333;
                pint = tsp * 0.0104167;
                quart = tsp * 0.00520833;
                gallon = tsp * 0.00130208;

 System.Console.WriteLine("tsb conversions: " + gallon + quart + tsp + tbsp + cup + pint);
     
        }if (currentMeasurement == 2 ) {
//tbsp
            tbsp = number;
                tsp = tbsp * 3;
                cup = tbsp * 0.0625;
                pint = tbsp * 0.03125;
                quart = tbsp * 0.015625;
                gallon = tbsp * 0.00390625;
            System.Console.WriteLine(gallon + quart + tsp + tbsp + cup + pint);

        }if (currentMeasurement == 3) {
//cup       
            cup = number;
                tsp = cup * 48;
                tbsp = cup * 16;
                pint = cup * 0.5;
                quart = cup * 0.25;
                gallon = cup * 0.0625;

            System.Console.WriteLine(gallon + quart + tsp + tbsp + cup + pint);

        }if (currentMeasurement == 4) {
//pint
            pint = number;
                tsp = pint * 96;
                tbsp = pint * 32;
                cup = pint * 2;
                quart = pint * 0.5;
                gallon = pint * 0.125;
            System.Console.WriteLine(gallon + quart + tsp + tbsp + cup + pint);

        }if (currentMeasurement == 5) {
//quart
            quart = number;
                tsp = quart * 192;
                tbsp = quart * 64;
                cup = quart * 4;
                pint = quart * 2;
               gallon = quart * 0.25;
            System.Console.WriteLine(gallon + quart + tsp + tbsp + cup + pint);
        }if (currentMeasurement == 6) {
//gallon
        gallon = number;
                tsp = gallon * 768;
                tbsp = gallon * 256;
                cup = gallon * 16;
                pint = gallon * 8;
                quart = gallon * 4;
            System.Console.WriteLine(gallon + quart + tsp + tbsp + cup + pint);;
        }
    }
}

//bakery POS

static void PointOfSale(){
    double tax;
    double price;
    double cakes;
    double answer;
    double payment;
    double total;
    double tip;
    double toPay;
    System.Console.Write("Enter in number of cakes: ");
    cakes = int.Parse(Console.ReadLine());
    price = cakes * 28.63;
    tax = price * 0.07;
    System.Console.Write("Would you like delivery for $4.99 extra? type 1 for Yes or 2 for No: ");
    answer = int.Parse(Console.ReadLine());
    if (answer == 1){
        price = price + 4.99;
    }   else{
        price = price + 0;
    }
    System.Console.WriteLine($"You owe: {price + tax}");
    System.Console.WriteLine("");
    System.Console.WriteLine("Would you like to tip? 1 for Yes 2 for No");
     answer = int.Parse(Console.ReadLine());
    if (answer == 1){
        System.Console.WriteLine("Reccommended Tips Ammounts:\n 15%- "+ price * 0.15 + "\n 18%- " + price * 0.18 + "\n 20%- " + price * 0.20);
        tip = int.Parse(Console.ReadLine());
        total = price + tax + tip;
    } else{
        total = price + tax;
    }
    System.Console.WriteLine($"You owe: {total}, Please enter cash ammount:");
    //payment with to pay and cash back
            payment = int.Parse(Console.ReadLine());
            while (payment < total){
               toPay = total - payment;
               System.Console.WriteLine("You owe: " + toPay + " Please enter more cash!");

            }
            if (payment > total){
                 toPay = payment - total;
               System.Console.WriteLine("Your change is: " + toPay +". Thank you for shopping with us!");
            }else{
                System.Console.WriteLine("Thank you for shopping with us! Have a great day!");
            }
            System.Console.WriteLine("");
             System.Console.WriteLine("");
              System.Console.WriteLine("");
    }



