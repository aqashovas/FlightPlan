using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;


namespace Flight_Radar
{
    public partial class Form1 : Form
    {
        //vp=72,
        private readonly radarEntities db = new radarEntities();
        //private List<Point> Points = new List<Point>();
        private List<Point> Points = new List<Point>();
        private List<Point> Pnts = new List<Point>();
        private List<Point> Pnts2 = new List<Point>();
        private List<Point> Pnts3 = new List<Point>();
        private List<Point> Pnts4 = new List<Point>();
        private List<Point> PntsA = new List<Point>();
        private List<Point> PntsF = new List<Point>();
        public int p2;
        public int p3;
        public int p4;



        //nöqtələr olan cədvəl (bazadakı)
        public Pointsloc pointsloc=new Pointsloc();
        public double Xcoor = 6371 * Math.Cos(40.45508056 * 3.14 / 180) * Math.Cos(50.06416667 * 3.14 / 180);
        public double Ycoor = 6371 * Math.Cos(40.45508056 * 3.14 / 180) * Math.Sin(50.06416667 * 3.14 / 180);

        public int count = 0;
        public int c = 0;
        public int c2 = 0;
        public int c3 = 0;


        public int say = 0;
        public Form1()
        {
            InitializeComponent();
            //webBrowser1.Navigate("http://maps.google.com/maps?q=Azerbaijan");
            Myfunc();
            FillCmb();
            pbLine.Controls.Add(pictureBox1);
            pbLine.Controls.Add(pBfire);
            pbLine.Controls.Add(pBAmbulance);
            pbLine.Controls.Add(pBplane2);
            pbLine.Controls.Add(pBplane3);
            pbLine.Controls.Add(pBplane4);
            pictureBox1.Left = 225;
            pictureBox1.Top = 383;
            pBplane2.Left = 260;
            pBplane2.Top = 369;
            pBplane3.Left = 271;
            pBplane3.Top = 344;
            pBplane4.Left = 243;
            pBplane4.Top = 320;
            pBAmbulance.Left = 165;
            pBAmbulance.Top = 302;
            pBfire.Left = 328;
            pBfire.Top = 258;


        }
        public void SetValues()
        {
            if(comboBox2.SelectedItem== "təyyarə1")
            {
                txtS.Text = lblT.Text.Split(' ')[0];
                txtT.Text = Pnts.Count.ToString();
            }
            else if (comboBox2.SelectedItem == "təyyarə2")
            {
                txtS.Text = lblT2.Text.Split(' ')[0];
                txtT.Text = Pnts2.Count.ToString();
            }
            else if (comboBox2.SelectedItem == "təyyarə3")
            {
                txtS.Text =lblET3.Text.Split(' ')[0];
                txtT.Text = Pnts3.Count.ToString();
            }
            else if (comboBox2.SelectedItem == "təyyarə4")
            {
                txtS.Text = lblT4.Text.Split(' ')[0];
                txtT.Text = Pnts4.Count.ToString();
            }
            else if (comboBox2.SelectedItem == "yanğınsöndürən")
            {
                txtS.Text = lblF.Text.Split(' ')[0];
                txtT.Text = PntsF.Count.ToString();
            }
            else if (comboBox2.SelectedItem == "təcili tibbi yardım")
            {
                txtS.Text = lblA.Text.Split(' ')[0];
                txtT.Text = PntsA.Count.ToString();
            }
        }
        public void FillCmb()
        {
            cmbtransportation.Items.Add("təyyarə1");
            cmbtransportation.Items.Add("təyyarə2");
            cmbtransportation.Items.Add("təyyarə3");
            cmbtransportation.Items.Add("təyyarə4");
            cmbtransportation.Items.Add("yanğınsöndürən");
            cmbtransportation.Items.Add("təcili tibbi yardım");
            comboBox2.Items.Add("təyyarə1");
            comboBox2.Items.Add("təyyarə2");
            comboBox2.Items.Add("təyyarə3");
            comboBox2.Items.Add("təyyarə4");
            comboBox2.Items.Add("yanğınsöndürən");
            comboBox2.Items.Add("təcili tibbi yardım");
            if (String.IsNullOrWhiteSpace(txtS.Text))
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("m");
                comboBox1.Items.Add("km");
                comboBox1.Items.Add("n.m");
               

            }
            else if (String.IsNullOrWhiteSpace(txtV.Text))
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("m/san");
                comboBox1.Items.Add("km/saat");
                comboBox1.Items.Add("n.m/san");

            }
            else if (String.IsNullOrWhiteSpace(txtT.Text))
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("san");
                comboBox1.Items.Add("saat");

            }
        }



        //public void myfunction()
        //{
        //    foreach (var item in db.Pointslocs.ToList())
        //    {
        //        Points.Add(new Point(Convert.ToInt32(item.PointX),Convert.ToInt32(item.PointY)));

        //    }


        //}


        //private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        //{
        //   /* Point curMousePos = e.Location;
        //    Graphics g;
        //    Pen brush = new Pen(Color.Blue, 5);
        //    g = pictureBox1.CreateGraphics();
        //    g.DrawLine(brush, oldMousePos.X, oldMousePos.Y, curMousePos.X, curMousePos.Y);
        //    g.Dispose();
        //    oldMousePos = curMousePos; */
        //}



        //private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    //bazadan gələn nöqtələrlə əyri çəkir
        //    //e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        //    //foreach (Point point in Points)
        //    //{
        //    //    e.Graphics.FillEllipse(Brushes.Black, point.X - 3, point.Y - 3, 5, 5);

        //    //    if (Points.Count < 2)
        //    //    {
        //    //        return;
        //    //    }
        //    //    e.Graphics.DrawCurve(Pens.Red, Points.ToArray());



        //    //}

        //}

        //private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    //Points.Add(e.Location);
        //    //bazaya məlumat atmağa çalışdığım hissə bazadakı cədvəl tipindən dəyişən 
        //    //yaradıb nöqtələri mənimsədib həmin cədvələ əlavə etməyə çalışır amma məlumat List kimi gəldiyi üçün bazaya atanda problem yaşıyır
        //    //pointsloc.PointX = e.Location.X;
        //    //pointsloc.PointY = e.Location.Y;
        //    //db.Pointslocs.Add(pointsloc);
        //    //db.SaveChanges();

        //    //Refresh();
        //}
        public void Myfunc()
        {
           


            //if (say > db.Pointslocs.Count())
            //{
            //    timer1.Stop();
            //}
            //foreach (var item in db.Pointslocs.ToList())
            //{
            //    Points.Add(new Point(Convert.ToInt32(item.PointX), Convert.ToInt32(item.PointY)));


            //}

            //Points.Add(new Point(Convert.ToInt32(db.Pointslocs.FirstOrDefault().PointX), Convert.ToInt32(db.Pointslocs.First().PointY)));
            //Points.Add(new Point(Convert.ToInt32(db.Pointslocs.LastOrDefault().PointX), Convert.ToInt32(db.Pointslocs.Last().PointY)));

            //GraphicsPath path = new GraphicsPath();
            //path.AddEllipse(Points);
            //foreach (PointF point in path.PathPoints)
            //{
            //    pictureBox2.Location = Point.Round(point);
            //    Thread.Sleep(100);
            //}
        }








        private void timer2_Tick(object sender, EventArgs e)
        {
            //pictureBox1.Visible = true;
            //c3++;
            //pictureBox1.Left = Pnts[c].X - pictureBox1.Width / 2;
            //pictureBox1.Top = Pnts[c].Y - pictureBox1.Height / 2;
           
            double y = Convert.ToDouble(pictureBox1.Location.Y) + Ycoor - 565+ pictureBox1.Width / 2;
            double x= Convert.ToDouble(pictureBox1.Location.X) + Xcoor+ pictureBox1.Height / 2;
            double coord = Math.Atan2(y,x);
            double coord2 = Math.Atan2(x, y);
            coord2 = coord2 * 180.0 / Math.PI;
            coord =  coord * 180.0/ Math.PI;
            double minutes = (coord - Math.Floor(coord)) * 60.0;
            double seconds = (minutes - Math.Floor(minutes)) * 60.0;
            double minutes2 = (coord2 - Math.Floor(coord2)) * 60.0;
            double seconds2 = (minutes2 - Math.Floor(minutes2)) * 60.0;
            //int sec = (int)Math.Round(coord * 3600);
            //int deg = sec / 3600;
            //sec = Math.Abs(sec % 3600);
            //int min = sec / 60;
            //sec %= 60;
            //textBox1.Text =(Convert.ToDouble(pictureBox1.Location.X)+Xcoor).ToString()+" "+ (Convert.ToDouble(pictureBox1.Location.Y) + Ycoor-660).ToString();
            richTextBox1.Text ="Lat="+Math.Round(coord,2).ToString() + "°" + Math.Round(minutes, 2).ToString() + "''" + Math.Round(seconds, 2).ToString() + "'"+Environment.NewLine+ "Long=" + Math.Round(coord2, 2).ToString() + "°" + Math.Round(minutes2, 2).ToString() + "''" + Math.Round(seconds2, 2).ToString() + "'";
            if (Convert.ToInt32(pictureBox1.Left) < 423 && Convert.ToInt32(pictureBox1.Top) < 287)
            {
                lblN.ForeColor = Color.Lime;
                lblW.ForeColor = Color.Lime;
                lblE.ForeColor = Color.Black;
                lblS.ForeColor = Color.Black;
            }
           else if (Convert.ToInt32(pictureBox1.Left) > 423 && Convert.ToInt32(pictureBox1.Top) < 287)
            {
                lblN.ForeColor = Color.Lime;
                lblE.ForeColor = Color.Lime;
                lblS.ForeColor = Color.Black;
                lblW.ForeColor = Color.Black;



            }
            else if (Convert.ToInt32(pictureBox1.Left) < 423 && Convert.ToInt32(pictureBox1.Top) > 287)
            {
                lblN.ForeColor = Color.Black;
                lblE.ForeColor = Color.Black;
                lblS.ForeColor = Color.Lime;
                lblW.ForeColor = Color.Lime;



            }
            else if (Convert.ToInt32(pictureBox1.Left) > 423 && Convert.ToInt32(pictureBox1.Top) > 287)
            {
                lblN.ForeColor = Color.Black;
                lblE.ForeColor = Color.Lime;
                lblS.ForeColor = Color.Lime;
                lblW.ForeColor = Color.Black;



            }
    

        }

      

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            //c++;
            //if (cmbtransportation.SelectedItem == "təyyarə")
            //{
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (Point point in Pnts)
                {
                    e.Graphics.FillEllipse(Brushes.Black, point.X - 3, point.Y - 3, 5, 5);

                    if (Pnts.Count < 2)
                    {
                        return;
                    }

                    e.Graphics.DrawCurve(Pens.Blue, Pnts.ToArray());

                    //GraphicsState transState = e.Graphics.Save();
                    //e.Graphics.Restore(transState);
                    e.Graphics.Save();
                    this.Invalidate();



                }

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (Point point in Pnts2)
            {
                e.Graphics.FillEllipse(Brushes.Black, point.X - 3, point.Y - 3, 5, 5);

                if (Pnts2.Count < 2)
                {
                    return;
                }

                e.Graphics.DrawCurve(Pens.LightBlue, Pnts2.ToArray());

                //GraphicsState transState = e.Graphics.Save();
                //e.Graphics.Restore(transState);
                e.Graphics.Save();
                this.Invalidate();



            }
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (Point point in Pnts3)
            {
                e.Graphics.FillEllipse(Brushes.Black, point.X - 3, point.Y - 3, 5, 5);

                if (Pnts3.Count < 2)
                {
                    return;
                }

                e.Graphics.DrawCurve(Pens.CadetBlue, Pnts3.ToArray());

                //GraphicsState transState = e.Graphics.Save();
                //e.Graphics.Restore(transState);
                e.Graphics.Save();
                this.Invalidate();



            }
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            foreach (Point point in Pnts4)
            {
                e.Graphics.FillEllipse(Brushes.Black, point.X - 3, point.Y - 3, 5, 5);

                if (Pnts4.Count < 2)
                {
                    return;
                }

                e.Graphics.DrawCurve(Pens.DeepSkyBlue, Pnts4.ToArray());

                //GraphicsState transState = e.Graphics.Save();
                //e.Graphics.Restore(transState);
                e.Graphics.Save();
                this.Invalidate();



            }
            //}
            //else if (cmbtransportation.SelectedItem == "yanğınsöndürən")
            //{
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (Point point in PntsF)
                {
                    e.Graphics.FillEllipse(Brushes.Black, point.X - 3, point.Y - 3, 5, 5);

                    if (PntsF.Count < 2)
                    {
                        return;
                    }

                    e.Graphics.DrawCurve(Pens.Yellow, PntsF.ToArray());

                    e.Graphics.Save();

                this.Invalidate();


            }


            //}
            //else if (cmbtransportation.SelectedItem == "təcili tibbi yardım")
            //{
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (Point point in PntsA)
                {
                    e.Graphics.FillEllipse(Brushes.Black, point.X - 3, point.Y - 3, 5, 5);

                    if (PntsA.Count < 2)
                    {
                        return;
                    }

                    e.Graphics.DrawCurve(Pens.Red, PntsA.ToArray());

                    e.Graphics.Save();

                this.Invalidate();



            }

            //}

        }
        

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            //pictureBox1.Visible = true;
            //pbLine.Controls.Add(pictureBox1);
            //pbLine.Controls.Add(pBfire);
            //pbLine.Controls.Add(pBAmbulance);
            if (cmbtransportation.SelectedItem == "təyyarə1")
            {
                Pnts.Add(e.Location);
               // this.Paint += new PaintEventHandler(pictureBox2_Paint);


            }
            else if (cmbtransportation.SelectedItem == "təyyarə2")
            {
                Pnts2.Add(e.Location);
                // this.Paint += new PaintEventHandler(pictureBox2_Paint);


            }
            else if (cmbtransportation.SelectedItem == "təyyarə3")
            {
                Pnts3.Add(e.Location);
                // this.Paint += new PaintEventHandler(pictureBox2_Paint);


            }
            else if (cmbtransportation.SelectedItem == "təyyarə4")
            {
                Pnts4.Add(e.Location);
                // this.Paint += new PaintEventHandler(pictureBox2_Paint);


            }
            else if (cmbtransportation.SelectedItem == "yanğınsöndürən")
            {
                PntsF.Add(e.Location);

                //this.Paint += new PaintEventHandler(pictureBox2_Paint2);


            }
            else if (cmbtransportation.SelectedItem == "təcili tibbi yardım")
            {
                PntsA.Add(e.Location);
                //this.Paint += new PaintEventHandler(pictureBox2_Paint3);


            }
            Refresh();
        }

        private void pbLine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //count++;
            //if (count % 2 != 0)
            //{
            //    timer2.Stop();

            //}
            //else timer2.Start();
            //if (cmbtransportation.SelectedItem == "təyyarə")
            //{
            //    tmrP.Stop();
            //}
            //else if (cmbtransportation.SelectedItem == "yanğınsöndürən")
            //{
            //    tmrF.Stop();

            //}
            //else if (cmbtransportation.SelectedItem == "təcili tibbi yardım")
            //{
            //    tmrA.Stop();

            //}
        }

        private void cmbtransportation_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //if (cmbtransportation.SelectedItem == "təyyarə")
            //{
            //    tmrP.Enabled = true;
            //    tmrP.Start();
            //}
            //else if (cmbtransportation.SelectedItem == "yanğınsöndürən")
            //{
            //    tmrF.Enabled = true;
            //    tmrF.Start();
            //}
            //else if (cmbtransportation.SelectedItem == "təcili tibbi yardım")
            //{
            //    tmrA.Enabled = true;
            //    tmrA.Start();
            //}
        }

    
     

        private void btnOk_Click(object sender, EventArgs e)
        {
            pBfire.Location = PntsF.FirstOrDefault();
            pBAmbulance.Location = PntsA.FirstOrDefault();

            pictureBox1.Location = Pnts.FirstOrDefault();
            pBplane2.Location = Pnts2.FirstOrDefault();
            pBplane3.Location = Pnts3.FirstOrDefault();
            pBplane4.Location = Pnts4.FirstOrDefault();

            tmrA.Enabled = true;
            tmrA.Start();
            tmrP.Enabled = true;
            tmrP.Start();
            tmrF.Enabled = true;
            tmrF.Start();
            timerE.Enabled = true;
            timerE.Start();           
            tmr2.Enabled = true;
            tmr2.Start();
            tmr3.Enabled = true;
            tmr3.Start();
            tmrP2.Enabled = true;
            tmrP2.Start();
            tmrP3.Enabled = true;
            tmrP3.Start();
            tmrP4.Enabled = true;
            tmrP4.Start();
            int xP1, yP1, xP2, yP2, xA1, yA1, xA2, yA2, xF1, yF1, xF2, yF2,mP,mP2,mP3,mP4,mA,mF, xP21, yP21, xP22, yP22, xP31, yP31, xP32, yP32, xP41, yP41, xP42, yP42;
            xP1 = Pnts.FirstOrDefault().X;
            xP2 = Pnts.LastOrDefault().X;
            yP1 = Pnts.FirstOrDefault().Y;
            yP2 = Pnts.LastOrDefault().Y;
            xP21 = Pnts2.FirstOrDefault().X;
            xP22 = Pnts2.LastOrDefault().X;
            yP21 = Pnts2.FirstOrDefault().Y;
            yP22 = Pnts2.LastOrDefault().Y;
            xP31 = Pnts3.FirstOrDefault().X;
            xP32 = Pnts3.LastOrDefault().X;
            yP31 = Pnts3.FirstOrDefault().Y;
            yP32 = Pnts3.LastOrDefault().Y;
            xP41 = Pnts4.FirstOrDefault().X;
            xP42 = Pnts4.LastOrDefault().X;
            yP41 = Pnts4.FirstOrDefault().Y;
            yP42 = Pnts4.LastOrDefault().Y;
            xA1 = PntsA.FirstOrDefault().X;
            xA2 = PntsA.LastOrDefault().X;
            yA1 = PntsA.FirstOrDefault().Y;
            yA2 = PntsA.LastOrDefault().Y;
            xF1 = PntsF.FirstOrDefault().X;
            xF2 = PntsF.LastOrDefault().X;
            yF1 = PntsF.FirstOrDefault().Y;
            yF2 = PntsF.LastOrDefault().Y;
            mP =Convert.ToInt32( Math.Sqrt(Math.Pow((xP2 - xP1), 2) + Math.Pow((yP2 - yP1), 2)));
            mP2 = Convert.ToInt32(Math.Sqrt(Math.Pow((xP22 - xP21), 2) + Math.Pow((yP22 - yP21), 2)));
            mP3 = Convert.ToInt32(Math.Sqrt(Math.Pow((xP32 - xP31), 2) + Math.Pow((yP32 - yP31), 2)));
            mP4 = Convert.ToInt32(Math.Sqrt(Math.Pow((xP42 - xP41), 2) + Math.Pow((yP42 - yP41), 2)));
            mA = Convert.ToInt32(Math.Sqrt(Math.Pow((xA2 - xA1), 2) + Math.Pow((yA2 - yA1), 2)));
            mF = Convert.ToInt32(Math.Sqrt(Math.Pow((xF1 - xF2), 2) + Math.Pow((yF2 - yF1), 2)));
            lblT.Text = mP.ToString() +" "+ "m";
            lblT2.Text = mP2.ToString() + " " + "m";
            lblT3.Text = mP3.ToString() + " " + "m";
            lblT4.Text = mP4.ToString() + " " + "m";

            lblF.Text = mF.ToString() + "m";
            lblA.Text = mA.ToString() + "m";



            //foreach (var item in PntsF)
            //{
            //    MessageBox.Show(item.ToString());
            //}


        }

        private void timerE_Tick(object sender, EventArgs e)
        {
            c++;
            
            if (c < PntsF.Count)
            {
                pBfire.Left = PntsF[c].X - pBfire.Width / 2;
                pBfire.Top = PntsF[c].Y - pBfire.Height / 2;
            }

        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            c3++;
            if (c3 < Pnts.Count)
            {
                pictureBox1.Left = Pnts[c3].X - pBfire.Width / 2;
                pictureBox1.Top = Pnts[c3].Y - pBfire.Height / 2;
            }
        }

        private void tmr3_Tick(object sender, EventArgs e)
        {
            c2++;
            if (c2 <= PntsA.Count)
            {
                pBAmbulance.Left = PntsA[c3].X - pBAmbulance.Width / 2;
                pBAmbulance.Top = PntsA[c3].Y - pBAmbulance.Height / 2;
            }
        }

        private void tmrA_Tick(object sender, EventArgs e)
        {
            double y = Convert.ToDouble(pBAmbulance.Location.Y) + Ycoor - 565 + pBAmbulance.Width / 2;
            double x = Convert.ToDouble(pBAmbulance.Location.X) + Xcoor + pBAmbulance.Height / 2;
            double coord = Math.Atan2(y, x);
            double coord2 = Math.Atan2(x, y);
            coord2 = coord2 * 180.0 / Math.PI;
            coord = coord * 180.0 / Math.PI;
            double minutes = (coord - Math.Floor(coord)) * 60.0;
            double seconds = (minutes - Math.Floor(minutes)) * 60.0;
            double minutes2 = (coord2 - Math.Floor(coord2)) * 60.0;
            double seconds2 = (minutes2 - Math.Floor(minutes2)) * 60.0;
            //int sec = (int)Math.Round(coord * 3600);
            //int deg = sec / 3600;
            //sec = Math.Abs(sec % 3600);
            //int min = sec / 60;
            //sec %= 60;
            //textBox1.Text =(Convert.ToDouble(pictureBox1.Location.X)+Xcoor).ToString()+" "+ (Convert.ToDouble(pictureBox1.Location.Y) + Ycoor-660).ToString();
            richTextBox3.Text = "Lat=" + Math.Round(coord, 2).ToString() + "°" + Math.Round(minutes, 2).ToString() + "''" + Math.Round(seconds, 2).ToString() + "'" + Environment.NewLine + "Long=" + Math.Round(coord2, 2).ToString() + "°" + Math.Round(minutes2, 2).ToString() + "''" + Math.Round(seconds2, 2).ToString() + "'";
            if (Convert.ToInt32(pBAmbulance.Left) < 423 && Convert.ToInt32(pBAmbulance.Top) < 287)
            {
                lblNA.ForeColor = Color.Lime;
                lblWA.ForeColor = Color.Lime;
                lblEA.ForeColor = Color.Black;
                lblSA.ForeColor = Color.Black;
            }
            else if (Convert.ToInt32(pBAmbulance.Left) > 423 && Convert.ToInt32(pBAmbulance.Top) < 287)
            {
                lblNA.ForeColor = Color.Lime;
                lblEA.ForeColor = Color.Lime;
                lblSA.ForeColor = Color.Black;
                lblWA.ForeColor = Color.Black;



            }
            else if (Convert.ToInt32(pBAmbulance.Left) < 423 && Convert.ToInt32(pBAmbulance.Top) > 287)
            {
                lblNA.ForeColor = Color.Black;
                lblEA.ForeColor = Color.Black;
                lblSA.ForeColor = Color.Lime;
                lblWA.ForeColor = Color.Lime;



            }
            else if (Convert.ToInt32(pBAmbulance.Left) > 423 && Convert.ToInt32(pBAmbulance.Top) > 287)
            {
                lblNA.ForeColor = Color.Black;
                lblEA.ForeColor = Color.Lime;
                lblSA.ForeColor = Color.Lime;
                lblWA.ForeColor = Color.Black;



            }
        }

        private void tmrF_Tick(object sender, EventArgs e)
        {
            //c++;
            // pBfire.Left = PntsF[c].X - pBfire.Width / 2;
            // pBfire.Top = PntsF[c].Y - pBfire.Height / 2;
            double y = Convert.ToDouble(pBfire.Location.Y) + Ycoor - 565 + pBfire.Width / 2;
            double x = Convert.ToDouble(pBfire.Location.X) + Xcoor + pBfire.Height / 2;
            double coord = Math.Atan2(y, x);
            double coord2 = Math.Atan2(x, y);
            coord2 = coord2 * 180.0 / Math.PI;
            coord = coord * 180.0 / Math.PI;
            double minutes = (coord - Math.Floor(coord)) * 60.0;
            double seconds = (minutes - Math.Floor(minutes)) * 60.0;
            double minutes2 = (coord2 - Math.Floor(coord2)) * 60.0;
            double seconds2 = (minutes2 - Math.Floor(minutes2)) * 60.0;
            //int sec = (int)Math.Round(coord * 3600);
            //int deg = sec / 3600;
            //sec = Math.Abs(sec % 3600);
            //int min = sec / 60;
            //sec %= 60;
            //textBox1.Text =(Convert.ToDouble(pictureBox1.Location.X)+Xcoor).ToString()+" "+ (Convert.ToDouble(pictureBox1.Location.Y) + Ycoor-660).ToString();
            richTextBox2.Text = "Lat=" + Math.Round(coord, 2).ToString() + "°" + Math.Round(minutes, 2).ToString() + "''" + Math.Round(seconds, 2).ToString() + "'" + Environment.NewLine + "Long=" + Math.Round(coord2, 2).ToString() + "°" + Math.Round(minutes2, 2).ToString() + "''" + Math.Round(seconds2, 2).ToString() + "'";
            if (Convert.ToInt32(pBfire.Left) < 423 && Convert.ToInt32(pBfire.Top) < 287)
            {
                lblNF.ForeColor = Color.Lime;
                lblWF.ForeColor = Color.Lime;
                lblEF.ForeColor = Color.Black;
                lblSF.ForeColor = Color.Black;
            }
            else if (Convert.ToInt32(pBfire.Left) > 423 && Convert.ToInt32(pBfire.Top) < 287)
            {
                lblNF.ForeColor = Color.Lime;
                lblEF.ForeColor = Color.Lime;
                lblSF.ForeColor = Color.Black;
                lblWF.ForeColor = Color.Black;



            }
            else if (Convert.ToInt32(pBfire.Left) < 423 && Convert.ToInt32(pBfire.Top) > 287)
            {
                lblNF.ForeColor = Color.Black;
                lblEF.ForeColor = Color.Black;
                lblSF.ForeColor = Color.Lime;
                lblWF.ForeColor = Color.Lime;



            }
            else if (Convert.ToInt32(pBfire.Left) > 423 && Convert.ToInt32(pBfire.Top) > 287)
            {
                lblNF.ForeColor = Color.Black;
                lblEF.ForeColor = Color.Lime;
                lblSF.ForeColor = Color.Lime;
                lblWF.ForeColor = Color.Black;



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "m")
            {
                txtS.Text = (Convert.ToDouble(txtT.Text) * Convert.ToDouble(txtV.Text)).ToString();
                label6.Text = comboBox1.SelectedItem.ToString();

            }
            else if (comboBox1.SelectedItem.ToString() == "km")
            {
                double s = Convert.ToDouble(txtT.Text) * Convert.ToDouble(txtV.Text);
                txtS.Text = (s / 1000).ToString();
                label6.Text = comboBox1.SelectedItem.ToString();

            }
            else if (comboBox1.SelectedItem.ToString() == "n.m")
            {
                double s = Convert.ToDouble(txtT.Text) * Convert.ToDouble(txtV.Text);
                txtS.Text = (s * 1852.2).ToString();
                label6.Text = comboBox1.SelectedItem.ToString();


            }
            else if (comboBox1.SelectedItem.ToString() == "km/saat")
            {
                double v = Convert.ToDouble(txtS.Text) / Convert.ToDouble(txtT.Text);
                txtV.Text = (v / 1000 * 3600).ToString();
                label6.Text = comboBox1.SelectedItem.ToString();

            }
            else if (comboBox1.SelectedItem.ToString() == "n.m/san")
            {
                double v = Convert.ToDouble(txtS.Text) / Convert.ToDouble(txtT.Text);
                txtS.Text = (v * 1852.2).ToString();
                label6.Text = comboBox1.SelectedItem.ToString();

            }
            else if (comboBox1.SelectedItem.ToString() == "m/san")
            {
                double v = Convert.ToDouble(txtS.Text) * Convert.ToDouble(txtT.Text);
                txtS.Text = v.ToString();
                label6.Text = comboBox1.SelectedItem.ToString();


            }
            else if (comboBox1.SelectedItem.ToString() == "san")
            {
                double t = Convert.ToDouble(txtS.Text) / Convert.ToDouble(txtV.Text);
                txtT.Text = t.ToString();
                label5.Text = comboBox1.SelectedItem.ToString();


            }
            else if (comboBox1.SelectedItem.ToString() == "saat")
            {
                double t = Convert.ToDouble(txtS.Text) / Convert.ToDouble(txtV.Text);
                txtT.Text = (t / 3600).ToString();
                label5.Text = comboBox1.SelectedItem.ToString();


            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            FillCmb();
        }

        private void tmrP2_Tick(object sender, EventArgs e)
        {
            p2++;

            if (p2 < Pnts2.Count)
            {
                pBplane2.Left = Pnts2[c].X - pBplane2.Width / 2;
                pBplane2.Top = Pnts2[c].Y - pBplane2.Height / 2;
            }
            double y = Convert.ToDouble(pBplane2.Location.Y) + Ycoor - 565 + pBplane2.Width / 2;
            double x = Convert.ToDouble(pBplane2.Location.X) + Xcoor + pBplane2.Height / 2;
            double coord = Math.Atan2(y, x);
            double coord2 = Math.Atan2(x, y);
            coord2 = coord2 * 180.0 / Math.PI;
            coord = coord * 180.0 / Math.PI;
            double minutes = (coord - Math.Floor(coord)) * 60.0;
            double seconds = (minutes - Math.Floor(minutes)) * 60.0;
            double minutes2 = (coord2 - Math.Floor(coord2)) * 60.0;
            double seconds2 = (minutes2 - Math.Floor(minutes2)) * 60.0;
            //int sec = (int)Math.Round(coord * 3600);
            //int deg = sec / 3600;
            //sec = Math.Abs(sec % 3600);
            //int min = sec / 60;
            //sec %= 60;
            //textBox1.Text =(Convert.ToDouble(pictureBox1.Location.X)+Xcoor).ToString()+" "+ (Convert.ToDouble(pictureBox1.Location.Y) + Ycoor-660).ToString();
            richTextBox4.Text = "Lat=" + Math.Round(coord, 2).ToString() + "°" + Math.Round(minutes, 2).ToString() + "''" + Math.Round(seconds, 2).ToString() + "'" + Environment.NewLine + "Long=" + Math.Round(coord2, 2).ToString() + "°" + Math.Round(minutes2, 2).ToString() + "''" + Math.Round(seconds2, 2).ToString() + "'";
            if (Convert.ToInt32(pBplane2.Left) < 423 && Convert.ToInt32(pBplane2.Top) < 287)
            {
                lblNT2.ForeColor = Color.Lime;
                lblWT2.ForeColor = Color.Lime;
                lblET2.ForeColor = Color.Black;
                lblST2.ForeColor = Color.Black;
            }
            else if (Convert.ToInt32(pBplane2.Left) > 423 && Convert.ToInt32(pBplane2.Top) < 287)
            {
                lblNT2.ForeColor = Color.Lime;
                lblET2.ForeColor = Color.Lime;
                lblST2.ForeColor = Color.Black;
                lblWT2.ForeColor = Color.Black;



            }
            else if (Convert.ToInt32(pBplane2.Left) < 423 && Convert.ToInt32(pBplane2.Top) > 287)
            {
                lblNT2.ForeColor = Color.Black;
                lblET2.ForeColor = Color.Black;
                lblST2.ForeColor = Color.Lime;
                lblWT2.ForeColor = Color.Lime;



            }
            else if (Convert.ToInt32(pBplane2.Left) > 423 && Convert.ToInt32(pBplane2.Top) > 287)
            {
                lblNT2.ForeColor = Color.Black;
                lblET2.ForeColor = Color.Lime;
                lblST2.ForeColor = Color.Lime;
                lblWT2.ForeColor = Color.Black;



            }

        }

        private void tmrP3_Tick(object sender, EventArgs e)
        {
            p3++;

            if (p3 <= Pnts3.Count)
            {
                pBplane3.Left = Pnts3[c].X - pBplane3.Width / 2;
                pBplane3.Top = Pnts3[c].Y - pBplane3.Height / 2;
            }
            double y = Convert.ToDouble(pBplane3.Location.Y) + Ycoor - 565 + pBplane3.Width / 2;
            double x = Convert.ToDouble(pBplane3.Location.X) + Xcoor + pBplane3.Height / 2;
            double coord = Math.Atan2(y, x);
            double coord2 = Math.Atan2(x, y);
            coord2 = coord2 * 180.0 / Math.PI;
            coord = coord * 180.0 / Math.PI;
            double minutes = (coord - Math.Floor(coord)) * 60.0;
            double seconds = (minutes - Math.Floor(minutes)) * 60.0;
            double minutes2 = (coord2 - Math.Floor(coord2)) * 60.0;
            double seconds2 = (minutes2 - Math.Floor(minutes2)) * 60.0;
            //int sec = (int)Math.Round(coord * 3600);
            //int deg = sec / 3600;
            //sec = Math.Abs(sec % 3600);
            //int min = sec / 60;
            //sec %= 60;
            //textBox1.Text =(Convert.ToDouble(pictureBox1.Location.X)+Xcoor).ToString()+" "+ (Convert.ToDouble(pictureBox1.Location.Y) + Ycoor-660).ToString();
            richTextBox5.Text = "Lat=" + Math.Round(coord, 2).ToString() + "°" + Math.Round(minutes, 2).ToString() + "''" + Math.Round(seconds, 2).ToString() + "'" + Environment.NewLine + "Long=" + Math.Round(coord2, 2).ToString() + "°" + Math.Round(minutes2, 2).ToString() + "''" + Math.Round(seconds2, 2).ToString() + "'";
            if (Convert.ToInt32(pBplane3.Left) < 423 && Convert.ToInt32(pBplane3.Top) < 287)
            {
                lblNT3.ForeColor = Color.Lime;
                lblWT3.ForeColor = Color.Lime;
                lblET3.ForeColor = Color.Black;
                lblST3.ForeColor = Color.Black;
            }
            else if (Convert.ToInt32(pBplane3.Left) > 423 && Convert.ToInt32(pBplane3.Top) < 287)
            {
                lblNT3.ForeColor = Color.Lime;
                lblET3.ForeColor = Color.Lime;
                lblST3.ForeColor = Color.Black;
                lblWT3.ForeColor = Color.Black;



            }
            else if (Convert.ToInt32(pBplane3.Left) < 423 && Convert.ToInt32(pBplane3.Top) > 287)
            {
                lblNT3.ForeColor = Color.Black;
                lblET3.ForeColor = Color.Black;
                lblST3.ForeColor = Color.Lime;
                lblWT3.ForeColor = Color.Lime;



            }
            else if (Convert.ToInt32(pBplane3.Left) > 423 && Convert.ToInt32(pBplane3.Top) > 287)
            {
                lblNT3.ForeColor = Color.Black;
                lblET3.ForeColor = Color.Lime;
                lblST3.ForeColor = Color.Lime;
                lblWT3.ForeColor = Color.Black;



            }
        }

        private void tmrP4_Tick(object sender, EventArgs e)
        {
            p4++;

            if (p4 <= Pnts4.Count)
            {
                pBplane4.Left = Pnts4[c].X - pBplane4.Width / 2;
                pBplane4.Top = Pnts4[c].Y - pBplane4.Height / 2;
            }
            double y = Convert.ToDouble(pBplane4.Location.Y) + Ycoor - 565 + pBplane4.Width / 2;
            double x = Convert.ToDouble(pBplane4.Location.X) + Xcoor + pBplane4.Height / 2;
            double coord = Math.Atan2(y, x);
            double coord2 = Math.Atan2(x, y);
            coord2 = coord2 * 180.0 / Math.PI;
            coord = coord * 180.0 / Math.PI;
            double minutes = (coord - Math.Floor(coord)) * 60.0;
            double seconds = (minutes - Math.Floor(minutes)) * 60.0;
            double minutes2 = (coord2 - Math.Floor(coord2)) * 60.0;
            double seconds2 = (minutes2 - Math.Floor(minutes2)) * 60.0;
            //int sec = (int)Math.Round(coord * 3600);
            //int deg = sec / 3600;
            //sec = Math.Abs(sec % 3600);
            //int min = sec / 60;
            //sec %= 60;
            //textBox1.Text =(Convert.ToDouble(pictureBox1.Location.X)+Xcoor).ToString()+" "+ (Convert.ToDouble(pictureBox1.Location.Y) + Ycoor-660).ToString();
            richTextBox6.Text = "Lat=" + Math.Round(coord, 2).ToString() + "°" + Math.Round(minutes, 2).ToString() + "''" + Math.Round(seconds, 2).ToString() + "'" + Environment.NewLine + "Long=" + Math.Round(coord2, 2).ToString() + "°" + Math.Round(minutes2, 2).ToString() + "''" + Math.Round(seconds2, 2).ToString() + "'";
            if (Convert.ToInt32(pBplane4.Left) < 423 && Convert.ToInt32(pBplane4.Top) < 287)
            {
                lblNT4.ForeColor = Color.Lime;
                lblWT4.ForeColor = Color.Lime;
                lblET4.ForeColor = Color.Black;
                lblST4.ForeColor = Color.Black;
            }
            else if (Convert.ToInt32(pBplane4.Left) > 423 && Convert.ToInt32(pBplane4.Top) < 287)
            {
                lblNT4.ForeColor = Color.Lime;
                lblET4.ForeColor = Color.Lime;
                lblST4.ForeColor = Color.Black;
                lblWT4.ForeColor = Color.Black;



            }
            else if (Convert.ToInt32(pBplane4.Left) < 423 && Convert.ToInt32(pBplane4.Top) > 287)
            {
                lblNT4.ForeColor = Color.Black;
                lblET4.ForeColor = Color.Black;
                lblST4.ForeColor = Color.Lime;
                lblWT4.ForeColor = Color.Lime;



            }
            else if (Convert.ToInt32(pBplane4.Left) > 423 && Convert.ToInt32(pBplane4.Top) > 287)
            {
                lblNT4.ForeColor = Color.Black;
                lblET4.ForeColor = Color.Lime;
                lblST4.ForeColor = Color.Lime;
                lblWT4.ForeColor = Color.Black;



            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetValues();
        }
    }
    }

