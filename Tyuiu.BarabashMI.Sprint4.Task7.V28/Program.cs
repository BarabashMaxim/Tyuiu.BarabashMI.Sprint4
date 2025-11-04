using Tyuiu.BarabashMI.Sprint4.Task7.V28.Lib;
string str = "623351179845632";
DataService ds = new DataService();
int res = ds.Calculate(5, 3, str);
Console.WriteLine(res);