using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment.Models
{
    public class Leave
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual UserInfo UserInfo { get; set; }

        public DateTime From { get; set; }
        public DateTime? To { get; set; }
        public string Reason { get; set; }
        public LeaveType LeaveType { get; set; }
        public LeaveStatus Status { get; set; }
    }

    public enum LeaveType
    {
        Casual,
        Force,
        Sick,
        Home,
    }

    public enum LeaveStatus
    {
        Pending,
        Accepted,
        Rejected
    }
}