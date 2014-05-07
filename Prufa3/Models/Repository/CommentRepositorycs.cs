﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Prufa3.Models.Interface;

namespace Prufa3.Models.Repository
{
    public class CommentRepositorycs : ICommentRepository
    {
        private SubDataContext _context;

        public IQueryable<Models.Entity.Comment> GetComments()
        {
            return _context.Comments;
        }
    }
}