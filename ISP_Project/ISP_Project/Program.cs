using SolidProject1_211229013.ISP_Classes;

namespace ISP_Project;
class Program
{
    static void Main(string[] args)
    {
        User_ISP_13 User5 = new User_ISP_13("Yusuf", 124, 360, 46096456, 4332, 11);
        User5.SetUserAndStartOrderService(User5);
        User5.OrderService.CreateOrder(4332);
    }
}
