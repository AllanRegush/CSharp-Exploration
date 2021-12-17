using Newtonsoft.Json;
using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ShoppingList.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        private readonly string  _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");
        
        private  List<ShoppingItemModel> _shoppingItems;

        public ListPage()
        {
            InitializeComponent();
            //_shoppingItems = new List<ShoppingItemModel>();
            
            
            if (File.Exists(_fileName))
            {
                string shoppingItemsJson = File.ReadAllText(_fileName);
                try
                {
                    _shoppingItems = JsonConvert.DeserializeObject<List<ShoppingItemModel>>(shoppingItemsJson);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    _shoppingItems = new List<ShoppingItemModel>();
                }
            } 
            else
            {
                _shoppingItems = new List<ShoppingItemModel>();
            }
            
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                collectionView.ItemsSource = _shoppingItems
                    .OrderBy(item => item.IsCrossedOff)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            ShoppingItemModel shoppingItem = new ShoppingItemModel { Id = _shoppingItems.Count + 1, Item = editor.Text, IsCrossedOff = false };
            _shoppingItems.Add(shoppingItem);
            collectionView.ItemsSource = _shoppingItems
            .OrderBy(item => item.IsCrossedOff)
            .ToList();
            var json = JsonConvert.SerializeObject(_shoppingItems);
            File.WriteAllText(_fileName, json);
        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            editor.Text = "";
        }

        void OnSelectionChanged(object sender, EventArgs e)
        {

        }
    }
}