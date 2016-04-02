namespace EuclidianProject
{
    using System;
using System.Collections;
using System.Collections.Generic;

    [VersionAttribute("2","4")]
    public class Path : IEnumerable<Point3D>
    {
        private List<Point3D> pointsSequence;

        public Path()
        {
            this.pointsSequence = new List<Point3D>();
        }

        public List<Point3D> PointsSequence
        {
            get
            {
                return this.pointsSequence;
            }

        }

        public void Add(Point3D point)
        {
            this.pointsSequence.Add(point);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.pointsSequence.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
