using CommonLibraries.Interfaces;
using Microsoft.EntityFrameworkCore;
using Products.DBContext;
using Products.Models;
using System.Linq;
using System.Threading.Tasks;

namespace DataManager.Manager
{
    public class UserDetailsManager : IUserDetails
    {
        private readonly IDataUoW _dataUow;
        public UserDetailsManager(IDataUoW dataUow)
        {
            _dataUow = dataUow;
        }
        public async Task<dynamic> GetAllUserDetails()
        {
            var userDetailsData = await _dataUow.UserDetails.GetAll().ToListAsync();
            return userDetailsData;
        }
        public async Task<dynamic> DeleteUserDetails(UserDetails userDetails)
        {
            _dataUow.UserDetails.Delete(userDetails);
            await _dataUow.CommitAsync("");
            return "Success";
        }
        public async Task<dynamic> UpdateUserDetails(UserDetails userDetails)
        {
            _dataUow.UserDetails.Update(userDetails);
            await _dataUow.CommitAsync("");
            return "Success";
        }
        public async Task<dynamic> SaveUserDetails(UserDetails userDetails)
        {
            _dataUow.UserDetails.Add(userDetails);
            await _dataUow.CommitAsync("");
            return "Success";
        }
        public async Task<dynamic> GetUserDetailsById(long id)
        {
            var userDetailsData = await _dataUow.UserDetails.GetAllWithNoTracking().Where(p => p.UserDetailsId == id).FirstOrDefaultAsync();
            return userDetailsData;
        }


    }
}
