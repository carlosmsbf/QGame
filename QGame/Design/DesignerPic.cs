using A2CBarros;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2CBarros.Forms.Design
{
    public class DesignerPic : PictureBox
    {
        private DesignerToolEnum picType;

        private int picRow, picColumn;

        public DesignerToolEnum PicType { get => picType; set => picType = value; }
        public int PicRow { get => picRow; set => picRow = value; }
        public int PicColumn { get => picColumn; set => picColumn = value; }

        //used to store the image and the type of the picture using enum. 
        public void SetImage(DesignerToolEnum pic)
        {
            PicType = pic;
            Image = GetImage(pic);
        }

        //Used to store the image for the user be able to change the picturebox generated.
        private Image GetImage(DesignerToolEnum pic)
        {
            Image choosenPic = Image;


            if (pic == DesignerToolEnum.None)
            {
                choosenPic = Resources.None;
            }

            else if (pic == DesignerToolEnum.Wall)
            {
                choosenPic = Resources.Wall;
            }
            else if (pic == DesignerToolEnum.RedBox)
            {
                choosenPic = Resources.RedBox;
            }
            else if (pic == DesignerToolEnum.RedDoor)
            {
                choosenPic = Resources.RedDoor;
            }
            else if (pic == DesignerToolEnum.BlueBox)
            {
                choosenPic = Resources.BlueBox;
            }
            else if (pic == DesignerToolEnum.BlueDoor)
            {
                choosenPic = Resources.BlueDoor;
            }
            return choosenPic;
        }

        // It set all other pictures in the Maze builther to a smaller size from others in order to user idenfify what he is using.
        public static void SelectImagePicture(PictureBox pic, int picSize)
        {
            pic.Size = new Size(picSize, picSize);
            pic.BorderStyle = BorderStyle.Fixed3D;
        }


        // It set all other pictures in the Maze builther to a normal size.
        public static void PicSize(Panel panel)
        {
            var picBox = panel.Controls.OfType<Panel>().SelectMany(p => p.Controls.OfType<PictureBox>());
            foreach (var image in picBox)
            {
                image.BorderStyle = BorderStyle.FixedSingle;
                image.Size = new Size(80, 80);
            }
        }


        public static void UnselectTool(PictureBox toolPicture, int squareSize)
        {
            toolPicture.Size = new Size(squareSize, squareSize);
            toolPicture.BorderStyle = BorderStyle.FixedSingle;
        }

        public static void SelectTool(PictureBox toolPicture, int squareSize)
        {
            toolPicture.Size = new Size(squareSize, squareSize);
            toolPicture.BorderStyle = BorderStyle.Fixed3D;
        }

    }
}
