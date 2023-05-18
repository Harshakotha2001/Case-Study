﻿
using On_DemandCarWash.Model;

namespace On_DemandCarWash.Interface
{
    public interface IAdmin
    {
        List<Admin> GetAllAdmin();
        Admin GetAdmin(int id);
        public string AddAdmin(Admin admin);
        public string UpdateAdmin(Admin admin);
        public string DeleteAdmin(int id);
    }
}

