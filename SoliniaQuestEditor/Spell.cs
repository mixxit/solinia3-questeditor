using Newtonsoft.Json;using System;
namespace SoliniaQuestEditor {
    public class Spell : ISearchableObject
     {
        [JsonProperty("id")]
        public int id { get; set; }

        [JsonProperty("name")]
        public String name { get; set; }

        [JsonProperty("player_1")]
        public String player1 { get; set; }

        [JsonProperty("teleport_zone")]
        public String teleportZone { get; set; }

        [JsonProperty("you_cast")]
        public String youCast { get; set; }

        [JsonProperty("other_casts")]
        public String otherCasts { get; set; }

        [JsonProperty("cast_on_you")]
        public String castOnYou { get; set; }

        [JsonProperty("cast_on_other")]
        public String castOnOther { get; set; }

        [JsonProperty("spell_fades")]
        public String spellFades { get; set; }

        [JsonProperty("range")]
        public int range { get; set; }

        [JsonProperty("aoerange")]
        public int aoerange { get; set; }

        [JsonProperty("pushback")]
        public int pushback { get; set; }

        [JsonProperty("pushup")]
        public int pushup { get; set; }

        [JsonProperty("cast_time")]
        public int castTime { get; set; }

        [JsonProperty("recovery_time")]
        public int recoveryTime { get; set; }

        [JsonProperty("recast_time")]
        public int recastTime { get; set; }

        [JsonProperty("buffdurationformula")]
        public int buffdurationformula { get; set; }

        [JsonProperty("buffduration")]
        public int buffduration { get; set; }

        [JsonProperty("AEDuration")]
        public int aEDuration { get; set; }

        [JsonProperty("mana")]
        public int mana { get; set; }

        [JsonProperty("effect_base_value1")]
        public int effectBaseValue1 { get; set; }

        [JsonProperty("effect_base_value2")]
        public int effectBaseValue2 { get; set; }

        [JsonProperty("effect_base_value3")]
        public int effectBaseValue3 { get; set; }

        [JsonProperty("effect_base_value4")]
        public int effectBaseValue4 { get; set; }

        [JsonProperty("effect_base_value5")]
        public int effectBaseValue5 { get; set; }

        [JsonProperty("effect_base_value6")]
        public int effectBaseValue6 { get; set; }

        [JsonProperty("effect_base_value7")]
        public int effectBaseValue7 { get; set; }

        [JsonProperty("effect_base_value8")]
        public int effectBaseValue8 { get; set; }

        [JsonProperty("effect_base_value9")]
        public int effectBaseValue9 { get; set; }

        [JsonProperty("effect_base_value10")]
        public int effectBaseValue10 { get; set; }

        [JsonProperty("effect_base_value11")]
        public int effectBaseValue11 { get; set; }

        [JsonProperty("effect_base_value12")]
        public int effectBaseValue12 { get; set; }

        [JsonProperty("effect_limit_value1")]
        public int effectLimitValue1 { get; set; }

        [JsonProperty("effect_limit_value2")]
        public int effectLimitValue2 { get; set; }

        [JsonProperty("effect_limit_value3")]
        public int effectLimitValue3 { get; set; }

        [JsonProperty("effect_limit_value4")]
        public int effectLimitValue4 { get; set; }

        [JsonProperty("effect_limit_value5")]
        public int effectLimitValue5 { get; set; }

        [JsonProperty("effect_limit_value6")]
        public int effectLimitValue6 { get; set; }

        [JsonProperty("effect_limit_value7")]
        public int effectLimitValue7 { get; set; }

        [JsonProperty("effect_limit_value8")]
        public int effectLimitValue8 { get; set; }

        [JsonProperty("effect_limit_value9")]
        public int effectLimitValue9 { get; set; }

        [JsonProperty("effect_limit_value10")]
        public int effectLimitValue10 { get; set; }

        [JsonProperty("effect_limit_value11")]
        public int effectLimitValue11 { get; set; }

        [JsonProperty("effect_limit_value12")]
        public int effectLimitValue12 { get; set; }

        [JsonProperty("max1")]
        public int max1 { get; set; }

        [JsonProperty("max2")]
        public int max2 { get; set; }

        [JsonProperty("max3")]
        public int max3 { get; set; }

        [JsonProperty("max4")]
        public int max4 { get; set; }

        [JsonProperty("max5")]
        public int max5 { get; set; }

        [JsonProperty("max6")]
        public int max6 { get; set; }

        [JsonProperty("max7")]
        public int max7 { get; set; }

        [JsonProperty("max8")]
        public int max8 { get; set; }

        [JsonProperty("max9")]
        public int max9 { get; set; }

        [JsonProperty("max10")]
        public int max10 { get; set; }

