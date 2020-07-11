function sort(array) {
    quickSort(array, 0, array.length - 1);

    return array;
}

function quickSort(array, l, r) {
    if(l < r) {
        const pivot = partition(array, l, r);
        quickSort(array, l, pivot - 1);
        quickSort(array, pivot + 1, r);
    }
}

function partition(array, low, high) {
    let pivot = array[high];
    let i = low - 1;

    for(let j = low; j <= high - 1; j++) {
        if(array[j] < pivot) {
            i++;
            [array[i], array[j]] = [array[j], array[i]];
        }
    }

    // swap the pivot value to the number to the right of i;
    [array[i+1],  array[high]] = [array[high], array[i+1]];
    return i + 1;
}


const items = [3,4,5,8,9,7];
console.log(items);
sort(items);
console.log(items);


const items2 = [99,45,34,443,550,3];
console.log(items2);
sort(items2);
console.log(items2);