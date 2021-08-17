using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace MultipleActivities_Xamarin_Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnNext;
        TextView txtName;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            txtName = FindViewById<TextView>(Resource.Id.txtName);
            btnNext = FindViewById<Button>(Resource.Id.btnNext);
            btnNext.Click += OnNextButtonClick;
        }
        public void OnNextButtonClick(object sender, EventArgs e)
        {
           var activity2 = new Intent(this, typeof(SecondActivity));

           activity2.PutExtra("Name", txtName.Text);
           activity2.PutExtra("ID", 101);
           activity2.PutExtra("Course", "Mobile Development ");

          StartActivity(activity2);

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}