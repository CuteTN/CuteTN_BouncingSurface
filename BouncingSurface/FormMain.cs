using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingSurface
{
    public partial class FormMain : Form
    {
        #region creation
        public FormMain()
        {
            InitializeComponent();
            InitializeCustomObjects();
        }

        public float Density = 1f/10;
        public int ModelWidth { get => (int)(Width*Density); }
        public Color WaterColor;
        public int WaterApplyRange = 5;


        SurfaceModel _Surface = null;
        public SurfaceModel Surface
        {
            get
            {
                if(_Surface == null)
                    _Surface = new SurfaceModel(ModelWidth, 300);
                return _Surface;
            }

            set
            {
                _Surface = value;
            }
        }


        private void InitializeCustomObjects()
        {
            foreach(var uc in Controls)
            {
                if(uc is NumericUpDown)
                    (uc as NumericUpDown).KeyDown += FormMain_KeyDown;
                if(uc is Button)
                    (uc as Button).KeyDown += FormMain_KeyDown;
            }

            Timer = new Timer();
            Timer.Interval = 20;
            Timer.Tick += Timer_Tick;
            Timer.Start();

            WaterColor = Color.HotPink;
        }

        #endregion

        #region Event handling
        private void HandleKeyDown_Common(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Escape:
                    {
                        Application.Exit();
                        break;
                    }
                default:
                    break;
            }
        }

        private void HandlePaint_FrameUpdate(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(WaterColor);
            Rectangle range = new Rectangle(0, 0, Width, Height); 

            Surface.Render(e.Graphics, range, brush);
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            HandleKeyDown_Common(sender, e);
        }

        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            HandlePaint_FrameUpdate(sender, e);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimerTick_UpdateModel();
            Refresh();
        }

        private void nudViscosity_ValueChanged(object sender, EventArgs e)
        {
            Viscosity = (float)(sender as NumericUpDown).Value;
        }
        private void nudFriction_ValueChanged(object sender, EventArgs e)
        {
            Friction = (float)(sender as NumericUpDown).Value;
        }

        private void nudFps_ValueChanged(object sender, EventArgs e)
        {
            int fps = (int)(sender as NumericUpDown).Value;

            Timer.Stop();
            
            if(fps != 0)
            { 
                // fps = 1000 / Timer.Interval <=> ...
                Timer.Interval = (int)Math.Round(1000f / fps);
                Timer.Start(); 
            }

            // When the fps is 0, don't start the timer!
        }

        private void nudDensity_ValueChanged(object sender, EventArgs e)
        {
            Density = (float)(sender as NumericUpDown).Value;
            Surface.CreateModel(ModelWidth, 300);
        }

        private void nudApplyRange_ValueChanged(object sender, EventArgs e)
        {
            WaterApplyRange = (int)(sender as NumericUpDown).Value;
        }

        private void btnWaterColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            var result = dlg.ShowDialog();

            if(result == DialogResult.OK)
            {
                WaterColor = dlg.Color;
            }
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            var result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                BackColor = dlg.Color;
            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            int MouseX = (int)Math.Round(e.X * Density); 
            for(int x=MouseX-WaterApplyRange+1; x<=MouseX+WaterApplyRange-1; x++)
            {
                try { Surface.SetCell(x, Height - e.Y); }
                catch { /*MessageBox.Show(MouseX.ToString());*/ }
            }
        }

        #endregion

        #region Frame Updating
        Timer Timer; 

        private void TimerTick_UpdateModel()
        {
            Surface.Update();
        }

        #endregion

        #region User Setting
        public float Viscosity
        {
            get => Surface.Viscosity;
            set => Surface.Viscosity = value;
        }

        public float Friction
        {
            get => Surface.Friction;
            set => Surface.Friction = value;
        }


        #endregion


    }
}
