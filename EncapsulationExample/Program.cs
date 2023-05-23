using EncapsulationExample;

var seth = new Person();

Console.WriteLine(seth.Name);
seth.Age = 29;

Console.WriteLine("Money in wallet:");
var amountInWallet = seth.CheckWallet();
Console.WriteLine(amountInWallet);

Console.WriteLine("Adding money..");
seth.AddMoney(500);
amountInWallet = seth.CheckWallet();
Console.WriteLine("Money in wallet:");
Console.WriteLine(amountInWallet);

Console.WriteLine("Adding money..");
seth.AddMoney(1000);
amountInWallet = seth.CheckWallet();
Console.WriteLine("Money in wallet:");
Console.WriteLine(amountInWallet);


