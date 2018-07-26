using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloatMeansFiles
{
    class stacker
    {
        //private variables
        private string magic_number;
        private int width;
        private int height;
        private int max_color;
        private int numOfPictures;
        private string groupFormat;
        private class Pixel
        {
            private int red;
            private int green;
            private int blue;
        };

        List<List<List<Pixel>>> folderOfGrids;
        List<List<Pixel>> pixelFinal;

        //public functions
        public stacker(int numOfFiles, string groupName)
        {
            numOfPictures = numOfFiles;
            groupFormat = groupName;

        }

        public void FileMan()
        {
            //grouping all file names under readInFIleName List
            List<string> readInFileName = new List<string>();
            for (int i = 0; i < numOfPictures; i++)
            {
                if (i<11)
                {
                    readInFileName.Add($"{groupFormat}_00{i++}.ppm");
                }
                else if (i<101)
                {
                    readInFileName.Add($"{groupFormat}_0{i++}.ppm");
                }
                else
                {
                    readInFileName.Add($"{groupFormat}_{i++}.ppm");
                }
            }
            readInFileName.TrimExcess();

            Console.WriteLine("Stacking images:");
            //file Reader used
            int count = 0;
            foreach (string element in readInFileName)
            {
                Console.WriteLine($"{groupFormat}/{element}");
                FileReader(element, count);
                count++;
            }

            //reducing list count
            readInFileName.Clear();
            readInFileName.TrimExcess();
        }

        public void FileReader(string inFile_Name, int whichPicture_inputting)
        {

        }

        public void FileSender(string fileName)
        {

        }

        public void AverageCal()
        {

        }

    }
}
