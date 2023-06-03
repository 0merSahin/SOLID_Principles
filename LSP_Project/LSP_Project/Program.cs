using SolidProject1_211229013.LSP_Classes;

namespace LSP_Project;
class Program
{
    static void Main(string[] args)
    {
        User_LSP_13 User4 = new User_LSP_13("Yusuf", 124, 360, 46096456, 4332, 11);
        User4.SetUserAndStartOrderService(User4);
        User4.OrderService.CreateOrder(4332);
    }
}
