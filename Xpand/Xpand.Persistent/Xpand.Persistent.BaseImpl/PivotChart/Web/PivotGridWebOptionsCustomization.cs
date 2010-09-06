﻿using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using Xpand.Persistent.Base.PivotChart.Web;

namespace Xpand.Persistent.BaseImpl.PivotChart.Web {
    [NonPersistent]
    public class PivotGridWebOptionsCustomization : BaseObject, IPivotGridWebOptionsCustomization
    {
        public PivotGridWebOptionsCustomization(Session session) : base(session) {
        }
    }
}