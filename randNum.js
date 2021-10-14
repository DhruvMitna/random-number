// Importing and defining the necessary functions.
const ps = require("prompt-sync")()
prompt = ps

function randInt(min, max) {

    min = Math.ceil(min);
    max = Math.floor(max);
    
    return Math.floor(Math.random() * (max - min + 1)) + min;

}

// Getting the necessary values from the user.
let start = parseInt(prompt("Enter the starting number for the range you want the random number to be selected from: "))
let end = parseInt(prompt("Enter the ending number for the range you want the random number to be selected from: "))

// Conditions that make sure the program doesn't break if the user enters the starting number greater than the ending number.
if (start < end) console.log(`The random number is ${randInt(start, end + 1)}`)

else if (start > end) console.log(`The random number generated is ${randInt(end, start + 1)}`)

else console.log("Starting and ending number cannot be equal")