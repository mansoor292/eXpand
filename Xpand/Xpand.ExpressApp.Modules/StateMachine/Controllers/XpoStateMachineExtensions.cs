using System.Linq;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.StateMachine.Xpo;
using DevExpress.Xpo;

namespace Xpand.ExpressApp.StateMachine.Controllers {
    public static class XpoStateMachineExtensions {
        public static bool CanExecuteTransition(this XpoStateMachine stateMachine) {
            var collection = (XPBaseCollection)stateMachine.GetMemberValue(XpandStateMachineModule.AdminRoles);
            return collection.OfType<ISecurityRole>().Any(IsInRole);
        }
        static bool IsInRole(ISecurityRole securityRole) {
            return ((ISecurityUserWithRoles)SecuritySystem.CurrentUser).Roles.Select(role => role.Name).Contains(securityRole.Name);
        }
    }
}