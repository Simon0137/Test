namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            using (AppContext db = new AppContext())
            {
                User user1 = new User() { Name = "George", Age = 27, Id = 1 };
                User user2 = new User() { Name = "Michael", Age = 31, Id = 2 };
                db.Users.Add(user1);
                Console.WriteLine("OK5");
                db.Users.Add(user2);
                Console.WriteLine("OK6");
                db.SaveChanges();
                Console.WriteLine("Data saved");
            }
        }
    }
}