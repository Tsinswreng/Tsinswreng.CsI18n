using Tsinswreng.CsCore;
using Tsinswreng.CsErr;

namespace Tsinswreng.CsI18n;

public delegate str OnKeyNotFound(II18n Self, II18nKey Key, params obj[] Args);

[Doc("國際化/本地化")]
public interface II18n{
	[Doc(@$"")]
	public str Get(II18nKey Key, params obj[] Args);
	public str this[II18nKey Key]{get;}
	public OnKeyNotFound? OnKeyNotFound{get;set;}
}

// public static class AppExtnErrItem{
// 	public static I18nKey ToI18nKey(this IErrNode z){
// 		return new I18nKey{
// 			RelaPathSegs=["Error", ..z.RelaPathSegs],
// 			DfltValueObj = z.DfltValueObj
// 			,Parent = z.Parent
// 			,Children = z.Children
// 		};
// 	}
// }


