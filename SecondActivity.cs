using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultipleActivities_Xamarin_Android
{
    [Activity(Label = "SecondActivity")]
    public class SecondActivity : Activity
    {
        TextView txtMessage;
        TextView txtIDMessage;
        TextView txtCourseMessage;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.SecondActivity);

            txtMessage = FindViewById<TextView>(Resource.Id.txtMessage);
            txtMessage.Text = "Hi " + Intent.GetStringExtra("Name");

            txtIDMessage = FindViewById<TextView>(Resource.Id.txtIDMessage);
            txtIDMessage.Text = (Intent.GetIntExtra("ID",0)).ToString();

            txtCourseMessage = FindViewById<TextView>(Resource.Id.txtCourseMessage);
            txtCourseMessage.Text = Intent.GetStringExtra("Course");

            
        }
    }
}