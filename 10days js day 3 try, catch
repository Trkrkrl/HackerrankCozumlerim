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
 * Complete the reverseString function
 * Use console.log() to print to stdout.
 */
//bize bir string verildi, bunu harflerine ayiracaz split ile
//bir array yapacaz ve sonra da reverse edecegiz
//join??-->The join() method returns an array as a string.default seperator is comma,  you should identify your //seperator
//yani join de parantezi bos birakirsan virgul  koyar araya, sen "" ile bos oldugunu gostermelisin

function reverseString(s) {
    try {
        s = s.split("").reverse().join("");//s artik yeni s , once split sonra reverse sonra join
    } catch(e) {//var ise hata yazdir e .message
        console.log(e.message);
    } finally {//sonuc olarak yok ise hata yazdir s
        console.log(s);
    }
   
}


function main() {
    const s = eval(readLine());
    
    reverseString(s);
}
