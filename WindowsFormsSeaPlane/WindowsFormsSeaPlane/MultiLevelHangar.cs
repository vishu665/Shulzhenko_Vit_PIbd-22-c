﻿using System;
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
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile("CountLeveles:" + hangarStages.Count + Environment.NewLine, fs);
                foreach (var level in hangarStages)
                {
                    WriteToFile("Level" + Environment.NewLine, fs);
                    for (int i = 0; i < countPlaces; i++)
                    {
                        try
                        {
                            var plane = level[i];
                            if (plane.GetType().Name == "Plane")
                            {
                                WriteToFile(i + ":Plane:", fs);
                            }
                            if (plane.GetType().Name == "SeaPlane")
                            {
                                WriteToFile(i + ":SeaPlane:", fs);
                            }
                            WriteToFile(plane + Environment.NewLine, fs);
                        }
                        finally { };
                    }
                }
            }
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }
  
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
                string bufferTextFromFile = "";
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (fs.Read(b, 0, b.Length) > 0)            
                {
                        bufferTextFromFile += temp.GetString(b);
                    }
                }
                bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
                var strs = bufferTextFromFile.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (hangarStages != null)
                    {
                        hangarStages.Clear();
                    }
                    hangarStages = new List<Hangar<ITransport>>(count);
                }
                else
                {
                    throw new Exception("Неверный формат файла");
                }
                int counter = -1;
                ITransport plane = null;
                for (int i = 1; i < strs.Length; ++i)
                {
                    if (strs[i] == "Level")
                    line = fs.ReadLine();
                    if (line == null)
                        break;
                    if (line == "Level")

                    {
                        counter++;
                        hangarStages.Add(new Hangar<ITransport>(countPlaces,
                        pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(strs[i]))
                    {
                        continue;
                    }
                    if (strs[i].Split(':')[1] == "Plane")
                    {
                        plane = new Plane(strs[i].Split(':')[2]);
                    }
                    else if (strs[i].Split(':')[1] == "SeaPlane")
                    {
                        plane = new SeaPlane(strs[i].Split(':')[2]);
                    }
                    hangarStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = plane;
                }         
        }
    }