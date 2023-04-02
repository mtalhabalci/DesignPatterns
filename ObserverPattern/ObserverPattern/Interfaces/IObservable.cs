﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    public interface IObservable
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }
}