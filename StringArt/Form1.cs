using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace StringArt
{
    public partial class Form1 : Form
    {
        Image file;
        Boolean opened = true;
        float brightness = 0.0f;
        float contrast = 1.0f;
        float saturation = 1.0f;
        float t = 0.0f;
        float luminanceR = 0.3086f;
        float luminanceG = 0.6094f;
        float luminanceB = 0.0820f;
        int offset = 0;
        int reduction = 256;

        static private int numberOfPoints = 0;
        static private int iterations = 0;
        int increase = 0;
       
        public List<Point> points;
        int ms1;       

        public Form1()
        {            
            InitializeComponent();

            label10.Text = trackBarBrightness.Value.ToString();
            label11.Text = trackBarContrast.Value.ToString();
            label12.Text = trackBarSaturation.Value.ToString();
            label14.Text = trackBarReduction.Value.ToString();
            offset = (int)numericUpDownOffset.Value;
            numberOfPoints = (int)numericUpDownPoints.Value;
            iterations = (int)numericUpDownLines.Value;
            increase = (int)numericUpDownIncrease.Value;
            reduction = trackBarReduction.Value;
            file = pictureBoxOrigin.Image;
        }
        private static List<Point> GenerateAnchorPoints(Point origin, float radius, int numberOfPoints)
        {
            List<Point> points2 = new List<Point>();
            float angle = (float)Math.PI * 2 / numberOfPoints;

            for (int i = 0; i < numberOfPoints; i++)
            {
                Point temp = new Point(origin.X + (int)(Math.Sin(angle * i) * radius), origin.Y - (int)(Math.Cos(angle * i) * radius));
                points2.Add(temp);
            }

            return points2;
        }

        private static List<Point> PlotLine(Point origin, Point destination)

        {
            List<Point> pts = new List<Point>();
            if (origin == destination)
            {
                pts.Add(origin);
                return pts;
            }
            if (Math.Abs(destination.Y - origin.Y) < Math.Abs(destination.X - origin.X))
            {
                if (origin.X > destination.X)
                {
                    pts = PlotLineLow(destination, origin);
                }
                else
                {
                    pts = PlotLineLow(origin, destination);
                }
            }
            else
            {
                if (origin.Y > destination.Y)
                {
                    pts = PlotLineHigh(destination, origin);
                }
                else
                {
                    pts = PlotLineHigh(origin, destination);
                }
            }
            return pts;
        }

        private static List<Point> PlotLineLow(Point origin, Point destination)
        {
            List<Point> pts = new List<Point>();
            int dx = destination.X - origin.X;
            int dy = destination.Y - origin.Y;
            int yi = 1;
            if (dy < 0)
            {
                yi = -1;
                dy = -dy;
            }
            int D = (2 * dy) - dx;
            int x = origin.X;
            int y = origin.Y;
            while (x < destination.X)
            {
                pts.Add(new Point(x, y));
                x++;
                if (D > 0)
                {
                    y += yi;
                    D += 2 * (dy - dx);
                }
                else
                {
                    D += 2 * dy;
                }
            }
            return pts;
        }

        private static List<Point> PlotLineHigh(Point origin, Point destination)
        {
            List<Point> pts = new List<Point>();
            int dx = destination.X - origin.X;
            int dy = destination.Y - origin.Y;
            int xi = 1;
            if (dx < 0)
            {
                xi = -1;
                dx = -dx;
            }
            int D = (2 * dx) - dy;
            int x = origin.X;
            int y = origin.Y;
            while (y < destination.Y)
            {
                Point temp = new Point(x, y);
                pts.Add(temp);
                y++;
                if (D > 0)
                {
                    x += xi;
                    D += 2 * (dx - dy);
                }
                else
                {
                    D += 2 * dx;
                }
            }
            return pts;
        }

        private byte[] BitmapToByteArray()
        {
            //##################################################################
            var stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
            Bitmap bitmap = new Bitmap(pictureBoxOrigin.Image);

            BitmapData bmdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);

            IntPtr Scan0 = bmdata.Scan0;
            int stride = bmdata.Stride;

            byte[] byteArray = new byte[bmdata.Width*bmdata.Height];
            int ind = 0;

            //Console.WriteLine($"BitmapToByteArray<< Width: {bmdata.Width} Height: {bmdata.Height} Strinde: {bmdata.Stride} ArrayLenght: {bmdata.Width * bmdata.Height}>>");
            unsafe
            {
                //ustaw scan0
                byte* ptr = (byte*)(void*)Scan0;
                for (int y = 0; y < bmdata.Height; y++)
                {
                    for (int x = 0; x < bmdata.Width; x++)
                    {
                        ind = y * stride + x*4;
                        byteArray[y * bmdata.Width + x] = ptr[ind];
                    }
                }
                
            }
            stopWatch.Stop();
            var ts = stopWatch.ElapsedMilliseconds;
            //Console.WriteLine("RunTime " + ts);

            bitmap.UnlockBits(bmdata);
            bitmap.Dispose();
            //##################################################################
            return byteArray;
        }

        private int CalculateMeanFromListOfPoints2(List<Point> pointsToCalculate, byte[] array, int width, int height)
        {

            int mean = 0;
            float total = 0;
            int ind = 0;

            foreach (Point pt in pointsToCalculate)
            {
                ind = pt.Y * width + pt.X;
                total += array[ind];
            }
            //wylicz srednia wartosc koloru
            if (pointsToCalculate.Count() > 0)
            {
                mean = (int)(total / pointsToCalculate.Count());
                //Console.WriteLine("mean:{0}", mean);
            }
            if (pointsToCalculate.Count() == 1)
            {
                mean = array[pointsToCalculate[0].Y * width + pointsToCalculate[0].X];
            }

            return mean;
        }

        private short CalculateMeanFromListOfPoints(List<Point> pointsToCalculate)
        {

            Bitmap bitmap = new Bitmap(pictureBoxOrigin.Image);
            BitmapData bmdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, bitmap.PixelFormat);
            short mean = 0;
            float total = 0;
            IntPtr Scan0 = bmdata.Scan0;
            int stride = bmdata.Stride;

            int ind = 0;
            unsafe
            {
                //ustaw scan0
                byte* ptr = (byte*)(void*)Scan0;
                //dla kazdego punktu na linii zliczaj sumę wartosci koloru
                foreach (Point pt in pointsToCalculate)
                {
                    ind = pt.Y * stride + pt.X * 4;
                    total += ptr[ind];
                }
                //wylicz srednia wartosc koloru
                if (pointsToCalculate.Count() > 0)
                {
                    mean = (short)(total / pointsToCalculate.Count());
                    //Console.WriteLine("mean:{0}", mean);
                }
                if (pointsToCalculate.Count() == 1)
                {
                    mean = ptr[pointsToCalculate[0].Y * stride + pointsToCalculate[0].X * 4];
                }
            }
            bitmap.UnlockBits(bmdata);
            bitmap.Dispose();
            return mean;
        }

        void openImage()
        {
            if (openFileDialogOrigin.ShowDialog() == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialogOrigin.FileName);
                pictureBoxOrigin.Image = file;
                opened = true;

                trackBarBrightness.Enabled = true;
                trackBarContrast.Enabled = true;
                trackBarSaturation.Enabled = true;
            }
        }

        void saveImageOrigin()
        {
            if (opened)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ext = Path.GetExtension(saveFileDialog.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBoxOrigin.Image.Save(saveFileDialog.FileName, format);
                }
            }
        }

        void saveImageResult()
        {
            saveFileDialogResult.FileName = $"{ openFileDialogOrigin.FileName.Substring(openFileDialogOrigin.FileName.LastIndexOf("\\") + 1, openFileDialogOrigin.FileName.LastIndexOf(".") - openFileDialogOrigin.FileName.LastIndexOf("\\") - 1) } Bright{ trackBarBrightness.Value.ToString() } Contr{ trackBarContrast.Value.ToString() } Satur{ trackBarSaturation.Value.ToString() } Points{ numberOfPoints.ToString() } Lines{ numericUpDownLines.Value.ToString() } Increase{ numericUpDownIncrease.Value.ToString() } Reduction{ trackBarReduction.Value.ToString() }.png";
           
            if(saveFileDialogResult.ShowDialog()==DialogResult.OK)
            {
                ImageFormat format = ImageFormat.Png;
                string ext = Path.GetExtension(saveFileDialogResult.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                pictureBoxResult.Image.Save(saveFileDialogResult.FileName, format);
            }
        }

        void drawImage()
        {
            Image img = file;
            Bitmap bmpnew = new Bitmap(img.Width, img.Height);
            int[] array = paletteArray(reduction);

            ImageAttributes ia = new ImageAttributes();
            ColorMatrix cmPicture = new ColorMatrix(new float[][]
            {
                    new float[]{contrast*(((1-saturation)*luminanceR)+saturation), contrast*((1 - saturation) * luminanceR), contrast * ((1 - saturation) * luminanceR), 0, 0},
                    new float[]{ contrast * ((1 - saturation) * luminanceG), contrast * (((1 - saturation) * luminanceG) + saturation), contrast * ((1 - saturation) * luminanceG), 0, 0},
                    new float[]{ contrast * ((1 - saturation) * luminanceB), contrast * ((1 - saturation) * luminanceB), contrast * (((1 - saturation) * luminanceB) + saturation), 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{t+brightness, t + brightness, t + brightness, 0, 0}
            });

            ia.SetColorMatrix(cmPicture);


            Graphics g = Graphics.FromImage(bmpnew);
            g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

            BitmapData bmdata = bmpnew.LockBits(new Rectangle(0, 0, bmpnew.Width, bmpnew.Height), ImageLockMode.ReadWrite, bmpnew.PixelFormat);

            IntPtr Scan0 = bmdata.Scan0;
            int stride = bmdata.Stride;
            int ind = 0;
            int color = 0;
            unsafe
            {
                //ustaw scan0
                byte* ptr = (byte*)(void*)Scan0;
                for (int y = 0; y < bmdata.Height; y++)
                {
                    for (int x = 0; x < bmdata.Width; x++)
                    {
                        ind = y * stride + 4 * x;
                        //ptr[ind] -> 0-255 wartosc koloru
                        color = ptr[ind];
                        ptr[ind] = (byte)array[color];
                        ptr[ind + 1] = (byte)array[color];
                        ptr[ind + 2] = (byte)array[color];
                    }
                }
            }
            g.Dispose();
            bmpnew.UnlockBits(bmdata);

            pictureBoxOrigin.Image = bmpnew;
        }
        private void obrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openImage();
        }

        private void obrazToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveImageOrigin();
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {
            brightness = trackBarBrightness.Value / 100f;
            label10.Text = trackBarBrightness.Value.ToString();
            if (opened)
            {
                drawImage();
            }
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            contrast = trackBarContrast.Value / 100f;
            t = (1.0f - contrast) / 2.0f;
            label11.Text = trackBarContrast.Value.ToString();

            if (opened)
            {
                drawImage();       
            }
        }

        private void trackBarSaturation_Scroll(object sender, EventArgs e)
        {
            saturation = trackBarSaturation.Value / 100f;
            label12.Text = trackBarSaturation.Value.ToString();

            if (opened)
            {
                drawImage();
            }
        }

        private void numericUpDownPoints_ValueChanged(object sender, EventArgs e)
        {
            numberOfPoints = (int)numericUpDownPoints.Value;
        }

        private void numericUpDownLines_ValueChanged(object sender, EventArgs e)
        {
            iterations = (int)numericUpDownLines.Value;
        }

        private void numericUpDownIncrease_ValueChanged(object sender, EventArgs e)
        {
            increase = (int)numericUpDownIncrease.Value;
        }

        private void obrazToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            saveImageResult();
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            trackBarBrightness.Enabled = true;
            trackBarContrast.Enabled = true;
            trackBarSaturation.Enabled = true;

            trackBarBrightness.Value = 0;
            brightness = trackBarBrightness.Value / 100f;

            trackBarContrast.Value = 100;
            contrast = trackBarContrast.Value / 100f;
            t = (1.0f - contrast) / 2.0f;

            trackBarSaturation.Value = 100;
            saturation = trackBarSaturation.Value / 100f;

            trackBarReduction.Value = trackBarReduction.Maximum;
            reduction = trackBarReduction.Value;

            label10.Text = trackBarBrightness.Value.ToString();
            label11.Text = trackBarContrast.Value.ToString();
            label12.Text = trackBarSaturation.Value.ToString();
            label14.Text = trackBarReduction.Value.ToString();

            drawImage();
            pictureBoxOrigin.Image = file;

        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            int[] histArray = new int[1+numberOfPoints/2];
            progressBar1.Value = 0;
            trackBarBrightness.Enabled = false;
            trackBarContrast.Enabled = false;
            trackBarSaturation.Enabled = false;
            iterations = (int)numericUpDownLines.Value;
            string[] lines;
            //StreamWriter file = new StreamWriter("WriteLines2.txt", append: true);
            bool enable = true;
            int height = 0;
            int width = 0;

            Pen penBlack = new Pen(Color.Black, 1);
            using (var bm = new Bitmap(pictureBoxOrigin.Image))
            {
                height = bm.Height;
                width = bm.Width;
            }
            Point origin = new Point(width / 2, height / 2);
            int radius = (int)Math.Min(width / 2, height / 2) - 2;

            points = GenerateAnchorPoints(origin, radius, numberOfPoints);
            {
                /*
                for (int i = 0; i < numberOfPoints / 2; i++)
                {
                    mean += CalculateMean(PlotLine(points[i], points[i + numberOfPoints / 2]));
                }
                mean = mean / (numberOfPoints / 2);
                Console.WriteLine("{0}", mean);
                */
            }
            var rand = new Random();
            if (enable)
            {
                Bitmap canvas = new Bitmap(width, height);                
                Graphics k = Graphics.FromImage(canvas);                    
                k.Clear(Color.White);


                int iter2 = iterations;
                float procent;
                Point start = points[0];
                int startIndex = 0;
                //szukanie najciemniejszego punktu
                {
                    int startingPoint = 0;
                    int count2 = 0;
                    int lowMean = 1000;
                    int candidate;
                    foreach (Point pt in points)
                    {
                        List<Point> list = new List<Point> { pt };
                        candidate = CalculateMeanFromListOfPoints(list);
                        if (lowMean > candidate)
                        {
                            lowMean = candidate;
                            startingPoint = count2;
                        }
                        count2++;
                    }
                    startIndex = startingPoint;
                }

                Point end = points[0];
                int endIndex = 0;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                while (iterations > 0)
                {
                    iterations--;

                    procent = 100 * (iter2 - iterations) / (float)iter2;
                    progressBar1.Value = (int)procent;

                    //szukanie najciemniejszej sciezki

                    endIndex = await FindEndIndex(startIndex);
                    string text = endIndex.ToString() + ", ";
                    File.AppendAllText("linie.txt", text);
                    //file.WriteLine("test");
                    //Console.WriteLine(endIndex);
                    end = points[endIndex];

                    //rysuj na bitmapie oryginalu
                    Bitmap bitmap = new Bitmap(pictureBoxOrigin.Image);
                    Pen penWhite = new Pen(Color.White, 1);

                    //zapis i rysowanie bialej linii
                    Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);
                    Graphics oGraphic = Graphics.FromImage(newBitmap);
                    oGraphic.DrawImage(bitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);
                    bitmap.Dispose();
                    oGraphic.Dispose();
                    bitmap = newBitmap;

                    BitmapData bmdata2 = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);

                    IntPtr Scan0 = bmdata2.Scan0;
                    int stride = bmdata2.Stride;
                    int ind = 0;
                    List<Point> pts = PlotLine(start, end);
                    unsafe
                    {
                        //ustaw scan0
                        byte* ptr = (byte*)(void*)Scan0;

                        foreach (Point pt in pts)
                        {

                            ind = pt.Y * stride + pt.X * 4;
                            //jeśli wartość pixela jest mniejsza niż '255-increase' to rozjaśnij go o 'increase', w przeciwnym wypadku rozjaśnij go zupełnie.
                            if (ptr[ind] <= (byte)(255 - increase))
                            {
                                ptr[ind] += (byte)increase;
                                ptr[ind + 1] += (byte)increase;
                                ptr[ind + 2] += (byte)increase;
                                //ptr[ind + 3] += (byte)increase;
                            }
                            else
                            {
                                //255=biale, 0=czarne
                                ptr[ind] = 255;
                                ptr[ind + 1] = 255;
                                ptr[ind + 2] = 255;
                                //ptr[ind + 3] = 255;
                            }

                        }
                    }
                    
                    bitmap.UnlockBits(bmdata2);
                    pictureBoxOrigin.Image = bitmap; 
                    //bitmap.Save(path, ImageFormat.Bmp);



                    //rysuj na bitmapie wynikowej
                    BitmapData bmdata = canvas.LockBits(new Rectangle(0, 0, canvas.Width, canvas.Height), ImageLockMode.ReadWrite, canvas.PixelFormat);

                    Scan0 = bmdata.Scan0;
                    stride = bmdata.Stride;
                    ind = 0;
                    unsafe
                    {
                        //ustaw scan0
                        byte* ptr = (byte*)(void*)Scan0;

                        foreach (Point pt in pts)
                        {
                            ind = pt.Y * stride + pt.X * 4;
                            //jeśli wartość pixela jest większa niż 'increase' to przyciemnij go o 'increase', w przeciwnym wypadku przyciemnij go zupełnie.
                            if (ptr[ind] >= (byte)increase)
                            {
                                ptr[ind] -= (byte)increase;
                                ptr[ind + 1] -= (byte)increase;
                                ptr[ind + 2] -= (byte)increase;
                                //ptr[ind + 3] -= (byte)increase;
                            }
                            else
                            {
                                //255=biale, 0=czarne
                                ptr[ind] = (byte)0;
                                ptr[ind + 1] = (byte)0;
                                ptr[ind + 2] = (byte)0;
                                //ptr[ind + 3] = (byte)0;
                            }

                        }
                    }

                    canvas.UnlockBits(bmdata);

                    histArray[Math.Min(Math.Abs(endIndex - startIndex), numberOfPoints - Math.Abs(endIndex - startIndex))] += 1;
                    start = end;
                    startIndex = endIndex;
                            
                    pictureBoxResult.Image = (Image)canvas;
                    pictureBoxOrigin.Refresh();
                    pictureBoxResult.Refresh();


                }
                //canvas.Save(@"C:\Users\Tommy Lee Jones\Desktop\Result.png");

                int dasdasda = 1;
                foreach (var item in histArray)
                {
                    chartHistogram.Series["Histogram"].Points.AddXY(dasdasda,item);
                    //Console.WriteLine($"histArray[{dasdasda}] = {item}");
                    dasdasda++;
                }

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;
                ms1 = (int)elapsedMs/1000;
                labelTimeDone.Text = ms1.ToString();

                k.Dispose();
            }
        }


        private void otwórzToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openImage();
        }

        private void zapiszToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveImageResult();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            int height = 0;
            int width = 0;
            Pen penBlack = new Pen(Color.Black, 1);
            using (var bm = new Bitmap(pictureBoxOrigin.Image))
            {
                height = bm.Height;
                width = bm.Width;
            }
            Point origin = new Point(width / 2, height / 2);
            int radius = (int)Math.Min(width / 2, height / 2) - 2;

            points = GenerateAnchorPoints(origin, radius, numberOfPoints);
            var temp = await FindEndIndex(7);
            Console.WriteLine(temp);



        }

        private async Task<int> FindEndIndex(int startIndex)
        {
            int endIndex;
            List<Task<int>> listOfMeans = new List<Task<int>>();
            byte[] array = BitmapToByteArray();
            var rand = new Random();

            int width = pictureBoxOrigin.Image.Width;
            int height = pictureBoxOrigin.Image.Height;
            for (int i = 0; i < numberOfPoints; i++)
            {
                List<Point> pointsToCalculate = PlotLine(points[startIndex], points[i]);
                listOfMeans.Add(Task.Run(() => CalculateMeanFromListOfPoints2(pointsToCalculate, array, width, height)));
            }

            var results = await Task.WhenAll(listOfMeans);
            List<int> wyniki = new List<int>();
            foreach (var item in results)
            {
                wyniki.Add(item);
                //wyniki.Add(255);
            }

            for (int i = 0; i < points.Count(); i++)
            {
                if (Math.Abs(startIndex - i) < offset || Math.Abs(startIndex - i) > numberOfPoints-offset)
                {
                    wyniki[i] = 255;
                }
            }

            return endIndex = wyniki.IndexOf(wyniki.Min());
        }

        private int[] paletteArray(int numberOfColors)
        {
            int[] array = new int[256];
            Point origin = new Point(0, 0);
            Point dest = new Point(256, numberOfColors-1);
            List<Point> list = PlotLine(origin, dest);
            int j = 0;
            foreach (Point pt in list)
            {
                //Console.WriteLine(pt);
                int i = pt.Y * 256 / numberOfColors;
                array[j]=i;
                j++;
            }
            return array;
        }

        private void colorReduction(int[] paletteArray)
        {
            Image img = file;
            Bitmap bitmap = new Bitmap(img);
            Bitmap newBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            Graphics oGraphic = Graphics.FromImage(newBitmap);
            oGraphic.DrawImage(bitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, bitmap.Width, bitmap.Height, GraphicsUnit.Pixel);
            bitmap.Dispose();
            oGraphic.Dispose();
            bitmap = newBitmap;

            BitmapData bmdata = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);

            IntPtr Scan0 = bmdata.Scan0;
            int stride = bmdata.Stride;
            int ind = 0;
            int color = 0;
            unsafe
            {
                //ustaw scan0
                byte* ptr = (byte*)(void*)Scan0;
                for (int y = 0; y < bmdata.Height; y++)
                {
                    for (int x = 0; x < bmdata.Width; x++)
                    {
                        ind = y * stride +  4*x;
                        //ptr[ind] -> 0-255 wartosc koloru
                        color = ptr[ind];
                        ptr[ind] = (byte)paletteArray[color];
                        ptr[ind+1] = (byte)paletteArray[color];
                        ptr[ind+2] = (byte)paletteArray[color];
                    }
                }                
            }

            bitmap.UnlockBits(bmdata);
            pictureBoxOrigin.Image = bitmap;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            reduction = trackBarReduction.Value;
            label14.Text = trackBarReduction.Value.ToString();

            //Console.WriteLine(reduction);
            drawImage();
            //int[] array = paletteArray(reduction);
            //colorReduction(array);
        }

        private void numericUpDownOffset_ValueChanged(object sender, EventArgs e)
        {
            offset = (int)numericUpDownOffset.Value;
        }

        private void testFunc()
        {

            int[] histArray = new int[numberOfPoints];
            int height, width;
            using (var bm = new Bitmap(pictureBoxOrigin.Image))
            {
                height = bm.Height;
                width = bm.Width;
            }
            Point origin = new Point(width / 2, height / 2);
            int radius = (int)Math.Min(width / 2, height / 2) - 2;
            points = GenerateAnchorPoints(origin, radius, numberOfPoints);

            foreach (var series in chartHistogram.Series)
            {
                series.Points.Clear();
            }

            for (int i = 0; i < numberOfPoints; i++)
            {
                List<Point> pointsToCalculate = PlotLine(points[0], points[i]);
                //int valueOnChart = CalculateMeanFromListOfPoints(pointsToCalculate);
                int valueOnChart = CalculateMeanFromListOfPoints(pointsToCalculate);
                histArray[i] = valueOnChart;
                //chartHistogram.Series["Histogram"].Points.AddXY(i, valueOnChart);
            }

            for (int i = 0; i < numberOfPoints; i++)
            {
                chartHistogram.Series["Histogram"].Points.AddXY(i, histArray[i] - histArray[(i + 1) % numberOfPoints]);
            }
            for (int i = 0; i < numberOfPoints; i++)
            {
                List<Point> pointsToCalculate = PlotLine(points[60], points[(i + 60) % numberOfPoints]);
                int valueOnChart = CalculateMeanFromListOfPoints(pointsToCalculate);
                histArray[i] = valueOnChart;
            }

            for (int i = 0; i < numberOfPoints; i++)
            {
                chartHistogram.Series["Series2"].Points.AddXY(i, histArray[i] - histArray[(i + 1) % numberOfPoints]);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            chartHistogram.ChartAreas[0].AxisY.Minimum = -30;
            chartHistogram.ChartAreas[0].AxisY.Maximum = 30;
            testFunc();
        }

        private void buttonClearChart_Click(object sender, EventArgs e)
        {
            foreach (var series in chartHistogram.Series)
            {
                series.Points.Clear();
            }
        }
    }
}
