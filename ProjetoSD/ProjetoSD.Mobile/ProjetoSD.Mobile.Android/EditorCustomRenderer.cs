﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ProjetoSD.Mobile.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Editor), typeof(EditorCustomRenderer))]
namespace ProjetoSD.Mobile.Droid
{
    public class EditorCustomRenderer : EditorRenderer
    {
        public EditorCustomRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            Control.BackgroundTintList = ColorStateList.ValueOf(Android.Graphics.Color.White);
            Control.SetHintTextColor(ColorStateList.ValueOf(Android.Graphics.Color.White));
        }
    }
}