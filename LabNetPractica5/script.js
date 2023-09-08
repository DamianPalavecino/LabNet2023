const inputNumber = document.getElementById('input-number');
const clue = document.getElementById('clue');
const score = document.getElementById('score');
const highscore = document.getElementById('highscore');
const finalNumber = document.getElementById('final-number');
const restartButton = document.getElementById('restart');
const inputButton = document.getElementById('input-button');

let targetNumber = generateRandomNumber(1, 20);
let currentScore = 20;
let bestScore = 0;

function generateRandomNumber(min, max) {
  return Math.floor(Math.random() * (max - min + 1)) + min;
}
console.log(targetNumber);

function verifyNumber() {
  const guess = parseInt(inputNumber.value);
  const isInvalidNumber = isNaN(guess) || guess < 1 || guess > 20;

  if (isInvalidNumber) {
    clue.textContent = 'Ingrese un número válido entre 1 y 20.';
  } else if (guess === targetNumber) {
    clue.textContent = '¡Adivinaste!';
    finalNumber.textContent = targetNumber;
    if (currentScore > bestScore) {
      bestScore = currentScore;
    }
    inputButton.disabled = true;
    document.body.style.backgroundColor = 'rgb(58, 180, 58)';
    setTimeout(() => restartGame(), 2500);
  } else if (guess < targetNumber) {
    clue.textContent = 'El número es más alto.';
    currentScore--;
  } else {
    clue.textContent = 'El número es más bajo.';
    currentScore--;
  }

  if (currentScore === 0) {
    inputButton.disabled = true;
    clue.textContent = 'Perdiste!';
    document.body.style.backgroundColor = 'red';
    setTimeout(() => restartGame(), 2500);
  }

  score.textContent = currentScore;
  highscore.textContent = bestScore;
  inputNumber.value = '';
}

function restartGame() {
  targetNumber = generateRandomNumber(1, 20);
  currentScore = 20;
  clue.textContent = '';
  score.textContent = currentScore;
  highscore.textContent = bestScore;
  finalNumber.textContent = '?';
  inputNumber.value = '';
  document.body.style.backgroundColor = 'white';
  inputButton.disabled = false;
}

restartButton.addEventListener('click', restartGame);
