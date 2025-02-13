// 12. Find the Peak Element in an Array
// Find an element that is greater than its neighbors.
// Signature: public static int FindPeakElement(int[] arr)
// Example Input: [1, 2, 3, 1]
// Output: 3


int [] arr = {1, 2,3,1};

int PeakEle(int[] arr){

    if (arr.Length == 1) return arr[0]; 
    if (arr[0] > arr[1]) return arr[0]; 
    if (arr[^1] > arr[^2]) return arr[^1];

    for(int i = 1; i < arr.Length-1; i++){
        if(arr[i-1] < arr[i] && arr[i] > arr[i+1]){
            return  arr[i];
        }
    }

    return  -1;

}

Console.WriteLine(PeakEle(arr));