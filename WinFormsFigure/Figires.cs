//Abramov Danil 220 GeometricFigures-4 24.06.2022
using System;
using System.Collections.Generic;
using System.IO;

namespace FigureTask
{
    class Figires
    {
        List<Figure> all;

        public Figires()
        {
            all = new List<Figure>();
        }
        public void Add(Figure figure)
        {
            all.Add(figure);
        }

        public int getLength()
        {
            return all.Count;
        }
        
        public void Save(string path)
        {
			Console.WriteLine("SAVE: " + path);
            using (var writer = new StreamWriter(path))
            {
                foreach (var f in all)
                {
                    writer.WriteLine(f.getInfo());
                }
            }
        }

		public void Load(string path)
		{
			Console.WriteLine("LOAD: " + path);
			using (var reader = new StreamReader(path))
			{
				string s;
				string[] data;
				while ((s = reader.ReadLine()) != null)
				{
					data = s.Split();
					switch (data[0])
					{
						case "L":
							all.Add(new
								Line(int.Parse(data[1]),
								int.Parse(data[2]),
								int.Parse(data[3]),
								int.Parse(data[4])));
							break;

						case "R":
							all.Add(new
								Rectangle(int.Parse(data[1]),
								int.Parse(data[2]),
								int.Parse(data[12]),
								int.Parse(data[15])));
							break;

						case "T":
							all.Add(new
								Triangle(int.Parse(data[1]),
								int.Parse(data[2]),
								int.Parse(data[10]),
								int.Parse(data[13])));
							break;

						case "C":
							all.Add(new
								Circle(int.Parse(data[1]),
								int.Parse(data[2]),
								int.Parse(data[3])));
							break;

						default:
							break;
					}
				}
			}
		}
	}
}