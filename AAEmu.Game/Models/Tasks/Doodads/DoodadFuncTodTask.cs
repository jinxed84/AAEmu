﻿
using AAEmu.Game.Models.Game.DoodadObj;
using AAEmu.Game.Models.Game.Units;

using NLog;

namespace AAEmu.Game.Models.Tasks.Doodads
{
    public class DoodadFuncTodTask : DoodadFuncTask
    {
        private static Logger _log = LogManager.GetCurrentClassLogger();
        private Unit _caster;
        private Doodad _owner;
        private uint _skillId;
        private uint _nextPhase;

        public DoodadFuncTodTask(Unit caster, Doodad owner, uint skillId, int nextPhase) : base(caster, owner, skillId)
        {
            _caster = caster;
            _owner = owner;
            _skillId = skillId;
            _nextPhase = (uint)nextPhase;
        }
        public override void Execute()
        {
            _log.Warn("[Doodad] DoodadFuncTodTask: Doodad {0}, TemplateId {1}. Using skill {2} with doodad phase {3}", _owner.ObjId, _owner.TemplateId, _skillId, _owner.FuncGroupId);
            _owner.FuncTask = null;
            _owner.GoToPhaseChanged(_caster, _nextPhase);
        }
    }
}
