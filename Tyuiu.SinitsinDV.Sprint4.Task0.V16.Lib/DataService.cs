﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SinitsinDV.Sprint4.Task0.V16.Lib
{
    public class DataService : ISprint4Task0V16
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int p = 1;
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i] % 2 == 0)
                p *= array[i];
            
            }
            return p;
            
        }
    }
}
