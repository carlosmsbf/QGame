using A2CBarros.Forms.Design;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CBarros.Design
{
   public class PicBoxGen
    {


        private Control parent;

        private int width;
        private int height;
        public static List<string> errorsMazeGenerator = new List<string>();


        public PicBoxGen(Control parent, int width, int height)
        {
            this.parent = parent;
            this.width = width;
            this.height = height;
        }


        //It generate a grid of picture box by letting the user giving the quantity of pictures using the textbox columns and rows.
        public void SquareGenerator(int rows, int cols, int positionX, int positionY, Control panel, EventHandler click)
        {   
                //allocate memory by memory by newing our array
               

                int x = positionX;
                int y = positionY;
                int gap = 5;
                int n = 0;
                int n2 = 0;
                for (int row = 0; row < rows; row++)
                {
                     n2++;
                    
                    for (int col = 0; col < cols; col++)
                    {
                      DesignerPic pictureBox = new DesignerPic();
                        pictureBox.Left = x;
                        pictureBox.Top = y;
                        pictureBox.Width = width;
                        pictureBox.Height = height;
                        pictureBox.Name = "pictureBox" + n + n2;
                        pictureBox.Image = Resources.None;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.PicType = DesignerToolEnum.None;
                        pictureBox.PicRow = row;
                        pictureBox.PicColumn = col;
                        n++;
                        pictureBox.Click += new EventHandler(click);
                        panel.Controls.Add(pictureBox);
                        x += width + gap;
                    }
                    x = positionX;
                    y += height + gap;
                }
         }

        //It will give an error in a case that has done something wrong in the program.
        public static List<string> ErrorGeneratorMaze(string rowTBox, string columnTBox)
        {
            errorsMazeGenerator.Clear();
            try
            {
                int rows = int.Parse(rowTBox);
                int columns = int.Parse(columnTBox);

                if (rows <= 0 || columns <= 0)
                {

                    errorsMazeGenerator.Add("The quantity of rows and columns can not be 0 and have to be an positive number.");

                }
            }
            catch (Exception error)
            {
                errorsMazeGenerator.Add(error + "\n\nPlease, give the correct data in the textbox\n");

            }
            if (errorsMazeGenerator.Count() != 0)
            {

                return errorsMazeGenerator;


            }
            else
            {
                return errorsMazeGenerator;
            }
        }

        //It will use the Grid Generator and set the picture at the right spot, cleaning if it remains any maze before.
        public static void GenerateMazeStructureGUI(int rows, int columns, Panel pnlStructure, EventHandler click)
        {
            pnlStructure.Controls.Clear();
            PicBoxGen pic2DGRIDgen = new PicBoxGen(pnlStructure, 80, 80);
            pic2DGRIDgen.SquareGenerator(rows, columns, 85, 85, pnlStructure, click);
            pnlStructure.Enabled = true;
        }






   }
}


    

