//Simple little Vector Library
//By: Arturo R. Contreras

namespace vector{

    public struct vec1d{
        public double vx;

        public double calvec(double pos0, double pos1){
            double poschange;
            poschange = pos1 - pos0;
            this.vx = poschange;
            return poschange;
        }
    }

    public struct vec2d{
        //The vector class should be capable of using any (numerical) data type
        //You can turn a high precision double into a lower precision integer fairly easily
        //But it's harder to turn a low precision integer into a higher precision double.
        public double x, y;

        public vec2d(double ix, double iy){
            x = ix;
            y = iy;
        }

    }

    public struct vec3d{
        public double x, y, z;

        public vec3d(double ix, double iy, double iz){
            x = ix;
            y = iy;
            z = iz;
        }

    }

    public struct vec4d{
        public double x, y, z, w;
        public vec4d(double ix, double iy, double iz, double iw){
            x = ix;
            y = iy;
            z = iz;
            w = iw;
        }

    }

}
