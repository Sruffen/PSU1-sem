﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTL.Models;

namespace GTL.DataAccess
{
    public class LoanDataAccess : IDataAccess
    {
        public object Action(string actionName, params object[] args)
        {
            object result;

            switch (actionName.ToLower())
            {

                default:
                    throw new ArgumentException("No action found with the name " + actionName);
            }

            return result;
        }

        public IModel Get(params int[] id)
        {
            // TODO implement properly

            throw new NotImplementedException();
        }

        public IModel Get(string id)
        {
            throw new NotImplementedException();
        }

        public IModel Insert(IModel model)
        {
            // TODO not implemented. Stub.

            return model;
        }
    }
}