using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        public void UpdateBoard()
        {
            Canvas.Controls.Clear();
            Canvas.Refresh();
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            Canvas.CreateGraphics().DrawLine(new Pen(Color.Red, 3), 100, 100, 200, 200);
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            Rectangle Ellipse = new Rectangle(5, 10, 150, 200);
            Canvas.CreateGraphics().DrawEllipse(new Pen(Color.Blue, 2), Ellipse);
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            Point s1 = new Point(10, 100); // Начальная точка
            Point s2 = new Point(100, 10);
            Point s3 = new Point(150, 150);
            Point s4 = new Point(200, 100);
            Canvas.CreateGraphics().DrawBezier(new Pen(Color.Black, 3), s1, s2, s3, s4);
        }

        private void btnBeziers_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            Point[] MyPoints = new[] { new Point(10, 100), new Point(75, 10),
                new Point(80, 50), new Point(100, 150), new Point(125, 80),
                new Point(175, 200), new Point(200, 80) };
            Canvas.CreateGraphics().DrawBeziers(new Pen(Color.Red, 3), MyPoints);
        }

        private void btnEllipseSepment_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            // указываем расположение и размеры эллипса
            float x = 0.0F;
            float y = 0.0F;
            float width = 150.0F;
            float height = 150.0F;
            // Указываем начальный и конечный углы
            float startAngle = 0.0F;
            float endAngle = 120.0F;
            // Заливаем сегмент
            Canvas.CreateGraphics().FillPie(new SolidBrush(Color.Blue), x, y, width, height, startAngle, endAngle);
        }

        private void btnDiagram_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            SolidBrush brush = new SolidBrush(Color.Honeydew);
            float[] Angles = new float[] { 0, 130, 205, 290, 360 };
            Color[] Colors = new[] { Color.LightGoldenrodYellow, Color.PaleTurquoise, Color.RoyalBlue, Color.Purple };
            Rectangle rect = new Rectangle(10, 50, 250, 150);
            for (int angle = 1; angle <= Angles.Length - 1; angle++)
            {
                brush.Color = Colors[angle - 1];
                Canvas.CreateGraphics().FillPie(brush, rect, Angles[angle - 1], Angles[angle] - Angles[angle - 1]);
            }
            Canvas.CreateGraphics().DrawEllipse(Pens.Black, rect);
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            // Определяем штриховую кисть
            HatchBrush hBrush = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.DarkGoldenrod, Color.Crimson);
            // Создаем точки, определяющие полигон
            PointF point1 = new PointF(0.0F, 0.0F);
            PointF point2 = new PointF(100.0F, 25.0F);
            PointF point3 = new PointF(200.0F, 5.0F);
            PointF point4 = new PointF(250.0F, 50.0F);
            PointF point5 = new PointF(300.0F, 100.0F);
            PointF point6 = new PointF(350.0F, 200.0F);
            PointF point7 = new PointF(200.0F, 200.0F);
            PointF point8 = new PointF(130.0F, 230.0F);
            PointF[] curvePoints = new[] { point1, point2, point3, point4, point5, point6, point7, point8 };
            // Определяем режим заливки
            FillMode newFillMode = FillMode.Winding;
            // Заливаем полигон
            Canvas.CreateGraphics().FillPolygon(hBrush, curvePoints, newFillMode);
        }

        private void btnPolygons_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            LinearGradientBrush linGrBrush = new LinearGradientBrush(new Point(0, 10), new Point(200, 10), Color.DarkOliveGreen, Color.DarkOrchid);
            PointF[] FirstCurvePoints = new[] { new PointF(0.0F, 0.0F), new PointF(100.0F, 50.0F), new PointF(200.0F, 5.0F), new PointF(250.0F, 50.0F) };
            PointF[] SecondCurvePoints = new[] { new PointF(300.0F, 100.0F), new PointF(350.0F, 200.0F), new PointF(200.0F, 200.0F), new PointF(130.0F, 230.0F) };
            // Объявляем путь
            GraphicsPath graphPath = new GraphicsPath();
            // Добавляем к пути первый полигон
            graphPath.AddPolygon(FirstCurvePoints);
            // Добавляем к пути второй полигон
            graphPath.AddPolygon(SecondCurvePoints);
            // Закрашиваем путь градиентной заливкой
            Canvas.CreateGraphics().FillPath(linGrBrush, graphPath);
        }

        private void btnTextPolygon_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            GraphicsPath myGraphicsPath = new GraphicsPath();
            Point[] myPointArray = new[] { new Point(15, 50), new Point(20, 40), new Point(50, 30) };
            FontFamily myFontFamily = new FontFamily("Comic Sans Ms");
            PointF myPointF = new PointF(50, 50);
            StringFormat myStringFormat = new StringFormat();
            myGraphicsPath.AddArc(0, 0, 30, 60, 30, 180);
            myGraphicsPath.AddCurve(myPointArray);
            myGraphicsPath.AddString("О сколько нам открытий...", myFontFamily, 0, 32, myPointF, myStringFormat);
            PointF[] CurvePoints = new[] { new PointF(300.0F, 100.0F), new PointF(350.0F, 200.0F), new PointF(200.0F, 200.0F), new PointF(130.0F, 230.0F) };
            myGraphicsPath.AddPolygon(CurvePoints);

            Pen MyPen = new Pen(Color.Black, 1);
            PathGradientBrush pthGrBrush = new PathGradientBrush(myGraphicsPath);
            pthGrBrush.CenterColor = Color.DarkRed;
            Color[] colors = new[] { Color.DarkViolet };
            pthGrBrush.SurroundColors = colors;
            Canvas.CreateGraphics().FillPath(pthGrBrush, myGraphicsPath);
            Canvas.CreateGraphics().DrawPath(MyPen, myGraphicsPath);
        }

        private void btnGradient_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            Rectangle MyRectangle = new Rectangle(0, 0, 200, 200);
            Pen MyPen = new Pen(Color.Red, 2);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(MyRectangle);
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            // Центр пути будет красного цвета
            pthGrBrush.CenterColor = Color.FromArgb(255, 255, 0, 0);
            Canvas.CreateGraphics().DrawEllipse(MyPen, MyRectangle);
            Canvas.CreateGraphics().FillPath(pthGrBrush, path);
        }

        private void btnPointsArray_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            // Строим градиент, основанный на массиве точке
            PointF[] myPoints = new[] { new PointF(30, 0), new PointF(60, 0), new PointF(90, 30), new PointF(90, 60), new PointF(60, 90), new PointF(30, 90), new PointF(0, 60), new PointF(0, 30) };
            PathGradientBrush myBrush = new PathGradientBrush(myPoints);
            Color[] colors = new[] { Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 0, 255, 0), Color.FromArgb(255, 0, 0, 255), Color.FromArgb(255, 0, 255, 0), Color.FromArgb(255, 255, 0, 0), Color.FromArgb(255, 0, 255, 0), Color.FromArgb(255, 0, 0, 255), Color.FromArgb(255, 255, 0, 0) };
            myBrush.SurroundColors = colors;
            // Центр будет белым
            myBrush.CenterColor = Color.White;
            // Используем градиентную кисть для заливки прямоугольника
            Canvas.CreateGraphics().FillRectangle(myBrush, new Rectangle(0, 0, 200, 200));
        }

        private void btnGradientAlongThePath_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            Graphics g = Canvas.CreateGraphics();
            // Создаем путь содержащий отдельный прямоугольник
            GraphicsPath MyPath = new GraphicsPath();
            MyPath.AddRectangle(new Rectangle(0, 0, 200, 100));
            // Создаем градиентную кисть, основанную на пути прямоугольника
            PathGradientBrush myBrush = new PathGradientBrush(MyPath);
            // Цвет за пределами границы будет красным
            // Изменяем имя переменной для цвета
            Color[] redColor = new[] { Color.Red };
            myBrush.SurroundColors = redColor;
            // Цвет центра будет морской волны
            myBrush.CenterColor = Color.Aqua;
            // Используем градиентную ксить для заливки прямоугольника
            g.FillPath(myBrush, MyPath);
            // Устанавливаем масштаб фокуса для градиентной кисти
            myBrush.FocusScales = new PointF(0.2F, 0.5F);
            // Используем градиентную кисть для заливки прямоугольника(снова)
            // Показываем этот залитый прямоугольник справа от первого(залитого) ;
            g.TranslateTransform(0.0F, 150.0F);
            g.FillPath(myBrush, MyPath);
        }

        private void btnInterpolation_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            // Вершины внешнего квадрата
            Point[] myPoints = new[] { new Point(0, 0), new Point(200, 0), new Point(200, 200), new Point(0, 200) };
            // Градиентный путь не используется.
            // Градиентная кисть строится прямо из массива точек
            PathGradientBrush myBrush = new PathGradientBrush(myPoints);
            // Создаем массив цветов
            Color[] colors = new[] { Color.FromArgb(255, 0, 128, 0), Color.FromArgb(255, 128, 0, 255), Color.FromArgb(255, 0, 128, 128) };
            float[] relativePositions = new[] { 0.0F, 0.4F, 1.0F };
            ColorBlend colorBlend = new ColorBlend();
            colorBlend.Colors = colors;
            colorBlend.Positions = relativePositions;
            myBrush.InterpolationColors = colorBlend;
            // Заливаем прямоугольник, больший по размерам, чем квадрат
            Canvas.CreateGraphics().FillRectangle(myBrush, 0, 0, 200, 200);

        }

        private void btnGradientCenterPoint_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            // Создаем путь, содержащий полигон
            GraphicsPath path = new GraphicsPath();
            PointF[] Mypoints = new[] { new PointF(0, 150), new PointF(150, 0), new PointF(300, 150), new PointF(150, 300) };
            path.AddPolygon(Mypoints);
            // Используем путь для создания кисти
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            // Размещаем центральную точку,
            // не являющуюся центром полигона
            pthGrBrush.CenterPoint = new PointF(120, 40);
            pthGrBrush.CenterColor = Color.DarkRed;
            Color[] colors = new[] { Color.CornflowerBlue };
            pthGrBrush.SurroundColors = colors;
            Canvas.CreateGraphics().FillPolygon(pthGrBrush, Mypoints);
        }

        private void btnRegion_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            // Создаем путь
            GraphicsPath MyPath = new GraphicsPath();
            Rectangle FirstRectangle = new Rectangle(0, 0, 100, 50);
            Rectangle SecondRectangle = new Rectangle(50, 50, 150, 100);
            // Добавляем к пути эллипс и прямоугольник
            MyPath.AddEllipse(FirstRectangle);
            MyPath.AddRectangle(SecondRectangle);
            // Добавляем путь к области
            Region myRegion = new Region(MyPath);
            SolidBrush MyBrush = new SolidBrush(Color.DarkCyan);
            // Закрашиваем область
            Canvas.CreateGraphics().FillRegion(MyBrush, myRegion);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            // Создаем первый путь
            GraphicsPath FirstPath = new GraphicsPath();
            // Добавляем к первому путиэллипс
            FirstPath.AddEllipse(new Rectangle(0, 0, 200, 100));
            // Добавляем к области первый путь
            Region myRegion = new Region(FirstPath);
            // Создаем второй путь
            GraphicsPath SecondPath = new GraphicsPath();
            SolidBrush myBrush = new SolidBrush(Color.Red);
            // Добавляем прямоугольник ко второму пути
            SecondPath.AddRectangle(new Rectangle(50, 50, 250, 150));
            // Вычитаем второй путь из области
            myRegion.Xor(SecondPath);
            Canvas.CreateGraphics().FillRegion(myBrush, myRegion);
        }

        private void btnComb_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            // Создаем первый путь
            GraphicsPath FirstPath = new GraphicsPath();
            // Добавляем к первому путиэллипс
            FirstPath.AddEllipse(new Rectangle(0, 0, 200, 100));
            // Добавляем к области первый путь
            Region myRegion = new Region(FirstPath);
            // Создаем второй путь
            GraphicsPath SecondPath = new GraphicsPath();
            SolidBrush myBrush = new SolidBrush(Color.Red);
            // Добавляем прямоугольник ко второму пути
            SecondPath.AddRectangle(new Rectangle(50, 50, 250, 150));
            // Объединяем второй путь с областью
            myRegion.Union(SecondPath);
            Canvas.CreateGraphics().FillRegion(myBrush, myRegion);
        }

        private void btnComplement_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            GraphicsPath FirstPath = new GraphicsPath();
            GraphicsPath SecondPath = new GraphicsPath();
            // Создаем эллипс и отображаем его на экране
            // с помощью черного цвета
            Rectangle regionRect = new Rectangle(20, 20, 100, 100);
            FirstPath.AddEllipse(regionRect);
            Canvas.CreateGraphics().DrawPath(Pens.Black, FirstPath);
            // Создаем второй эллипс, пересекающийся с первым,
            // и отображаем его на экране с помощью красного цвета
            Rectangle complementRect = new Rectangle(90, 30, 100, 100);
            SecondPath.AddEllipse(complementRect);
            Canvas.CreateGraphics().DrawPath(Pens.Red, SecondPath);
            // Создаем две области, используя соответственно
            // первый и второй пути
            Region myRegion = new Region(FirstPath);
            // Возвращаем дополнение первой области
            // при объединении со второй областью
            Region complementRegion = new Region(SecondPath);
            // Выполняем заливку области дополнения
            // синим цветом и изображаем ее на экране
            myRegion.Complement(SecondPath);
            // Заливаем дополнение синим цветом
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            Canvas.CreateGraphics().FillRegion(myBrush, myRegion);
        }

        private void btnExclude_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            GraphicsPath FirstPath = new GraphicsPath();
            GraphicsPath SecondPath = new GraphicsPath();
            // Создаем эллипс и отображаем его
            // на экране с помощью черного цвета
            Rectangle regionRect = new Rectangle(20, 20, 100, 100);
            FirstPath.AddEllipse(regionRect);
            Canvas.CreateGraphics().DrawPath(Pens.Black, FirstPath);
            // Создаем второй эллипс, пересекающийся с первым,
            // и отображаем его на экране с помощью красного цвета
            RectangleF complementRect = new RectangleF(90, 30, 100, 100);
            SecondPath.AddEllipse(complementRect);
            Canvas.CreateGraphics().DrawPath(Pens.Red, SecondPath);
            // Создаем область, используя первый эллипс
            Region myRegion = new Region(FirstPath);
            // Возвращаем неисключенную часть области
            // при объединении со вторым эллипсом
            myRegion.Exclude(SecondPath);
            // Выполняем заливку неисключенной области
            // синим цветом и изображает ее на экране
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            Canvas.CreateGraphics().FillRegion(myBrush, myRegion);
        }

        private void btnIntersect_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            GraphicsPath FirstPath = new GraphicsPath();
            GraphicsPath SecondPath = new GraphicsPath();
            // Создаем первый эллипс и отображаем
            // его на экране с помощью черного цвета
            Rectangle regionRect = new Rectangle(20, 20, 100, 100);
            FirstPath.AddEllipse(regionRect);
            Canvas.CreateGraphics().DrawPath(Pens.Black, FirstPath);
            // Создаем второй эллипс и отображаем его
            // на экране с помощью красного цвета
            RectangleF complementRect = new RectangleF(90, 30, 100, 100);
            SecondPath.AddEllipse(complementRect);
            Canvas.CreateGraphics().DrawPath(Pens.Red, SecondPath);
            // Создаем область, используя первый эллипс
            Region myRegion = new Region(FirstPath);
            // Возвращаем для области область пересечения
            // при объединении со вторым эллипсом
            myRegion.Intersect(SecondPath);
            // Выполняем заливку области пересечения
            // синим цветом и отображаем ее на экране
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            Canvas.CreateGraphics().FillRegion(myBrush, myRegion);
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            PictureBox MyPictureBox = new PictureBox();
            MyPictureBox.Location = new Point(10, 10);
            MyPictureBox.Size = new Size(750, 409);
            Canvas.Controls.Add(MyPictureBox);
            Image img;
            img = Image.FromFile(@"C:\\png.png");
            MyPictureBox.Image = img;
        }
        string str;
        private void btnDownloadImage_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            Stream myStream;
            OpenFileDialog MyopenFileDialog = new OpenFileDialog();
            MyopenFileDialog.Filter = @"Images|*.GIF;*JPG;*.TIF;*BMP";
            MyopenFileDialog.FilterIndex = 2;
            MyopenFileDialog.RestoreDirectory = true;
            PictureBox MyPictureBox = new PictureBox();
            if (MyopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                myStream = MyopenFileDialog.OpenFile();
                str = MyopenFileDialog.FileName;
                if (!(myStream == null))
                {
                    MyPictureBox.Location = new Point(0, 0);
                    Canvas.Controls.Add(MyPictureBox);
                    int height = Image.FromFile(MyopenFileDialog.FileName).Height;
                    int width = Image.FromFile(MyopenFileDialog.FileName).Width;
                    MyPictureBox.Size = new Size(width, height);
                    MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    MyPictureBox.Image = Image.FromFile(MyopenFileDialog.FileName);
                    myStream.Close();
                }
            }
        }
        private void btnRotateFlip_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            PictureBox MyPictureBox = new PictureBox();
            MyPictureBox.Location = new Point(10, 10);
            MyPictureBox.Size = new Size(750, 409);
            Image img;
            img = Image.FromFile(@str);
            MyPictureBox.Image = img;
            MyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Canvas.Controls.Add(MyPictureBox);
        }

        private void btnColorInversion_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            PictureBox MyPictureBox = new PictureBox();
            MyPictureBox.Location = new Point(10, 10);
            MyPictureBox.Size = new Size(400, 218);
            Canvas.Controls.Add(MyPictureBox);
            MyPictureBox.Image = Image.FromFile(str);
            Bitmap bmap = new Bitmap(MyPictureBox.Image);
            MyPictureBox.Image = bmap;
            Bitmap tempbmp = new Bitmap(MyPictureBox.Image);
            int DX = 1;
            int DY = 1;
            int red, green, blue;
            int i, j;
            {
                var withBlock = tempbmp;
                for (i = DX; i <= withBlock.Height - DX - 1; i++)
                {
                    for (j = DY; j <= withBlock.Width - DY - 1; j++)
                    {
                        red = 255 - Convert.ToInt32(Convert.ToInt32(withBlock.GetPixel(j - 1, i - 1).R));
                        green = 255 - Convert.ToInt32(Convert.ToInt32(withBlock.GetPixel(j - 1, i - 1).G));
                        blue = 255 - Convert.ToInt32(Convert.ToInt32(withBlock.GetPixel(j - 1, i - 1).B));

                        red = Math.Min(Math.Max(red, 0), 255);
                        green = Math.Min(Math.Max(green, 0), 255);
                        blue = Math.Min(Math.Max(blue, 0), 255);
                        bmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                        if (i % 10 == 0)
                        {
                            MyPictureBox.Invalidate();
                            MyPictureBox.Refresh();
                        }

                    }
                }
            }
        }

        private void btnScale_Click(object sender, EventArgs e)
        {
            UpdateBoard();
            PictureBox MyPictureBox = new PictureBox();
            MyPictureBox.Location = new Point(10, 10);

            MyPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(MyPictureBox_Paint);
            Canvas.Controls.Add(MyPictureBox);
        }

        private void MyPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(@"C:\\JPG.jpg");
            (sender as PictureBox).Size = new Size(bitmap.Size.Width, bitmap.Size.Height);
            e.Graphics.DrawImage(bitmap, new Rectangle(10, 10, bitmap.Size.Width/2, bitmap.Size.Height/2));
        }
    }
}