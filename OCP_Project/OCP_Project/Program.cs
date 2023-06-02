using SolidProject1_211229013.OCP_Classes;

namespace OCP_Project;
class Program
{
    static void Main(string[] args)
    {
        User_OCP_13 User3 = new User_OCP_13("Ömer", 224, 150, 46096289, 6666, 123);
        User3.SetUserAndStartOrderService(User3);
        User3.OrderService.CreateOrder(6666);
    }
}
