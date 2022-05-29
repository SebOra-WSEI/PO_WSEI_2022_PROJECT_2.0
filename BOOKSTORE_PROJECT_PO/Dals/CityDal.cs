﻿using BOOKSTORE_PROJECT_PO.Dal_Models;
using BOOKSTORE_PROJECT_PO.Models;
using System.Collections.Generic;
using System.Linq;

namespace BOOKSTORE_PROJECT_PO
{
    internal class CityDal
    {
        private BookstoreDBEntities db = new BookstoreDBEntities();

        public IList<CityDalModelForSelector> getCityList =>  
            db.Cities.Select(
                city => new CityDalModelForSelector 
                { 
                    ID = city.ID, 
                    Name = city.CityName 
                }).ToList();

        public IList<CityDalModel> getCityNameList =>
            db.Cities.Select(
                city => new CityDalModel 
                { 
                    City = city.CityName 
                }).ToList();

        internal void Add( string city)
        {
            var newCity = new Cities()
            {
                CityName = city,
            };

            db.Cities.Add(newCity);
            db.SaveChanges();
        }
    }
}