namespace Tsinswreng.CsI18n;

using Jeffijoe.MessageFormat;
using Tsinswreng.CsCfg;


public class I18nKey:CfgNode<str>, II18nKey{
	public static II18nKey Mk(
		II18nKey? Parent
		,IList<str> Path
	){
		var R = new I18nKey{
			RelaPathSegs=Path,
			Parent=Parent
		};
		return R;
	}
}
