﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTL.DataAccess;
using GTL.Models;


namespace GTL.Controllers
{
    public class AuthorController : IController
    {
        public IDataAccess DataAccess { get; }

        public AuthorController(IDataAccess dataAccess)
        {
            this.DataAccess = dataAccess;
        }

        public virtual IModel Get(params int[] id)
        {
            Author a = null;

            a = (Author)DataAccess.Get(id);

            return a;
        }

        public virtual IModel Get(params string[] id)
        {
            throw new NotImplementedException();
        }

        public ICollection<IModel> GetAll(int amount, int offset)
        {
            throw new NotImplementedException();
        }


        // return created object
        public Author Create()
        {
            throw new NotImplementedException();

            // Instantiate variables


            // Check if objects exists and requirements have been met.


            // Get object from model factory


            // Create additional objects if needed


            // Assign additional variables if needed


            // Insert into the database

            // return created object
        }
    }
}
