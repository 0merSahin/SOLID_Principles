namespace SRP_Project;
using SRP_Project.SRP_Classes;

class Program
{
    static void Main(string[] args)
    {
        // SRP:
        User_SRP_13 User2 = new User_SRP_13("Veli", 223, 200, 46096288, 4589, 103);
        User2.SetUserAndStartOrderService(User2);
        User2.OrderService.CreateOrder(4589);
    }
}

