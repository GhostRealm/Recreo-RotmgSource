﻿using wServer.realm.worlds;

namespace wServer.realm.setpieces
{
    class Aroom22 : ISetPiece
    {
        public int Size { get { return 32; } }

        public void RenderSetPiece(World world, IntPoint pos)
        {
            var proto = world.Manager.Resources.Worlds["Aroom22"];
            SetPieces.RenderFromProto(world, pos, proto);
        }
    }
}
