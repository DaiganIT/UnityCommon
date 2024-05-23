using UnityEngine;

namespace Daigan.Extensions
{
    public static class VectorExtensions
    {
        /// <summary>
        /// Returns a new Vector2 changing only the given coordinates and mantaining the other coordinates
        /// </summary>
        /// <param name="v">The original vector</param>
        /// <param name="x">The new x coordinate</param>
        /// <param name="y">The new y coordinate</param>
        /// <returns>The new Vector2</returns>
        public static Vector2 With(this Vector2 v, float? x = null, float? y = null) => new Vector2(x ?? v.x, y ?? v.y);

        /// <summary>
        /// Returns a new Vector2 adding only the given coordinates and mantaining the other coordinates
        /// </summary>
        /// <param name="v">The original vector</param>
        /// <param name="x">The add x coordinate</param>
        /// <param name="y">The add y coordinate</param>
        /// <returns>The new Vector2</returns>
        public static Vector2 Add(this Vector2 v, float x = 0, float y = 0) => new Vector2(v.x + x, v.y + y);

        /// <summary>
        /// Returns a new Vector3 changing only the given coordinates and mantaining the other coordinates
        /// </summary>
        /// <param name="v">The original vector</param>
        /// <param name="x">The new x coordinate</param>
        /// <param name="y">The new y coordinate</param>
        /// <param name="z">The new z coordinate</param>
        /// <returns>The new Vector3</returns>
        public static Vector3 With(this Vector3 v, float? x = null, float? y = null, float? z = null) => new Vector3(x ?? v.x, y ?? v.y, z ?? v.z);

        /// <summary>
        /// Returns a new Vector3 adding only the given coordinates and mantaining the other coordinates
        /// </summary>
        /// <param name="v">The original vector</param>
        /// <param name="x">The add x coordinate</param>
        /// <param name="y">The add y coordinate</param>
        /// <param name="z">The add z coordinate</param>
        /// <returns>The new Vector3</returns>
        public static Vector3 Add(this Vector3 v, float x = 0, float y = 0, float z = 0) => new Vector3(v.x + x, v.y + y, v.z + z);
    }
}