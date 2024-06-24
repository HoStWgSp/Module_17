using Module_17.Observers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    internal interface IObservable
    {
        // добавить наблюдателя
        void RegisterObserver(IObserver o);

        // удалить наблюдателя
        void RemoveObserver(IObserver o);

        // уведомление наблюдателей
        void NotifyObservers();
    }
}
