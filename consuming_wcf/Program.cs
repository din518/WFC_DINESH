static void Main(string[] args)
{
ServiceReference1.ServiceClient objService = new ServiceClient();
Console.WriteLine("Please Enter your Name");
string Message = objService.SampleMethod(Console.ReadLine());
Console.WriteLine(Message);
Console.ReadLine();
}