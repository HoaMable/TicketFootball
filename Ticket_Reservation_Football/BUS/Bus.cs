using System.Data;
using DAL;
using DTO;
namespace BUS
{
    public class Bus
    {
        Dal da = new Dal();
        Dto L = new Dto();
        public DataTable ShowDrink()
        {
            string sql = "Select * from NameRoundd";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertDrink(int mdu, string tdu)
        {
            string sql = "insert NameRoundd values('" + mdu + "','" + tdu + "')";
            da.ExecuteNonQuery(sql);
        }
        public void UpdateDrink(int mdu, string tdu)
        {
            string sql = "update NameRoundd set NameRound='" + tdu + "'Where NameRoundID='" + mdu + "'";
            da.ExecuteNonQuery(sql);
        }
        public void DeleteDrink(int mdu)
        {
            string sql = "delete NameRoundd where NameRoundID='" + mdu + "'";
            da.ExecuteNonQuery(sql);
        }
        public DataTable LookDrink(int dk)
        {
            string sql = "Select * from NameRoundd where NameRoundID like '%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
