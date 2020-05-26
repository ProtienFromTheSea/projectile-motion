namespace Science_Fair_Projectile_Motion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.yprompt_lb = new System.Windows.Forms.Label();
            this.xprompt_lb = new System.Windows.Forms.Label();
            this.angleprompt_lb = new System.Windows.Forms.Label();
            this.yvelopropmt_lb = new System.Windows.Forms.Label();
            this.xveloprompt_lb = new System.Windows.Forms.Label();
            this.Velocityprompt_lb = new System.Windows.Forms.Label();
            this.graphics_pnl = new System.Windows.Forms.Panel();
            this.lb_range = new System.Windows.Forms.Label();
            this.lb_finaltime = new System.Windows.Forms.Label();
            this.rangeprompt_lb = new System.Windows.Forms.Label();
            this.finaltimeprompt_lb = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.timeprompt_lb = new System.Windows.Forms.Label();
            this.btn_pauseplay = new System.Windows.Forms.Button();
            this.lb_yvelo = new System.Windows.Forms.Label();
            this.trb_angle = new System.Windows.Forms.TrackBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tb_velocity = new System.Windows.Forms.TextBox();
            this.lb_angle = new System.Windows.Forms.Label();
            this.lb_ypos = new System.Windows.Forms.Label();
            this.lb_xpos = new System.Windows.Forms.Label();
            this.lb_xvelo = new System.Windows.Forms.Label();
            this.tenthsecond_tim = new System.Windows.Forms.Timer(this.components);
            this.graphics_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_angle)).BeginInit();
            this.SuspendLayout();
            // 
            // yprompt_lb
            // 
            this.yprompt_lb.AutoSize = true;
            this.yprompt_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.yprompt_lb.Location = new System.Drawing.Point(252, 128);
            this.yprompt_lb.Name = "yprompt_lb";
            this.yprompt_lb.Size = new System.Drawing.Size(287, 37);
            this.yprompt_lb.TabIndex = 1;
            this.yprompt_lb.Text = "Current Y Position:";
            // 
            // xprompt_lb
            // 
            this.xprompt_lb.AutoSize = true;
            this.xprompt_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xprompt_lb.Location = new System.Drawing.Point(545, 411);
            this.xprompt_lb.Name = "xprompt_lb";
            this.xprompt_lb.Size = new System.Drawing.Size(286, 37);
            this.xprompt_lb.TabIndex = 2;
            this.xprompt_lb.Text = "Current X Position:";
            // 
            // angleprompt_lb
            // 
            this.angleprompt_lb.AutoSize = true;
            this.angleprompt_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angleprompt_lb.Location = new System.Drawing.Point(12, 128);
            this.angleprompt_lb.Name = "angleprompt_lb";
            this.angleprompt_lb.Size = new System.Drawing.Size(219, 37);
            this.angleprompt_lb.TabIndex = 3;
            this.angleprompt_lb.Text = "Starting Angle";
            this.toolTip1.SetToolTip(this.angleprompt_lb, "The starting angle is expressed as θ.");
            // 
            // yvelopropmt_lb
            // 
            this.yvelopropmt_lb.AutoSize = true;
            this.yvelopropmt_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.yvelopropmt_lb.Location = new System.Drawing.Point(17, 305);
            this.yvelopropmt_lb.Name = "yvelopropmt_lb";
            this.yvelopropmt_lb.Size = new System.Drawing.Size(369, 37);
            this.yvelopropmt_lb.TabIndex = 4;
            this.yvelopropmt_lb.Text = "Current Vertical Velocity:";
            this.toolTip1.SetToolTip(this.yvelopropmt_lb, "uᵧ = u · sinθ - g · t");
            // 
            // xveloprompt_lb
            // 
            this.xveloprompt_lb.AutoSize = true;
            this.xveloprompt_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xveloprompt_lb.Location = new System.Drawing.Point(17, 384);
            this.xveloprompt_lb.Name = "xveloprompt_lb";
            this.xveloprompt_lb.Size = new System.Drawing.Size(291, 37);
            this.xveloprompt_lb.TabIndex = 5;
            this.xveloprompt_lb.Text = "Horizontal Velocity:";
            this.toolTip1.SetToolTip(this.xveloprompt_lb, "The horizontal velocity remains constant throughout.");
            // 
            // Velocityprompt_lb
            // 
            this.Velocityprompt_lb.AutoSize = true;
            this.Velocityprompt_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Velocityprompt_lb.Location = new System.Drawing.Point(5, 12);
            this.Velocityprompt_lb.Name = "Velocityprompt_lb";
            this.Velocityprompt_lb.Size = new System.Drawing.Size(248, 37);
            this.Velocityprompt_lb.TabIndex = 6;
            this.Velocityprompt_lb.Text = "Starting Velocity";
            this.toolTip1.SetToolTip(this.Velocityprompt_lb, "The initial velocity is expressed as  u, which can be broken up into its x and y " +
        "components with the following equations: uₓ = u · cosθ, and uᵧ = u · sinθ");
            // 
            // graphics_pnl
            // 
            this.graphics_pnl.Controls.Add(this.lb_range);
            this.graphics_pnl.Controls.Add(this.lb_finaltime);
            this.graphics_pnl.Controls.Add(this.rangeprompt_lb);
            this.graphics_pnl.Controls.Add(this.finaltimeprompt_lb);
            this.graphics_pnl.Controls.Add(this.lb_time);
            this.graphics_pnl.Controls.Add(this.timeprompt_lb);
            this.graphics_pnl.Controls.Add(this.btn_pauseplay);
            this.graphics_pnl.Controls.Add(this.lb_yvelo);
            this.graphics_pnl.Location = new System.Drawing.Point(539, 12);
            this.graphics_pnl.Name = "graphics_pnl";
            this.graphics_pnl.Size = new System.Drawing.Size(613, 396);
            this.graphics_pnl.TabIndex = 7;
            // 
            // lb_range
            // 
            this.lb_range.AutoSize = true;
            this.lb_range.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_range.Location = new System.Drawing.Point(210, 84);
            this.lb_range.Name = "lb_range";
            this.lb_range.Size = new System.Drawing.Size(0, 37);
            this.lb_range.TabIndex = 21;
            this.lb_range.Visible = false;
            // 
            // lb_finaltime
            // 
            this.lb_finaltime.AutoSize = true;
            this.lb_finaltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_finaltime.Location = new System.Drawing.Point(188, 47);
            this.lb_finaltime.Name = "lb_finaltime";
            this.lb_finaltime.Size = new System.Drawing.Size(0, 37);
            this.lb_finaltime.TabIndex = 20;
            this.lb_finaltime.Visible = false;
            // 
            // rangeprompt_lb
            // 
            this.rangeprompt_lb.AutoSize = true;
            this.rangeprompt_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rangeprompt_lb.Location = new System.Drawing.Point(6, 84);
            this.rangeprompt_lb.Name = "rangeprompt_lb";
            this.rangeprompt_lb.Size = new System.Drawing.Size(198, 37);
            this.rangeprompt_lb.TabIndex = 19;
            this.rangeprompt_lb.Text = "Final Range:";
            this.toolTip1.SetToolTip(this.rangeprompt_lb, "The x value once y reaches 0.");
            this.rangeprompt_lb.Visible = false;
            // 
            // finaltimeprompt_lb
            // 
            this.finaltimeprompt_lb.AutoSize = true;
            this.finaltimeprompt_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.finaltimeprompt_lb.Location = new System.Drawing.Point(6, 47);
            this.finaltimeprompt_lb.Name = "finaltimeprompt_lb";
            this.finaltimeprompt_lb.Size = new System.Drawing.Size(176, 37);
            this.finaltimeprompt_lb.TabIndex = 18;
            this.finaltimeprompt_lb.Text = "Final Time:";
            this.toolTip1.SetToolTip(this.finaltimeprompt_lb, "The time when the projectile stops,(when y = 0, epressed as T) can be calculated " +
        "as  T= uᵧ / g");
            this.finaltimeprompt_lb.Visible = false;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_time.Location = new System.Drawing.Point(274, 3);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(0, 37);
            this.lb_time.TabIndex = 16;
            // 
            // timeprompt_lb
            // 
            this.timeprompt_lb.AutoSize = true;
            this.timeprompt_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.timeprompt_lb.Location = new System.Drawing.Point(6, 3);
            this.timeprompt_lb.Name = "timeprompt_lb";
            this.timeprompt_lb.Size = new System.Drawing.Size(262, 37);
            this.timeprompt_lb.TabIndex = 17;
            this.timeprompt_lb.Text = "Time Since Start:";
            this.toolTip1.SetToolTip(this.timeprompt_lb, "Time is expressed as t.");
            // 
            // btn_pauseplay
            // 
            this.btn_pauseplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.btn_pauseplay.Location = new System.Drawing.Point(529, 3);
            this.btn_pauseplay.Name = "btn_pauseplay";
            this.btn_pauseplay.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.btn_pauseplay.Size = new System.Drawing.Size(81, 81);
            this.btn_pauseplay.TabIndex = 10;
            this.btn_pauseplay.Text = "▶";
            this.btn_pauseplay.UseVisualStyleBackColor = true;
            this.btn_pauseplay.Click += new System.EventHandler(this.btn_pauseplay_Click);
            // 
            // lb_yvelo
            // 
            this.lb_yvelo.AutoSize = true;
            this.lb_yvelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_yvelo.Location = new System.Drawing.Point(-156, 294);
            this.lb_yvelo.Name = "lb_yvelo";
            this.lb_yvelo.Size = new System.Drawing.Size(0, 37);
            this.lb_yvelo.TabIndex = 14;
            // 
            // trb_angle
            // 
            this.trb_angle.Location = new System.Drawing.Point(12, 215);
            this.trb_angle.Maximum = 90;
            this.trb_angle.Name = "trb_angle";
            this.trb_angle.Size = new System.Drawing.Size(219, 69);
            this.trb_angle.TabIndex = 8;
            this.trb_angle.Value = 45;
            this.trb_angle.Scroll += new System.EventHandler(this.trb_angle_Scroll);
            // 
            // tb_velocity
            // 
            this.tb_velocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_velocity.Location = new System.Drawing.Point(12, 52);
            this.tb_velocity.Name = "tb_velocity";
            this.tb_velocity.Size = new System.Drawing.Size(157, 44);
            this.tb_velocity.TabIndex = 6;
            this.toolTip1.SetToolTip(this.tb_velocity, "Velocity is express");
            // 
            // lb_angle
            // 
            this.lb_angle.AutoSize = true;
            this.lb_angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_angle.Location = new System.Drawing.Point(12, 175);
            this.lb_angle.Name = "lb_angle";
            this.lb_angle.Size = new System.Drawing.Size(64, 37);
            this.lb_angle.TabIndex = 9;
            this.lb_angle.Text = "45°";
            // 
            // lb_ypos
            // 
            this.lb_ypos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_ypos.AutoSize = true;
            this.lb_ypos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_ypos.Location = new System.Drawing.Point(374, 165);
            this.lb_ypos.Name = "lb_ypos";
            this.lb_ypos.Size = new System.Drawing.Size(0, 37);
            this.lb_ypos.TabIndex = 12;
            // 
            // lb_xpos
            // 
            this.lb_xpos.AutoSize = true;
            this.lb_xpos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lb_xpos.Location = new System.Drawing.Point(828, 411);
            this.lb_xpos.Name = "lb_xpos";
            this.lb_xpos.Size = new System.Drawing.Size(0, 37);
            this.lb_xpos.TabIndex = 13;
            // 
            // lb_xvelo
            // 
            this.lb_xvelo.AutoSize = true;
            this.lb_xvelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_xvelo.Location = new System.Drawing.Point(305, 384);
            this.lb_xvelo.Name = "lb_xvelo";
            this.lb_xvelo.Size = new System.Drawing.Size(0, 37);
            this.lb_xvelo.TabIndex = 15;
            // 
            // tenthsecond_tim
            // 
            this.tenthsecond_tim.Tick += new System.EventHandler(this.tenthsecond_tim_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 450);
            this.Controls.Add(this.lb_xvelo);
            this.Controls.Add(this.xveloprompt_lb);
            this.Controls.Add(this.lb_xpos);
            this.Controls.Add(this.lb_ypos);
            this.Controls.Add(this.tb_velocity);
            this.Controls.Add(this.lb_angle);
            this.Controls.Add(this.trb_angle);
            this.Controls.Add(this.graphics_pnl);
            this.Controls.Add(this.Velocityprompt_lb);
            this.Controls.Add(this.yvelopropmt_lb);
            this.Controls.Add(this.angleprompt_lb);
            this.Controls.Add(this.xprompt_lb);
            this.Controls.Add(this.yprompt_lb);
            this.Name = "Form1";
            this.Text = "Projectile Motion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.graphics_pnl.ResumeLayout(false);
            this.graphics_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_angle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label yprompt_lb;
        private System.Windows.Forms.Label xprompt_lb;
        private System.Windows.Forms.Label angleprompt_lb;
        private System.Windows.Forms.Label yvelopropmt_lb;
        private System.Windows.Forms.Label xveloprompt_lb;
        private System.Windows.Forms.Label Velocityprompt_lb;
        private System.Windows.Forms.Panel graphics_pnl;
        private System.Windows.Forms.TrackBar trb_angle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btn_pauseplay;
        private System.Windows.Forms.Label lb_angle;
        private System.Windows.Forms.TextBox tb_velocity;
        private System.Windows.Forms.Label lb_ypos;
        private System.Windows.Forms.Label lb_xpos;
        private System.Windows.Forms.Label lb_yvelo;
        private System.Windows.Forms.Label lb_xvelo;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label timeprompt_lb;
        private System.Windows.Forms.Label lb_range;
        private System.Windows.Forms.Label lb_finaltime;
        private System.Windows.Forms.Label rangeprompt_lb;
        private System.Windows.Forms.Label finaltimeprompt_lb;
        private System.Windows.Forms.Timer tenthsecond_tim;
    }
}

