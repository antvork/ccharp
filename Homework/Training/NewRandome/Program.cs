//int ranNum = new Random().Next(3, 9);
//Console.WriteLine(rnd);
Random rnd = new Random();
for (uint ctr = 1; ctr <= 10; ctr++)
   Console.WriteLine($"{rnd.Next(),15:N0}"); // более развернутая запись
