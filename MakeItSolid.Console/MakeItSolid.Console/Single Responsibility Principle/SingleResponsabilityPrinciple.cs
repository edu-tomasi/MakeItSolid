using System;
using System.Collections.Generic;
using System.IO;

namespace MakeItSolid.Console
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{count++}:{text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        #region Métodos que violam a SRP
        ///Esses métodos violam a SRP pois adicionam mais responsábilidades à classe Journal.
        ///Agora a classe Journal tem a responsabilidade de manter as entries e gerenciar as funcionalidades de persistência.
        ///
        //public void Save(string fileName)
        //{
        //    File.WriteAllText(fileName, ToString());
        //}

        //public static Journal Load(string fileName)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Load(Uri uri)
        //{

        //}
        #endregion
    }

    public class Persistence
    {
        public void SaveToFile(Journal j, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
            {
                File.WriteAllText(fileName, j.ToString());
            }
        }
    }
}
