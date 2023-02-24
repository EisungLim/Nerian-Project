using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVTProgram
{
    public class VectorModel : NotifyBase
    {
        private float _pointX;
        private float _pointY;
        private float _pointZ;

        public float PointX { get => _pointX; set => SetProperty(ref _pointX, value); }
        public float PointY { get => _pointY; set => SetProperty(ref _pointY, value); }
        public float PointZ { get => _pointZ; set => SetProperty(ref _pointZ, value); }

        public VectorModel(float pointX, float pointY, float pointZ ) 
        {
            PointX = pointX;
            PointY = pointY; 
            PointZ = pointZ;
        }
    }
}
