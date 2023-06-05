using SolidProject1_211229013.DIP_Classes;

namespace DIP_Project;
class Program
{
    static void Main(string[] args)
    {
        User_DIP_13 User7 = new User_DIP_13("MEhmet", 124, 360, 46096456, 4332, 372);
        User7.SetUserAndStartOrderService(User7);
        User7.OrderService.CreateOrder(4332);
    }
}

