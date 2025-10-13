let fortune1 = "Your cat will look very cuddly today.";
let fortune2 = "The weather will be nice tomorrow."
let fortune3 = "Be cautious of your new neighbors.";
let fortune4 = "You will find a new hobby soon.";
let fortune5 = "It would be wise to avoid the color red today.";
let randomNumber = Math.round(Math.random() * 5) + 1;
let selectedFortune = randomNumber;
if (randomNumber == 1) {
  console.log(fortune1);
} else if (randomNumber == 2) {
  console.log(fortune2);
} else if (randomNumber == 3) {
  console.log(fortune3);
} else if (randomNumber == 4) {
  console.log(fortune4);
} else if (randomNumber == 5) {
  console.log(fortune5);
}

console.log(selectedFortune);