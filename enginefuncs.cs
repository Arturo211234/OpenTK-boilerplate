using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;
using vector;

namespace gamefuncs{
    public class funcs{
    public static void background(float red, float green, float blue){
            float r = (float)(red * 0.003921568627);
            float g = (float)(green * 0.003921568627);
            float b = (float)(blue * 0.003921568627);
            if (r > 1){
                r = 1.0f;
            } else if (g > 1){
                g = 1.0f;
            } else if (b > 1){
                b = 1.0f;
            }
            GL.ClearColor(r, g, b, 1);
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }


        public static float getCoord(float coord_pos, int max){
            float hw = max / 2;
            float work = coord_pos - hw;
            int tsgn = sign(work);
            float abdist = (float)(abs(work));
            float thepos = tsgn * (abdist / hw);
            return thepos;
        }

         public static void setColor(float red, float green, float blue){
            
            float r = (float)(red * 0.003921568627);
            float g = (float)(green * 0.003921568627);
            float b = (float)(blue * 0.003921568627);
            if (r > 1){
                r = 1.0f;
            } else if (g > 1){
                g = 1.0f;
            } else if (b > 1){
                b = 1.0f;
            }
            GL.Color3(r, g, b);
        }

         public static void point(double x, double y){
            GL.Begin(PrimitiveType.Points);
            GL.Vertex2(x, y);
            GL.End();
        }

         public static void line(double xs, double ys, double xe, double ye){
            GL.Begin(PrimitiveType.Lines);
            GL.Vertex2(xs, ys);
            GL.Vertex2(xe, ye);
            GL.End();
        }

        public static double sin(double val){
            double yay = Math.Sin(val);
            return yay;
        }

        public static double cos(double val){
            double yay = Math.Cos(val);
            return yay;
        }

        public static int sign(double val){
            if(val > 0){
                return 1;
            } else if (val < 0){
                return -1;
            } else {
                return 0;
            }
        }

        public static double pow(double inp, double raise){
            double yay = Math.Pow(inp, raise);
            return yay;
        }

        public static double abs(double val){
            double yay = Math.Abs(val);
            return yay;
        }

        //BASIC FUNCTIONS END
    }
}