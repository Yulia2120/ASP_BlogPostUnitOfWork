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

                Account u1  = new Account { UserName = "Vasil", Password = "vasil@gmail.com", EnumRole = EnumRole.Admin };
                Account u2 = new Account { UserName = "Natasha", Password = "natasha@gmail.com", EnumRole = EnumRole.Admin };

                context.Posts.AddRange(
                                new Post
                                { 
                                    Title = "Македонія",
                                    Content = "Македонія - країна, розташована на півдні Балканського півострова.",
                                    PostedOn = DateTime.Now,
                                    //User = u1,
                                    //Blog = b3

                                },
                                new Post
                                    {
                                        Title = "Дельфіни",
                                        Content = "Вчені висувають гіпотезу, що біломорді дельфіни викидаються на берег через інфекції і захворювання, що їх переслідують.",
                                        PostedOn = DateTime.Now,
                                        //User = u1,
                                        //Blog = b2

                                    },
                                new Post
                                        {
                                            Title = "Птахи ",
                                            Content = "Вчені - орнітологи помітили дивний факт: у містах птахи почали співати ночами.",
                                            PostedOn = DateTime.Now,
                                            //User = u2,
                                            //Blog = b1

                                        }


                                );
                context.SaveChanges();

            }
        }
    }
}
