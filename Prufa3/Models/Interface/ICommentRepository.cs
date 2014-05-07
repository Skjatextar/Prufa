using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prufa3.Models.Entity;

namespace Prufa3.Models.Interface
{
    interface ICommentRepository
    {
        IQueryable<Comment> GetComments();
    }
}
