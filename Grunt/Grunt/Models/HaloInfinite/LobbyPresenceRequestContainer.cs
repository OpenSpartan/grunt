﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grunt.Models.HaloInfinite
{
    [IsAutomaticallySerializable]
    public class LobbyPresenceRequestContainer
    {
        public long[] Xuids { get; set; }
    }

}