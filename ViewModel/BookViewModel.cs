using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Globalization;

namespace ViewModel
{
    public class BookViewModel
    {
        public ObservableCollection<Book> listBook { get; set; }

        public ICommand DeleteCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand UpdateCommand { get; set; }

        private ObservableCollection<Book> castListToObservableCollection(List<Book> list)
        {
            ObservableCollection<Book> result = new ObservableCollection<Book>();
            foreach (Book item in list)
            {
                result.Add(item);
            }
            return result;
        }

        public BookViewModel()
        {
            listBook = castListToObservableCollection(DataProvider.Ins.db.Books.ToList());            

            //Delete
            DeleteCommand = new RelayCommand<object>((p) => p != null, (p) => 
            {
                try
                {
                    DataProvider.Ins.db.Books.Remove(p as Book);
                    listBook.Remove(p as Book);
                    DataProvider.Ins.db.SaveChanges();
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            });

            AddCommand = new RelayCommand<UIElementCollection>((p) => true, (p) =>
            {
                Book obj = new Book();
                int amount = 0;
                double price = 0;
                DateTime dt;
                foreach(var item in p)
                {   
                    TextBox mytextbox = item as TextBox;
                    if (mytextbox == null)
                        continue;
                    switch (mytextbox.Name)
                    {
                        case "txtName": obj.name = mytextbox.Text; break;
                        case "txtCategory": obj.category = mytextbox.Text; break;
                        case "txtAmount": obj.amount = int.TryParse(mytextbox.Text, out amount) ? int.Parse(mytextbox.Text) : 0; break;
                        case "txtPrice": obj.price = double.TryParse(mytextbox.Text, out price) ? int.Parse(mytextbox.Text) : 0; break;
                        case "txtSize": obj.size = mytextbox.Text; break;
                        case "txtAuthor": obj.author = mytextbox.Text; break;
                        case "txtPublicationDate": obj.publicationdate = DateTime.TryParse(mytextbox.Text, out dt) ? DateTime.ParseExact(mytextbox.Text, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) : DateTime.Now ; break;
                        case "txtPublishCompany":obj.publishcompany = mytextbox.Text; break;
                        default:break;
                    }
                }


                try
                {
                    DataProvider.Ins.db.Books.Add(obj);
                    listBook.Add(obj);
                    DataProvider.Ins.db.SaveChanges();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

            });

            UpdateCommand = new RelayCommand<UIElementCollection>((p) => true, (p) =>
            {
                Book obj = new Book();
                string oldName = "";
                int amount = 0;
                double price = 0;
                DateTime dt;
                foreach (var item in p)
                {
                    TextBox mytextbox = item as TextBox;
                    if (mytextbox == null)
                        continue;
                    switch (mytextbox.Name)
                    {
                        case "txtID": obj.id = int.TryParse(mytextbox.Text, out amount) ? int.Parse(mytextbox.Text) : 0; break;
                        case "txtName": obj.name = mytextbox.Text; oldName = mytextbox.Text; break;
                        case "txtCategory": obj.category = mytextbox.Text; break;
                        case "txtAmount": obj.amount = int.TryParse(mytextbox.Text, out amount) ? int.Parse(mytextbox.Text) : 0; break;
                        case "txtPrice": obj.price = double.TryParse(mytextbox.Text, out price) ? int.Parse(mytextbox.Text) : 0; break;
                        case "txtSize": obj.size = mytextbox.Text; break;
                        case "txtAuthor": obj.author = mytextbox.Text; break;
                        case "txtPublicationDate": obj.publicationdate = DateTime.TryParse(mytextbox.Text, out dt) ? DateTime.ParseExact(mytextbox.Text, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture) : DateTime.Now; break;
                        case "txtPublishCompany": obj.publishcompany = mytextbox.Text; break;
                        default: break;
                    }
                }


                try
                {
                    Book b = DataProvider.Ins.db.Books.SingleOrDefault(d => d.id == obj.id);
                    if (b != null)
                    {
                        b.name = obj.name;
                        b.category = obj.category;
                        b.amount = obj.amount;
                        b.price = obj.price;
                        b.author = obj.author;
                        b.size = obj.size;
                        b.publicationdate = obj.publicationdate;
                        b.publishcompany = obj.publishcompany;

                        DataProvider.Ins.db.SaveChanges();

                        Book itemCollection = listBook.SingleOrDefault(tmp => tmp.id == obj.id);
                        listBook[listBook.IndexOf(itemCollection)] = obj;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

        });


        }

    }
}
