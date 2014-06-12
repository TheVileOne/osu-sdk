using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace osu.GameplayElements.Beatmaps
{
    public abstract class BeatmapBase : MarshalByRefObject
    {
        #region Difficulty Settings
        public float DifficultyApproachRate = 5;
        public float DifficultyCircleSize = 5;
        public float DifficultyHpDrainRate = 5;
        public float DifficultyOverall = 5;

        public double DifficultySliderMultiplier = 1.4;
        public double DifficultySliderTickRate = 1;
        #endregion

        #region Metadata
        public string Artist = string.Empty;
        public string ArtistUnicode;

        public string Tags = string.Empty;
        public string Title = string.Empty;
        public string TitleUnicode;
        #endregion
    }
}