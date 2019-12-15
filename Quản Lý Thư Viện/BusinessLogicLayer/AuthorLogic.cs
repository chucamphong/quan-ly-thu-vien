using DataAccessLayer.Data;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BusinessLogicLayer
{
    public class AuthorLogic
    {
        public static IEnumerable<object> GetAll()
        {
            using (var authorData = new AuthorData())
            {
                return authorData.GetAll()
                                 .Select(author => new { author.Id, author.Name })
                                 .ToList();
            }
        }

        public static IEnumerable<object> FindByName(string name)
        {
            using (var authorData = new AuthorData())
            {
                return authorData.Get(author => author.Name.Contains(name))
                                 .Select(author => new { author.Id, author.Name })
                                 .ToList();
            }
        }

        public static int Count()
        {
            using (var authorData = new AuthorData())
            {
                return authorData.Count();
            }
        }
    }
}
