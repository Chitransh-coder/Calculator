using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Calculator
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            EditText no1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText no2 = FindViewById<EditText>(Resource.Id.editText2);
            Button buttonD = FindViewById<Button>(Resource.Id.button4);
            Button buttonS = FindViewById<Button>(Resource.Id.button3);
            Button buttonA = FindViewById<Button>(Resource.Id.button1);
            Button buttonM = FindViewById<Button>(Resource.Id.button2);
            TextView result = FindViewById<TextView>(Resource.Id.textView3);

            buttonA.Click += (s, e) =>
            {
                if (no1.Text == "")
                {
                    no1.Text = "0";
                }

                if (no2.Text == "")
                {
                    no2.Text = "0";
                }
                double x = Convert.ToDouble(no1.Text);
                double y = Convert.ToDouble(no2.Text);
                result.Text = Convert.ToString(x + y);
            };
            buttonS.Click += (s, e) =>
            {
                if (no1.Text == "")
                {
                    no1.Text = "0";
                }

                if (no2.Text == "")
                {
                    no2.Text = "0";
                }
                double x = Convert.ToDouble(no1.Text);
                double y = Convert.ToDouble(no2.Text);
                result.Text = Convert.ToString(x - y);
            };
            buttonM.Click += (s, e) =>
            {
                if (no1.Text == "")
                {
                    no1.Text = "0";
                }

                if (no2.Text == "")
                {
                    no2.Text = "0";
                }
                double x = Convert.ToDouble(no1.Text);
                double y = Convert.ToDouble(no2.Text);
                result.Text = Convert.ToString(x * y);
            };
            buttonD.Click += (s, e) =>
            {
                if (no1.Text == "")
                {
                    no1.Text = "0";
                }

                if (no2.Text == "")
                {
                    no2.Text = "0";
                }
                double x = Convert.ToDouble(no1.Text);
                double y = Convert.ToDouble(no2.Text);
                result.Text = Convert.ToString(x / y);
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}