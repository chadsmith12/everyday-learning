using System.Collections.Generic;

namespace AlgorithmTesting
{
    public static class Sorting
    {
        public static void MergeSort(IList<int> items)
        {
            MergeSort(items, 0, items.Count - 1);
        }

        private static void MergeSort(IList<int> items,int low, int high)
        {
            if(high > low)
            {
                var middle = (low + high) / 2;
                MergeSort(items, low, middle);
                MergeSort(items, middle + 1, high);
                Merge(items, low, middle, high);
            }
        }

        private static void Merge(IList<int> items, int low, int middle, int high)
        {
            // find the size of the left side of the array = m - l + 1
            // find the size of the right side of the array = h -  m
            var leftSize = middle - low + 1;
            var rightSize = high - middle;

            var leftTemp = new int[leftSize];
            var rightTemp = new int[rightSize];
            // copy the data into the left side of the array
            // from 0 - leftSize
            // temp[index] = low + index
            for(var index = 0; index < leftSize; index++)
            {
                leftTemp[index] = items[low + index];
            }

            // copy the data into the right side of the  array
            // from 0 - rightSize
            // temp2[index] = middle + 1 + index
            for(var index  = 0; index < rightSize; index++)
            {
                rightTemp[index] = items[middle + 1 + index];
            }

            // currentIndex starts from from low
            var currentIndex = low;
            // i, and j represent the current index we are on from left and  right side of the array
            var i = 0;
            var j = 0;
            // while i < leftSize AND j < rightSize
            while(i < leftSize &&  j  < rightSize)
            {
                // if the left side is SMALLER than the right side, use the left side of the array
                // items[currentIndex] = temp[i];
                // increase i,
                if (leftTemp[i] <= rightTemp[j])
                {
                    items[currentIndex] = leftTemp[i];
                    i++;
                }
                // otherwise take it from the right side of the array
                // items[currentIndex] = temp[j];
                // increase j
                else
                {
                    items[currentIndex] = rightTemp[j];
                    j++;
                }

                // always increase currentIndex;
                currentIndex++;
            }
            
            // we need to check if we have any items in the left side of the array, that we missed
            // while i < leftSize
            while(i < leftSize)
            {
                // set the position
                // items[currentIndex] = temp[i]
                // increase i and currentIndex
                items[currentIndex] = leftTemp[i];
                i++;
                currentIndex++;
            }


            // we need to check if we have  any items  in the right side of  the array, that  we missed
            //  while j < rightSize
            while(j < rightSize)
            {
                // set the position
                // items[currentIndex] = temp[j]
                // increase j and currentIndex
                items[currentIndex] = rightTemp[j];
                j++;
                currentIndex++;
            }
        }
    }
}
