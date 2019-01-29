using QiShiShe.Entity.Model;

namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public class OrderApartmentRep {
        public object Insert(OrderApartment model) {
            return QISHISHEDB.GetInstance().Insert(model);
        }
    }
}
