using MauiApp3.MVVM.Model;

namespace MauiApp3.MVVM.ViewModel
{
    public class BMIViewModel
    {
        public BMI BMI { get; set; }

        public BMIViewModel() 
        {
            BMI = new BMI();
            BMI.Height = 180;
            BMI.Weight = 73;
        }
    }
}
