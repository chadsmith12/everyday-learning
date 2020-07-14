## Merge Sort
Merge Sort, just like Quick Sort is a divide and conquer sorting algorithm. The upper bound of merge sort is 
`O(nlogn)`.

Merge Sort takes in the input array  and starts diving the array in half.  It then takes the two arrays and merge them together. This is the `merge` part of the Merge Sort. This is the most important part of the algorithm. This assumes that the left side of the array is sorted, and the right side of the array is sorted also. It then takes these two and sorts them while it merges them together

### Merging
The `merge` function takes in the input items, lower bound, middle index, and high bound. We take temporary arrays which represent the left sides and the right sides of the array.

The left side of the array is `items[low...middle]`  and the right side of the array is `items[middle + 1...high]`.

To make the left side and right side of the arrays, copy from the input items to the left side and right side temporary arrays.

Start frm the current lowest bound and keep track of which index on the left side and right side that you are on. We will call this `i` and `j`, respectively. While both `i` and `j` are less than the size of their respective arrays, check to see which side is smaller.

If the left side is smaller, then we take the current item on the left side of the array and place it at the current index of the input items. We also increase `i` to signal that we moved further on the left side. Do visa-versa for right side of the array. Always increase the current index at the end of the loop.

After this you will want to try to copy any left over items from the left side of the array to the current index of the input items, and also any left over items from the right side of the array to the current index of the input items.

