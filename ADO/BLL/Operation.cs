
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using DAL;

namespace BLL
{


    public class Operation
    {


        public DataTable GetData()
        {
            try
            {
                DataDAL dataTable = new DataDAL();
                DataTable Alldata = dataTable.ReadData();
                int temp;
                Random rnd = new Random();
                int count = Alldata.Rows.Count;
                temp = rnd.Next(count);
                DataTable data = new DataTable();
                data = Alldata.Clone();

                data.ImportRow(Alldata.Rows[temp]);

                for (int i = 1; i < 10; i++)
                {

                    temp = rnd.Next(count);
                    DataRow x = Alldata.Rows[temp];
                    while (IsDup((int)x["Id"], data))
                    {
                        temp = rnd.Next(count);

                    }
                    data.ImportRow(Alldata.Rows[temp]);


                }
                return data;
            }
            catch
            {
                throw;
            }

        }

        public static bool IsDup(int id, DataTable data)
        {
            foreach (DataRow row in data.Rows)
            {
                if (id == (int)row["Id"])
                {
                    return true;
                }
            }
            return false;

        }


    }
}
