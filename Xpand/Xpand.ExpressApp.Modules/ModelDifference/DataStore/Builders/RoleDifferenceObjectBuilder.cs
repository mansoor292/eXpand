using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Security;
using Xpand.ExpressApp.ModelDifference.DataStore.BaseObjects;
using Xpand.ExpressApp.Core;

namespace Xpand.ExpressApp.ModelDifference.DataStore.Builders{
    public class RoleDifferenceObjectBuilder
    {

        private static ITypeInfo GetRoleTypeInfo(ISecurityComplex security){
            return XafTypesInfo.Instance.PersistentTypes.Where(info => info.Type== security.RoleType).Single();
        }

        public static bool CreateDynamicMembers(ISecurityComplex security)
        {
            return XafTypesInfo.Instance.CreateBothPartMembers(typeof(RoleModelDifferenceObject), 
                GetRoleTypeInfo(security).Type,
                XafTypesInfo.XpoTypeInfoSource.XPDictionary, true) != null;
        }
    }
}