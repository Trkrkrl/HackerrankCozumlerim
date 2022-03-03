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

/*
 * Complete the vowelsAndConsonants function.
 * Print your output using 'console.log()'.
 */
function vowelsAndConsonants(s) {
//For Turkish coders: ilk döngüde sesli harf mi diye bakacaz.bunun için match adında bir fonksiyon var
//bu fonksiyon(/ buraya yazılan pattern/) patterni yani o kalıbı , yazım sırasını kontrol eder gibi bişey
//bakıyor sesli harf mi
//evet ise 
//i ,nci indisteki karakteri yazdırıyor
//diğer döngüde ise ! ile tersini aldım
    for(let i = 0; i < s.length; i++) {//at this loop .match (comes from regex?) checks if it is fits the pattern --this is how we write pattern
        if(s.charAt(i).match(/[aeiou]/))
        console.log(s.charAt(i));
    }
    //and this is for non vowels
    for(let i = 0; i < s.length; i++) {
        if(!s.charAt(i).match(/[aeiou]/))
        console.log(s.charAt(i));
    }









    
}


function main() {
    const s = readLine();
    
    vowelsAndConsonants(s);
}
