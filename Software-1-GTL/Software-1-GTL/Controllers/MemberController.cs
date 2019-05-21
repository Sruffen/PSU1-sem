﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTL.Models;
using GTL.DataAccess;
using GTL.Factories;

namespace GTL.Controllers
{
    public class MemberController : IController
    {

        public IDataAccess DataAccess { get;}

        public MemberController(IDataAccess dataAccess)
        {
            this.DataAccess = dataAccess;
        }

        public virtual IModel Get(params int[] id)
        {
            IModel m = null ;

            m = DataAccess.Get(id);

            return m;
        }

        public virtual IModel Get(string id)
        {
            throw new NotImplementedException();
        }

        public ICollection<IModel> GetAll(int amount, int offset)
        {
            throw new NotImplementedException();
        }
        

        // return created object
        public Member Create(int ssn, string firstName, string lastName, string mobileNr, Address campusAdr, Address homeAdr, MemberType memberType)
        {
            LibraryCardController libCardCtr = (LibraryCardController)FactoryController.Instance.Create("libraryCard");

            DateTime dateCreated = DateTime.UtcNow;


            // Check if objects exists and requirements have been met.
            if (DataAccess.Get(ssn) != null)
                throw new Exception("Member already exists");


            // Get object from model factory
            Member m = FactoryModels.CreateMember(ssn, firstName, lastName, mobileNr, campusAdr, homeAdr, memberType, dateCreated);


            // Create additional objects if needed
            LibraryCard libCard = libCardCtr.Create();


            // Assign additional variables if needed
            m.LibraryCards.Add(libCard);
            m.IsActive = true;


            // Insert into the database
            m = (Member)DataAccess.Insert(m);

            // return created object
            return m;
        }
    }


    // Instantiate variables


    // Check if objects exists and requirements have been met.


    // Get object from model factory


    // Create additional objects if needed


    // Assign additional variables if needed


    // Insert into database


    // return created object
}
