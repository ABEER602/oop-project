﻿using self_assessment__week_6_.BL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace self_assessment__week_6_.DL
{
    class DegreeProgramDL
    {
        public static List<DegreeProgram> programList = new List<DegreeProgram>();
              
        public static void addIntoDegreeList(DegreeProgram d)
        {
            programList.Add(d);
        }
        public static  DegreeProgram isDegreeExists(string degreeName)
        {
            foreach(DegreeProgram d in programList)
            {
                if (d.degreeName == degreeName)
                {
                    return d;
                }
            }
            return null;
        }

        public static void storeintoFile(string path, DegreeProgram d)
        {
            StreamWriter  f = new StreamWriter(path, true);
            string SubjectNames = "";
            for (int x = 0; x < d.subjects.Count -1; x++)
            {
                SubjectNames = SubjectNames + d.subjects[x].type + ";";
            }
           
            SubjectNames = SubjectNames + d.subjects[d.subjects.Count - 1].type;
            f.WriteLine(d.degreeName + "," + d.degreeDuration + "," + d.seats + "," + SubjectNames);
            f.Flush();
            f.Close();
        }

        public static bool readFromFile(string path)
        {
            StreamReader f = new StreamReader(path);
            string record;
            if (File.Exists (path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');
                    string degreeName = splittedRecord[0];
                    float degreeDuartion = float.Parse(splittedRecord[1]);
                    int seats = int.Parse(splittedRecord[2]);
                    string[] splittedRecordForSubject = splittedRecord[3].Split(',');
                    DegreeProgram d = new DegreeProgram(degreeName, degreeDuartion, seats);
                    for (int x = 0; x < splittedRecordForSubject.Length; x++)
                    {
                        Subject s = SubjectDL.isSubjectExists(splittedRecordForSubject[x]);
                        if (s!= null)
                        {
                            d.AddSubject(s);
                        }
                        addIntoDegreeList(d);
                    }
                   
                }
                f.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
