﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DEQueue<T>
    {
        private List<T> queue = new List<T>();
        public int Count => queue.Count;

        public void pushBack(T item) //Добавление элемента в конец
        {
            //Console.WriteLine(item);
            if (item == null)
            {
                Console.WriteLine("Элемент пустой");
                return;
            }
            queue.Add(item);
        }
        public void pushFront(T item) //Добавление элемента в начало
        {
            if (item == null)
            {
                Console.WriteLine("Элемент пустой");
                return;
            }
            queue.Reverse();
            queue.Add(item);
            queue.Reverse();
        }
        public T popBack() //Извлечение элемента с конца
        {
            var item = back();
            queue.Remove(item);
            return item;
        }
        public T popFront() //Извлечение элемента из начала
        {
            var item = front();
            queue.Remove(item);
            return item;
        }

        public T back() //Просмотр последнего элемента
        {
            var item = queue.LastOrDefault();
            if (item == null)
            {
                Console.WriteLine("Очередь пуста");
                return item;
            }
            return item;
        }
        public T front() //Просмотр первого элемента
        {
            var item = queue.FirstOrDefault();
            if (item == null)
            {
                Console.WriteLine("Очередь пуста");
                return item;
            }
            return item;
        }
        public int size() //Количество элементов
        {
            return Count;
        }
        public void clear() //Очистка очереди(удаление всех элементов)
        {
            queue.Clear();
        }
        public T[] toArray() //Преобразование в массив
        {
            T[] arr = queue.ToArray();
            return arr;
        }

    }
}