        [JsonProperty("max11")]
        public int max11 { get; set; }

        [JsonProperty("max12")]
        public int max12 { get; set; }

        [JsonProperty("icon")]
        public int icon { get; set; }

        [JsonProperty("memicon")]
        public int memicon { get; set; }

        [JsonProperty("components1")]
        public int components1 { get; set; }

        [JsonProperty("components2")]
        public int components2 { get; set; }

        [JsonProperty("components3")]
        public int components3 { get; set; }

        [JsonProperty("components4")]
        public int components4 { get; set; }

        [JsonProperty("component_counts1")]
        public int componentCounts1 { get; set; }

        [JsonProperty("component_counts2")]
        public int componentCounts2 { get; set; }

        [JsonProperty("component_counts3")]
        public int componentCounts3 { get; set; }

        [JsonProperty("component_counts4")]
        public int componentCounts4 { get; set; }

        [JsonProperty("NoexpendReagent1")]
        public int noexpendReagent1 { get; set; }

        [JsonProperty("NoexpendReagent2")]
        public int noexpendReagent2 { get; set; }

        [JsonProperty("NoexpendReagent3")]
        public int noexpendReagent3 { get; set; }

        [JsonProperty("NoexpendReagent4")]
        public int noexpendReagent4 { get; set; }

        [JsonProperty("formula1")]
        public int formula1 { get; set; }

        [JsonProperty("formula2")]
        public int formula2 { get; set; }

        [JsonProperty("formula3")]
        public int formula3 { get; set; }

        [JsonProperty("formula4")]
        public int formula4 { get; set; }

        [JsonProperty("formula5")]
        public int formula5 { get; set; }

        [JsonProperty("formula6")]
        public int formula6 { get; set; }

        [JsonProperty("formula7")]
        public int formula7 { get; set; }

        [JsonProperty("formula8")]
        public int formula8 { get; set; }

        [JsonProperty("formula9")]
        public int formula9 { get; set; }

        [JsonProperty("formula10")]
        public int formula10 { get; set; }

        [JsonProperty("formula11")]
        public int formula11 { get; set; }

        [JsonProperty("formula12")]
        public int formula12 { get; set; }

        [JsonProperty("LightType")]
        public int lightType { get; set; }

        [JsonProperty("goodEffect")]
        public int goodEffect { get; set; }

        [JsonProperty("Activated")]
        public int activated { get; set; }

        [JsonProperty("resisttype")]
        public int resisttype { get; set; }

        [JsonProperty("effectid1")]
        public int effectid1 { get; set; }

        [JsonProperty("effectid2")]
        public int effectid2 { get; set; }

        [JsonProperty("effectid3")]
        public int effectid3 { get; set; }

        [JsonProperty("effectid4")]
        public int effectid4 { get; set; }

        [JsonProperty("effectid5")]
        public int effectid5 { get; set; }

        [JsonProperty("effectid6")]
        public int effectid6 { get; set; }

        [JsonProperty("effectid7")]
        public int effectid7 { get; set; }

        [JsonProperty("effectid8")]
        public int effectid8 { get; set; }

        [JsonProperty("effectid9")]
        public int effectid9 { get; set; }

        [JsonProperty("effectid10")]
        public int effectid10 { get; set; }

        [JsonProperty("effectid11")]
        public int effectid11 { get; set; }

        [JsonProperty("effectid12")]
        public int effectid12 { get; set; }

        [JsonProperty("targettype")]
        public int targettype { get; set; }

        [JsonProperty("basediff")]
        public int basediff { get; set; }

        [JsonProperty("skill")]
        public int skill { get; set; }

        [JsonProperty("zonetype")]
        public int zonetype { get; set; }

        [JsonProperty("EnvironmentType")]
        public int environmentType { get; set; }

        [JsonProperty("TimeOfDay")]
        public int timeOfDay { get; set; }

        [JsonProperty("classes1")]
        public int classes1 { get; set; }

        [JsonProperty("classes2")]
        public int classes2 { get; set; }

        [JsonProperty("classes3")]
        public int classes3 { get; set; }

        [JsonProperty("classes4")]
        public int classes4 { get; set; }

        [JsonProperty("classes5")]
        public int classes5 { get; set; }

        [JsonProperty("classes6")]
        public int classes6 { get; set; }

        [JsonProperty("classes7")]
        public int classes7 { get; set; }

        [JsonProperty("classes8")]
        public int classes8 { get; set; }

        [JsonProperty("classes9")]
        public int classes9 { get; set; }

        [JsonProperty("classes10")]
        public int classes10 { get; set; }

        [JsonProperty("classes11")]
        public int classes11 { get; set; }

