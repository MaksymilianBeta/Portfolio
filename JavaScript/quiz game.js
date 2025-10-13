let questions = [
    {
        category: "Nauka",
        question: "Jaki jest symbol chemiczny wody?",
        choices: ["H2O", "CO2", "O2"],
        answer: "H2O"
    },
    {
        category: "Geografia",
        question: "Jakie jest największe jezioro w Polsce?",
        choices: ["Śniardwy", "Mamry", "Hańcza"],
        answer: "Śniardwy"
    },
    {
        category: "Historia",
        question: "Kto był pierwszym królem Polski?",
        choices: ["Mieszko I", "Bolesław Chrobry", "Kazimierz Wielki"],
        answer: "Bolesław Chrobry"
    },
    {
        category: "Matematyka",
        question: "Ile wynosi pierwiastek kwadratowy z 81?",
        choices: ["9", "8", "7"],
        answer: "9"
    },
    {
        category: "Sport",
        question: "Ile zawodników liczy drużyna piłkarska?",
        choices: ["9", "11", "13"],
        answer: "11"
    }
];


function getRandomQuestion(arr) {
    return arr[Math.floor(Math.random() * arr.length)];
}

function getRandomComputerChoice(choices) {
    return choices[Math.floor(Math.random() * choices.length)];
}

function getResults(questionObj, computerChoice) {
    if (computerChoice === questionObj.answer) {
        return "The computer's choice is correct!";
    } else {
        return `The computer's choice is wrong. The correct answer is: ${questionObj.answer}`;
    }
}
