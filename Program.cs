using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics.OpenGL;
using System.Collections.Generic;
using vector;
using gamefuncs;

namespace gamengine{
    class Program{
        
        static void Main(string[] args){
        

        //BASIC FUNCTIONS START

        

        void frameUpdate(object sender, EventArgs e){


        }

        //Declare your variables above this function, and initialise them in the function. They won't work if declared below
        int width = 800;
        int height = 600;
        
         void initVariables(){
             
         }

         initVariables();
         OpenTK.GameWindow window = new OpenTK.GameWindow(width, height, OpenTK.Graphics.GraphicsMode.Default, "Myprogram - Lilly");
         window.Load += init;
         window.RenderFrame += running;
         window.UpdateFrame += frameUpdate;
         window.Run();
         
         
         
         void init(object sender, EventArgs e){
         GL.PointSize(3);
         
         }

         void running(object sender, EventArgs e){
          //CODE FOR RENDEREING HERE:
          funcs.background(135, 206, 235); // set background color
             
          funcs.setColor(244, 66, 223); //linecolor and stuff
          GL.Begin(PrimitiveType.Points); // if u actually set-up where TF u want ur dots to be drawn use this aafter

          
          
          window.SwapBuffers();
          
         }

         

        }

         
    }
}
