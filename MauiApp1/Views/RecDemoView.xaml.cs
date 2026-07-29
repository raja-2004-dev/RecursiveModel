using MauiApp1.Models;
using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class RecDemoView : ContentView
{
    public static readonly BindableProperty RecursiveModelProperty =
    BindableProperty.Create(
        nameof(RecursiveModel),
        typeof(RecursiveModel),
        typeof(RecDemoView),
        defaultValue: null,
        propertyChanged: OnRecursiveModelChanged);

    public RecursiveModel RecursiveModel
    {
        get => (RecursiveModel)GetValue(RecursiveModelProperty);
        set => SetValue(RecursiveModelProperty, value);
    }

    public bool _isFile;
    public bool IsFile
    {
        get => _isFile;
        set => _isFile = value;
    }

    private static void OnRecursiveModelChanged(
        BindableObject bindable,
        object oldValue,
        object newValue)
    {
        if (bindable is RecDemoView control)
        {
            control.BuildUI();
            
        }
    }
    public RecDemoView()
    {
        InitializeComponent();

    }

    void BuildUI()
    {
       
        Textlabel.Text = RecursiveModel.Name;

        if (RecursiveModel.Directories != null && RecursiveModel.Directories.Count > 0)
        {
           ComponentImage.Source = "folder.png";
            Arrow.IsVisible = true;
            ComponentsCollectionView.ItemsSource = RecursiveModel.Directories;
           
        }
        

    }
    

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        ComponentsCollectionView.IsVisible = !ComponentsCollectionView.IsVisible;
        if (ComponentsCollectionView.IsVisible)
        {
            Arrow.RotateToAsync(90);
        }
        else
        {
            Arrow.RotateToAsync(0);
           
        }
    }
}