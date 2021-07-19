using System;
using System.Collections.Generic;
using System.Text;
using LTCSDL.DAL.DTO;
using LTCSDL.DAL;

namespace LTCSDL.BLL
{
    public class CategoriesBLL
    {
        CategoriesDAL dal;
        public CategoriesBLL()
        {
            dal = new CategoriesDAL();
        }

        public void selectAll(out string msg)
        {
            dal.selectAll(out msg);
        }

        public int delete(int id, out string msg)
        {
            int res = dal.delete(id, out msg);
            return res;
        }

        public int update(int id, string name, out string msg)
        {
            int res = dal.update(id, name, out msg);
            return res;
        }

        public int insert(string name, string description, out string msg)
        {
            int res = dal.insert(name, description, out msg);
            return res;
        }

        public CategoriesDTO getCategoryById(int id, out string msg)
        {
            CategoriesDTO res = new CategoriesDTO();
            res = dal.getCategoryById(id, out msg);
            return res;
        }
    }
}
