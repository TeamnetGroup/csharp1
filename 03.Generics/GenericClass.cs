﻿using System;
using System.ComponentModel;

namespace Generics
{
    // type parameter definit de clasă e disponibil peste tot
    class GenericClass<T>
    {
        private readonly T value;

        public void SomeMethod()
        {
            Console.WriteLine(value);
        }

        // metodele pot introduce type parameters noi
        public void MoreGenericMethod<TComponent>(
            T otherValue,
            TComponent component)
            where TComponent : Component
        {
            Console.WriteLine(
                "{0} și {1}",
                otherValue,
                component.Site);
        }

        public GenericClass(T value)
        {
            this.value = value;
        }
    }
}