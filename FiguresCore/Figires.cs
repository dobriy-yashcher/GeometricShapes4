//Turushkin Sergey, 220P "GeometricShapes3" 01.06.22

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FiguresCore
{
    [Serializable]
    public class Figires
    {
        public List<FilledFigure> page = new List<FilledFigure>();
        public Drawer drawer;
        public Color strokeColor;
        public Color fillColor;

        public Figires() 
        {
            strokeColor = Color.Black;
            fillColor = Color.Black;
        }

        public void Add(FilledFigure figure)
        {
            page.Add(figure);
        }

        public void Save(string path)
        {
            var formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, page);
            }
        }

        public void Load(string path)
        {
            var formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                page = (List<FilledFigure>)formatter.Deserialize(fs);
            }
        }

        public override string ToString()
        {
            string result = "";

            foreach (Figure fig in page)
            {
                result += fig.ToString() + Environment.NewLine;
            }

            return result;
        }

        public void Draw()
        {
            /*foreach (var fig in page)
            {
                fig.drawer = drawer;
                fig.Draw();
            }*/
            drawer.DrawFigires(page);
        }
    }
}