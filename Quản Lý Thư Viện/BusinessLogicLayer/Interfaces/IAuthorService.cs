using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace BusinessLogicLayer
{
    internal interface IAuthorService
    {
        List<Author> FindByName(string name);
    }
}
