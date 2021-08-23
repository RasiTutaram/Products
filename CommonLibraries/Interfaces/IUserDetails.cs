using Products.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibraries.Interfaces
{
    public interface IUserDetails
    {
        Task<dynamic> GetAllUserDetails();
        Task<dynamic> GetUserDetailsById(long id);
        Task<dynamic> SaveUserDetails(UserDetails userDetails);
        Task<dynamic> UpdateUserDetails(UserDetails userDetails);
        Task<dynamic> DeleteUserDetails(UserDetails userDetails);

    }

}
