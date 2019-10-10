using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ControlResizing
{
    class ResizeControl : Form
    {
        private Rectangle originalControlRectangle;
        private Size originalFormSize;

        public ResizeControl()
        {

        }

        public ResizeControl(Rectangle rectangle)
        {
            originalControlRectangle = rectangle;
        }

        public ResizeControl(Size size)
        {
            originalFormSize = size;    
        }

        public ResizeControl(Rectangle rectangle,Size size)
        {
            originalControlRectangle = rectangle;
            originalFormSize = size;
        }

        public Rectangle AddRectangle
        {
            set
            {
                originalControlRectangle = value;
            }
        }

        public Size AddSize
        {
            set
            {
                originalFormSize = value;
            }
        }

        public void ChangeWidth(Size current_size,Control control)
        {
            float xRatio = (float)(current_size.Width) / (float)(originalFormSize.Width);
            int newWidth = (int)(originalControlRectangle.Size.Width * xRatio);
            control.Width = newWidth;
        }

        public void ChangeWidthAndMoveLocation(Size current_size,Control control)
        {
            float xRatio = (float)(current_size.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(current_size.Height) / (float)(originalFormSize.Height);
            int newX = (int)(originalControlRectangle.Location.X * xRatio);
            int newY = (int)(originalControlRectangle.Location.Y * yRatio);
            int newWidth = (int)(originalControlRectangle.Size.Width * xRatio);
            control.Location = new Point(newX, newY);
            control.Width = newWidth;
        }

        public void ChangeHeight(Size current_size,Control control)
        {
            float yRatio = (float)(current_size.Height) / (float)(originalFormSize.Height);
            int newHeight = (int)(originalControlRectangle.Size.Height * yRatio);
            control.Height = newHeight;
        }

        public void ChangeHeightAndMoveLocation(Size current_size,Control control)
        {
            float xRatio = (float)(current_size.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(current_size.Height) / (float)(originalFormSize.Height);
            int newX = (int)(originalControlRectangle.Location.X * xRatio);
            int newY = (int)(originalControlRectangle.Location.Y * yRatio);
            int newHeight = (int)(originalControlRectangle.Size.Height * yRatio);
            control.Location = new Point(newX, newY);
            control.Height = newHeight;
        }
        public void ResizeSize(Size current_size,Control control)
        {
            float xRatio = (float)(current_size.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(current_size.Height) / (float)(originalFormSize.Height);
            int newWidth = (int)(originalControlRectangle.Size.Width * xRatio);
            int newHeight = (int)(originalControlRectangle.Size.Height * yRatio);
            control.Size = new Size(newWidth, newHeight);
        }

        public void MoveLocation(Size current_size,Control control)
        {
            float xRatio = (float)(current_size.Width) / (float)(originalFormSize.Width);
            float yRatio = (float)(current_size.Height) / (float)(originalFormSize.Height);
            int newX = (int)(originalControlRectangle.Location.X * xRatio);
            int newY = (int)(originalControlRectangle.Location.Y * yRatio);
            control.Location = new Point(newX, newY);
        }

        public void ResizeAll(Size current_size,Control control)
        {
            float xRatio = (float)(current_size.Width) /(float)(originalFormSize.Width);
            float yRatio = (float)(current_size.Height) / (float)(originalFormSize.Height);
            int newX = (int)(originalControlRectangle.Location.X * xRatio);
            int newY = (int)(originalControlRectangle.Location.Y * yRatio);
            int newWidth = (int)(originalControlRectangle.Size.Width * xRatio);
            int newHeight = (int)(originalControlRectangle.Size.Height * yRatio);
            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }
    }
}
