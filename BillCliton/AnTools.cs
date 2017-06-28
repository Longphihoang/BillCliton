using System;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;
using Android.Graphics;
using Java.IO;

using Android.Content;

namespace BlueDagdroid
{
    static class  AnTools
    {
        //initilizes during main acitibity
        public static Typeface AndroidBoldtf;
        public static Typeface Cabintf;
        public static Color DefaultFontColor = Color.White;
        public static float DefaultFonrtSize=14;

        public static void initFontSize(float a)
        {
            DefaultFonrtSize = a;
        }
        public static void initDefaultFontColor(Color c)
        {
            //DefaultFontColor = c;
        }
        public static  void initFont(Typeface a, Typeface b)
        {
            AndroidBoldtf = a;
            Cabintf = b;
        }

        public static void toast(String text, Context context)
        {

            Toast toast = Toast.MakeText(context, text, ToastLength.Short);
            toast.Show();

        }

        public static bool hideAllChildren(View v)
        {
            
            LinearLayout li = (LinearLayout)(v);
            if(li.ChildCount==1)
            {
                return false;
            }
            for(int i = 1; i < li.ChildCount;i++)
            {
                li.GetChildAt(i).Animate().TranslationY(li.GetChildAt(i).Height).Alpha(0.0f).SetDuration(200);
                li.GetChildAt(i).Visibility= ViewStates.Gone;
            }
            return true;
        }

        public static bool showAllChildren(View v)
        {
            LinearLayout li = (LinearLayout)(v);
            if(li.ChildCount==1)
            {
                return false;
            }
            for (int i = 1; i < li.ChildCount; i++)
            {
                li.GetChildAt(i).Animate().TranslationY(0).Alpha(1.0f).SetDuration(200);
                li.GetChildAt(i).Visibility = ViewStates.Visible;
            }
            return true;
        }

        public static void coloredToast(String text, Context context, Color color, GravityFlags gravity)
        {
            Toast toast = Toast.MakeText(context, text, ToastLength.Long);
            toast.SetGravity(gravity,0,0);
            View view = toast.View;
            view.SetBackgroundColor(color);
            
            toast.Show();
        }

        public static void addCustomBorder(View lc, int strokeSize, int radius)
        {
            Random random = new Random();
            GradientDrawable gd = new GradientDrawable();
            //gd.SetColor(Color.Rgb(random.Next(100, 150), random.Next(100, 150), random.Next(100, 150)));
            gd.SetCornerRadius(radius);
            gd.SetStroke(strokeSize, Color.White);
            lc.SetBackgroundDrawable(gd);
        }

        public static TextView getTextView(String content, float fontsize, Typeface tf,  Context c)
        {
            TextView tv = new TextView(c);
            LinearLayout.LayoutParams ll = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            ll.SetMargins(5, 0, 5, 0);
            tv.LayoutParameters = ll;
            tv.SetSingleLine(false);
            tv.TextSize=fontsize;
            tv.Typeface = tf;
            tv.SetTextColor(DefaultFontColor);
            tv.Text = content;
            return tv;
        }

        //margins/colors
        public static TextView getTextView(String content, float fontsize, Typeface tf, Context c, Color color,int left,int top, int right, int bottom)
        {
            TextView tv = new TextView(c);
            LinearLayout.LayoutParams ll = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            ll.SetMargins(left, top, right, bottom);
            tv.LayoutParameters = ll;
            tv.SetSingleLine(false);
            tv.SetTextColor(color);
            tv.TextSize = fontsize;
            tv.Typeface = tf;
            tv.SetTextColor(color);
            tv.Text = content;
            return tv;
        }

        public static TextView getTextViewColor(String content, float fontsize, Typeface tf, Color color, Context c)
        {
            TextView tv = new TextView(c);
            tv.SetSingleLine(false);
            tv.TextSize = fontsize;
            tv.Typeface = tf;
            tv.SetTextColor(color);
            tv.Text = content;
            return tv;

        }


        public static TextView getTextViewColor(String content, Context c)
        {
            TextView tv = new TextView(c);
            tv.SetSingleLine(false);
            tv.Text = content;
            return tv;

        }


        public static void addBorder(LinearLayout lc)
        {
                        Random random = new Random();
            GradientDrawable gd = new GradientDrawable();
            //gd.SetColor(Color.Rgb(random.Next(100, 150), random.Next(100, 150), random.Next(100, 150)));
            gd.SetCornerRadius(5);
            gd.SetStroke(2, Color.White);
            lc.SetBackgroundDrawable(gd);
        }

        public static void addBorderNoRadius(LinearLayout lc)
        {
            Random random = new Random();
            GradientDrawable gd = new GradientDrawable();
            //gd.SetColor(Color.Rgb(random.Next(100, 150), random.Next(100, 150), random.Next(100, 150)));
            gd.SetCornerRadius(0);
            gd.SetStroke(1, Color.White);
            lc.SetBackgroundDrawable(gd);
        }

        public static void addBorderNoColor(View lc)
        {
            Random random = new Random();
            GradientDrawable gd = new GradientDrawable();
            //gd.SetColor(Color.Rgb(random.Next(100, 150), random.Next(100, 150), random.Next(100, 150)));
            gd.SetCornerRadius(5);
            gd.SetStroke(1, Color.White);
            lc.SetBackgroundDrawable(gd);
        }

        public static int randomInt(int start, int end)
        {
            Random random = new Random();
            return random.Next(start, end);

        }

        public static void removeNeighborVViewsAndParent(View v)
        {
            LinearLayout parent = (LinearLayout)(v.Parent);
            parent.RemoveViews(0, parent.ChildCount);
        }

        public static void viewGlowTransition(View view)
        {
            view.SetBackgroundColor(Color.Transparent);
        }

        public static LinearLayout getHorizLayout(Context context)
        {
            LinearLayout layout = new LinearLayout(context);
            layout.Orientation = Orientation.Horizontal;
            return layout;
        }

        public static ImageView getFixedSizeImageView(Context context,int width, int height)
        {
            ImageView view = new ImageView(context);

            if (height == 0)
            {

            }
            else
            {
                view.SetMaxHeight(height);

            }
            if(width==0)
            {

            }
            else
            {
                view.SetMaxWidth(width);
            }
            return view;
        }




    }
}