using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace osu.GameplayElements.Beatmaps
{
    public abstract class BeatmapBase : MarshalByRefObject
    {
        #region Difficulty Settings
        public byte DifficultyApproachRate = 5;
        public byte DifficultyCircleSize = 5;
        public byte DifficultyHpDrainRate = 5;
        public byte DifficultyOverall = 5;

        public float BaseHitObjectRadius = 32;

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