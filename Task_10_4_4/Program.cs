namespace Task_10_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Account account = new Account();

            UserService<User> service = new UserService<User>();
            service.Update(account);
            
            
        }
    }
    public class User { }

    public class Account : User { }
    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    public class UserService<User> : IUpdater<User>
    {
        public void Update(User entity)
        {
            Console.WriteLine(entity.GetType().Name);
        }
    }
}