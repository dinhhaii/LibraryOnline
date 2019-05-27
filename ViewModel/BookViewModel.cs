using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class BookViewModel
    {
        public ObservableCollection<Book> listBook { get; set; }

        public ICommand DeleteCommand;
        public ICommand AddCommand;
        public ICommand UpdateCommand;

        public BookViewModel()
        {
            listBook = new ObservableCollection<Book>();
            List<Book> list = DataProvider.Ins.db.Books.ToList();
            foreach(Book item in list)
            {
                listBook.Add(item);
            }

            //Delete
            DeleteCommand = new RelayCommand<object>((p) => p != null, (p) => {
                try
                {
                    DataProvider.Ins.db.Books.Remove(p as Book);
                    DataProvider.Ins.db.SaveChanges();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                }
            });

            //Update
            DeleteCommand = new RelayCommand<object>((p) => p != null, (p) => {
                try
                {
                    DataProvider.Ins.db.Books.Remove(p as Book);
                    DataProvider.Ins.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            });

            //Add
            DeleteCommand = new RelayCommand<object>((p) => p != null, (p) => {
                try
                {
                    DataProvider.Ins.db.Books.Add(p as Book);
                    DataProvider.Ins.db.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            });
        }

    }
}
