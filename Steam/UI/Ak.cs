using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;
namespace Aka.UI
{
    #region Helper
    static class Helpers
    {
        public enum MouseState : byte
        {
            None = 0,
            Over = 1,
            Down = 2
        }

        public static Rectangle FullRectangle(Size S, bool Subtract)
        {
            if (Subtract)
            {
                return new Rectangle(0, 0, S.Width - 1, S.Height - 1);
            }
            else {
                return new Rectangle(0, 0, S.Width, S.Height);
            }
        }

        public static Color GreyColor(int G)
        {
            return Color.FromArgb(G, G, G);
        }

        public static void CenterString(Graphics G, string T, Font F, Color C, Rectangle R)
        {
            SizeF TS = G.MeasureString(T, F);
            using (SolidBrush B = new SolidBrush(C))
            {
                G.DrawString(T, F, B, new Point(checked((int)Math.Round((double)R.Width / 2 - (double)(TS.Width / 2f))), checked((int)Math.Round((double)R.Height / 2 - (double)(TS.Height / 2f)))));
            }
        }

        public static void FillRoundRect(Graphics G, Rectangle R, int Curve, Brush B)
        {
            G.FillPie(B, R.X, R.Y, Curve, Curve, 180, 90);
            G.FillPie(B, R.X + R.Width - Curve, R.Y, Curve, Curve, 270, 90);
            G.FillPie(B, R.X, R.Y + R.Height - Curve, Curve, Curve, 90, 90);
            G.FillPie(B, R.X + R.Width - Curve, R.Y + R.Height - Curve, Curve, Curve, 0, 90);
            G.FillRectangle(B, Convert.ToInt32(R.X + Curve / 2), R.Y, R.Width - Curve, Convert.ToInt32(Curve / 2));
            G.FillRectangle(B, R.X, Convert.ToInt32(R.Y + Curve / 2), R.Width, R.Height - Curve);
            G.FillRectangle(B, Convert.ToInt32(R.X + Curve / 2), Convert.ToInt32(R.Y + R.Height - Curve / 2), R.Width - Curve, Convert.ToInt32(Curve / 2));
        }

        public static void DrawRoundRect(Graphics G, Rectangle R, int Curve, Pen PP)
        {
            G.DrawArc(PP, R.X, R.Y, Curve, Curve, 180, 90);
            G.DrawLine(PP, Convert.ToInt32(R.X + Curve / 2), R.Y, Convert.ToInt32(R.X + R.Width - Curve / 2), R.Y);
            G.DrawArc(PP, R.X + R.Width - Curve, R.Y, Curve, Curve, 270, 90);
            G.DrawLine(PP, R.X, Convert.ToInt32(R.Y + Curve / 2), R.X, Convert.ToInt32(R.Y + R.Height - Curve / 2));
            G.DrawLine(PP, Convert.ToInt32(R.X + R.Width), Convert.ToInt32(R.Y + Curve / 2), Convert.ToInt32(R.X + R.Width), Convert.ToInt32(R.Y + R.Height - Curve / 2));
            G.DrawLine(PP, Convert.ToInt32(R.X + Curve / 2), Convert.ToInt32(R.Y + R.Height), Convert.ToInt32(R.X + R.Width - Curve / 2), Convert.ToInt32(R.Y + R.Height));
            G.DrawArc(PP, R.X, R.Y + R.Height - Curve, Curve, Curve, 90, 90);
            G.DrawArc(PP, R.X + R.Width - Curve, R.Y + R.Height - Curve, Curve, Curve, 0, 90);
        }

        public enum Direction : byte
        {
            Up = 0,
            Down = 1,
            Left = 2,
            Right = 3
        }

        public static void DrawTriangle(Graphics G, Rectangle Rect, Direction D, Color C)
        {
            int halfWidth = Rect.Width / 2;
            int halfHeight = Rect.Height / 2;
            Point p0 = Point.Empty;
            Point p1 = Point.Empty;
            Point p2 = Point.Empty;

            switch (D)
            {
                case Direction.Up:
                    p0 = new Point(Rect.Left + halfWidth, Rect.Top);
                    p1 = new Point(Rect.Left, Rect.Bottom);
                    p2 = new Point(Rect.Right, Rect.Bottom);

                    break;
                case Direction.Down:
                    p0 = new Point(Rect.Left + halfWidth, Rect.Bottom);
                    p1 = new Point(Rect.Left, Rect.Top);
                    p2 = new Point(Rect.Right, Rect.Top);

                    break;
                case Direction.Left:
                    p0 = new Point(Rect.Left, Rect.Top + halfHeight);
                    p1 = new Point(Rect.Right, Rect.Top);
                    p2 = new Point(Rect.Right, Rect.Bottom);

                    break;
                case Direction.Right:
                    p0 = new Point(Rect.Right, Rect.Top + halfHeight);
                    p1 = new Point(Rect.Left, Rect.Bottom);
                    p2 = new Point(Rect.Left, Rect.Top);

                    break;
            }

            using (SolidBrush B = new SolidBrush(C))
            {
                G.FillPolygon(B, new Point[] {
                p0,
                p1,
                p2
            });
            }

        }

