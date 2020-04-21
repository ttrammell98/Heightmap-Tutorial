using Microsoft.Xna.Framework;

namespace HeightmapTerrainStarter
{
    /// <summary>
    /// An interface defining a camera
    /// </summary>
    public interface ICamera
    {
        /// <summary>
        /// The view matrix
        /// </summary>
        Matrix View { get; }

        /// <summary>
        /// The projection matrix
        /// </summary>
        Matrix Projection { get; }

        /// <summary>
        /// Gets or sets the heightmap this camera is interacting with
        /// </summary>
        public IHeightMap HeightMap { get; set; }

        /// <summary>
        /// Gets or sets how high above the heightmap the camera should be
        /// </summary>
        float HeightOffset { get; set; }


    }
}
