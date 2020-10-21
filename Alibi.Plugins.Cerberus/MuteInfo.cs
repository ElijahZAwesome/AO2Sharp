﻿using System;

namespace Alibi.Plugins.Cerberus
{
    public class MuteInfo
    {
        public int IcMessages = 0;
        public bool IcMuted = false;
        public DateTime IcTimer = DateTime.Now;
        public int MusicMessages = 0;
        public bool MusicMuted = false;
        public DateTime MusicTimer = DateTime.Now;
        public int OocMessages = 0;
        public bool OocMuted = false;
        public DateTime OocTimer = DateTime.Now;
    }
}