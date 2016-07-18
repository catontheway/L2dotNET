﻿using L2dotNET.GameService.Model.Player;
using L2dotNET.GameService.Network.Serverpackets;
using L2dotNET.Network;

namespace L2dotNET.GameService.Network.Clientpackets.RecipeAPI
{
    class RequestRecipeBookOpen : PacketBase
    {
        private readonly GameClient _client;
        private readonly int _type;

        public RequestRecipeBookOpen(Packet packet, GameClient client)
        {
            _client = client;
            _type = packet.ReadInt();
        }

        public override void RunImpl()
        {
            L2Player player = _client.CurrentPlayer;

            player.SendPacket(new RecipeBookItemList(player, _type));
        }
    }
}