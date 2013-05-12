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
        protected static OsuHelper Instance;

        public static void Initialize(OsuHelper instance = null)
        {
            Instance = instance;
        }

        abstract protected BeatmapBase getCurrentBeatmap();
        #endregion
    }
}
