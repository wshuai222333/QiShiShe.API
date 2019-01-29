using QiShiShe.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public class OrderPassengerRep {
        public object Insert(OrderPassenger model) {
            return QISHISHEDB.GetInstance().Insert(model);
        }
    }
}
