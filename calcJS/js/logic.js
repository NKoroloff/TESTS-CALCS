function summ(a, b) {
    if (a == null || b == null) {
        return false;
    }
    if (typeof a !== 'number' || typeof b !== 'number') {
        return 'не число';
    } else {
        a += b;
        if(isError(a) === false) return a = 'error';
        return cutValue(a);
    }
}

function minus(a, b) {
    if (a == null || b == null) {
        return false;
    }
    if (typeof a !== 'number' || typeof b !== 'number') {
        return 'не число';
    } else {
        a -= b;
        if(isError(a) === false) return a = 'error';
        return cutValue(a);
    }
}

function divide(a, b) {
    if (a == null || b == null) {
        return false;
    }
    if (typeof a !== 'number' || typeof b !== 'number') {
        return 'не число';
    } else if (b === 0) {
        return 0;
    } else {
        a /= b;
        if(isError(a) === false) return a = 'error';
        return cutValue(a);
    }
}

function multiply(a, b) {
    if (a == null || b == null) {
        return false;
    }
    if (typeof a !== 'number' || typeof b !== 'number') {
        return 'не число';
    } else if (b === 0) {
        return 0;
    }
    else {
        a *= b;
        if(isError(a) === false) return a = 'error';
        return cutValue(a);
    }
}

function isError(a){
    if(isNaN(a)) return false;
    let d = String(a);
    for (let i = 0; i < d.length; i++) {
        let dot = '.';
        let idx = d.indexOf(dot);
        if (idx > 9 || d.length  > 9 && idx == -1) {
            console.log(idx)
            return false;
        }
    }
}

function displayError() {
    if(display.value === 'error'){
        model.setCountNumber(0);
        model.setMemoryNumber(0);
        model.setOperationType('')

    }
}

function cutDisplay(a) {
    if (a == null) {
        return false
    }
    if (a.length > 9) {
        a = a.slice(0, 9);
    }
    return a;
}

function displayCut(a) {
    display.value = cutDisplay(a)
}

const logic = {
    summ,
    minus,
    divide,
    multiply,
    cutDisplay,
    displayCut,
    displayError,
};

function cutValue(a) {
    let d = String(a);
    a = cutDisplay(d);
    a = parseFloat(a);
    return a;
}

