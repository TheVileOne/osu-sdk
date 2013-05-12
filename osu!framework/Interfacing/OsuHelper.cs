using System;
using System.Collections.Generic;
using System.Text;
using osu.GameplayElements.Beatmaps;

namespace osu.Interfacing
{
    public abstract class OsuHelper : MarshalByRefObject
    {
        public static BeatmapBase GetCurrentBeatmap()
        {
            return Instance.getCurrentBeatmap();
        }

        #region Internal osu! connection handling
        public static OsuHelper Instance;

        abstract protected BeatmapBase getCurrentBeatmap();
        #endregion
    }
}