        [JsonProperty("classes12")]
        public int classes12 { get; set; }

        [JsonProperty("classes13")]
        public int classes13 { get; set; }

        [JsonProperty("classes14")]
        public int classes14 { get; set; }

        [JsonProperty("classes15")]
        public int classes15 { get; set; }

        [JsonProperty("classes16")]
        public int classes16 { get; set; }

        [JsonProperty("CastingAnim")]
        public int castingAnim { get; set; }

        [JsonProperty("TargetAnim")]
        public int targetAnim { get; set; }

        [JsonProperty("TravelType")]
        public int travelType { get; set; }

        [JsonProperty("SpellAffectIndex")]
        public int spellAffectIndex { get; set; }

        [JsonProperty("disallow_sit")]
        public int disallowSit { get; set; }

        [JsonProperty("deities0")]
        public int deities0 { get; set; }

        [JsonProperty("deities1")]
        public int deities1 { get; set; }

        [JsonProperty("deities2")]
        public int deities2 { get; set; }

        [JsonProperty("deities3")]
        public int deities3 { get; set; }

        [JsonProperty("deities4")]
        public int deities4 { get; set; }

        [JsonProperty("deities5")]
        public int deities5 { get; set; }

        [JsonProperty("deities6")]
        public int deities6 { get; set; }

        [JsonProperty("deities7")]
        public int deities7 { get; set; }

        [JsonProperty("deities8")]
        public int deities8 { get; set; }

        [JsonProperty("deities9")]
        public int deities9 { get; set; }

        [JsonProperty("deities10")]
        public int deities10 { get; set; }

        [JsonProperty("deities11")]
        public int deities11 { get; set; }

        [JsonProperty("deities12")]
        public int deities12 { get; set; }

        [JsonProperty("deities13")]
        public int deities13 { get; set; }

        [JsonProperty("deities14")]
        public int deities14 { get; set; }

        [JsonProperty("deities15")]
        public int deities15 { get; set; }

        [JsonProperty("deities16")]
        public int deities16 { get; set; }

        [JsonProperty("field142")]
        public int field142 { get; set; }

        [JsonProperty("field143")]
        public int field143 { get; set; }

        [JsonProperty("new_icon")]
        public int newIcon { get; set; }

        [JsonProperty("spellanim")]
        public int spellanim { get; set; }

        [JsonProperty("uninterruptable")]
        public int uninterruptable { get; set; }

        [JsonProperty("ResistDiff")]
        public int resistDiff { get; set; }

        [JsonProperty("dot_stacking_exempt")]
        public int dotStackingExempt { get; set; }

        [JsonProperty("deleteable")]
        public int deleteable { get; set; }

        [JsonProperty("RecourseLink")]
        public int recourseLink { get; set; }

        [JsonProperty("no_partial_resist")]
        public int noPartialResist { get; set; }

        [JsonProperty("field152")]
        public int field152 { get; set; }

        [JsonProperty("field153")]
        public int field153 { get; set; }

        [JsonProperty("short_buff_box")]
        public int shortBuffBox { get; set; }

        [JsonProperty("descnum")]
        public int descnum { get; set; }

        [JsonProperty("typedescnum")]
        public int typedescnum { get; set; }

        [JsonProperty("effectdescnum")]
        public int effectdescnum { get; set; }

        [JsonProperty("effectdescnum2")]
        public int effectdescnum2 { get; set; }

        [JsonProperty("npc_no_los")]
        public int npcNoLos { get; set; }

        [JsonProperty("field160")]
        public int field160 { get; set; }

        [JsonProperty("reflectable")]
        public int reflectable { get; set; }

        [JsonProperty("bonushate")]
        public int bonushate { get; set; }

        [JsonProperty("field163")]
        public int field163 { get; set; }

        [JsonProperty("field164")]
        public int field164 { get; set; }

        [JsonProperty("ldon_trap")]
        public int ldonTrap { get; set; }

        [JsonProperty("EndurCost")]
        public int endurCost { get; set; }

        [JsonProperty("EndurTimerIndex")]
        public int endurTimerIndex { get; set; }

        [JsonProperty("IsDiscipline")]
        public int isDiscipline { get; set; }

        [JsonProperty("field169")]
        public int field169 { get; set; }

        [JsonProperty("field170")]
        public int field170 { get; set; }

        [JsonProperty("field171")]
        public int field171 { get; set; }

        [JsonProperty("field172")]
        public int field172 { get; set; }

        [JsonProperty("HateAdded")]
        public int hateAdded { get; set; }

        [JsonProperty("EndurUpkeep")]
        public int endurUpkeep { get; set; }

        [JsonProperty("numhitstype")]
        public int numhitstype { get; set; }

