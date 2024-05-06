using Starbuzz;

Beverage myDrink;

myDrink= new Espresso();
Console.WriteLine(myDrink.WriteOrder());

myDrink = new Espresso();
myDrink = new CaramelShot(myDrink);
Console.WriteLine(myDrink.WriteOrder());

myDrink = new Latte();
myDrink = new SoyaMilk(myDrink);
Console.WriteLine(myDrink.WriteOrder());

myDrink = new Latte();
myDrink = new SoyaMilk(myDrink);
myDrink = new CaramelShot(myDrink);
Console.WriteLine(myDrink.WriteOrder());

myDrink = new Latte();
myDrink = new OatMilk(myDrink);
Console.WriteLine(myDrink.WriteOrder());

myDrink = new Latte();
myDrink = new SkimmedMilk(myDrink);
Console.WriteLine(myDrink.WriteOrder());

myDrink = new Latte();
myDrink = new SkimmedMilk(myDrink);
myDrink = new CaramelShot(myDrink);
Console.WriteLine(myDrink.WriteOrder());