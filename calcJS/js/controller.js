function initElements() {
    dotBtn = document.getElementById('dot');
    display = document.getElementById('talo');
    clearBtn = document.getElementById('del');
    plusBtn = document.getElementById('plusBtn');
    minusBtn = document.getElementById('minusBtn');
    resultBtn = document.getElementById('equally');
    divideBtn = document.getElementById('divideBtn');
    multiplyBtn = document.getElementById('multiplyBtn');
    buttonsList = document.getElementsByClassName('btn');
}

function addListeners() {
    for (let i = 0; i < buttonsList.length; i++) {
        let btn = buttonsList[i];
        btn.addEventListener('click', function (e) {
            logic.displayError();
            clickNumber(e.target.textContent);
            if (e.target.textContent == 0 && display.value === '0') {
                model.setIsCheck(true);
            }
        });
    }

    dotBtn.addEventListener('click', function () {
        for (let i = 0; i < display.value.length; i++) {
            if (display.value[i] === '.') {
                return;
            }
        }
        display.value += '.';
        model.setIsCheck(false);
        displayCut(display.value);
    });

    plusBtn.addEventListener('click', function () {
        logic.displayError();
        lastOperation(model.getIsCheck());
        cutDisplay(display.value);
        onOperationsClickBtn('+');
        console.log("+");
    });

    minusBtn.addEventListener('click', function () {
        logic.displayError();
        lastOperation(model.getIsCheck());
        onOperationsClickBtn('-');
        console.log("-");
    });

    divideBtn.addEventListener('click', function () {
        logic.displayError();
        lastOperation(model.getIsCheck());
        if (memoryNumber === 0 && display.value === '0') {
            display.value = '0';
        }
        if (isNaN(display.value) || isNaN(memoryNumber)) {
            display.value = '0';
        }
        onOperationsClickBtn('/');
        console.log("/");
    });

    multiplyBtn.addEventListener('click', function () {
        logic.displayError();
        lastOperation(model.getIsCheck());
        onOperationsClickBtn('*');
        console.log("*");
    });

    clearBtn.addEventListener('click', function () {
        display.value = 0;
        memoryNumber = 0;
        operationType = '';
        model.setIsCheck(true);
        model.setIsResult(true);
        console.log("Clear");
    });
    resultBtn.addEventListener('click', function () {
        if(model.getIsResult()) {
            model.setCountNumber(+display.value);
            switch (model.getOperationType()) {
                case '+':
                    model.setMemoryNumber(logic.summ(memoryNumber, model.getCountNumber()));
                    break;
                case '-':
                    model.setMemoryNumber(logic.minus(memoryNumber, model.getCountNumber()));
                    break;
                case '/':
                    if (countNumber === 0) {
                        memoryNumber = 0;
                        display.value = countNumber;
                    } else {
                        model.setMemoryNumber(logic.divide(memoryNumber, model.getCountNumber()))
                    }
                    break;
                case '*':
                    model.setMemoryNumber(logic.multiply(memoryNumber, model.getCountNumber()));
                    break;
            }
            model.setIsResult(false);
            model.setCountNumber(+display.value);
            display.value = model.getMemoryNumber();
            model.setOperationType('');
            model.setMemoryNumber(0);
            model.setCountNumber(0)
            model.setIsCheck(true)
        }
    });
}

function onOperationsClickBtn(operType) {
    model.setMemoryNumber(+display.value);
    model.setOperationType(operType);
    model.setIsCheck(true);
    model.setIsResult(true);
}

let clickNumber = num => {
    if (isCheck) {
        display.value = num;
        model.setIsCheck(false);
    } else {
        display.value += num;
        displayCut(display.value);
    }
};

function lastOperation() {
    if (model.getIsCheck) {
        model.setMemoryNumber(display.value);
    }
        switch (operationType) {
            case '+' :
                model.setMemoryNumber(logic.summ(+memoryNumber, Number(display.value)));
                break;
            case '-' :
                model.setMemoryNumber(logic.minus(+memoryNumber, Number(display.value)));
                break;
            case '/' :
                model.setMemoryNumber(logic.divide(+memoryNumber, Number(display.value)));
                break;
            case '*' :
                model.setMemoryNumber(logic.multiply(+memoryNumber, Number(display.value)));
                break;
        }
        display.value = model.getMemoryNumber();
}

// блокировка клавы + правого клика
window.oncontextmenu = function () {
    return false;
}

function press() {
    return false;
}

document.onkeydown = press;
// блокировка клавы + правого клика

