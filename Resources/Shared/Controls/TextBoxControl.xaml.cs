using my_school.MVVM.ViewModel.LoginViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace my_school.Resources.Shared.Controls
{
    /// <summary>
    /// Interação lógica para TextBoxControl.xam
    /// </summary>
    public partial class TextBoxControl : UserControl

    {

        //public event PropertyChangedEventHandler PropertyChanged;

        //// Método auxiliar para chamar o evento PropertyChanged
        //protected virtual void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        public static readonly DependencyProperty LabelTextProperty =
            DependencyProperty.Register("LabelText", typeof(string), typeof(TextBoxControl));

        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(TextBoxControl));

        public static readonly DependencyProperty BorderBrushProperty =
            DependencyProperty.Register("BorderBrush", typeof(SolidColorBrush), typeof(TextBoxControl));

        public static readonly DependencyProperty ErrorTextProperty =
            DependencyProperty.Register("ErrorText", typeof(string), typeof(TextBoxControl));

        public string LabelText
        {
            get => (string)GetValue(LabelTextProperty);
            set => SetValue(LabelTextProperty, value);
        }

        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public SolidColorBrush BorderBrush
        {
            get => (SolidColorBrush)GetValue(BorderBrushProperty);
            set => SetValue(BorderBrushProperty, value);
        }

        public string ErrorText
        {
            get => (string)GetValue(ErrorTextProperty);
            set => SetValue(ErrorTextProperty, value);
        }

        public TextBoxControl()
        {
            InitializeComponent();


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DataContext is LoginViewModel viewModel)
            {
                // Assumindo que o DataContext é do tipo LoginViewModel
                viewModel.ValidateForm("UserName"); // Ou passe o nome do campo dinamicamente
            }
        }
    }
}