        [JsonProperty("numhits")]
        public int numhits { get; set; }

        [JsonProperty("pvpresistbase")]
        public int pvpresistbase { get; set; }

        [JsonProperty("pvpresistcalc")]
        public int pvpresistcalc { get; set; }

        [JsonProperty("pvpresistcap")]
        public int pvpresistcap { get; set; }

        [JsonProperty("spell_category")]
        public int spellCategory { get; set; }

        [JsonProperty("field181")]
        public int field181 { get; set; }

        [JsonProperty("field182")]
        public int field182 { get; set; }

        [JsonProperty("field183")]
        public int field183 { get; set; }

        [JsonProperty("field184")]
        public int field184 { get; set; }

        [JsonProperty("can_mgb")]
        public int canMgb { get; set; }

        [JsonProperty("nodispell")]
        public int nodispell { get; set; }

        [JsonProperty("npc_category")]
        public int npcCategory { get; set; }

        [JsonProperty("npc_usefulness")]
        public int npcUsefulness { get; set; }

        [JsonProperty("MinResist")]
        public int minResist { get; set; }

        [JsonProperty("MaxResist")]
        public int maxResist { get; set; }

        [JsonProperty("viral_targets")]
        public int viralTargets { get; set; }

        [JsonProperty("viral_timer")]
        public int viralTimer { get; set; }

        [JsonProperty("nimbuseffect")]
        public int nimbuseffect { get; set; }

        [JsonProperty("ConeStartAngle")]
        public int coneStartAngle { get; set; }

        [JsonProperty("ConeStopAngle")]
        public int coneStopAngle { get; set; }

        [JsonProperty("sneaking")]
        public int sneaking { get; set; }

        [JsonProperty("not_extendable")]
        public int notExtendable { get; set; }

        [JsonProperty("field198")]
        public int field198 { get; set; }

        [JsonProperty("field199")]
        public int field199 { get; set; }

        [JsonProperty("suspendable")]
        public int suspendable { get; set; }

        [JsonProperty("viral_range")]
        public int viralRange { get; set; }

        [JsonProperty("songcap")]
        public int songcap { get; set; }

        [JsonProperty("field203")]
        public int field203 { get; set; }

        [JsonProperty("field204")]
        public int field204 { get; set; }

        [JsonProperty("no_block")]
        public int noBlock { get; set; }

        [JsonProperty("field206")]
        public int field206 { get; set; }

        [JsonProperty("spellgroup")]
        public int spellgroup { get; set; }

        [JsonProperty("rank")]
        public int rank { get; set; }

        [JsonProperty("field209")]
        public int field209 { get; set; }

        [JsonProperty("field210")]
        public int field210 { get; set; }

        [JsonProperty("CastRestriction")]
        public int castRestriction { get; set; }

        [JsonProperty("allowrest")]
        public int allowrest { get; set; }

        [JsonProperty("InCombat")]
        public int inCombat { get; set; }

        [JsonProperty("OutofCombat")]
        public int outofCombat { get; set; }

        [JsonProperty("field215")]
        public int field215 { get; set; }

        [JsonProperty("field216")]
        public int field216 { get; set; }

        [JsonProperty("field217")]
        public int field217 { get; set; }

        [JsonProperty("aemaxtargets")]
        public int aemaxtargets { get; set; }

        [JsonProperty("maxtargets")]
        public int maxtargets { get; set; }

        [JsonProperty("field220")]
        public int field220 { get; set; }

        [JsonProperty("field221")]
        public int field221 { get; set; }

        [JsonProperty("field222")]
        public int field222 { get; set; }

        [JsonProperty("field223")]
        public int field223 { get; set; }

        [JsonProperty("persistdeath")]
        public int persistdeath { get; set; }

        [JsonProperty("field225")]
        public int field225 { get; set; }

        [JsonProperty("field226")]
        public int field226 { get; set; }

        [JsonProperty("min_dist")]
        public Double minDist { get; set; }

        [JsonProperty("min_dist_mod")]
        public Double minDistMod { get; set; }

        [JsonProperty("max_dist")]
        public Double maxDist { get; set; }

        [JsonProperty("max_dist_mod")]
        public Double maxDistMod { get; set; }

        [JsonProperty("min_range")]
        public int minRange { get; set; }

        [JsonProperty("field232")]
        public int field232 { get; set; }

        [JsonProperty("field233")]
        public int field233 { get; set; }

        [JsonProperty("field234")]
        public int field234 { get; set; }

        [JsonProperty("field235")]
        public int field235 { get; set; }

        [JsonProperty("field236")]
        public int field236 { get; set; }

        public string GetSearchValue()
         {
            return this.name;
        }
    }}