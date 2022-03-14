//napises cisla
Console.WriteLine("napis prvni cislo");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("napis druhe cislo");
int b = Convert.ToInt32(Console.ReadLine());
//vypocita a vypise cisla
int c = Math.Min(a, b);
int d = Math.Max(a, b);
Console.WriteLine(c);
Console.WriteLine(d);
