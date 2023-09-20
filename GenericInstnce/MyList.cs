using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInstnce
{
    //list classındaki hazır ekleme metodunu kullanmaksızın add metodu oluşturma
    public class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList() 
        {
            _array = new T[0]; 
        }
        public void Add(T item) 
        {
            _tempArray = _array;                            // dizi boyutu değişmeden evvel referansını geçici tutmalıyız
            _array= new T[_tempArray.Length+1];             //dizini boyutu 1 arttı 
            for(int i=0; i < _tempArray.Length; i++) 
            {
                _array[i] = _tempArray[i];                  //yeni dizi eski adresinde boyutu 1 artmış şekilde
            }
            _array[_array.Length-1] = item;                 //now new item has added to list
        }
        public int MyCount 
        { 
            get { return _array.Length; }
        }

    }
}
