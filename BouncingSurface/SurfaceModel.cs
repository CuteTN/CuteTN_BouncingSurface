using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncingSurface
{
    public class SurfaceModel
    {
        #region creation
        private int Width;
        private List<float> CellHeight;
        private List<float> CellVelocity;
        private List<float> CellAcceleration;

        public SurfaceModel(int width, float avgHeigth)
        {
            CreateModel(width, avgHeigth);
        }

        public void CreateModel(int width, float avgHeigth)
        {
            Width = width;

            // Fill the default value to each cell element
            CellHeight = Enumerable.Repeat(avgHeigth, width).ToList();
            CellVelocity = Enumerable.Repeat(0f, width).ToList();
            CellAcceleration = Enumerable.Repeat(0f, width).ToList();
        }
        #endregion

        #region get and set cell height
        // I didnt make CellHeight public so that other class cant change its size externally

        public float GetCell(int x)
        {
            return CellHeight[x];
        }

        public void SetCell(int x, float value)
        {
            CellHeight[x] = value;
        }
        
        /// <summary>
        /// Set the cell height at x to value but still maintain the sum of the height by decreasing nearby cells
        /// </summary>
        /// <param name="x"></param>
        /// <param name="value"></param>
        public void PushCell(int x, float value)
        {
            float delta = value - CellHeight[x];
            if(delta % 2 != 0)
                delta++;

            CellHeight[x] += delta;
            
            if(x > 0)
                CellHeight[x-1] -= delta / 2;

            if(x<Width-1)
                CellHeight[x+1] -= delta / 2;
        }
        #endregion

        #region Frame Update
        public float Viscosity = 0.5f;
        public float Friction = 0.05f;
        public int GlueRange = 5;


        public float SumRange(int L, int R)
        {
            float result = 0;
            for(int i=Math.Max(L, 0); i<=Math.Min(Width-1, R); i++)
                result += CellHeight[i];

            return result;
        }

        public int CountRange(int L, int R)
        {
            return Math.Min(Width - 1, R) - Math.Max(L, 0) + 1;
        }

        public float AverageRange(int L, int R)
        {
            float result = SumRange(L, R);
            result /= CountRange(L, R);

            return result;
        }

        private void UpdateAcceleration()
        {
            // CellAcceleration[0] = CellHeight[1] - CellHeight[0];
            // CellAcceleration[Width-1] = CellHeight[Width-2] - CellHeight[Width-1]; 

            for(int i=0; i<Width; i++)
            {
                int left = i - GlueRange;
                int right = i + GlueRange;

                float temp = AverageRange(left, right);
                CellAcceleration[i] = (temp - CellHeight[i]) * (1f - Viscosity);
            }
        }

        private void UpdateVelocity()
        {
            for(int i=0; i<Width; i++)
            {
                CellVelocity[i] = CellVelocity[i] * (1 - Friction);
                CellVelocity[i] += CellAcceleration[i];
            }
        }

        private void UpdateHeight()
        {
            for(int i=0; i<Width; i++)
            {
                CellHeight[i] += CellVelocity[i];
            }
        }

        public void Update()
        {
            UpdateAcceleration();
            UpdateVelocity();
            UpdateHeight();
        }
        #endregion

        #region Rendering
        private PointF[] PointsToRender(Rectangle range)
        {
            PointF[] result = new PointF[Width + 4];

            float deltaX = (float)range.Width / (Width-1);

            result[Width  ] = new PointF(range.Right + 15, range.Bottom - CellHeight[Width-1]);
            result[Width+1] = new PointF(range.Right, range.Bottom + 15);
            result[Width+2] = new PointF(range.Left, range.Bottom + 15);
            result[Width+3] = new PointF(range.Left - 15, range.Bottom - CellHeight[0]);

            for(int i=0; i<Width; i++)
            {
                result[i] = new PointF(range.Left + deltaX*i, range.Bottom - CellHeight[i]);
            }

            return result;
        }

        public void Render(Graphics g, Rectangle range, Brush brush)
        {
            PointF[] points = PointsToRender(range);
            g.FillClosedCurve(brush, points);
            // g.DrawPolygon(new Pen(Color.Blue), points);
        }
        #endregion
    }
}
