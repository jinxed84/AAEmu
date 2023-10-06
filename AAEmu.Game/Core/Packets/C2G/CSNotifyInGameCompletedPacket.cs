﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Managers.World;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G;

public class CSNotifyInGameCompletedPacket : GamePacket
{
    public CSNotifyInGameCompletedPacket() : base(CSOffsets.CSNotifyInGameCompletedPacket, 1)
    {
    }

    public override void Read(PacketStream stream)
    {

        WorldManager.Instance.OnPlayerJoin(Connection.ActiveChar);
        Logger.Info("NotifyInGameCompleted SubZoneId {0}", Connection.ActiveChar.SubZoneId);
    }
}
