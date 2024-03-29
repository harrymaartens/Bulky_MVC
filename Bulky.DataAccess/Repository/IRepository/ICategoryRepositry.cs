﻿using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ICategoryRepositry : IRepository<Category>
    {
        void Update(Category obj);        
    }
}
