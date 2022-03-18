using HRManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagment
{
    //1. Private constructor
    //2. It has a property of its own which is checked null and return its instace accordingly
    public class Singleton
    {
        #region Singleton Definition

        private Singleton()
        {
        }

        private static Singleton instance = null;

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        #endregion Singleton Definition

        #region Properties

        public bool IsLoggedIn { get; set; }
        public string Username { get; set; }
        public UserType UserType { get; set; }

        public delegate void UserChange();

        public event UserChange UserChangeEvent;

        public void ApplyUserChange()
        {
            UserChangeEvent?.Invoke();
        }

        #endregion Properties
    }
}