using BIT.Joseph.Udoka.Models;
    
namespace BIT.Joseph.Udoka
{
    public class BITJosephUdoka
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the height of the Triangle");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("This is the height of the triangle: " + h);

            Console.WriteLine("Input the base of the Triangle");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("This is the base of the triangle: " + b);


            double area = Area.AreaOfTriangle(b, h);

            Console.WriteLine("The area of a triangle is: " + area);

            Console.WriteLine("Welcome to the User Entities program ");
            Console.WriteLine("Please follow the prompt and correctly enter the required data");

            List<User> userList = new List<User>();
            Console.WriteLine("Please enter in the following order: ID, first Name" +
                    "Last Name and Email");

            for (int i = 0; i < 5; i++)
            {
                User newUser = new User()
                {
                    id = Convert.ToInt32(Console.ReadLine()),
                    firstName = Console.ReadLine(),
                    lastName = Console.ReadLine(),
                    Email = Console.ReadLine()
                };

                userList.Add(newUser);

                Console.WriteLine("Id: " + userList[i].id + ", First Name: "
                   + userList[i].firstName + ", Last Name: " + userList[i].lastName
                   + ", Email" + userList[i].Email);
            }

            List<Payments> paymentList = new List<Payments>();
            Console.WriteLine("Please enter in the following order: userID, payerID and Amount");

            for (int i = 0; i < 15; i++)
            {
                Payments newPayment = new Payments()
                {
                    userID = Convert.ToInt32(Console.ReadLine()),
                    payerID = Convert.ToInt32(Console.ReadLine()),
                    Amount = Convert.ToDecimal(Console.ReadLine())
                };

                paymentList.Add(newPayment);

                Console.WriteLine("userID: " + paymentList[i].userID + ", payerID: "
                   + paymentList[i].payerID + ", Last Name: " + paymentList[i].Amount);
            }

            for (int i = 0; i < userList.Count; i++)
            {
                Console.WriteLine("Id: " + userList[i].id + ", First Name: "
                  + userList[i].firstName + ", Last Name: " + userList[i].lastName
                  + ", Email" + userList[i].Email);
            }

            for (int i = 0; i < paymentList.Count; i++)
            {
                Console.WriteLine("userID: " + paymentList[i].userID + ", payerID: "
                + paymentList[i].payerID + ", Last Name: " + paymentList[i].Amount);

            }


        }
    }
}