using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using QiShiShe.DDD.EntityValidation;

namespace QiShiShe.DDD.Domain {
    /// <summary>
    /// 领域模型，实体模型基类，它可能有多种持久化方式，如DB,File,Redis,Mongodb,XML等
    /// </summary>
    [Serializable]
    public abstract class EntityBase : IEntity {
        #region Contructors
        /// <summary>
        /// 实体初始化
        /// </summary>
        public EntityBase() {
            //this.DataCreateTime = DateTime.Now;
        }

        #endregion

        #region Properties
        ///// <summary>
        ///// 建立时间
        ///// </summary>
        //[XmlIgnore, DataMember(Order = 3), XmlElement(Order = 3), DisplayName("建立时间"), Required]
        //public DateTime DataCreateTime { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// 拿到实体验证的结果列表
        /// 结果为null或者Enumerable.Count()==0表达验证成功
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RuleViolation> GetRuleViolations() {
            var properties = this.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance).ToArray();

            foreach (var i in properties) {
                var attr = i.GetCustomAttributes();
                foreach (var a in attr) {
                    var val = (a as ValidationAttribute);
                    if (val != null)
                        if (!val.IsValid(i.GetValue(this))) {
                            yield return new RuleViolation(
                                val.ErrorMessage ?? val.FormatErrorMessage(i.Name)
                                , i.Name);
                        }
                }
            }

        }
        /// <summary>
        /// 实体验证是否通过
        /// </summary>
        public bool IsValid {
            get {
                return GetRuleViolations() == null || GetRuleViolations().Count() == 0;
            }
        }
        #endregion

    }
}
