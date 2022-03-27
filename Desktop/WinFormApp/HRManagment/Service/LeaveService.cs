using HRManagment.Models;
using HRManagment.Repository;
using HRManagment.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace HRManagment.Service
{
    public class LeaveService
    {
        public LeaveRepository leaveRepository = new LeaveRepository();

        public (bool, string) ApplyForLeave(ApplyLeaveViewModel model)
        {
            try
            {
                //transform to model
                var leave = new Leave()
                {
                    From = model.From,
                    LeaveType = model.LeaveType,
                    Reason = model.Reason,
                    To = model.To,
                    UserId = Singleton.Instance.UserId
                };
                // pass to repository
                return leaveRepository.CreateLeave(leave);
            }
            catch (System.Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public List<AdminLeaveDetailsViewModel> GetAllList()
        {
            return leaveRepository.GetAll().Select(p => new AdminLeaveDetailsViewModel()
            {
                Id = p.Id,
                From = p.From,
                LeaveStatus = p.Status,
                LeaveType = p.LeaveType,
                Reason = p.Reason,
                To = p.To,
                UserName = p.UserInfo.Username
            }).ToList();
        }

        public (bool, string) ChangeLeaveStatus(int id, LeaveStatus leaveStatus)
        {
            return leaveRepository.ChangeLeaveState(id, leaveStatus);
        }
    }
}