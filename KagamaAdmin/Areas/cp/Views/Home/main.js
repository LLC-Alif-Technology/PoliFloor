const date = 3;
const currentDate = 31;

let temp = 0;
let hours = 0;

let restDay = 0;
let workingDays = 0;

for (let i = date; i <= currentDate; i++) {
  if (temp < 2) {
    hours += ((++temp % 2) + 1) * 8;
    workingDays++;
  }

  if (i - date - temp - workingDays > 0) {
    restDay++;
  }

  if (restDay === 3) {
    temp = 0;
  }
}

console.log(hours);
