let lunches = [];

function addLunchToEnd(arr, item) {
    arr.push(item);
    console.log(`${item} added to the end of the lunch menu.`);
    return arr;
}

function addLunchToStart(arr, item) {
    arr.unshift(item);
    console.log(`${item} added to the start of the lunch menu.`);
    return arr;
}

function removeLastLunch(arr) {
    if (arr.length === 0) {
        console.log("No lunches to remove.");
    } else {
        let removedItem = arr.pop();
        console.log(`${removedItem} removed from the end of the lunch menu.`);
    }
    return arr;
}

function removeFirstLunch(arr) {
    if (arr.length === 0) {
        console.log("No lunches to remove.");
    } else {
        let removedItem = arr.shift();
        console.log(`${removedItem} removed from the start of the lunch menu.`);
    }
    return arr;
}

function getRandomLunch(arr) {
    if (arr.length === 0) {
        console.log("No lunches available.");
    } else {
        let randomItem = arr[Math.floor(Math.random() * arr.length)];
        console.log(`Randomly selected lunch: ${randomItem}`);
    }
}

function showLunchMenu(arr) {
    if (arr.length === 0) {
        console.log("The menu is empty.");
    } else {
        console.log(`Menu items: ${arr.join(", ")}`);
    }
}