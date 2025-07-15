using Mission.Entities.context;
using Mission.Entities.Entities;
using System;
using Mission.Repositories.IRepositories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mission.Entities.Models;

namespace Mission.Repositories.Repositories
{
    public class LoginRepositories(MissionDbContext missionDbContext): ILoginRepositories
    {
        private readonly MissionDbContext _missionDbContext = missionDbContext;
        public LoginUserResponseModel login(LoginUserRequestModel model)
        {
            var existingUser = _missionDbContext.Users.Where(x => x.EmailAddress.ToLower() == model.EmailAddress.ToLower() && !x.IsDeleted).FirstOrDefault();
            if (existingUser == null)
            {
                return new LoginUserResponseModel() { Message = "Email address Not found" };
            }
            if (existingUser.Password != model.Password)
            {
                return new LoginUserResponseModel() { Message = "Incorrect Password" };
            }
            return new LoginUserResponseModel()
            {
                Id = existingUser.Id,
                First_Name = existingUser.First_Name,
                Last_Name = existingUser.Last_Name,
                EmailAddress = existingUser.EmailAddress,
                PhoneNumber = existingUser.PhoneNumber,
                UserImage = existingUser.UserImage,
                UserType = existingUser.UserType,
                Message = "Login Successfully"
            };
        }
    }
}

//            var user = _missionDbContext.Users.Where(x => x.EmailAddress == EmailAddress && x.Password == Password).FirstOrDefault();
//            if (user == null)
//            {
//                return null;
//            }
//            return user;

//        }


//    }
//}
