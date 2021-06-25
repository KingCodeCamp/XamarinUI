using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wave.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Lesson = new ObservableCollection<Lessons>();

            GetLesson();
        }

        public ObservableCollection<Lessons> Lesson { get; set; }

        void GetLesson()
        {
            Lesson.Add(new Lessons() { title = "Creative Thinking", imageUrl = "feedback.png", learners = "123 learners" });
            Lesson.Add(new Lessons() { title = "Team Work", imageUrl = "tinst.png", learners = "2331 learners" });
            Lesson.Add(new Lessons() { title = "Emotional Intelegent", imageUrl = "congratulation.png", learners = "0 learners" });

            lesson.ItemsSource = Lesson;
        }
    }

    public class Lessons
    {
        public string title { get; set; }
        public string learners { get; set; }
        public string imageUrl { get; set; }
    }
}