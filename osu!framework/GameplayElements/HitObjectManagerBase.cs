using System;
using System.Collections.Generic;
using System.Text;
using osu.GameplayElements.Beatmaps;
using osu.GameplayElements.HitObjects;

namespace osu.GameplayElements
{
    public abstract class HitObjectManagerBase : MarshalByRefObject
    {
        public abstract BeatmapBase GetBeatmap();

        public abstract List<HitObjectBase> GetHitObjects();


        /// <summary>
        /// Radius of a HitObject.
        /// </summary>
        public float HitObjectRadius;

        /// <summary>
        /// Time window in milliseconds for acquiring 300/100/50 when hitting HitObjects.
        /// </summary>
        public int hitWindow50;
        public int hitWindow100;
        public int hitWindow300;

        /// <summary>
        /// Distance between slider scoring points.
        /// </summary>
        public double SliderScoringPointDistance;

        /// <summary>
        /// Slider velocity at a given point in time.
        /// </summary>
        public abstract double SliderVelocityAt(int time);

        /// <summary>
        /// Number of rotations per second required for full score.
        /// </summary>
        public double SpinnerRotationRatio;

        /// <summary>
        /// Pixels to offset on stacked notes.
        /// </summary>
        public float StackOffset;
    }
}
