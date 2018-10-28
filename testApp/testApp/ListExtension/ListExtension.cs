using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace testApp.ListExtension
{
    public static class ListExtension
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> list)
        {
            var observableList = new ObservableCollection<T>();

            foreach (var item in list)
            {
                observableList.Add(item);
            }

            return observableList;
        }
    }
}
