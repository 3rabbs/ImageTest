using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;

namespace ImageMerge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            String sourceDir = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName).FullName).FullName).FullName;
        
            String path = sourceDir + "\\res\\Characters\\male\\";
            Bitmap bitmap = new Bitmap(128, 128);  //base image to add layers onto
            Random rand = new Random(); //used to randomly select images from a directory


            List<Bitmap> hats = new List<Bitmap>();
            
            hats.Add(new Bitmap(path + "hats\\hats1.png"));
            hats.Add(new Bitmap(path + "hats\\hats2.png"));



            List<Bitmap> faces = new List<Bitmap>();

            faces.Add(new Bitmap(path + "faces\\faces1.png"));
            faces.Add(new Bitmap(path + "faces\\faces2.png"));



            rand.Next(0, hats.Count);
            Bitmap image = hats[Convert.ToInt32(rand)];
            using (var g = Graphics.FromImage(bitmap))
            {
                
                g.DrawImage(image, 0, 0);
           
            }

            
            rand.Next(0, faces.Count);
            image = faces[Convert.ToInt32(rand)];
            using (var g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(image, 0, 0);

            }


            image.Save(path + "\\res\\Charcters");

        }
    }

}