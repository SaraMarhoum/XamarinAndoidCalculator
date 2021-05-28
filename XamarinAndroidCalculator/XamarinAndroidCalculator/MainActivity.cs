using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace XamarinAndroidCalculator
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

            Button plus = FindViewById<Button>(Resource.Id.buttonplus);
            Button moins = FindViewById<Button>(Resource.Id.buttonmoins);
            Button fois = FindViewById<Button>(Resource.Id.buttonmultipli);
            Button divise = FindViewById<Button>(Resource.Id.buttondivise);
            Button clear = FindViewById<Button>(Resource.Id.buttonClear);

            EditText val1 = FindViewById<EditText>(Resource.Id.editText1);
            EditText val2 = FindViewById<EditText>(Resource.Id.editText2);

            TextView result = FindViewById<TextView>(Resource.Id.textView1);

            //Addition
            plus.Click += (S, e) =>
                {
                    int var1 = int.Parse(val1.Text);
                    int var2 = int.Parse(val2.Text);

                    result.Text = (var1 + var2).ToString();
                };


            //Soustraction
            moins.Click += (S, e) =>
            {
                int var1 = int.Parse(val1.Text);
                int var2 = int.Parse(val2.Text);

                result.Text = (var1 - var2).ToString();
            };

            //Multiplication
            fois.Click += (S, e) =>
            {
                int var1 = int.Parse(val1.Text);
                int var2 = int.Parse(val2.Text);

                result.Text = (var1 * var2).ToString();
            };

            //Division
            divise.Click += (S, e) =>
            {
                int var1 = int.Parse(val1.Text);
                int var2 = int.Parse(val2.Text);

                result.Text = (var1 / var2).ToString();
            };

            //Annuler
            clear.Click += (S, e) =>
            {
                val1.Text = "";
                val2.Text = "";
                result.Text = "0";
            };

        }
    }
}