using System;
using System.Collections.Generic;
using System.Text;
using osu.GameplayElements.Beatmaps;

namespace osu.Interfacing
{
    public abstract class OsuHelper
    {
        public static BeatmapBase GetCurrentBeatmap()
        {
            return instance.getCurrentBeatmap();
        }

        #region Internal osu! connection handling
        protected static OsuHelper instance;

        abstract protected BeatmapBase getCurrentBeatmap();
        #endregion
    }
}
