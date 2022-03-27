using HRManagment.Models;
using System;

namespace HRManagment.ViewModels
{
    public class ApplyLeaveViewModel
    {
        public int Id { get; set; }
        public DateTime From { get; set; }
        public DateTime? To { get; set; }
        public string Reason { get; set; }
        public LeaveType LeaveType { get; set; }
    }
}