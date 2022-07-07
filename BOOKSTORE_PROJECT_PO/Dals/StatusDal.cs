using BOOKSTORE_PROJECT_PO.Dal_Models.StatusModels;
using BOOKSTORE_PROJECT_PO.Models;
using System.Collections.Generic;
using System.Linq;


namespace BOOKSTORE_PROJECT_PO.Dals
{
    internal class StatusDal
    {
        private BookstoreDBEntities db = new BookstoreDBEntities();

        public IList<StatusDalModelForSelector> getStatusList =>
            db.Status.Select
            (
                status => new StatusDalModelForSelector
                {
                    ID = status.ID,
                    Name = status.StatusName,
                }).ToList();

        public IList<StatusDalModel> getCStatusList =>
           db.Status
               .Select(status => new StatusDalModel
               {
                   Status = status.StatusName,
               }).ToList();
    }
}
