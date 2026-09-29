
//PrintDelegate del1 = delegate ()
//{
//    Console.WriteLine("PrintDelegate Instance Called");
//};

//using lambda expression

//PrintDelegate del1 =  () => 
//{
//    Console.WriteLine("PrintDelegate Instance Called");
//};

//single line lambda expression 

PrintDelegate del1 = () => Console.WriteLine("PrintDelegate Instance Called");

FullNameDel del2 = (fn,  ln) =>
             fn + " " + ln;


string result = del2("avi", "linge");
Console.WriteLine(result);

AddDelegate del3 = (a, b) => Console.WriteLine($"{a} + {b} = {a + b}");

del3(10, 20);

AdditionDelegate del4 = (a, b) => a + b;
Console.WriteLine($"Addition Delegate : {del4(10, 7)}");







Console.ReadLine();