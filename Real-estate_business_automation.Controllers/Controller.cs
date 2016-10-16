using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Real_estate_business_automation.Repositories;
using Real_estate_business_automation.Entities;
using System.Data.SqlClient;

namespace Real_estate_business_automation.Controllers
{
    public static class Controller 
    {
        #region Fields

        private static string _connectionstring;
        private static User _currentUser;

        private static List<District> _districtsList;

        private static EstateRepository _repEstate;
        private static PersonRepository _repPerson;
        private static DistrictRepository _repDistrict;
        private static UserRepository _repUser;
        private static ContractRepository _repConract;

        #endregion
        static Controller()
        {
            Rooms = new Dictionary<string, int>()
            {
                {"rooms", 0 },
                {"1 room", 1},
                {"2 rooms", 2},
                {"3 rooms", 3 },
                {"4 rooms", 4 },
                {"5 rooms", 5 },
                {"6 rooms", 6 }
            };

            _currentUser = null;
        }

        public static void Initialize(string connectionstring)
        {
            _connectionstring = connectionstring;

            _repEstate = new EstateRepository(_connectionstring);
            _repPerson = new PersonRepository(_connectionstring);
            _repDistrict = new DistrictRepository(_connectionstring);
            _repUser = new UserRepository(_connectionstring);
            _repConract = new ContractRepository(_connectionstring);

            _districtsList = _repDistrict.GetAllDistricts();
        }

        #region Properties

        public static IEnumerable<District> DistrictsList
        {
            get
            {
                return _districtsList;
            }
        }

        public static User CurrentUser
        {
            get
            {
                return _currentUser;
            }
        }
        public static Dictionary<string, int> Rooms { get; set; }
        #endregion





        #region PropertyModelMethods

        public static IEnumerable<PropertyViewModel> GetAllPropertyViewModels()
        {
            var list = new List<PropertyViewModel>();
            var set = _repEstate.GetAll().Where((item) =>
                {
                    return item.Rent == true || item.Sale == true;
                });


            foreach (var estate in set)
            {
                var model = new PropertyViewModel();
                model.Estate = estate;
                model.District = estate.DistrictId == null ? null : _repDistrict.GetDistrictById((int)estate.DistrictId);
                model.Owner = _repPerson.GetPersonByID(estate.OwnerId);

                list.Add(model);
            }

            return list;
        }

        public static PropertyViewModel GetModelByEstateId(int id)
        {
            var result = new PropertyViewModel();

            result.Estate = _repEstate.GetEstateById(id);
            result.Owner = _repPerson.GetPersonByID(result.Estate.OwnerId);
            result.District = result.Estate.DistrictId == null ? null : _repDistrict.GetDistrictById((int)result.Estate.DistrictId);

            return result;
        }
        public static bool DeleteModelByEstateId(int id)
        {
            return _repPerson.Delete(_repEstate.Delete(id));
        }

        public static bool AddModel(PropertyViewModel model)
        {
            model.Estate.OwnerId = _repPerson.Add(model.Owner);
            return _repEstate.Add(model.Estate);
        }

        public static bool UpdateByModel(PropertyViewModel model)
        {
            _repPerson.Update(model.Owner);
            _repEstate.Update(model.Estate);

            return true;
        }
        #endregion




        #region ArchiveModelMethods

        public static IEnumerable<PropertyArchiveModel> GetAllPropertyArchiveModel()
        {
            var result = new List<PropertyArchiveModel>();
            var archive = _repConract.GetAll();

            foreach (var contract in archive)
            {
                var model = new PropertyArchiveModel();

                model.Customer = _repPerson.GetPersonByID(contract.CustId);
                model.Employee = _repPerson.GetPersonByID(contract.EmpId);
                model.Estate = _repEstate.GetEstateById(contract.EstateId);
                model.District = model.Estate.DistrictId == null?null: _repDistrict.GetDistrictById((int)model.Estate.DistrictId);
                model.Owner = _repPerson.GetPersonByID(model.Estate.OwnerId);
                model.Date = contract.Date;

                result.Add(model);
            }

            return result;
        }


        public static bool AddContractToArchive(Contract contract)
        {
             _repConract.Add(contract);

            var archiveestate = _repEstate.GetEstateById(contract.EstateId);
            archiveestate.Rent = archiveestate.Sale = false;

            return _repEstate.Update(archiveestate);
        }

        #endregion


        public static int AddPerson(Person person)
        {
            return _repPerson.Add(person);
        }

        public static bool Login (string login, string password)
        {
            _currentUser = _repUser.GetUserByLogin(login, HashService.getMd5Hash(password));

            return _currentUser != null;
        }


    }
}
