using QiShiShe.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public class T_AirPortsRep {
        public List<T_AirPorts> GetT_AirPortsList() {
            string sql = string.Empty;
            string wherestr = string.Empty;
            sql = string.Format(@"
SELECT  *
FROM    dbo.T_AirPorts
WHERE 1=1 {0}
ORDER BY Order_Index", wherestr);
            return QISHISHEDB.GetInstance().Fetch<T_AirPorts>(sql);
        }
    }
}
