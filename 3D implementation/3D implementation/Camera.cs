using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _3D_implementation
{
    class Camera
    {
        private Point3D position;
        float xRotation;
        float yRotation;

        public Camera(float x, float y, float z, float xRotation, float yRotation)
        {
            this.position = new Point3D(x,y,z);
            this.xRotation = xRotation;
            this.yRotation = yRotation;
        }

        public Camera()
        {
            this.position = new Point3D(0,0,0);
            this.xRotation = 0;
            this.yRotation = 0;
        }

        public void move(LOOKDIRECTION lookdirection)
        {
            //Todo implement Move in Camera
        }

        public void Look(LOOKDIRECTION lookdirection)
        {
            switch (lookdirection)
            {
                case LOOKDIRECTION.UP:
                    yRotation = 360 % (yRotation + 1);
                    break;
                case LOOKDIRECTION.DOWN:
                    yRotation = 360 % (yRotation - 1);
                    break;
                case LOOKDIRECTION.LEFT:
                    yRotation = 360 % (xRotation + 1);
                    break;
                case LOOKDIRECTION.RIGHT:
                    yRotation = 360 % (xRotation - 1);
                    break;
            }
        }

        public Point3D parseToCameraPoint(float x, float y, float z)
        {
            float returnX;
            returnX = x - this.position.X;
            returnX = (float)Math.Sin((Math.PI / 180) * xRotation) *returnX;
            
       
            float returnY;
            returnY = y - this.position.Y;
            returnY = (float)Math.Sin((Math.PI / 180) * yRotation) * returnY;
            
       
            float returnZ;
            returnZ = z - this.position.Z;

            return new Point3D(returnX,returnY,returnZ);

        }

        public enum LOOKDIRECTION
        {
            UP, DOWN, LEFT, RIGHT
        }
        public enum MOVEDIRECTION
        {
            FORWARD, BACKWARDS, LEFT, RIGHT
        }
    }
}
