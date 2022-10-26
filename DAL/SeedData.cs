using Logic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SeedData
    {
        public static void SeedDatabase(BlogContext context)
        {
            if (context.Posts.Count() == 0 && context.Users.Count() == 0 && context.Blogs.Count() == 0)
            {
                Blog b1 = new Blog {Url = "Нотатки про природу" };
                Blog b2 = new Blog { Url = "Нотатки про тварин" };
                Blog b3 = new Blog { Url = "Нотатки про  країни" };

                User u1  = new User { UserName = "Vasil", Password = "vasil@gmail.com", EnumRole = EnumRole.Admin };
                User u2 = new User { UserName = "Natasha", Password = "natasha@gmail.com", EnumRole = EnumRole.Admin };

                context.Posts.AddRange(
                                new Post
                                { 
                                    Title = "Македонія",
                                    Content = "Македонія - країна, розташована на півдні Балканського півострова.",
                                    PostedOn = DateTime.Now,
                                    UserId = u1.Id,
                                    BlogId = b3.BlogId

                                },
                                new Post
                                    {
                                        Title = "Дельфіни",
                                        Content = "Вчені висувають гіпотезу, що біломорді дельфіни викидаються на берег через інфекції і захворювання, що їх переслідують.",
                                        PostedOn = DateTime.Now,
                                        UserId = u1.Id,
                                        BlogId = b2.BlogId

                                    },
                                new Post
                                        {
                                            Title = "Птахи ",
                                            Content = "Вчені - орнітологи помітили дивний факт: у містах птахи почали співати ночами.",
                                            PostedOn = DateTime.Now,
                                            UserId = u1.Id,
                                            BlogId = b1.BlogId

                                        }


                                );
                context.SaveChanges();

            }
        }
    }
}
