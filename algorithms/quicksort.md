# Quick Sort
Quick Sort is a sorting alogrithm. When discussing Quick Sort you usually see terms like "pivot" and "partitioning."  Quick Sort is also most of the modeled as a recursive algorithm. 

The basic idea of Quick Sort is you first partiton the elements to find a pivot. Once you find the pivot, you  "split" the  elements into seperate trees. The partition sub-routine is to find what is called a "pivot"

## Partitioning
The job of the parition is to find a "pivot." The "pivot" is the value within the partitioning space that I want to find a position for. 

Lets look at an example. Lets say we have the following elements:
```
3,7,8,2,1
L       R
```
And the pivot is 1. Really all the pivot is, is the item that you want to find a position for.

You start out with two "pointers" `i`  and `j`.  

They point to the first element. `i`'s job is to remember the last position that an element was placed in, that was less than the pivot. So `i` will only move if it is less than the pivot. This means anything to the left of i  will be less than what the pivot is. `j`'s job is to scan  from L to R-1 to see if they are less than or greater than the pivot.

* With this example we start with `3`, this is greater than 1, so `i` stays  where it is at.
* 7 > 1, so move on
* 8 > 1, so move on
* 2 > 1, so move on

This gives you 1's final position. It is the position between everything less than it, and everything greater than it. This index that it sits at, is what you return.

The example above ends up being the worst case for quick sort. If you choose the greatest or smallest number, then quick sort will end up running  the worst case. The worst cast of quick sort of `O(n^2)`.

When choose a pivot, the best case is to usually find the median of the items. Lets look at the following example, which shows off the best case.
```
3,4,5,8,9,7
```
And the Pivot is 7.

* i and j both start on index 0 right now.
* 3 < 7. Since i and j are the same, swap means nothing
* 3 < 7. Swap i and j. The elements now are: `4,3,5,8,9,7`, now you increase i.
* 5 < 7. Swap i and j. The  elements now  are: `4,5,3,8,9,7`, now you increase i.
* 8 > 7, just advanced J.
* 9 > 7, just advanced J.
* Now swap the pivot with the number right after `i`. . This gives us: `4,5,3,7,9,8`

## Psuedo Code
The following is some psuedo code to demonstrate what coding Quick Sort would look like.

```js
function quickSort(array, l, r) {
    if(l < r)  {
        pivot = partition(array, l, r)
        quickSort(array, l, pivot - 1)
        quickSort(array, pivot + 1, r)
    }
}
```
