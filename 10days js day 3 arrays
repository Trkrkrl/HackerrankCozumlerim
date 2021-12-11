'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
    inputString += inputStdin;
});

process.stdin.on('end', _ => {
    inputString = inputString.trim().split('\n').map(string => {
        return string.trim();
    });
    
    main();    
});

function readLine() {
    return inputString[currentLine++];
}

/**
*   Return the second largest number in the array.
*   @param {Number[]} nums - An array of numbers.
*   @return {Number} The second largest number in the array.
**/
function getSecondLargest(nums) {
    
   let enb1 = nums[0];
    let enb2 = nums[0];
    
    for (let i = 1; i < nums.length; i++) {
        if (nums[i] > enb1) {
            enb2 = enb1;//once ilk enbuyugun degeri degismeden 2nci en buyuge atiyor
            enb1 = nums[i];//ikinci en buyuk buyuyor
            continue;
        }
        
        if ((nums[i] > enb2) && (nums[i] < enb1)) {
            enb2 = nums[i];//rastgele sayilar geliyor ya gelmis olansayi en1 den kucuk ve enb2 den buyuk ise enb2 yi yukselt
        }
    }
    
    return enb2;
     
    
    
}


function main() {
    const n = +(readLine());
    const nums = readLine().split(' ').map(Number);
    
    console.log(getSecondLargest(nums));
}
