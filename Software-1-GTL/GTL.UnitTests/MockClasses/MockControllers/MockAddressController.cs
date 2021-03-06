﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTL.Models;
using GTL.Controllers;
using GTL.DataAccess;

namespace GTL.UnitTests.MockClasses.MockControllers
{
    public class MockAddressController : AddressController
    {
        public MockAddressController(IDataAccess dataAccess) : base(dataAccess)
        {
        }

        public IModel Get(params int[] id)
        {
            throw new NotImplementedException();
        }

        public IModel Get(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<IModel> GetAll(int amount, int offset)
        {
            throw new NotImplementedException();
        }

        public new Address Create(string zip, string city, string streetName, string streetNr, int floorNr = -1, string aptNr = "", string phoneNr = "")
        {
            Address result = new Address()
            {
                Zip =zip,
                City = city,
                StreetName = streetName,
                StreetNr = streetNr,
                FloorNr = floorNr,
                AptNr = aptNr,
                PhoneNr = phoneNr
            };

            return result;
        }
    }
}
