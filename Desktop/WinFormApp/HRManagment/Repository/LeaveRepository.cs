using HRManagment.Context;
using HRManagment.Models;
using System;
using System.Linq;

namespace HRManagment.Repository
{
    public class LeaveRepository
    {
        private DefaultContext db = new DefaultContext();

        public (bool, string) CreateLeave(Leave leave)
        {
            try
            {
                db.Leaves.Add(leave);
                db.SaveChanges();
                return (true, "Added Successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public IQueryable<Leave> GetAll()
        {
            return db.Leaves;
        }

        public (bool, string) ChangeLeaveState(int id, LeaveStatus leaveStatus)
        {
            try
            {
                var existing = db.Leaves.FirstOrDefault(l => l.Id == id);
                if (existing == null)
                {
                    return (false, "Record not found");
                }
                else
                {
                    existing.Status = leaveStatus;
                    db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return (true, "Updated");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}