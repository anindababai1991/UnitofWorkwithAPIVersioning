using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using InnovationApp.DAL;

namespace InnovationWebAPICore
{
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("api/userapi/v{ver:apiVersion}")]
    public class UserAPIController : Controller, IUserAPI
    {
        private IUserRepository userRepository;
        private UnitOfWork unitOfWork;

        public UserAPIController()
        {
            this.userRepository = new UserRepository(new Entity());
            this.unitOfWork = new UnitOfWork(new Entity());
        }

        [HttpGet]
        [ActionName("GetUsers")]
        public List<User> GetUsers()
        {
            List<User> _user = new List<User>();
            List<User> _userDal = new List<User>();

            _userDal = unitOfWork.UserRepo.GetUsers();

            // _userDal = userRepository.GetUsers();

            //Convert the dal model to model layer model and return
            foreach (var item in _userDal)
            {
                _user.Add(new User()
                {
                    Password = item.Password,
                    TemplateMasters = item.TemplateMasters,
                    UserId = item.UserId,
                    Username = item.Username,
                    UserRoles = item.UserRoles
                });
            }
            return _user;
        }
    }


    [Produces("application/json")]
    [ApiVersion("2.0")]
    [Route("api/userapi/v{ver:apiVersion}")]
    public class UserAPIControllerV2 : Controller, IUserAPI
    {
        private IUserRepository userRepository;
        private UnitOfWork unitOfWork;

        public UserAPIControllerV2()
        {
            this.userRepository = new UserRepository(new Entity());
            this.unitOfWork = new UnitOfWork(new Entity());
        }

        [HttpGet]
        [ActionName("GetUsers")]
        public List<User> GetUsers()
        {
            List<User> _user = new List<User>();
            List<User> _userDal = new List<User>();

            _userDal = unitOfWork.UserRepo.GetUsers();

            // _userDal = userRepository.GetUsers();

            //Convert the dal model to model layer model and return
            foreach (var item in _userDal)
            {
                _user.Add(new User()
                {
                    Username = item.Username,
                    UserRoles = item.UserRoles
                });
            }
            return _user;
        }
    }

}