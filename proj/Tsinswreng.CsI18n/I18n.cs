namespace Tsinswreng.CsI18n;

using Jeffijoe.MessageFormat;
using Tsinswreng.CsCfg;

public class I18n:II18n{
	#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
	public I18n(ICfgAccessor CfgAccessor){
		this.CfgAccessor = CfgAccessor;
	}
	public ICfgAccessor CfgAccessor{get;set;}
	MessageFormatter MsgFmt = new();
	public str Get(II18nKey Key, params obj[] Args){
		if(!CfgAccessor.TryGet(Key.GetFullPathSegs(), out var Value)){
			return Key.GetFullPathSegs().Last();
		}
		if(Value is str Template){
			if(Args.Length == 0){
				return Template;
			}else{
				var ArgDict = new Dictionary<str, obj?>();
				for(var i = 0; i < Args.Length; i++){
					ArgDict[i+""] = i;
				}
				return MsgFmt.FormatMessage(Template, ArgDict);
			}
		}
		//TODO handle Dict {type: "xxx", data: ""}
		throw new NotSupportedException();
	}

	public str this[II18nKey Key]{get{
		return Get(Key);
	}}
}

