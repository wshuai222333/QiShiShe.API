namespace QiShiShe.Api {
    public class ContractResolver : Newtonsoft.Json.Serialization.DefaultContractResolver {
        protected override string ResolvePropertyName(string propertyName) {
            return propertyName;
        }
    }
}
