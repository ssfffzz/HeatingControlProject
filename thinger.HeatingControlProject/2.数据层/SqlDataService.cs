using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace thinger.HeatingControlProject
{
    public class SqlDataService
    {
        //定时存储
        public int AddPlcData(PLCData pLCData)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("insert into ActualData(InsertTime, PressureIn, PressureOut, TempIn, TempOut, PressureBoiler, LevelBoiler, TempBoiler, LevelTank)");
            stringBuilder.Append(" values(@InsertTime, @PressureIn, @PressureOut, @TempIn, @TempOut, @PressureBoiler, @LevelBoiler, @TempBoiler, @LevelTank)");
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@InsertTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")),
                new SqlParameter("@PressureIn", pLCData.PressureIn),
                new SqlParameter("@PressureOut", pLCData.PressureOut),
                new SqlParameter("@TempIn", pLCData.TempIn),
                new SqlParameter("@TempOut", pLCData.TempOut),
                new SqlParameter("@PressureBoiler", pLCData.PressureBoiler),
                new SqlParameter("@LevelBoiler", pLCData.LevelBoiler),
                new SqlParameter("@TempBoiler", pLCData.TempBoiler),
                new SqlParameter("@LevelTank", pLCData.LevelTank)
            };
            return SqlHelper.ExecuteNonQuery(stringBuilder.ToString(), sqlParameter);

        }

        /// <summary>
        /// 根据时间段查询历史数据
        /// </summary>
        /// <param name="start"></param>
        /// <param name="stop"></param>
        /// <returns></returns>
        public DataSet GetActualDataByTime(DateTime start, DateTime stop)
        {
            string sql = "select InsertTime, PressureIn, PressureOut, TempIn, TempOut, PressureBoiler, LevelBoiler, TempBoiler, LevelTank from ActualData ";
            sql += "where InsertTime between @start and @stop";
            SqlParameter[] sqlParameter = new SqlParameter[]
            {
                new SqlParameter("@start", start),
                new SqlParameter("@stop", stop),
            };

            return SqlHelper.GetDataSet(sql, null, sqlParameter);

        }

    }
}
