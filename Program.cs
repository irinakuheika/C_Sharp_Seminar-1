Console.WriteLine("Введите число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberA > numberB){
    Console.WriteLine("Число А (" + numberA + ") больше числа В (" + numberB + ")");
}
else {
    Console.WriteLine("Число B (" + numberB + ") больше числа A (" + numberA + ")");
}