// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("歡迎使用BMI計算器");
        Console.Write("請輸入您的體重（公斤）：");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("請輸入您的身高（公分）：");
        double height = Convert.ToDouble(Console.ReadLine()) / 100; // 身高轉換為米
        double bmi = CalculateBMI(weight, height);
        Console.WriteLine($"您的BMI是：{bmi:F2}");
    }

    static double CalculateBMI(double weight, double height)
    {
        return weight / (height * height);
    }
}
