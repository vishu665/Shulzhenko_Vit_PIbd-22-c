using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsSeaplane;

namespace WindowsFormsSeaPlane
{
    class MultiLevelHangar
    {
        List<Hangar<ITransport>> hangarStages;
        private const int countPlaces = 20;       
        private int pictureWidth;
        private int pictureHeight;
        public MultiLevelHangar(int countStages, int pictureWidth, int pictureHeight)
        {
            hangarStages = new List<Hangar<ITransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                hangarStages.Add(new Hangar<ITransport>(countPlaces, pictureWidth, pictureHeight));
            }
        }
        public Hangar<ITransport> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < hangarStages.Count)
                {
                    return hangarStages[ind];
                }
                return null;
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename, false, System.Text.Encoding.Default))
            {
                fs.WriteLine("CountLeveles:" + hangarStages.Count);
                foreach (var level in hangarStages)
                {
                    fs.WriteLine("Level");
                    for (int i = 0; i < countPlaces; i++)
                    {
                        var plane = level[i];
                        if (plane != null)
                        {

                            if (plane.GetType().Name == "Plane")
                            {
                                fs.Write(i + ":Plane:");
                            }
                            if (plane.GetType().Name == "SeaPlane")
                            {
                                fs.Write(i + ":SeaPlane:");
                            }
                            fs.WriteLine(plane);
                        }
                    }
                }
            }
            return true;
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
  
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader fs = new StreamReader(filename, System.Text.Encoding.Default))
            {
                int counter = -1;
                ITransport transport = null;
                string line;
                line = fs.ReadLine();
                if (line.Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(line.Split(':')[1]);
                    if (hangarStages != null)
                    {
                        hangarStages.Clear();
                    }
                    hangarStages = new List<Hangar<ITransport>>(count);
                }
                else
                {                
                    return false;
                }
                while (true)
                {
                    line = fs.ReadLine();
                    if (line == null)
                        break;
                    if (line == "Level")
                    {
                        counter++;
                        hangarStages.Add(new Hangar<ITransport>(countPlaces, pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(line))
                    {
                        continue;
                    }
                    if (line.Split(':')[1] == "Plane")
                    {
                        transport = new Plane(line.Split(':')[2]);
                    }
                    else if (line.Split(':')[1] == "SeaPlane")
                    {
                        transport = new SeaPlane(line.Split(':')[2]);
                    }
                    hangarStages[counter][Convert.ToInt32(line.Split(':')[0])] = transport;
                }
                return true;
            }
        }
    }
}
