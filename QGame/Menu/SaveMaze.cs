using A2CBarros.Forms.Design;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CBarros.Design
{
    public class SaveMaze
    {

        private Panel panel;
        private int rowsNumber;
        private int columnsNumber;
        private static int wallsTotal;
        private static int emptySquareTotal;
        private static int redDoorTotal;
        private static int redBoxTotal;
        private static int blueBoxTotal;
        private static int blueDoorTotal;

        public static int rowPrivate;
        public static int columnPrivate;
        public static List<string> errorsSave = new List<string>();

        public SaveMaze(Panel panel, int rowsNumber, int columnsNumber)
        {
            this.panel = panel;
            this.rowsNumber = rowsNumber;
            this.columnsNumber = columnsNumber;
        }

        //It create the file created by the user as .txt.
        public static void SaveLayout(int rowsNumber, int columnsNumber, Panel maze)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = @"C:\",
                RestoreDirectory = true,
                FileName = "CBarros.txt"

            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = saveFileDialog.OpenFile();
                StreamWriter writer = new StreamWriter(fileStream);

                writer.WriteLine(rowsNumber);
                writer.WriteLine(columnsNumber);

                foreach (var pictureBox in maze.Controls.OfType<DesignerPic>())
                {
                    writer.WriteLine(pictureBox.PicRow);
                    writer.WriteLine(pictureBox.PicColumn);
                    writer.WriteLine(Convert.ToInt32(pictureBox.PicType));
                }

                writer.Close();
                fileStream.Close();
                DialogCountPic(maze);
            }

        }

        //It send to the user how many pictures of each type has in the maze, using the method MazeCount().
        public static void DialogCountPic(Panel pnlStructure)
        {
            int doorsTotal = 0;
            int boxsTotal = 0;

            MazeCount(pnlStructure);

            doorsTotal = redDoorTotal + blueDoorTotal;
            boxsTotal = redBoxTotal + blueBoxTotal;


            MessageBox.Show("File saved successfully: " +
                "\n Empty squares: " + emptySquareTotal +
                "\n Walls used: " + wallsTotal +
                "\n Doors used: " + doorsTotal +
                "\n (Red Doors: "+redDoorTotal+" / Blue Doors: "+blueDoorTotal+") "+
                "\n Boxs used: " + boxsTotal+
                "\n (Red Boxs: " + redBoxTotal + " / Blue Boxs: " + blueBoxTotal + ") ", "Q - Puzzle Game");
        }

        //Veryfy if there is 


        //It will count how many types of pictures has inside of Maze
        private static void MazeCount(Panel pnlStructure)
        {
            emptySquareTotal = pnlStructure.Controls.OfType<DesignerPic>().Count(p => p.PicType == DesignerToolEnum.None);
            wallsTotal = pnlStructure.Controls.OfType<DesignerPic>().Count(p => p.PicType == DesignerToolEnum.Wall);
            redDoorTotal = pnlStructure.Controls.OfType<DesignerPic>().Count(p => p.PicType == DesignerToolEnum.RedDoor);
            redBoxTotal = pnlStructure.Controls.OfType<DesignerPic>().Count(p => p.PicType == DesignerToolEnum.RedBox);
            blueBoxTotal = pnlStructure.Controls.OfType<DesignerPic>().Count(p => p.PicType == DesignerToolEnum.BlueBox);
            blueDoorTotal = pnlStructure.Controls.OfType<DesignerPic>().Count(p => p.PicType == DesignerToolEnum.BlueDoor);
        }


        //Created to veryfy if textBox has a empty/null/0 string. If it has, it will not allow the user to save
        public static bool TextBoxVerifer(string txt)
        {
            if (txt == string.Empty || txt == null || txt == "0")
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Created to send the error to the user, telling them what was the problem that occured.
        public static List<string> SaveMessage(string row,string column, Panel pnlStructure, List<string> errors)
            {
            errorsSave.Clear();
            if (!TextBoxVerifer(row) || !TextBoxVerifer(column))
            {
                errorsSave.Add("It is necessery to set number of rows and columns.");
            }
            else
            {
                rowPrivate = int.Parse(row);
                columnPrivate = int.Parse(row);

                    try
                    {
                        SaveLayout(int.Parse(row), int.Parse(column), pnlStructure);
                    }
                    catch (FileNotFoundException error)
                    {
                        errorsSave.Add("FileNotFoundException: " + error + Environment.NewLine);
                    }
                    catch (DirectoryNotFoundException error)
                    {
                        errorsSave.Add("DirectoryNotFoundException: " + error + Environment.NewLine);
                    }
                    catch (IOException error)
                    {
                        errorsSave.Add("IOException: " + error + Environment.NewLine);

                    }
                    catch (Exception error)
                    {
                        errorsSave.Add("Unexpected Exception: " + error + Environment.NewLine);

                    }   
            }
            if (errorsSave.Count() != 0)
            {     
                return errorsSave;
            }
            else { return errorsSave; }
        }
   
    }



}
