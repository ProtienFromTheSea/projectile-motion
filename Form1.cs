using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Science_Fair_Projectile_Motion
{
    public partial class Form1 : Form
    {
        Graphics ballgraphics;
        Pen myPen;
        int angle;
        int velocity;
      //  int oldangle;
      //  int oldvelocity;
        double x;
        double y;
        double xvelocity, yveloccity;
        double conversionfactor = Math.PI / 180;
        double seconds;
        double parabola, a,b;
        double range;
        bool finished = false;
        double slope;
        double drawx, drawy;
        Pen penline = new Pen(Color.Green, 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void trb_angle_Scroll(object sender, EventArgs e)
        {
            angle = trb_angle.Value;
            lb_angle.Text = trb_angle.Value.ToString() + "°";
            //ballgraphics.Clear(graphics_pnl.BackColor);
            //slope = Math.Tan(angle);
            drawx = Math.Cos(angle * conversionfactor)*30;
            drawy = graphics_pnl.Height - (Math.Sin(angle * conversionfactor)*30);
            ballgraphics.DrawLine(penline,0,0,(float)drawx,(float)drawy);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ballgraphics = graphics_pnl.CreateGraphics();
            myPen = new Pen(Color.Black, 10);
            seconds = 0.0;
            
        }

        private void btn_pauseplay_Click(object sender, EventArgs e)
        {
            
            if(btn_pauseplay.Text == "▶")
            {


                if (int.TryParse(tb_velocity.Text, out velocity))
                {
                    angle = trb_angle.Value;
                    xvelocity = velocity * Math.Cos(angle * conversionfactor);
                    a = Math.Tan(angle * conversionfactor);
                    b = -9.8 / (2 * xvelocity * xvelocity);
                    //parabola = 9.8 / (2 * Math.Pow(velocity, 2) * Math.Pow(Math.Cos(angle * conversionfactor), 2));
                    tenthsecond_tim.Enabled = true;
                    lb_finaltime.Visible = false;
                    lb_range.Visible = false;
                    finaltimeprompt_lb.Visible = false;
                    rangeprompt_lb.Visible = false;
                    btn_pauseplay.Text = "⏸";
                    // MessageBox.Show(xvelocity.ToString());
                   range = (velocity * velocity * Math.Sin(angle * conversionfactor * 2)) / 9.8;
                   // range = 2 * velocity * velocity * Math.Sin(angle * conversionfactor) * Math.Cos(angle * conversionfactor) / 9.8;


                    MessageBox.Show(range.ToString());
                }
                else
                {
                    MessageBox.Show("Please enter a number in the 'velocity' box");
                }
                if (finished)
                {
                    seconds = 0.0;
                    ballgraphics.Clear(graphics_pnl.BackColor);
                }
                    

            }
            else
            {
                tenthsecond_tim.Stop();
                //lb_finaltime.Visible = true;
                lb_range.Visible = true;
                finaltimeprompt_lb.Visible = true;
                rangeprompt_lb.Visible = true;
                btn_pauseplay.Text = "▶";
                lb_range.Text = range.ToString();

            }
        }

        private void tenthsecond_tim_Tick(object sender, EventArgs e)
        {
             seconds +=0.1;
            if (x >= range)
            {
                tenthsecond_tim.Enabled = false;
                lb_finaltime.Visible = true;
                lb_range.Visible = true;
                finaltimeprompt_lb.Visible = true;
                rangeprompt_lb.Visible = true;
                btn_pauseplay.Text = "▶";
                lb_range.Text = range.ToString();
                lb_finaltime.Text = seconds.ToString();
                tenthsecond_tim.Enabled = false;
                finished = true;
                

            }
            else
            {
                x = xvelocity * seconds;
                yveloccity = velocity * Math.Sin(angle * conversionfactor) - 9.8 * seconds;
                y = a * x + b * x * x;
              // c  y = yveloccity * seconds;
                // y = ((Math.Tan(angle * conversionfactor) * x) - parabola) * Math.Pow(x, 2);
                //ballgraphics.Clear(graphics_pnl.BackColor);
                ballgraphics.DrawEllipse(myPen, (float)x - 6, (float)(graphics_pnl.Height - y) - 6, 5, 5);
                lb_xpos.Text = x.ToString();
                lb_ypos.Text = y.ToString();
            }
        }

    }
}
