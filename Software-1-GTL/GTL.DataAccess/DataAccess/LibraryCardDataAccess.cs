﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTL.Models;

namespace GTL.DataAccess
{
    public class LibraryCardDataAccess : IDataAccess
    {
        public object Action(string actionName, params object[] args)
        {
            throw new NotImplementedException();
        }

        public IModel Get(params int[] id)
        {
            throw new NotImplementedException();
        }

        public IModel Get(params string[] id)
        {
            throw new NotImplementedException();
        }
        public ICollection<IModel> GetAll(int amount, int offset)
        {
            throw new NotImplementedException();
        }
        public IModel Insert(IModel model)
        {
            LibraryCard lc, newLc = (LibraryCard)model;

            newLc.Member = null;

            using (var context = new GTL_Entities())
            {
                lc = context.LibraryCards.Add(newLc);
                context.SaveChanges();
            }

            return lc;

        }
    }
}
