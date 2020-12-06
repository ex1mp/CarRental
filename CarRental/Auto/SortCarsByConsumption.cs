using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Auto
{
    class SortCarsByConsumption
    {
        public Car[] SorеByConsumption(List<Car> listOfCars)
        {
            Car[] arrayOfCar = listOfCars.ToArray();
            
            static void Swap(ref Car x, ref Car y)
            {
                var t = x;
                x = y;
                y = t;
            }

            static int Partition(Car[] array, int minIndex, int maxIndex)
            {
                var pivot = minIndex - 1;
                for (var i = minIndex; i < maxIndex; i++)
                {
                    if (array[i].ConsumptionOfFuel < array[maxIndex].ConsumptionOfFuel)
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);
                return pivot;
            }

            static Car[] QuickSort(Car[] array, int minIndex, int maxIndex)
            {
                if (minIndex >= maxIndex)
                {
                    return array;
                }

                var pivotIndex = Partition(array, minIndex, maxIndex);
                QuickSort(array, minIndex, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, maxIndex);

                return array;
            }

            static Car[] Sort(Car[] array)
            {
                return QuickSort(array, 0, array.Length - 1);
            }

            return Sort(arrayOfCar);
        }
    }
}
