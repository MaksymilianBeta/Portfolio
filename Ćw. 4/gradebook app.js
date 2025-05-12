function getAverage(scores) {
  let total = 0;
  let i = 0;
  while (i < scores.length) {
    total = total + scores[i];
    i++;
  }

  if (scores.length === 0) {
    return 0;
  } else {
    return total / scores.length;
  }
}

function getGrade(score) {
  if (score === 100) {
    return "A+";
  }
  if (score >= 90) {
    return "A";
  }
  if (score >= 80) {
    return "B";
  }
  if (score >= 70) {
    return "C";
  }
  if (score >= 60) {
    return "D";
  }
  if (score < 60) {
    return "F";
  }
}

function hasPassingGrade(score) {
  let grade = getGrade(score);
  if (grade === "F") {
    return false;
  } else {
    return true;
  }
}

function studentMsg(scores, studentScore) {
  let average = getAverage(scores);
  let grade = getGrade(studentScore);
  let passed = hasPassingGrade(studentScore);
  let message = "Class average: " + average.toFixed(2) + ". Your grade: " + grade + ". ";

  if (passed === true) {
    message = message + "You passed the course.";
  } else {
    message = message + "You failed the course.";
  }

  return message;
}
let scores = [90, 85, 70, 95, 100];
let student = 58;
console.log(studentMsg(scores, student));