namespace RegexDemo
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("please enter the name");
            string name = Console.ReadLine();
            Email email = new Email();
            bool val = email.ValidateEmail(name);
            if (val)
            {
                Console.WriteLine("Mathed");
            }
            else
            {
                Console.WriteLine(" not Mathed");

            }
        }
    }
}
