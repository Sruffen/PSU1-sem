﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTL.Models;

namespace GTL.DataAccess
{
    public interface IDataAccess
    {
        IModel Get(params int[] id);

        IModel Get(string id);

        IModel Insert(IModel model);

        object Action(string actionName, params object[] args);
    }
}