        public static Color ColorFromHex(string Hex)
        {
            Hex = Strings.Replace(Hex, "#", "", 1, -1, CompareMethod.Binary);
            string R = Conversions.ToString(Conversion.Val(string.Concat("&H", Strings.Mid(Hex, 1, 2))));
            string G = Conversions.ToString(Conversion.Val(string.Concat("&H", Strings.Mid(Hex, 3, 2))));
            string B = Conversions.ToString(Conversion.Val(string.Concat("&H", Strings.Mid(Hex, 5, 2))));
            Color ColorFromHex = Color.FromArgb(Conversions.ToInteger(R), Conversions.ToInteger(G), Conversions.ToInteger(B));
            return ColorFromHex;
        }

    }
    #endregion

    #region Tag
    public class AkaTagBox : Control
    {


        private Graphics G;
        public Color Background { get; set; }
        public Color Border { get; set; }
        public Color TextColor { get; set; }

        public AkaTagBox()
        {
            DoubleBuffered = true;
            Text = "Tag";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            G = e.Graphics;
            this.G.SmoothingMode = SmoothingMode.HighQuality;
            this.G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            base.OnPaint(e);

            using (SolidBrush B1 = new SolidBrush(Background))
            {
                using (Pen P1 = new Pen(Border))
                {
                    using (SolidBrush B2 = new SolidBrush(TextColor))
                    {
                        G.FillRectangle(B1, Helpers.FullRectangle(Size, true));
                        Helpers.DrawRoundRect(G, Helpers.FullRectangle(Size, true), 3, P1);


                        if (Information.IsNumeric(Text))
                        {
                            using (Font F1 = new Font("Segoe UI", 8, FontStyle.Bold))
                            {
                                G.DrawString(Text, F1, B2, new Point(2, 0));

                            }


                        }
                        else {
                            using (Font F1 = new Font("Segoe UI", 7, FontStyle.Bold))
                            {
                                G.DrawString(Text.ToUpper(), F1, B2, new Point(2, 1));
                            }

                        }

                    }
                }
            }

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(Width, 15);
        }

    }
    #endregion

    #region circle
    public class AkaCircleProgress : Control
    {

        private Graphics G;
        private float ProgressAngle;
        private float RemainderAngle;
        private bool ExceedingLimits;

        private string ExceedingSign;
        private float _Progress;
        private float _Max = 100;

        private float _Min = 0;
        public bool Percent { get; set; }


        public float Progress
        {
            get
            {
                return this._Progress;
            }
            set
            {
                float single = value;
                if (single > this.Max)
                {
                    value = this.Max;
                    this.ExceedingSign = "+";
                    this.ExceedingLimits = true;
                    base.Invalidate();
                }
                else if (single < this.Min)
                {
                    value = this.Min;
                    this.ExceedingSign = "-";
                    this.ExceedingLimits = true;
                    base.Invalidate();
                }
                this._Progress = value;
                base.Invalidate();
            }
        }

        public float Max
        {
            get
            {
                return this._Max;
            }
            set
            {
                if (value < this._Progress)
                {
                    this._Progress = value;
                }
                this._Max = value;
                base.Invalidate();
            }
        }

        public float Min
        {
            get
            {
                return this._Min;
            }
            set
            {
                if (value > this._Progress)
                {
                    this._Progress = value;
                }
                this._Min = value;
                base.Invalidate();
            }
        }


        public Color Border { get; set; }
        public Color HatchPrimary { get; set; }
        public Color HatchSecondary { get; set; }

        public AkaCircleProgress()
        {
            DoubleBuffered = true;
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            G = e.Graphics;
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            G.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            base.OnPaint(e);

            ProgressAngle = 360 / Max * Progress;
            RemainderAngle = 360 - ProgressAngle;

            using (Pen P1 = new Pen(new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.LightUpwardDiagonal, HatchPrimary, HatchSecondary), 4))
            {
                using (Pen P2 = new Pen(Border, 4))
                {
                    G.DrawArc(P1, new Rectangle(2, 2, Width - 5, Height - 5), -90, ProgressAngle);
                    G.DrawArc(P2, new Rectangle(2, 2, Width - 5, Height - 5), ProgressAngle - 90, RemainderAngle);
                }
            }


            if (Percent)
            {
                using (Font F1 = new Font("Segoe UI", 9, FontStyle.Bold))
                {

                    if (ExceedingLimits)
                    {
                        Helpers.CenterString(G, Progress + "%" + ExceedingSign, F1, Color.FromArgb(100, 100, 100), new Rectangle(1, 1, Width, Height + 1));
                    }
                    else {
                        Helpers.CenterString(G, Progress + "%", F1, Color.FromArgb(100, 100, 100), new Rectangle(1, 1, Width, Height + 1));
                    }

                }


            }
            else {
                if (ExceedingLimits)
                {
                    Helpers.CenterString(G, Progress + ExceedingSign, new Font("Segoe UI", 9, FontStyle.Bold), Color.FromArgb(100, 100, 100), new Rectangle(1, 1, Width, Height + 1));
                }
                else {
                    Helpers.CenterString(G, Conversions.ToString(this.Progress), new Font("Segoe UI", 9, FontStyle.Bold), Color.FromArgb(100, 100, 100), new Rectangle(1, 1, Width, Height + 1));
                }

            }

            ExceedingLimits = false;

            Helpers.CenterString(G, Text.ToUpper(), new Font("Segoe UI", 6, FontStyle.Bold), Color.FromArgb(170, 170, 170), new Rectangle(2, 2, Width, Height + 27));

        }

    }

    #endregion
}
