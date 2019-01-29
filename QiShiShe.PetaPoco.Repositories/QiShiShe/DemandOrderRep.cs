using QiShiShe.Entity.Model;
namespace QiShiShe.PetaPoco.Repositories.QiShiShe {
    public class DemandOrderRep {
        public object Insert(DemandOrder model) {
            return QISHISHEDB.GetInstance().Insert(model);
        }
    }
}
