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
        private struct Pixel
        {
            private int red;
            private int green;
            private int blue;
        };

        //public functions
        public stacker(int numOfFiles, string groupName)
        {
            numOfPictures = numOfFiles;
            groupFormat = groupName;

        }

        public void FileMan(int numOfPics, string fileName)
        {

        }

        public void FileReader(string inFile_Name, int whichPicture_inputting)
        {

        }



    }
}
