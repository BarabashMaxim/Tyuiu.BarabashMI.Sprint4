using Tyuiu.BarabashMI.Sprint4.Task6.V2.Lib;
DataService ds = new DataService();
string[] ar = { "Белый", "Чёрный", "Зелёный", "Синий", "Красный", "Жёлтый", "Фиолетовый" };
string[] res = ds.Calculate(ar);
foreach (string s in res)
{ 
    Console.WriteLine(s);
}