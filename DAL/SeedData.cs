using Logic.Domain;

namespace DAL
{
    public class SeedData
    {
        public static void SeedDatabase(BlogContext context)
        {

            context.Database.EnsureCreated();
            if (context.Posts.Count() == 0 && context.Accounts.Count() == 0 && context.Blogs.Count() == 0)
            {
                Blog b1 = new Blog { Url = "Нотатки про природу" };
                Blog b2 = new Blog { Url = "Нотатки про тварин" };
                Blog b3 = new Blog { Url = "Нотатки про  країни" };
                context.Blogs.AddRange(b1, b2,b3);
             
                Account u1  = new Account { UserName = "Vasil", Email = "vasil@gmail.com", Password = "12345", EnumRole = EnumRole.Admin };
                Account u2 = new Account { UserName = "Natasha", Email = "natasha@gmail.com", Password = "123", EnumRole = EnumRole.User };
                context.Accounts.AddRange(u1, u2);

                context.Posts.AddRange(
                                new Post
                                { 
                                    Title = "Македонія",
                                    Content = "Македонія - країна, розташована на півдні Балканського півострова.",
                                

                                  

                                },
                                new Post
                                    {
                                        Title = "Дельфіни",
                                        Content = "Вчені висувають гіпотезу, що біломорді дельфіни викидаються на берег через інфекції і захворювання, що їх переслідують.",
                                     
                                    

                                    },
                                new Post
                                        {
                                            Title = "Птахи ",
                                            Content = "Вчені - орнітологи помітили дивний факт: у містах птахи почали співати ночами.",
                                         
                                         

                                        }


                                );
                context.SaveChanges();

            }
        }
    }
}
