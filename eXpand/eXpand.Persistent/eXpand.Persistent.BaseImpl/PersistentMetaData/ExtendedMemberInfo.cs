using System;
using System.ComponentModel;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using eXpand.Persistent.Base.PersistentMetaData;
using eXpand.Xpo.Converters.ValueConverters;
using eXpand.Utils.Helpers;

namespace eXpand.Persistent.BaseImpl.PersistentMetaData {
    [RuleCombinationOfPropertiesIsUnique(null, DefaultContexts.Save, "Owner,Name")]
    public abstract class ExtendedMemberInfo : PersistentTypeInfo, IExtendedMemberInfo
    {
        protected ExtendedMemberInfo(Session session) : base(session) {
            
        }
        private Type _owner;
        [Size(SizeAttribute.Unlimited)]
        [ValueConverter(typeof(TypeValueConverter))]
        [RuleRequiredField(null, DefaultContexts.Save)]
        [TypeConverter(typeof(LocalizedClassInfoTypeConverter))]
        public Type Owner
        {
            get
            {
                this.GetMethodInfo()
                return _owner;
            }
            set
            {
                SetPropertyValue("Owner", ref _owner, value);
            }
        }
        
    }
}