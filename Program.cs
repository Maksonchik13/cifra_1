Console.WriteLine("введите катет ");
double kat=double.Parse(Console.ReadLine());
Console.WriteLine("Введите гипотенузу ");
double git=double.Parse(Console.ReadLine());
double kat_2 = Math.Sqrt(git * git - kat * kat);
Console.WriteLine($"Второй катет = {kat_2:f2}");