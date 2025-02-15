//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace editor.cfg
{

public sealed partial class NSSpeedBuffCfg :  BuffCfg 
{
    public NSSpeedBuffCfg()
    {
            audio_buffOn = "";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
        { 
            var _fieldJson = _json["moveSpeedPer"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  moveSpeedPer = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["atkSpeedPer"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  atkSpeedPer = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["resetTime"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  resetTime = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["audio_buffOn"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  audio_buffOn = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
        {
            _json["moveSpeedPer"] = new JSONNumber(moveSpeedPer);
        }
        {
            _json["atkSpeedPer"] = new JSONNumber(atkSpeedPer);
        }
        {
            _json["resetTime"] = new JSONNumber(resetTime);
        }
        {

            if (audio_buffOn == null) { throw new System.ArgumentNullException(); }
            _json["audio_buffOn"] = new JSONString(audio_buffOn);
        }
    }

    public static NSSpeedBuffCfg LoadJsonNSSpeedBuffCfg(SimpleJSON.JSONNode _json)
    {
        NSSpeedBuffCfg obj = new NSSpeedBuffCfg();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonNSSpeedBuffCfg(NSSpeedBuffCfg _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 移动速度改变百分比
    /// </summary>
    public int moveSpeedPer { get; set; }

    /// <summary>
    /// 攻击速度改变百分比
    /// </summary>
    public int atkSpeedPer { get; set; }

    /// <summary>
    /// 速度改变持续时间
    /// </summary>
    public int resetTime { get; set; }

    /// <summary>
    /// 被动buff启动时音效
    /// </summary>
    public string audio_buffOn { get; set; }

}
}
