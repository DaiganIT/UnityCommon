using NUnit.Framework;
using UnityEngine;
using Daigan.Extensions;

namespace Daigan.Tests
{
    public class VectorExtensionsTests
    {
        [Test]
        [TestCase(1f, null, null, 1f, 0f, 0f)]
        [TestCase(null, 4f, null, 0f, 4f, 0f)]
        [TestCase(null, null, 10f, 0f, 0f, 10f)]
        [TestCase(7f, null, 8f, 7f, 0f, 8f)]
        [TestCase(7f, 3f, null, 7f, 3f, 0f)]
        [TestCase(5f, 12f, 45f, 5f, 12f, 45f)]
        public void CanChangeVector3Zero(float? x, float? y, float? z, float expX, float expY, float expZ)
        {
            var expectedVector = new Vector3(expX, expY, expZ);
            var vector = Vector3.zero.With(x: x, y: y, z: z);

            AssertVector(vector, expectedVector);
        }

        [Test]
        [TestCase(2f, 3f, 4f, 1f, 0f, null, 3f, 3f, 4f)]
        [TestCase(2f, 3f, 4f, null, 4f, null, 2f, 7f, 4f)]
        [TestCase(2f, 3f, 4f, null, null, 10f, 2f, 3f, 14f)]
        [TestCase(2f, 3f, 4f, 7f, null, 8f, 9f, 3f, 12f)]
        [TestCase(2f, 3f, 4f, 7f, 3f, null, 9f, 6f, 4f)]
        [TestCase(2f, 3f, 4f, 5f, 12f, 45f, 7f, 15f, 49f)]
        [TestCase(2f, 3f, 4f, -5f, -12f, -5f, -3f, -9f, -1f)]
        public void CanAddVector3(float startX, float startY, float startZ, float? x, float? y, float? z, float expX, float expY, float expZ)
        {
            var startVector = new Vector3(startX, startY, startZ);
            var expectedVector = new Vector3(expX, expY, expZ);
            var vector = startVector.Add(x: x ?? 0, y: y ?? 0, z: z ?? 0);

            AssertVector(vector, expectedVector);
        }

        [Test]
        [TestCase(1f, null, 1f, 0f)]
        [TestCase(null, 4f, 0f, 4f)]
        [TestCase(7f, null, 7f, 0f)]
        [TestCase(7f, 3f, 7f, 3f)]
        public void CanChangeVector2Zero(float? x, float? y, float expX, float expY)
        {
            var expectedVector = new Vector2(expX, expY);
            var vector = Vector2.zero.With(x: x, y: y);

            AssertVector(vector, expectedVector);
        }

        [Test]
        [TestCase(2f, 3f, 1f, null, 3f, 3f)]
        [TestCase(2f, 3f, null, 4f, 2f, 7f)]
        [TestCase(2f, 3f, 7f, null, 9f, 3f)]
        [TestCase(2f, 3f, 7f, 3f, 9f, 6f)]
        [TestCase(2f, 3f, -5f, -12f, -3f, -9f)]
        public void CanAddVector2(float startX, float startY, float? x, float? y, float expX, float expY)
        {
            var startVector = new Vector2(startX, startY);
            var expectedVector = new Vector2(expX, expY);
            var vector = startVector.Add(x: x ?? 0, y: y ?? 0);

            AssertVector(vector, expectedVector);
        }

        public void AssertVector(Vector3 vector, Vector3 expectedVector)
        {
            Assert.That(vector.x, Is.EqualTo(expectedVector.x), "X is different");
            Assert.That(vector.y, Is.EqualTo(expectedVector.y), "Y is different");
            Assert.That(vector.z, Is.EqualTo(expectedVector.z), "Z is different");
        }

        public void AssertVector(Vector2 vector, Vector2 expectedVector)
        {
            Assert.That(vector.x, Is.EqualTo(expectedVector.x), "X is different");
            Assert.That(vector.y, Is.EqualTo(expectedVector.y), "Y is different");
        }
    }
}