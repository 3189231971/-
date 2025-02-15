//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;
using Sirenix.OdinInspector;


namespace editor.cfg
{
    [Serializable]
public sealed partial class HouyiMultipleSkillModifyBuffCfg :  BuffCfg 
{
    public HouyiMultipleSkillModifyBuffCfg()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
        { 
            var _fieldJson = _json["originalID"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  originalID = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["powerID"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  powerID = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["superPowerID"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  superPowerID = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["triggerOverCount"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  triggerOverCount = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["resetTime"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  resetTime = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
        {
            _json["originalID"] = new JSONNumber(originalID);
        }
        {
            _json["powerID"] = new JSONNumber(powerID);
        }
        {
            _json["superPowerID"] = new JSONNumber(superPowerID);
        }
        {
            _json["triggerOverCount"] = new JSONNumber(triggerOverCount);
        }
        {
            _json["resetTime"] = new JSONNumber(resetTime);
        }
    }

    public static HouyiMultipleSkillModifyBuffCfg LoadJsonHouyiMultipleSkillModifyBuffCfg(SimpleJSON.JSONNode _json)
    {
        HouyiMultipleSkillModifyBuffCfg obj = new HouyiMultipleSkillModifyBuffCfg();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonHouyiMultipleSkillModifyBuffCfg(HouyiMultipleSkillModifyBuffCfg _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    [ShowInInspector, VerticalGroup("特殊")]public int originalID { get; set; }

    [ShowInInspector, VerticalGroup("特殊")]public int powerID { get; set; }

    [ShowInInspector, VerticalGroup("特殊")]public int superPowerID { get; set; }

    [ShowInInspector, VerticalGroup("特殊")]public int triggerOverCount { get; set; }

    [ShowInInspector, VerticalGroup("特殊")]public int resetTime { get; set; }

}
}
