using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace ConsoleApplication4
{
    class ArrayList<T> : ClassVariable<T>
    {
        public ArrayList()
        {
            this._array = new T[defaultCapacity];
        }

        public ArrayList(int Capacity)
        {
            this._array = new T[Capacity];
        }

        public void Add(T item) //Добавляет новый элемент в список.
        {
            if (pointer == _array.Length - 1)
                resize(_array.Length * 2);
            _array[pointer++] = item;
        }

        public void Remove(int index)
        {
            for (int i = index; i < pointer; i++)
            {
                _array[i] = _array[i + 1];
                _array[pointer] = default(T);
                pointer--;
            }
            if (_array.Length > defaultCapacity && pointer < _array.Length / CUT_RATE)
                resize(_array.Length / 2); // если элементов в CUT_RATE раз меньше чем длина массива, то уменьшим в два раза
        }
    }

    class Stack<T> : ClassVariable<T>
    {

        public Stack()
        {
            this._array = new T[defaultCapacity];
        }
       
        public Stack(int Capacity)
        {
            this._array = new T[Capacity];
        }

        //Возвращает объект в верхней части Stack без его удаления.
        public T Peek()
        {
            if (pointer == 0)
            {
                throw new InvalidOperationException();
            }
            return this._array[pointer - 1];
        }

        public T Pop() //Удаляет и возвращает объект, находящийся в начале Stack.
        {
            if (this.size() == 0)
            { //вброс ошибки при взятии с пустого стека (Overflow)
                throw new InvalidOperationException();
            }
            return this._array[--pointer];
        }

        public void Push(T obj)
        {
            if (pointer == _array.Length) //если у нас переполнение...
            {
                T[] tmp = _array;
                _array = null;
                _array = new T[2 * tmp.Length];
                for (int i = 0; i <= tmp.Length; i++)
                {
                    _array[i] = tmp[i];
                }
            }
            else if ((pointer * 3) >= _array.Length)
            {
                T[] tmp = _array;
                _array = new T[_array.Length / 2];
                _array = tmp;
            }
            _array[pointer] = obj;
            pointer++;
        }    
    }

    class Queue<T> : ClassVariable<T>
        {
            int capacity = defaultCapacity;
            int tail = 0;
            int head = -1;
        public Queue()
        {
            this._array = new T[defaultCapacity];
        }

        public void Enqueue(T newElement) //добавление элемента в конец очереди
        {
            if (pointer == capacity)
            {
                T[] newQueue = new T[2 * capacity];
                Array.Copy(_array, 0, newQueue, 0, _array.Length);
                _array = newQueue;
                capacity *= 2;
            }
            pointer++;
            _array[tail++ % capacity] = newElement;
        }

            public T Dequeue() //удаляет объект из начала очереди и возвращает его
            {
                if (pointer == 0)
                {
                    throw new InvalidOperationException();
                }
                pointer--;
                return _array[++head % capacity];
            }

            public T Peek() //Просмотр элемента на вершине очереди.
            {
                if (Count == 0)
                    throw new InvalidOperationException();
                return _array[Count-1];
            }

            public void Clear() //Очистка очереди
            {
                if (head < tail)
                    Array.Clear(_array, head, Count);
                else
                {
                    Array.Clear(_array, head, _array.Length - head);
                    Array.Clear(_array, 0, tail);
                }
                head = 0;
                tail = 0;
                pointer = 0;
            }
        }   
}